using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1.Pages
{
    public class RispostaModel : PageModel
    {
        public string cognome { get; set; }

        public string nome { get; set; }
        public void OnGet(String cognome, string nome)
        {
            cognome = cognome;
            nome = nome;
        }
    }
}
