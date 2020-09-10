using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HaandvaerkerFirma.Pages
{
    public class ContactModel : PageModel
    {
        /// <summary>
        /// Properties til forsendelse af en KontaktFormular.
        /// </summary>
        public string KFNavn { get; set; }
        public string KFMobilnummer { get; set; }
        public string KFEmail { get; set; }
        public string KFBesked { get; set; }

        /// <summary>
        /// Property til at tilmelde sig Nyhedsbrev.
        /// </summary>
        public string NBEmail { get; set; }

        public void OnGet()
        {

        }

        public void OnPost(string KFnavn, string KFMobilnummer, string KFEmail, string KFBesked, string NBEmail)
        { 
        }
    }
}
