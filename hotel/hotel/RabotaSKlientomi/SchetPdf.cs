using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using iTextSharp.text;
using iTextSharp;
using iTextSharp.text.pdf;
using System.Drawing;
using System.Diagnostics;

namespace hotel.RabotaSKlientomi
{
    class SchetPdf
    {
        Mapping.DBhotel dbhot = new Mapping.DBhotel(hotel.Program.Pole.pole);
        Mapping.DBjurnalnomera dbjn=new Mapping.DBjurnalnomera (hotel.Program.Pole.pole);
        Mapping.DBnomera dbn=new Mapping.DBnomera (hotel.Program.Pole.pole);
        Mapping.DBjurnaldopuslug dbjdu=new Mapping.DBjurnaldopuslug(hotel.Program.Pole.pole);
        Mapping.DBdopuslugi dbdu=new Mapping.DBdopuslugi(hotel.Program.Pole.pole);
        public void CozdSchetPdf(string push, int ID)
        {
            //try
            {
                var doc = new Document();
                var linq=from n in dbhot.hotel
                         where n.id == 1
                            select n;
                PdfWriter.GetInstance(doc, new FileStream(push, FileMode.Create));
                doc.Open();
                BaseFont basefont = BaseFont.CreateFont(@"C:\Windows\Fonts\arial.ttf", BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
                foreach (var i in linq)
                {
                    iTextSharp.text.Phrase j = new Phrase("Отель " + i.nazvanie, new iTextSharp.text.Font(basefont, 16, iTextSharp.text.Font.NORMAL, new BaseColor(Color.Black)));
                    Paragraph a1 = new Paragraph(j);
                    a1.Add(Environment.NewLine);
                    a1.Add("Адрес " + i.adres);
                    a1.Add(Environment.NewLine);
                    a1.Add("email " + i.email);
                    a1.Alignment = Element.ALIGN_RIGHT;
                    a1.SpacingAfter = 5;
                    doc.Add(a1);
                }
                var linq2 = from n in dbjn.jurnalnomera
                            where n.id == ID
                            select n;
                foreach (var i in linq2)
                {
                    Paragraph a2 = new Paragraph();
                    a2.Add(new Phrase("Счет № " + ID + " за период " + i.datazaezda + " - " + i.dataviezda, new iTextSharp.text.Font(basefont, 14, iTextSharp.text.Font.NORMAL, new BaseColor(Color.Black))));
                    a2.Alignment = Element.ALIGN_RIGHT;
                    a2.SpacingAfter = 5;
                    a2.Add(Environment.NewLine);
                    a2.Add(Environment.NewLine);
                    a2.Add(Environment.NewLine);
                    a2.Add(Environment.NewLine);
                    doc.Add(a2);
                    PdfPTable table2 = new PdfPTable(4);
                    table2.WidthPercentage = 100;
                    PdfPCell cell1 = new PdfPCell(new Phrase("Бронирован ", new iTextSharp.text.Font(basefont, 14, iTextSharp.text.Font.NORMAL, new BaseColor(Color.Black))));
                    cell1.BackgroundColor = new BaseColor(Color.White);
                    cell1.HorizontalAlignment = Element.ALIGN_CENTER;
                    var linq3 = from n in dbn.nomera
                                where n.id == i.idnomera
                                select n;

                    PdfPCell cell2 = new PdfPCell(new Phrase("Номер ", new iTextSharp.text.Font(basefont, 14, iTextSharp.text.Font.NORMAL, new BaseColor(Color.Black))));
                    PdfPCell cell3 = new PdfPCell(new Phrase("Цена", new iTextSharp.text.Font(basefont, 14, iTextSharp.text.Font.NORMAL, new BaseColor(Color.Black))));
                    PdfPCell cell4 = new PdfPCell(new Phrase("Ставка", new iTextSharp.text.Font(basefont, 14, iTextSharp.text.Font.NORMAL, new BaseColor(Color.Black))));
                    table2.AddCell(cell1);
                    table2.AddCell(cell2);
                    table2.AddCell(cell3);
                    table2.AddCell(cell4);
                    PdfPCell cell5 = new PdfPCell(new Phrase(i.nalichbroni, new iTextSharp.text.Font(basefont, 14, iTextSharp.text.Font.NORMAL, new BaseColor(Color.Black))));
                    int itogo = 0;
                    int day = (i.datazaezda - i.dataviezda).Days; 
                    foreach (var j in linq3)
                    {
                        PdfPCell cell6 = new PdfPCell(new Phrase(j.nomer, new iTextSharp.text.Font(basefont, 14, iTextSharp.text.Font.NORMAL, new BaseColor(Color.Black))));
                        PdfPCell cell7 = new PdfPCell(new Phrase(j.cena.ToString(), new iTextSharp.text.Font(basefont, 14, iTextSharp.text.Font.NORMAL, new BaseColor(Color.Black))));
                        PdfPCell cell8 = new PdfPCell(new Phrase(j.stavka, new iTextSharp.text.Font(basefont, 14, iTextSharp.text.Font.NORMAL, new BaseColor(Color.Black))));

                        table2.AddCell(cell5);
                        table2.AddCell(cell6);
                        table2.AddCell(cell7);
                        table2.AddCell(cell8);
                    
                    doc.Add(table2);
                    Paragraph a3 = new Paragraph();
                    
                    
                        if (i.nalichbroni == "Нет")
                        {
                            if (day == 0)
                            {
                                itogo += j.cena;
                            }
                            else
                            {
                                itogo = (day*(-1) * j.cena + j.cena + j.cena) ;
                            }
                        }
                        else {

                            if (day == 0)
                            {
                                itogo += j.cena;
                            }
                            else { itogo = (day*(-1) * j.cena + j.cena); }
                        }
                                         
                        a3.Add(new Phrase("Итого за номер: " + (itogo).ToString(), new iTextSharp.text.Font(basefont, 14, iTextSharp.text.Font.NORMAL, new BaseColor(Color.Black))));
                    a3.Alignment = Element.ALIGN_RIGHT;
                    a3.SpacingAfter = 5;
                    a3.Add(Environment.NewLine);
                    doc.Add(a3);
                    }
                    PdfPTable table = new PdfPTable(3);
                    table.WidthPercentage = 100;
                    PdfPCell cell9 = new PdfPCell(new Phrase("Услуга", new iTextSharp.text.Font(basefont, 14, iTextSharp.text.Font.NORMAL, new BaseColor(Color.Black))));
                    cell9.BackgroundColor = new BaseColor(Color.White);
                    cell9.HorizontalAlignment = Element.ALIGN_CENTER;
                    PdfPCell cell10 = new PdfPCell(new Phrase("Цена", new iTextSharp.text.Font(basefont, 14, iTextSharp.text.Font.NORMAL, new BaseColor(Color.Black))));
                    PdfPCell cell11 = new PdfPCell(new Phrase("Ставка", new iTextSharp.text.Font(basefont, 14, iTextSharp.text.Font.NORMAL, new BaseColor(Color.Black))));
                    table.AddCell(cell9);
                    table.AddCell(cell10);
                    table.AddCell(cell11);
                    var linq4 = from n in dbjdu.jurnaldopuslug
                                where n.idjurnalanomera == ID
                                select n;
                    foreach (var j in linq4)
                    {
                        var linq5 = from n in dbdu.dopuslugi
                                    where n.id == j.iddopuslug
                                    select n;
                        int itogo2 = 0;
                        foreach (var k in linq5)
                        {
                            PdfPCell cell12 = new PdfPCell(new Phrase(k.nazvanie, new iTextSharp.text.Font(basefont, 14, iTextSharp.text.Font.NORMAL, new BaseColor(Color.Black))));
                            PdfPCell cell13 = new PdfPCell(new Phrase(k.cena.ToString(), new iTextSharp.text.Font(basefont, 14, iTextSharp.text.Font.NORMAL, new BaseColor(Color.Black))));
                            PdfPCell cell14 = new PdfPCell(new Phrase(k.stavka, new iTextSharp.text.Font(basefont, 14, iTextSharp.text.Font.NORMAL, new BaseColor(Color.Black))));
                            table.AddCell(cell12);
                            table.AddCell(cell13);
                            table.AddCell(cell14);

                            if (k.stavka == "в день")
                            {
                                if (day == 0)
                                {
                                    itogo2 += k.cena;
                                }
                                else
                                {
                                    itogo2 = day*(-1) * k.cena + k.cena + k.cena;
                                }
                            }
                            if (k.stavka == "за раз") { itogo2 += k.cena; }
                            doc.Add(table);
                        }

                        Paragraph a4 = new Paragraph();
                        a4.Add(Environment.NewLine);
                        a4.Add(new Phrase("Итого за доп услуги: " + itogo2.ToString(), new iTextSharp.text.Font(basefont, 14, iTextSharp.text.Font.ITALIC, new BaseColor(Color.Black))));
                        a4.Alignment = Element.ALIGN_RIGHT;
                        a4.SpacingAfter = 5;
                        a4.Add(Environment.NewLine);
                        a4.Add(Environment.NewLine);
                        a4.Add(Environment.NewLine);
                        a4.Add(Environment.NewLine);
                        Mapping.Metjurnal metj = new Mapping.Metjurnal();       
                        metj.ADD2(i.dataviezda, itogo+itogo2);
                        a4.Add(new Phrase("Итого за все:"+(itogo+itogo2).ToString(), new iTextSharp.text.Font(basefont, 14, iTextSharp.text.Font.ITALIC, new BaseColor(Color.Black))));
                        a4.Add(Environment.NewLine);
                        doc.Add(a4);
                    }
                    doc.Close();
                    System.Diagnostics.Process.Start(push);
                }
            }
            //catch { }
        }
        public void CozdSchetPdf2(string push, int ID)
        {
            //try
            {
                var doc = new Document();
                var linq = from n in dbhot.hotel
                           where n.id == 1
                           select n;
                PdfWriter.GetInstance(doc, new FileStream(push, FileMode.Create));
                doc.Open();
                BaseFont basefont = BaseFont.CreateFont(@"C:\Windows\Fonts\arial.ttf", BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
                foreach (var i in linq)
                {
                    iTextSharp.text.Phrase j = new Phrase("Отель " + i.nazvanie, new iTextSharp.text.Font(basefont, 16, iTextSharp.text.Font.NORMAL, new BaseColor(Color.Black)));
                    Paragraph a1 = new Paragraph(j);
                    a1.Add(Environment.NewLine);
                    a1.Add("Адрес " + i.adres);
                    a1.Add(Environment.NewLine);
                    a1.Add("email " + i.email);
                    a1.Alignment = Element.ALIGN_RIGHT;
                    a1.SpacingAfter = 5;
                    doc.Add(a1);
                }
                var linq2 = from n in dbjn.jurnalnomera
                            where n.id == ID
                            select n;
                foreach (var i in linq2)
                {
                    Paragraph a2 = new Paragraph();
                    a2.Add(new Phrase("Счет № " + ID + " за период " + i.datazaezda + " - " + i.dataviezda, new iTextSharp.text.Font(basefont, 14, iTextSharp.text.Font.NORMAL, new BaseColor(Color.Black))));
                    a2.Alignment = Element.ALIGN_RIGHT;
                    a2.SpacingAfter = 5;
                    a2.Add(Environment.NewLine);
                    a2.Add(Environment.NewLine);
                    a2.Add(Environment.NewLine);
                    a2.Add(Environment.NewLine);
                    doc.Add(a2);
                    PdfPTable table2 = new PdfPTable(4);
                    table2.WidthPercentage = 100;
                    PdfPCell cell1 = new PdfPCell(new Phrase("Бронирован ", new iTextSharp.text.Font(basefont, 14, iTextSharp.text.Font.NORMAL, new BaseColor(Color.Black))));
                    cell1.BackgroundColor = new BaseColor(Color.White);
                    cell1.HorizontalAlignment = Element.ALIGN_CENTER;
                    var linq3 = from n in dbn.nomera
                                where n.id == i.idnomera
                                select n;

                    PdfPCell cell2 = new PdfPCell(new Phrase("Номер ", new iTextSharp.text.Font(basefont, 14, iTextSharp.text.Font.NORMAL, new BaseColor(Color.Black))));
                    PdfPCell cell3 = new PdfPCell(new Phrase("Цена", new iTextSharp.text.Font(basefont, 14, iTextSharp.text.Font.NORMAL, new BaseColor(Color.Black))));
                    PdfPCell cell4 = new PdfPCell(new Phrase("Ставка", new iTextSharp.text.Font(basefont, 14, iTextSharp.text.Font.NORMAL, new BaseColor(Color.Black))));
                    table2.AddCell(cell1);
                    table2.AddCell(cell2);
                    table2.AddCell(cell3);
                    table2.AddCell(cell4);
                    PdfPCell cell5 = new PdfPCell(new Phrase(i.nalichbroni, new iTextSharp.text.Font(basefont, 14, iTextSharp.text.Font.NORMAL, new BaseColor(Color.Black))));
                    int itogo = 0;
                    int day = (i.datazaezda - i.dataviezda).Days;
                    foreach (var j in linq3)
                    {
                        PdfPCell cell6 = new PdfPCell(new Phrase(j.nomer, new iTextSharp.text.Font(basefont, 14, iTextSharp.text.Font.NORMAL, new BaseColor(Color.Black))));
                        PdfPCell cell7 = new PdfPCell(new Phrase(j.cena.ToString(), new iTextSharp.text.Font(basefont, 14, iTextSharp.text.Font.NORMAL, new BaseColor(Color.Black))));
                        PdfPCell cell8 = new PdfPCell(new Phrase(j.stavka, new iTextSharp.text.Font(basefont, 14, iTextSharp.text.Font.NORMAL, new BaseColor(Color.Black))));

                        table2.AddCell(cell5);
                        table2.AddCell(cell6);
                        table2.AddCell(cell7);
                        table2.AddCell(cell8);

                        doc.Add(table2);
                        Paragraph a3 = new Paragraph();


                        if (i.nalichbroni == "Нет")
                        {
                            if (day == 0)
                            {
                                itogo += j.cena;
                            }
                            else
                            {
                                itogo = (day * (-1) * j.cena + j.cena + j.cena);
                            }
                        }
                        else
                        {

                            if (day == 0)
                            {
                                itogo += j.cena;
                            }
                            else { itogo = (day * (-1) * j.cena + j.cena); }
                        }

                        a3.Add(new Phrase("Итого за номер: " + (itogo).ToString(), new iTextSharp.text.Font(basefont, 14, iTextSharp.text.Font.NORMAL, new BaseColor(Color.Black))));
                        a3.Alignment = Element.ALIGN_RIGHT;
                        a3.SpacingAfter = 5;
                        a3.Add(Environment.NewLine);
                        doc.Add(a3);
                    }
                    PdfPTable table = new PdfPTable(3);
                    table.WidthPercentage = 100;
                    PdfPCell cell9 = new PdfPCell(new Phrase("Услуга", new iTextSharp.text.Font(basefont, 14, iTextSharp.text.Font.NORMAL, new BaseColor(Color.Black))));
                    cell9.BackgroundColor = new BaseColor(Color.White);
                    cell9.HorizontalAlignment = Element.ALIGN_CENTER;
                    PdfPCell cell10 = new PdfPCell(new Phrase("Цена", new iTextSharp.text.Font(basefont, 14, iTextSharp.text.Font.NORMAL, new BaseColor(Color.Black))));
                    PdfPCell cell11 = new PdfPCell(new Phrase("Ставка", new iTextSharp.text.Font(basefont, 14, iTextSharp.text.Font.NORMAL, new BaseColor(Color.Black))));
                    table.AddCell(cell9);
                    table.AddCell(cell10);
                    table.AddCell(cell11);
                    var linq4 = from n in dbjdu.jurnaldopuslug
                                where n.idjurnalanomera == ID
                                select n;
                    foreach (var j in linq4)
                    {
                        var linq5 = from n in dbdu.dopuslugi
                                    where n.id == j.iddopuslug
                                    select n;
                        int itogo2 = 0;
                        foreach (var k in linq5)
                        {
                            PdfPCell cell12 = new PdfPCell(new Phrase(k.nazvanie, new iTextSharp.text.Font(basefont, 14, iTextSharp.text.Font.NORMAL, new BaseColor(Color.Black))));
                            PdfPCell cell13 = new PdfPCell(new Phrase(k.cena.ToString(), new iTextSharp.text.Font(basefont, 14, iTextSharp.text.Font.NORMAL, new BaseColor(Color.Black))));
                            PdfPCell cell14 = new PdfPCell(new Phrase(k.stavka, new iTextSharp.text.Font(basefont, 14, iTextSharp.text.Font.NORMAL, new BaseColor(Color.Black))));
                            table.AddCell(cell12);
                            table.AddCell(cell13);
                            table.AddCell(cell14);

                            if (k.stavka == "в день")
                            {
                                if (day == 0)
                                {
                                    itogo2 += k.cena;
                                }
                                else
                                {
                                    itogo2 = day * (-1) * k.cena + k.cena + k.cena;
                                }
                            }
                            if (k.stavka == "за раз") { itogo2 += k.cena; }
                            doc.Add(table);
                        }

                        Paragraph a4 = new Paragraph();
                        a4.Add(Environment.NewLine);
                        a4.Add(new Phrase("Итого за доп услуги: " + itogo2.ToString(), new iTextSharp.text.Font(basefont, 14, iTextSharp.text.Font.ITALIC, new BaseColor(Color.Black))));
                        a4.Alignment = Element.ALIGN_RIGHT;
                        a4.SpacingAfter = 5;
                        a4.Add(Environment.NewLine);
                        a4.Add(Environment.NewLine);
                        a4.Add(Environment.NewLine);
                        a4.Add(Environment.NewLine);
                        Mapping.Metjurnal metj = new Mapping.Metjurnal();
                        metj.ADD2(i.dataviezda, itogo + itogo2);
                        a4.Add(new Phrase("Итого за все:" + (itogo + itogo2).ToString(), new iTextSharp.text.Font(basefont, 14, iTextSharp.text.Font.ITALIC, new BaseColor(Color.Black))));
                        a4.Add(Environment.NewLine);
                        doc.Add(a4);
                    }                    
                    doc.Close();
                    System.Diagnostics.Process command = new System.Diagnostics.Process();
                    command.StartInfo.FileName = @"C:\Program Files\Adobe\Reader 10.0\ Reader\acrord32.exe";
                    command.StartInfo.Arguments = "/h /p " + push;
                    command.StartInfo.UseShellExecute = false;
                    command.StartInfo.CreateNoWindow = true;
                    command.Start();
                    command.WaitForExit(31000);
                    if (!command.HasExited)
                        command.Kill();
                    else command.Close();

                    
        }

                }
            }
            //catch { }
        }
    }
