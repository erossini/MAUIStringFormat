using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiTest.Models
{
    /// <summary>
    /// Class FormattedText.
    /// </summary>
    public class FormattedText
    {
        /// <summary>
        /// Gets or sets the font attributes.
        /// </summary>
        /// <value>The font attributes.</value>
        public FontAttributes FontAttributes { get; set; } = FontAttributes.None;

        /// <summary>
        /// Gets or sets the text.
        /// </summary>
        /// <value>The text.</value>
        public string? Text { get; set; }

        /// <summary>
        /// Gets or sets the color of the text.
        /// </summary>
        /// <value>The color of the text.</value>
        public Color TextColor { get; set; } = Colors.Black;
    }
}