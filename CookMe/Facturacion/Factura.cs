using System;
using System.Collections.Generic;
using System.Windows.Forms;  // Asegúrate de tener esta referencia
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using iText.Kernel.Font;
using iText.IO.Font.Constants;
using iText.Kernel.Colors;
using iText.Kernel.Geom;
using iText.Layout.Borders;
using iText.Kernel.Pdf.Canvas.Draw;


namespace CookMe.Facturacion
{
    public static class Factura
    {
        public static void GenerarTicket(string compradorEmail, Dictionary<int, int> compra)
        {
            // 🔁 Obtén los datos reales con tus métodos
            Datos.Modelos.Usuario usuCliente = new Logica.Controles.UsuarioControl().ObtenerUsuarioPorEmail(compradorEmail);
            var nombre= usuCliente.Nombre;
            var apellido = usuCliente.Apellido;

            // Muestra el SaveFileDialog para elegir la ruta de guardado
            using (var saveDialog = new SaveFileDialog())
            {
                saveDialog.Filter = "PDF files (*.pdf)|*.pdf";
                saveDialog.Title = "Guardar factura como...";
                saveDialog.FileName = "ticket.pdf";

                // Si el usuario selecciona una ruta
                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    string rutaArchivo = saveDialog.FileName;

                    // Generar el PDF y guardarlo en la ruta elegida
                    var writer = new PdfWriter(rutaArchivo);
                    var pdf = new PdfDocument(writer);
                    var pageSize = new PageSize(226, 600);  // Tamaño de ticket

                    var document = new Document(pdf, pageSize);
                    document.SetMargins(10, 10, 10, 10);

                    PdfFont font = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);

                    // Empresa
                    document.Add(new Paragraph("COOKME")
                        .SetFont(font)
                        .SetFontSize(14)
                        .SetTextAlignment(TextAlignment.CENTER));

                    document.Add(new Paragraph("CIF: X12345678\nCalle Falsa 123\nMadrid, España\nTel: +34 600 123 456")
                        .SetFont(font)
                        .SetFontSize(8)
                        .SetTextAlignment(TextAlignment.CENTER));

                    document.Add(new Paragraph(new string('-', 50)));
                    document.Add(new Paragraph("FACTURA").SetTextAlignment(TextAlignment.CENTER));

                    document.Add(new Paragraph(new string('-', 50)));

                    // Cliente
                    document.Add(new Paragraph($"Cliente: {nombre} {apellido}\nEmail: {compradorEmail}")
                        .SetFontSize(9)
                        .SetTextAlignment(TextAlignment.LEFT));

                    document.Add(new Paragraph(new string('-', 50)));

                    // Tabla de productos
                    var table = new Table(new float[] { 4, 1, 2 }).UseAllAvailableWidth();
                    table.SetFontSize(9);
                    table.SetBorder(Border.NO_BORDER);
                    table.AddHeaderCell(new Cell().Add(new Paragraph("Producto")).SetBorder(Border.NO_BORDER));
                    table.AddHeaderCell(new Cell().Add(new Paragraph("Cant")).SetBorder(Border.NO_BORDER));
                    table.AddHeaderCell(new Cell().Add(new Paragraph("Precio")).SetBorder(Border.NO_BORDER));

                    decimal total = 0m;

                    Datos.Modelos.Producto prod;

                    foreach (var item in compra)
                    {
                        prod = new Logica.Controles.ProductoControl().ObtenerProductoPorID(item.Key);

                        var nombreProducto = prod.Nombre;
                        var precio = prod.Precio;

                        var cantidad = item.Value;
                        var subtotal = cantidad * precio;
                        total += subtotal;

                        table.AddCell(new Cell().Add(new Paragraph(nombreProducto)).SetBorder(Border.NO_BORDER));
                        table.AddCell(new Cell().Add(new Paragraph(cantidad.ToString())).SetBorder(Border.NO_BORDER));
                        table.AddCell(new Cell().Add(new Paragraph($"{subtotal:0.00} €")).SetBorder(Border.NO_BORDER));
                     
                    }

                    document.Add(table);

                    document.Add(new Paragraph(new string('-', 50)));

                    document.Add(new Paragraph($"TOTAL: {total:0.00} €")
                        .SetFontSize(10)
                        .SetTextAlignment(TextAlignment.RIGHT));

                    document.Add(new Paragraph(new string('-', 50)));

                    // Mensajes de agradecimiento y condiciones
                    document.Add(new Paragraph("Gracias por su compra")
                        .SetFontSize(9)
                        .SetTextAlignment(TextAlignment.CENTER)
                        .SetMarginTop(10));

                    document.Add(new Paragraph("No se aceptan devoluciones sin ticket.")
                        .SetFontSize(7)
                        .SetTextAlignment(TextAlignment.CENTER)
                        .SetMarginTop(5));

                    document.Add(new Paragraph("Productos perecederos no tienen devolución.")
                        .SetFontSize(7)
                        .SetTextAlignment(TextAlignment.CENTER)
                        .SetMarginTop(5));

                    document.Close();

                   // MessageBox.Show($"Factura guardada correctamente en: {rutaArchivo}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        
    }
}