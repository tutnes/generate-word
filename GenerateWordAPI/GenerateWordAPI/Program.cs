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

        public static void CreateFromTemplate(string templateFilename, string documentFilename,ReportData data)
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
                

                // Add a Paragraph and a Run with the specified Text
                var para = body.AppendChild(new Paragraph());
                var run = para.AppendChild(new Run());
                run.AppendChild(new Text("Hello World" + data.name));
                //
                Table table = addTable(data.services);
                document.Body.Append(table);
                document.Save();
            }
        }
        public static Table addTable(List<Service> services)
        {
        
            Table table = new Table();

            TableProperties props = new TableProperties(
              new TableBorders(
                new TopBorder
                {
                    Val = new EnumValue<BorderValues>(BorderValues.Single),
                    Size = 12
                },
                new BottomBorder
                {
                    Val = new EnumValue<BorderValues>(BorderValues.Single),
                    Size = 12
                },
                new LeftBorder
                {
                    Val = new EnumValue<BorderValues>(BorderValues.Single),
                    Size = 12
                },
                new RightBorder
                {
                    Val = new EnumValue<BorderValues>(BorderValues.Single),
                    Size = 12
                },
                new InsideHorizontalBorder
                {
                    Val = new EnumValue<BorderValues>(BorderValues.Single),
                    Size = 12
                },
                new InsideVerticalBorder
                {
                    Val = new EnumValue<BorderValues>(BorderValues.Single),
                    Size = 12
                }));
            table.AppendChild<TableProperties>(props);

            foreach (var service in services)
            {
                var tr = new TableRow();
                    
                    //Add name of service
                    var tc = new TableCell();
                    tc.Append(new Paragraph(new Run(new Text(service.name))));
                    // Assume you want columns that are automatically sized.
                    tc.Append(new TableCellProperties(
                      new TableCellWidth { Type = TableWidthUnitValues.Auto }));
                    tr.Append(tc);
                    var tb = new TableCell();
                    //Add availability of service
                    tb.Append(new Paragraph(new Run(new Text(service.availability.ToString()))));
                    // Assume you want columns that are automatically sized.
                    tb.Append(new TableCellProperties(
                    new TableCellWidth { Type = TableWidthUnitValues.Auto }));
                    tr.Append(tb);
                
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
            public object downtime { get; set; }
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
        public static void ReplaceTextByTag(string sdtBlockTag, string newtext, List<SdtBlock> sdtList)
        {
            // https://blogs.msdn.microsoft.com/brian_jones/2009/01/28/traversing-in-the-open-xml-dom/
            // = mainDocumentPart.Document.Descendants<SdtBlock>().ToList();
            SdtBlock sdtA = null;

                foreach (SdtBlock sdt in sdtList)
                {
                    if (sdt.SdtProperties.GetFirstChild<Tag>().Val.Value == sdtBlockTag)
                    {
                        sdtA = sdt;
                        break;
                    }
                }
                SdtBlock cloneSdkt = (SdtBlock)sdtA.Clone();



                OpenXmlElement sdtc = cloneSdkt.GetFirstChild<SdtContentBlock>();
                //  OpenXmlElement parent = cloneSdkt.Parent;

                OpenXmlElementList elements = cloneSdkt.ChildElements;

                // var mySdtc = new SdtContentBlock(cloneSdkt.OuterXml);

                foreach (OpenXmlElement elem in elements)
                {
                    string innerxml = elem.InnerText;
                    if (innerxml.Length > 0)
                    {
                        string modified = "Class Name : My Class.Description : mydesc.AttributesNameDescriptionMy Attri name.my attri desc.Operations NameDescriptionmy ope name.my ope descriptn.";
                        string replace = elem.InnerText.Replace(innerxml, modified);
                        // mainDocumentPart.Document.Save();
                    }
                    // string text = parent.FirstChild.InnerText;
                    // parent.Append((OpenXmlElement)elem.Clone());
                }

          


            }
        }
    }
}
