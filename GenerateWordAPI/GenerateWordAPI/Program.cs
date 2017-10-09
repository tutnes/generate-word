using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using Newtonsoft.Json;
using System.Diagnostics;


namespace GenerateWordAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = new WebHostBuilder()
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseIISIntegration()
                .UseStartup<Startup>()
                .UseApplicationInsights()
                .Build();

            host.Run();
        }

        public static MemoryStream CreateFromTemplate(string templateFilename, string documentFilename,ReportData data)
        {
            // WordprocessingDocument.Create will overwrite an existing file. 
            // If we are using Open we have to delete the file first 
            // if we want to copy that behavior.
            if (File.Exists(documentFilename))
            {
                File.Delete(documentFilename);
            }

            // Copy the template to the output file name.
            File.Copy(templateFilename, documentFilename);
            
            // Now open the copied file
            using (var wordDocument = WordprocessingDocument.Open(documentFilename, true))
            {
                // We need to change the file type from template to document.
                wordDocument.ChangeDocumentType(WordprocessingDocumentType.Document);

                // MainDocumentPart, root Document and Body already exist just access them
                var mainPart = wordDocument.MainDocumentPart;
                var document = mainPart.Document;
                var body = document.Body;
                List<SdtElement> blocks = body.Descendants<SdtElement>().ToList();

                
                ReplaceTagWithText("ccDocumentTitle", data.name, blocks);
                

                DateTime fromEpoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
                fromEpoch = fromEpoch.AddMilliseconds(data.fromDate+1);
                DateTime toEpoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
                toEpoch = toEpoch.AddMilliseconds(data.toDate);

                ReplaceTagWithText("ccDocumentSubtitle", fromEpoch.ToString("MMMM dd") + " - " + toEpoch.ToString("MMMM dd"), blocks);

                

                foreach(Service service in data.services)
                {
                    if (service.name != "Other")
                    {
                        Paragraph para = body.AppendChild(new Paragraph());
                        Run run = para.AppendChild(new Run());
                        run.AppendChild(new Text(service.name));
                        para.ParagraphProperties = new ParagraphProperties(new ParagraphStyleId() { Val = "Heading1" });
                        TableProperties props = new TableProperties(new TableStyle() { Val = "TableGrid" });
                        Table serviceTable = new Table();
                        serviceTable.AppendChild<TableProperties>(props);
                        TableRow sName = new TableRow(new TableCell(new Paragraph(new Run(new RunProperties(new Bold(), new Text("Service Name"))))));
                        sName.Append(new TableCell(new Paragraph(new Run(new Text(service.name)))));
                        TableRow aVb = new TableRow(new TableCell(new Paragraph(new Run(new RunProperties(new Bold(), new Text("Availability"))))));
                        aVb.Append(new TableCell(new ParagraphProperties(new Justification() { Val = JustificationValues.Right }), new Paragraph(new Run(new Text(service.availability.ToString())))));
                        serviceTable.Append(sName);
                        serviceTable.Append(aVb);
                        
                        body.Append(serviceTable);
                        body.Append(new Paragraph());
                        Table serverTable = addTable(service.servers);

                        body.Append(serverTable);
                        body.Append(new Break() { Type = BreakValues.Page });
                    }
                                       
                }

                //document.Body.Append(table);
                document.Save();
                MemoryStream ms = new MemoryStream();
                document.Save(ms);
                return ms;
            }
        }
        public static Table addTable(List<Server> servers)
        {

            TableCellProperties tProps = new TableCellProperties(
                      new TableCellWidth { Type = TableWidthUnitValues.Auto });
            Table table = new Table();

            TableProperties props = new TableProperties(new TableStyle() { Val = "TableGrid" });
            table.AppendChild<TableProperties>(props);

            //Table Header
            var th = new TableRow();
            th.Append(new TableCell(new Paragraph(new Run(new RunProperties(new Bold(), new Text("Server Name"))))));
            th.Append(new TableCell(new Paragraph(new Run(new RunProperties(new Bold(), new Text("Availability"))))));
            th.Append(new TableCell(new Paragraph(new Run(new RunProperties(new Bold(), new Text("Downtime"))))));
            table.Append(th);
            foreach (var server in servers)
            {

                var tr = new TableRow();
                //Add name of service
                tr.Append(new TableCell(new Paragraph(new Run(new Text(server.name)))));
                tr.Append(new TableCell(new ParagraphProperties(new Justification() { Val = JustificationValues.Right}), new Paragraph(new Run(new Text(server.availability.ToString())))));
                TimeSpan time = TimeSpan.FromMilliseconds(server.downtime);
                string str = time.ToString(@"hh\:mm");
                tr.Append(new TableCell(new Paragraph(new Run(new Text(str + "h")))));
                table.Append(tr);
            }
            return table;
                       
        }
        public class Breaches
        {
        }

        public class Server
        {
            public string ID { get; set; }
            public double availability { get; set; }
            public int availabilityOffPeakTarget { get; set; }
            public int availabilityTarget { get; set; }
            public Breaches breaches { get; set; }
            public double down { get; set; }
            public double downtime { get; set; }
            public string name { get; set; }
        }

        public class Transactions
        {
        }

        public class Service
        {
            public string ID { get; set; }
            public double availability { get; set; }
            public int availabilityOffPeakTarget { get; set; }
            public int availabilityTarget { get; set; }
            public double down { get; set; }
            public string name { get; set; }
            public List<Server> servers { get; set; }
            public Transactions transactions { get; set; }
        }

        public class ReportData
        {
            public string ID { get; set; }
            public long fromDate { get; set; }
            public bool includeApp { get; set; }
            public string name { get; set; }
            public List<Service> services { get; set; }
            public long toDate { get; set; }
        }
        public static Run replaceTextInRun(Run r, string newText)
        {
            string innerText = r.InnerText;
            string modifiedString = "";
            modifiedString = r.InnerText.Replace(innerText, newText);
            // if the InnerText doesn't modify
            if (modifiedString != r.InnerText)
            {
                Text t = new Text(modifiedString);
                r.RemoveAllChildren<Text>();
                r.AppendChild<Text>(t);
            }
            return r;
        }

        public static SdtElement FindBlockByTag(string sdtBlockTag, List<SdtElement> sdtList)
        {
            // https://blogs.msdn.microsoft.com/brian_jones/2009/01/28/traversing-in-the-open-xml-dom/
            
            SdtElement sdtA = null;
            foreach (SdtElement sdt in sdtList)
                {
                    //Console.Write(sdt.SdtProperties.GetFirstChild<Tag>().Val.Value);
                if (sdt.SdtProperties.GetFirstChild<Tag>().Val.Value == sdtBlockTag)
                    {
                        sdtA = sdt;
                        break;
                    }
                }
            return sdtA;       

        }
        public static void ReplaceTagWithText(string tag, string text, List<SdtElement> blocks)
        {
            Run r;
            SdtElement stdE = FindBlockByTag(tag, blocks);
            if (stdE != null)
            {
                r = stdE.Descendants<Run>().First();
                r = replaceTextInRun(r, text);
            }
        }
        
    }
}
