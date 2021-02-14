using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace pdf1
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
               https://www.c-sharpcorner.com/UploadFile/f2e803/basic-pdf-creation-using-itextsharp-part-i/
               https://www.c-sharpcorner.com/uploadfile/f2e803/basic-pdf-creation-using-itextsharp-part-ii/
               https://www.c-sharpcorner.com/uploadfile/f2e803/basic-pdf-creation-using-itextsharp-part-iii/
               https://www.c-sharpcorner.com/blogs/create-table-in-pdf-using-c-sharp-and-itextsharp
            */

            var fileName = "test.pdf";
            using (var stream = new FileStream(fileName, FileMode.Create))
            {
                var doc = new Document(PageSize.A4.Rotate(),15,15,15,15);
                var writer = PdfWriter.GetInstance(doc, stream);
                doc.Open();

                var data = GetTestData();
                MakePdf(doc, data);

                doc.Close();
                writer.Close();
            }
            ///Открытие файла для ускорения
            Process.Start(new ProcessStartInfo(fileName)
            {
                UseShellExecute = true
            });
        }

        ///Создание pdf-файла и его заполнение
        static void MakePdf(Document document, Report data)
        {
            string ttf = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "ARIAL.TTF");
            var baseFont = BaseFont.CreateFont(ttf, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
            var font = new Font(baseFont, Font.DEFAULTSIZE, Font.NORMAL);

            var title = $"Hello from {data.From.ToShortDateString()} to {data.To.ToShortDateString()}";
            document.Add(new Paragraph(title, font));

            var table = new PdfPTable(3);
            table.SpacingBefore = 20;
            table.WidthPercentage = 100;
            table.SetWidths(new float[] { 0.4f, 1.0f, 1.0f });

            foreach(var item in data.Items) {
                table.AddCell($"{item.Id}");
                table.AddCell($"{item.Name}");
                table.AddCell($"{item.CompanyCount}");
            }
            document.Add(table);
        }

        static Report GetTestData()
        {
            var result = new Report()
            {
                From = new DateTime(2021, 01, 01),
                To = DateTime.Now,
                Items = new List<Category>()
                {
                    new Category()
                    {
                        Id = 1,
                        Name = "Test111",
                        CompanyCount = 153
                    },
                    new Category()
                    {
                        Id = 2,
                        Name = "Test222",
                        CompanyCount = 153
                    },
                    new Category()
                    {
                        Id = 3,
                        Name = "Test333",
                        CompanyCount = 153
                    }
                }
            };
            return result;
        }
    }
}
