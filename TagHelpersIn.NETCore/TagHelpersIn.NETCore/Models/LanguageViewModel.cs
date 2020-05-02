using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

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
