using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1.Pages
{
    public class DatosModel : PageModel
    {
        [BindProperty]
        public NotaModel Nota { get; set; }

        public class NotaModel
        {
            public string Nombre { get; set; }
            public string Materia { get; set; }
            public double Parcial1 { get; set; }
            public double Parcial2 { get; set; }
            public double ExamenFinal { get; set; }
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            // Procesar los datos aquí si la validación es exitosa.

            // Calcular el promedio de las notas
            double parcial1 = Nota.Parcial1;
            double parcial2 = Nota.Parcial2;
            double examenFinal = Nota.ExamenFinal;
            double notaFinal = parcial1 + parcial2 + examenFinal;

            // Guardar los datos en TempData
            TempData["Nombre"] = Nota.Nombre;
            TempData["Materia"] = Nota.Materia;
            TempData["Parcial1"] = parcial1.ToString();
            TempData["Parcial2"] = parcial2.ToString();
            TempData["ExamenFinal"] = examenFinal.ToString();
            TempData["NotaFinal"] = notaFinal.ToString();

            return RedirectToPage("./Calculos");
        }
    }
}
