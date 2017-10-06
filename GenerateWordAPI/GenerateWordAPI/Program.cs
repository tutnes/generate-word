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

        public static void CreateFromTemplate(string templateFilename, string documentFilename,int value)
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
                run.AppendChild(new Text("Hello World" + value));
                //
                Table table = addTable(new string[,]{ { "Texas", "TX" }, { "California", "CA" }, { "New York", "NY" }, { "Massachusetts", "MA" }});
                document.Body.Append(table);
                document.Save();
            }
        }
        public static Table addTable(string[,] data)
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

            for (var i = 0; i <= data.GetUpperBound(0); i++)
            {
                var tr = new TableRow();
                for (var j = 0; j <= data.GetUpperBound(1); j++)
                {
                    var tc = new TableCell();
                    tc.Append(new Paragraph(new Run(new Text(data[i, j]))));
                    // Assume you want columns that are automatically sized.
                    tc.Append(new TableCellProperties(
                      new TableCellWidth { Type = TableWidthUnitValues.Auto }));
                    tr.Append(tc);
                }
                table.Append(tr);
            }
            return table;
                       
        }
    }
}
