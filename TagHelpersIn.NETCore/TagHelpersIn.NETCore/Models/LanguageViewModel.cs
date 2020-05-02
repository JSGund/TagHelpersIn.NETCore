using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TagHelpersIn.NETCore.Models
{
    public class LanguageViewModel
    {
        public string Language { get; set; }

        public List<SelectListItem> Languages { get; } = new List<SelectListItem>
        {
            new SelectListItem { Value = "CS", Text = "C#" },
            new SelectListItem { Value = "JS", Text = "JavaScript" },
            new SelectListItem { Value = "TS", Text = "TypeScript"  },
        };
    }
}
