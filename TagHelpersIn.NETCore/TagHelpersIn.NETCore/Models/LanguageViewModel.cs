using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace TagHelpersIn.NETCore.Models
{
    public class LanguageViewModel
    {
        private static SelectListGroup _backEndGrp { get; } = new SelectListGroup() { Name = "Back-end" };
        private static SelectListGroup _frontEndGrp { get; } = new SelectListGroup() { Name = "Front-end" };
        private static SelectListGroup _frontEndDisableGrp { get; } = new SelectListGroup() { Name = "Front-end", Disabled = true };

        public string SelLanguage1 { get; set; }
        public string SelLanguage2 { get; set; }
        public string SelLanguage3 { get; set; }

        public List<SelectListItem> LanguagesEx1 { get; } = new List<SelectListItem>
        {
            new SelectListItem { Value = "CS", Text = "C#" },
            new SelectListItem { Value = "JS", Text = "JavaScript" },
            new SelectListItem { Value = "TS", Text = "TypeScript" },
        };

        public List<SelectListItem> LanguagesEx2 { get; } = new List<SelectListItem>
        {
            new SelectListItem { Value = "CS", Text = "C#" },
            new SelectListItem { Value = "JAVA", Text = "Java" },
            new SelectListItem { Value = "PY", Text = "Python" },
            new SelectListItem { Value = "JS", Text = "JavaScript" },
            new SelectListItem { Value = "TS", Text = "TypeScript" },
        };

        public List<SelectListItem> LanguagesEx3 { get; } = new List<SelectListItem>
        {
            new SelectListItem { Value = "CS", Text = "C#", Group = _backEndGrp },
            new SelectListItem { Value = "JAVA", Text = "Java", Group = _backEndGrp },
            new SelectListItem { Value = "PY", Text = "Python", Group = _backEndGrp },
            new SelectListItem { Value = "JS", Text = "JavaScript", Group = _frontEndGrp },
            new SelectListItem { Value = "TS", Text = "TypeScript", Group = _frontEndGrp },
        };

        public List<SelectListItem> LanguagesEx4 { get; } = new List<SelectListItem>
        {
            new SelectListItem { Value = "CS", Text = "C#", Group = _backEndGrp },
            new SelectListItem { Value = "JAVA", Text = "Java", Group = _backEndGrp, Disabled = true },
            new SelectListItem { Value = "PY", Text = "Python", Group = _backEndGrp },
            new SelectListItem { Value = "JS", Text = "JavaScript", Group = _frontEndDisableGrp },
            new SelectListItem { Value = "TS", Text = "TypeScript", Group = _frontEndDisableGrp },
        };
    }
}
