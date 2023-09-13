using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1.Pages
{
    public class ResumenModel : PageModel
    {
        public double Parcial1 { get; set; }
        public double Parcial2 { get; set; }
        public double ExamenFinal { get; set; }
        public double NotaFinal { get; set; }

        public void OnGet()
        {
            if (TempData.ContainsKey("Parcial1"))
            {
                Parcial1 = double.Parse(TempData["Parcial1"].ToString());
            }

            if (TempData.ContainsKey("Parcial2"))
            {
                Parcial2 = double.Parse(TempData["Parcial2"].ToString());
            }

            if (TempData.ContainsKey("ExamenFinal"))
            {
                ExamenFinal = double.Parse(TempData["ExamenFinal"].ToString());
            }

            if (TempData.ContainsKey("NotaFinal"))
            {
                NotaFinal = double.Parse(TempData["NotaFinal"].ToString());
            }
        }
    }
}
