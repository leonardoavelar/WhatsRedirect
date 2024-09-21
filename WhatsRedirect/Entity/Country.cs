using System.Diagnostics.Metrics;
using System.Text.RegularExpressions;

namespace WhatsRedirect.Entity
{
    public class Country
    {
        public required string Name { get; set; }

        public required string Image { get; set; }

        //private string _image = string.Empty;
        //public required string Image
        //{
        //    get
        //    {
        //        string pattern = @"[^a-zA-Zá-úÁ-Ú]";
        //        string fileName = Regex.Replace(Name, pattern, string.Empty);
        //        string resourceImage = $"Resources/Images/{fileName}.png";

        //        return resourceImage;
        //    }
        //    set
        //    {
        //        _image = value;
        //    }
        //}

        public required int DDI { get; set; }

        public required string Continent { get; set; }

        public string Description { get => $"{Name} ({DDI})"; }
    }
}
