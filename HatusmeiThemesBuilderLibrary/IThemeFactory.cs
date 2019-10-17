using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HatusmeiThemesBuilderLibrary
{
    /// <summary>
    /// Main apstraction interface for every theme.
    /// </summary>
    public interface IThemeFactory
    {
        Color ButtonBackColor { get; set; }
        Color ButtonForeColor { get; set; }
        Color BackgroundColor { get; set; }
        Font HeadersFont { get; set; }
        Font ButtonsFont { get; set; }
    }

}
