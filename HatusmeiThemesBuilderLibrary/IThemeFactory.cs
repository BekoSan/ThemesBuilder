using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThemesBuilderLibrary
{
    /// <summary>
    /// Main apstraction interface for every theme.
    /// </summary>
    public interface IThemeFactory
    {
        Color ButtonBackColor { get; set; }
        Color ButtonForeColor { get; set; }
        Font ButtonsFont { get; set; }
        FlatStyle ButtonFlatStyle { get; set; } 
        Color HoverColor { get; set; }
        int ButtonBorderSize { get; set; }
        Color SelectionColor { get; set; }
        Color BackgroundColor { get; set; }
        Font HeadersFont { get; set; }
        Color HeadersForeColor { get; set; }
        Color HeadersBackground { get; set; }
        Color DGVColumnHeaderBackColor { get; set; }
        Color DGVColumnHeaderForeColor { get; set; }
        Font DGVColumnHeaderFont { get; set; }
        DataGridViewCellBorderStyle DGVCellBorderStyle {get;set;}
        DataGridViewHeaderBorderStyle DGVHeaderBorderStyle { get; set; }
        Color DGVRowBackgroundColor { get; set; }
        Color DGVRowForeColor { get; set; }
        Color DGVRowSelectionForeColor { get; set; }
        Color DGVBackgroundColor { get; set; }
        Color DGVGridColor { get; set; }
    }

}
