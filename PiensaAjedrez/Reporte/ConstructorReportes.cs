using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiensaAjedrez.Reporte
{
    public abstract class ConstructorReportes
    {
        public static Document ConstruirReporte(DataSet fuente, string escuela, string tipoArchivo)
        {   
            string nombreArchivo = @"\" + tipoArchivo + DateTime.Now.Year + DateTime.Now.Month + DateTime.Now.Day + DateTime.Now.Hour + DateTime.Now.Minute + ".pdf";
            
            PdfPTable tablitaPDF = new PdfPTable(fuente.Tables[0].Columns.Count);            
            tablitaPDF.DefaultCell.Padding = 3;
            tablitaPDF.WidthPercentage = 100;
            tablitaPDF.HorizontalAlignment = Element.ALIGN_CENTER;            
            foreach (var item in fuente.Tables[0].Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(item.ToString(), FontFactory.GetFont("Segoe UI", 10.0f, BaseColor.WHITE)));
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                cell.BackgroundColor = BaseColor.DARK_GRAY;
                tablitaPDF.AddCell(cell);
            }

            for (int intContador = 0; intContador < fuente.Tables[1].Rows.Count; intContador++)
            {
                for (int intContadorInterno = 0; intContadorInterno < fuente.Tables[1].Columns.Count; intContadorInterno++)
                {
                    var datoDuro = fuente.Tables[1].Rows[intContador][intContadorInterno];
                    string datoDuroMostrado = "";                     

                    if (datoDuro is DateTime)
                    {
                        DateTime datoDuroDateTime = (DateTime)datoDuro;
                        datoDuroMostrado = datoDuroDateTime.ToShortDateString();
                    }
                    else
                    {
                        if (datoDuro is decimal)
                        {
                            decimal datoDuroDouble = (decimal)datoDuro;
                            datoDuroMostrado = datoDuroDouble.ToString("C");
                            datoDuroMostrado = datoDuroMostrado.Substring(0, datoDuroMostrado.IndexOf('.'));
                        }
                        else
                            datoDuroMostrado = datoDuro.ToString();
                        
                    }
                        
                        
                    PdfPCell accel = new PdfPCell(new Phrase(datoDuroMostrado, FontFactory.GetFont("Segoe UI", 10.0f, BaseColor.BLACK)));
                    accel.HorizontalAlignment = Element.ALIGN_CENTER;
                    accel.VerticalAlignment = Element.ALIGN_CENTER;
                    tablitaPDF.AddCell(accel);
                }
            }
            
            
            string folderPath = Directory.GetCurrentDirectory();
            if (!Directory.Exists(folderPath))            
                Directory.CreateDirectory(folderPath);            
            Document pdfDoc = new Document(new Rectangle(0, 0, (int)PageSize.A4.Height, (int)PageSize.A4.Width), 10f, 10f, 20f, 10f);
            using (FileStream stream = new FileStream(folderPath + nombreArchivo, FileMode.Create))
            {
                PdfWriter.GetInstance(pdfDoc, stream);
                pdfDoc.Open();
                Cursos unCurso = ConexionBD.CargarCursoActivo(escuela);
                Image pic = Image.GetInstance("PiensaAjedrezLogo.png");
                pic.Alignment = Element.ALIGN_CENTER;
                pic.ScalePercent(18);
                pdfDoc.Add(pic);
                pdfDoc.Add(new Paragraph(" "));
                string header = "";
                if(!tipoArchivo.Contains("Egresos"))
                    header = tipoArchivo + "     " +escuela +"     " +unCurso.InicioCursos.ToShortDateString() +" - " +unCurso.FinCurso.ToShortDateString() +"     " +DateTime.Now.ToShortDateString();
                else                
                    header = tipoArchivo + "     " + escuela + "     " + DateTime.Now.ToShortDateString();

                Paragraph prHeader = new Paragraph(header,FontFactory.GetFont("Courier", 14.0f, BaseColor.BLACK));
                prHeader.Alignment = Element.ALIGN_CENTER;
                pdfDoc.Add(prHeader);
                pdfDoc.Add(new Paragraph(" "));
                pdfDoc.Add(tablitaPDF);
                pdfDoc.Close();
                stream.Close();
            }
            Process.Start(folderPath + nombreArchivo);
            return pdfDoc;
        }        
    }
}