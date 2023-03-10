using iTextSharp.text.pdf;
using LanchoneteDoProgramador.Entidades;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace LanchoneteDoProgramador
{
    internal class PdfGenerator
    {
        //public void GeneratePdf(List<Venda> items, string filename)
        //{
        //    // Get the path to "MeusDocumentos"
        //    string folderPath = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "C:\\MeusDocumentos\\");

        //    // Check if the folder exists; create it if it doesn't
        //    if (!Directory.Exists(folderPath))
        //    {
        //        Directory.CreateDirectory(folderPath);
        //    }

        //    // Create a new PDF document
        //    PdfDocument pdf = new PdfDocument(new PdfWriter(new FileStream(@"C:\MeusDocumentos\" + filename + ".pdf", FileMode.Create)));

        //    // Set up the document
        //    Document document = new Document(pdf, PageSize.A4, true);

        //    // Define styles for header and table
        //    Style headerStyle = new Style()
        //        .SetBackgroundColor(new DeviceGray(0.5f))
        //        .SetFont(PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD))
        //        .SetFontSize(16f)
        //        .SetTextAlignment(TextAlignment.CENTER);

        //    Style tableHeaderStyle = new Style()
        //        .SetFont(PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD))
        //        .SetFontSize(12f);

        //    Style tableCellStyle = new Style()
        //        .SetFont(PdfFontFactory.CreateFont(StandardFonts.HELVETICA))
        //        .SetFontSize(12f);

        //    // Create header
        //    Paragraph header = new Paragraph("Lista de Itens")
        //        .AddStyle(headerStyle);

        //    // Create table
        //    Table table = new Table(new float[] { 1, 3 })
        //        .UseAllAvailableWidth();

        //    // Add table headers
        //    table.AddHeaderCell(new Cell().Add(new Paragraph("ID")).AddStyle(tableHeaderStyle));
        //    table.AddHeaderCell(new Cell().Add(new Paragraph("Nome")).AddStyle(tableHeaderStyle));
        //    double acumulador = 0;
        //    // Add table cells
        //    foreach (ItemVenda item in items)
        //    {
        //        double valorProduto = item.Quantidade * item.Produto.ValorUnitario;
        //        acumulador = acumulador + valorProduto;
        //        table.AddCell(new Cell().Add(new Paragraph(item.Produto.Id.ToString() + " " + item.Produto.Titulo + " x " + item.Quantidade.ToString() + " = " + (valorProduto).ToString())).AddStyle(tableCellStyle));
        //    }
        //    table.AddCell(new Cell().Add(new Paragraph("Total: " + acumulador.ToString())));
        //    // Add header and table to the document
        //    document.Add(header);
        //    document.Add(table);

        //    // Close the document
        //    document.Close();
        }
    }
}
