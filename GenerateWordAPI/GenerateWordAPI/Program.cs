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

        public static void CreateFromTemplate(string templateFilename, string documentFilename)
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
                run.AppendChild(new Text("Hello World"));

                document.Save();
            }
        }
    }
}
