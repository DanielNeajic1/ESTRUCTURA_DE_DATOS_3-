using System;
using System.Collections.Generic;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

class Program
{
    static void Main()
    {
        HashSet<string> ciudadanos = GenerarCiudadanos(500);
        HashSet<string> vacunadosPfizer = GenerarCiudadanos(75);
        HashSet<string> vacunadosAstrazeneca = GenerarCiudadanos(75);

        HashSet<string> vacunadosTotal = new HashSet<string>(vacunadosPfizer);
        vacunadosTotal.UnionWith(vacunadosAstrazeneca);

        HashSet<string> noVacunados = new HashSet<string>(ciudadanos);
        noVacunados.ExceptWith(vacunadosTotal);

        HashSet<string> vacunadosAmbas = new HashSet<string>(vacunadosPfizer);
        vacunadosAmbas.IntersectWith(vacunadosAstrazeneca);

        HashSet<string> soloPfizer = new HashSet<string>(vacunadosPfizer);
        soloPfizer.ExceptWith(vacunadosAstrazeneca);

        HashSet<string> soloAstrazeneca = new HashSet<string>(vacunadosAstrazeneca);
        soloAstrazeneca.ExceptWith(vacunadosPfizer);

        GenerarReportePDF(noVacunados, vacunadosAmbas, soloPfizer, soloAstrazeneca);

        Console.WriteLine("Reporte generado con éxito en 'Reporte_Vacunacion.pdf'.");
    }

    static HashSet<string> GenerarCiudadanos(int cantidad)
    {
        HashSet<string> ciudadanos = new HashSet<string>();
        Random rand = new Random();
        for (int i = 0; i < cantidad; i++)
        {
            ciudadanos.Add("Ciudadano_" + rand.Next(1000, 9999));
        }
        return ciudadanos;
    }

    static void GenerarReportePDF(HashSet<string> noVacunados, HashSet<string> vacunadosAmbas, HashSet<string> soloPfizer, HashSet<string> soloAstrazeneca)
    {
        Document doc = new Document();
        PdfWriter.GetInstance(doc, new FileStream("Reporte_Vacunacion.pdf", FileMode.Create));
        doc.Open();

        doc.Add(new Paragraph("Reporte de Vacunación COVID-19"));
        doc.Add(new Paragraph("\nListado de ciudadanos no vacunados:"));
        foreach (var item in noVacunados) doc.Add(new Paragraph(item));

        doc.Add(new Paragraph("\nCiudadanos con ambas vacunas:"));
        foreach (var item in vacunadosAmbas) doc.Add(new Paragraph(item));

        doc.Add(new Paragraph("\nCiudadanos con solo Pfizer:"));
        foreach (var item in soloPfizer) doc.Add(new Paragraph(item));

        doc.Add(new Paragraph("\nCiudadanos con solo Astrazeneca:"));
        foreach (var item in soloAstrazeneca) doc.Add(new Paragraph(item));

        doc.Close();
    }
}
