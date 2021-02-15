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
            PersonExample();
            CarExample();

            /*
               0. Посмотреть про ввод данных
               1. Посмотреть про массивы
               2. Сделать класс Person - ученика в школе (имя, фамилия, массив оценок)
               3. Сделать сохранение в файл / чтение из файла
               4. Вывести всех учеников на экран + средний балл
               5. Вывести всех учеников у кого средний бал > 4.0 на экран 
             */
        }

        static void CarExample()
        {
            var car = new Car(52);

            if (car.CanMove())
            {
                var km = 10.5;
                car.Move(km);
                var fuel = car.GetFuilLiters();
                Console.WriteLine($"Проехали: {km} км, осталось {fuel} литров бензина");
            }

            car.Name = Car.GetName(0); //использование статического метода
            int a = MathUtils.Add(15, 25);

            Console.WriteLine("Машина: " + car.Name);

            var car2 = new Car
            {
                Name = Car.GetName(1),
                Color = "White"
            };
        }
      


        static void PersonExample()
        {
            Person test = new Person();
            Person bill = new Person(18, "Bill");
            Person bob = new Person(24, "Bob");
            var somebody = new Person(24, "Some Body");
        }

        static void MakePdf()
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
                var doc = new Document(PageSize.A4.Rotate(), 15, 15, 15, 15);
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
            //string ttf = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "Arial.ttf");
            var baseFont = BaseFont.CreateFont("C:\\Windows\\Fonts\\arial.ttf", BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
            var font = new Font(baseFont, Font.DEFAULTSIZE, Font.NORMAL);

            var title = $"Hello from {data.From.ToShortDateString()} to {data.To.ToShortDateString()}";
            document.Add(new Paragraph(title, font));
            //Console.Write(ttf);

            var table = new PdfPTable(6);
            table.SpacingBefore = 20;
            table.WidthPercentage = 100;
            table.SetWidths(new float[] { 0.07f, 0.5f, 0.5f, 0.5f, 0.5f, 0.5f });

            foreach (var item in data.Items) 
            {
                table.AddCell(new Paragraph($"{item.Id}", font));
                table.AddCell(new Paragraph($"{item.Name}", font));
                table.AddCell(new Paragraph($"{item.CompanyCount}", font));
                table.AddCell(new Paragraph($"{item.DispName}", font));
                table.AddCell(new Paragraph($"{item.EmployeeName}", font));
                table.AddCell(new Paragraph($"{item.Description}", font));
            }
            document.Add(table);
        }
        static Report GetTestData()
        {
            var result = new Report
            {
                From = new DateTime(2021, 01, 01),
                To = DateTime.Now,
                Items = new List<Category>()
                {
                    new Category()
                    {
                        Id = 1,
                        Name = "Вентиляция",
                        CompanyCount = 10,
                        DispName = "Родионов М.Е.",
                        EmployeeName = "Тарбеев Д.И.",
                        Description = "Шумит фанкойл"
                    },
                    new Category()
                    {
                        Id = 2,
                        Name = "Хладоснабжение",
                        CompanyCount = 55,
                        DispName = "Солдатенков С.Н.",
                        EmployeeName = "Щербаков А.А.",
                        Description = "Не работает кондиционер"
                    },
                    new Category()
                    {
                        Id = 3,
                        Name = "Видеонаблюдение",
                        CompanyCount = 7,
                        DispName = "Солдатенков С.Н.",
                        EmployeeName = "Сапунов С.Н.",
                        Description = "Моргает уличная камера"
                    }
                }
            };
            return result;
        }
    }
}
