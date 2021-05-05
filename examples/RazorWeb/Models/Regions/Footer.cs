using Piranha.Extend;
using Piranha.Extend.Fields;
using Piranha.Models;

namespace RazorWeb.Models.Regions
{
    public class Footer
    {
        /// <summary>
        /// Gets/sets the optional primary image.
        /// </summary>
        [Field(Title = "Logo Image", Options = FieldOption.HalfWidth)]
        public ImageField LogoImage { get; set; }

        /// <summary>
        /// Gets/sets the header title.
        /// </summary>
        [Field(Options = FieldOption.HalfWidth)]
        public StringField Title { get; set; }

        /// <summary>
        /// Gets/sets the optional primary image.
        /// </summary>
        [Field(Title = "Slogan Image")]
        public ImageField SloganImage { get; set; }

        /// <summary>
        /// Gets/sets the optional background image.
        /// </summary>
        [Field(Title = "Background Image")]
        public ImageField BackgroundImage { get; set; }
    }
}
