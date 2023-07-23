using System;
using System.IO;
using iText.Kernel.Colors;
using iText.Kernel.Font;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using iText.Kernel.Pdf.Canvas.Draw;

namespace CLOsBasedEvaluationSystem.Utility
{
    public class Reports
    {

        public static void GenerateResultPDF(DataGridView dataGrid, string name, string marks)
        {
            try
            {
                //Create a new PDF file using the open file dialog
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "PDF files (*.pdf)|*.pdf";
                saveFileDialog1.FilterIndex = 2;
                saveFileDialog1.RestoreDirectory = true;
                saveFileDialog1.FileName = "ResultReport_" + name;

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream stream = new FileStream(saveFileDialog1.FileName, FileMode.Create))
                    {
                        PdfWriter writer = new PdfWriter(stream);
                        PdfDocument pdfDoc = new PdfDocument(writer);
                        Document document = new Document(pdfDoc, iText.Kernel.Geom.PageSize.A4, true);

                        // Tiitle Section
                        Paragraph title = new Paragraph("Assessment Report")
                            .SetFontSize(20)
                            .SetTextAlignment(TextAlignment.CENTER);
                        document.Add(title);

                        // Section-1
                        Paragraph asmtName = new Paragraph("Assesssment : " + name)
                            .SetFontSize(14)
                            .SetFontColor(DeviceRgb.BLACK)
                            .SetTextAlignment(TextAlignment.CENTER)
                            .SetBackgroundColor(DeviceGray.GRAY);
                        document.Add(asmtName);

                        Paragraph createDate = new Paragraph("Date : " + DateTime.Now.ToString())
                            .SetFontSize(11)
                            .SetFontColor(DeviceRgb.BLACK);
                        document.Add(createDate);

                        Paragraph tMakrs = new Paragraph( marks)
                            .SetFont(PdfFontFactory.CreateFont())
                            .SetFontSize(11)
                            .SetFontColor(DeviceRgb.BLACK);
                        document.Add(tMakrs);

                        // Section-2 Table
                        Table table = new Table(dataGrid.Columns.Count-2)
                            .UseAllAvailableWidth()
                            .SetMarginTop(10);

                        // header of table
                        //Add the column headers to the table
                        table.AddCell(new Cell().Add(new Paragraph(dataGrid.Columns[2].HeaderText)));
                        table.AddCell(new Cell().Add(new Paragraph(dataGrid.Columns[3].HeaderText)));
                        table.AddCell(new Cell().Add(new Paragraph(dataGrid.Columns[4].HeaderText)));
                        table.AddCell(new Cell().Add(new Paragraph(dataGrid.Columns[5].HeaderText)));
                        table.AddCell(new Cell().Add(new Paragraph(dataGrid.Columns[6].HeaderText)));

                        //Add the rows to the table
                        foreach (DataGridViewRow row in dataGrid.Rows)
                        {
                            table.AddCell(new Cell().Add(new Paragraph(row.Cells[2].Value.ToString())));
                            table.AddCell(new Cell().Add(new Paragraph(row.Cells[3].Value.ToString())));
                            table.AddCell(new Cell().Add(new Paragraph(row.Cells[4].Value.ToString())));
                            table.AddCell(new Cell().Add(new Paragraph(row.Cells[5].Value.ToString())));
                            table.AddCell(new Cell().Add(new Paragraph(row.Cells[6].Value.ToString())));
                        }
                         
                        document.Add(table);
                        document.Close();
                    }
                    MessageBox.Show(name + " Result PDF file saved successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public static void GenerateCLOResultPDF( )
        {
            try
            {
                //Create a new PDF file using the open file dialog
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "PDF files (*.pdf)|*.pdf";
                saveFileDialog1.FilterIndex = 2;
                saveFileDialog1.RestoreDirectory = true;
                saveFileDialog1.FileName = "CloResultReport";

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream stream = new FileStream(saveFileDialog1.FileName, FileMode.Create))
                    {
                        PdfWriter writer = new PdfWriter(stream);
                        PdfDocument pdfDoc = new PdfDocument(writer);
                        Document document = new Document(pdfDoc, iText.Kernel.Geom.PageSize.A4, true);

                        // Tiitle Section
                        Paragraph title = new Paragraph("CLO Result Report")
                            .SetFontSize(20)
                            .SetTextAlignment(TextAlignment.CENTER);
                        document.Add(title);

                        // Section-1

                        // Line separator
                        LineSeparator ls = new LineSeparator(new SolidLine());
                        document.Add(ls);

                        Paragraph createDate = new Paragraph("Date : " + DateTime.Now.ToString())
                            .SetFontSize(14)
                            .SetFontColor(DeviceRgb.BLACK);
                        document.Add(createDate);

                        DataTable dtClos = Queries.getCloTMarks();
                        int totalMarks = 0;

                        List<int> cloIds = new List<int>();
                        foreach(DataRow dtClo in dtClos.Rows)
                        {
                            string id = dtClo.ItemArray[0].ToString();
                            string cloName = dtClo.ItemArray[1].ToString();
                            string cloTMarks = dtClo.ItemArray[2].ToString();

                            cloIds.Add(int.Parse(id));

                            totalMarks += int.Parse(cloTMarks);

                            Paragraph pCloName = new Paragraph(cloName + "\nMarks: " + cloTMarks)
                                .SetFont(PdfFontFactory.CreateFont())
                                .SetFontSize(14)
                                .SetFontColor(DeviceRgb.BLACK);
                            document.Add(pCloName);

                            /*Paragraph pCloTM = new Paragraph("Total Marks : " + cloTMarks)
                                .SetFont(PdfFontFactory.CreateFont())
                                .SetFontSize(12)
                                .SetFontColor(DeviceRgb.BLACK);
                            document.Add(pCloTM);*/
                            
                        }

                        Paragraph pCloTM = new Paragraph("Total Marks : " + totalMarks)
                                .SetFont(PdfFontFactory.CreateFont())
                                .SetFontSize(12)
                                .SetFontColor(DeviceRgb.BLACK);
                        document.Add(pCloTM);

                        // Section-2 Table
                        Table table = new Table(dtClos.Rows.Count + 3)
                            .UseAllAvailableWidth()
                            .SetMarginTop(10);

                        // header of table
                        //Add the column headers to the table
                        table.AddCell(new Cell()
                            .SetBackgroundColor(ColorConstants.GRAY)
                            .SetTextAlignment(TextAlignment.CENTER)
                            .SetFontSize(10)
                            .Add(new Paragraph("Reg. No")));

                        table.AddCell(new Cell()
                            .SetBackgroundColor(ColorConstants.GRAY)
                            .SetTextAlignment(TextAlignment.CENTER)
                            .SetFontSize(10)
                            .Add(new Paragraph("Name")));

                        foreach (DataRow dtClo in dtClos.Rows)
                        {
                            string cloName = dtClo.ItemArray[1].ToString();
                            string cloTMarks = dtClo.ItemArray[2].ToString();

                            table.AddCell(new Cell()
                            .SetBackgroundColor(ColorConstants.GRAY)
                            .SetTextAlignment(TextAlignment.CENTER)
                            .SetFontSize(10)
                            .Add(new Paragraph(cloName)));
                            
                        }
                        table.AddCell(new Cell()
                            .SetBackgroundColor(ColorConstants.GRAY)
                            .SetTextAlignment(TextAlignment.CENTER)
                            .SetFontSize(10)
                            .Add(new Paragraph("Obtain Marks")));


                        DataTable dtStd = Queries.queryActiveStudentsForAttendance("Active");
                        //Add the rows to the table
                        foreach (DataRow rowStd in dtStd.Rows)
                        {
                            string regNo = rowStd.ItemArray[2].ToString();
                            string stdName = rowStd.ItemArray[1].ToString();
                            string stdId = rowStd.ItemArray[0].ToString();
                            int obtMarks = 0;

                            table.AddCell(new Cell().Add(new Paragraph(regNo)));
                            table.AddCell(new Cell().Add(new Paragraph(stdName)));

                            foreach (int cloId in cloIds)
                            {
                                int sId = int.Parse(stdId);

                                DataTable dtMarks = Queries.getCloResult(sId, cloId);
                                if (dtMarks.Rows.Count != 0)
                                {
                                    string marks = dtMarks.Rows[0][3].ToString();
                                    obtMarks += int.Parse(marks);
                                    table.AddCell(new Cell().Add(new Paragraph(marks)));
                                }
                                else
                                {
                                    table.AddCell(new Cell().Add(new Paragraph("-")));
                                }
                            }
                            table.AddCell(new Cell().Add(new Paragraph(obtMarks.ToString())));
                        }

                        document.Add(table);
                        document.Close();
                    }
                    MessageBox.Show(" Result PDF file saved successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public static void GenerateAttendancePDF( )
        {
            try
            {
                //Create a new PDF file using the open file dialog
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "PDF files (*.pdf)|*.pdf";
                saveFileDialog1.FilterIndex = 2;
                saveFileDialog1.RestoreDirectory = true;
                saveFileDialog1.FileName = "Attendance";

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream stream = new FileStream(saveFileDialog1.FileName, FileMode.Create))
                    {
                        PdfWriter writer = new PdfWriter(stream);
                        PdfDocument pdfDoc = new PdfDocument(writer);
                        Document document = new Document(pdfDoc, iText.Kernel.Geom.PageSize.A4, true);

                        // Footer Section
                        Paragraph title = new Paragraph("Attendance Report")
                            .SetFontSize(20)
                            .SetTextAlignment(TextAlignment.CENTER);
                        document.Add(title);

                        // Section-1
                        // Line separator
                        LineSeparator ls = new LineSeparator(new SolidLine());
                        document.Add(ls);

                        Paragraph createDate = new Paragraph("Date : " + DateTime.Now.ToString())
                            .SetFontSize(11)
                            .SetFontColor(DeviceRgb.BLACK);
                        document.Add(createDate);

                        // Section-2 Table
                        DataTable dates = Queries.queryAttendanceDates();
                        Table table = new Table(dates.Rows.Count+2)
                            .UseAllAvailableWidth()
                            .SetMarginTop(10);

                        // header of table
                        //Add the column headers to the table
                        table.AddCell(new Cell()
                            .SetBackgroundColor(ColorConstants.GRAY)
                            .SetTextAlignment(TextAlignment.CENTER)
                            .SetFontSize(8)
                            .Add(new Paragraph("Reg. No")));

                        table.AddCell(new Cell()
                            .SetBackgroundColor(ColorConstants.GRAY)
                            .SetTextAlignment(TextAlignment.CENTER)
                            .SetFontSize(8)
                            .Add(new Paragraph("Name")));

                        foreach (DataRow row in dates.Rows)
                        {
                            DateTime date = (DateTime)row.ItemArray[0];
                            table.AddCell(new Cell()
                            .SetBackgroundColor(ColorConstants.GRAY)
                            .SetTextAlignment(TextAlignment.CENTER)
                            .SetFontSize(8)
                            .Add(new Paragraph(date.Day.ToString()+"/"+ date.Month.ToString())));
                        }


                        DataTable students = Queries.queryActiveStudentsForAttendance("Active");

                        foreach(DataRow row in students.Rows)
                        {
                            int id = (int)row.ItemArray[0];

                            table.AddCell(new Cell()
                            .SetTextAlignment(TextAlignment.CENTER)
                            .SetFontSize(8)
                            .Add(new Paragraph(row.ItemArray[2].ToString())));

                            table.AddCell(new Cell()
                            .SetTextAlignment(TextAlignment.CENTER)
                            .SetFontSize(8)
                            .Add(new Paragraph(row.ItemArray[1].ToString())));

                            foreach(DataRow date in dates.Rows)
                            {
                                DateTime dateTime = (DateTime)date.ItemArray[0];
                                DataTable status =  Queries.GETAttd(id, dateTime);

                                if(status.Rows.Count == 0)
                                {
                                    table.AddCell(new Cell()
                                        .SetTextAlignment(TextAlignment.CENTER)
                                        .SetFontSize(8)
                                        .Add(new Paragraph("N/A")));
                                }
                                else
                                {
                                    table.AddCell(new Cell()
                                        .SetTextAlignment(TextAlignment.CENTER)
                                        .SetFontSize(8)
                                        .Add(new Paragraph(status.Rows[0][0].ToString())));
                                }
                            }
                        }
                        document.Add(table);
                        document.Close();
                    }

                    MessageBox.Show("Attendance PDF file saved successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

    }

}