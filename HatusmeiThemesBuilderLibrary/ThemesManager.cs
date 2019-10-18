using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThemesBuilderLibrary
{

    /// <summary>
    /// Manage themes and how to apply them.
    /// </summary>
   public static  class ThemesManager
    {

        /// <summary>
        /// The default theme for the application.
        /// </summary>
        public static IThemeFactory AppTheme { get; private set; }

        /// <summary>
        /// Initalize theme for your application.
        /// </summary>
        /// <param name="theme">The theme you want to apply.</param>
        public static void InitializeTheme(IThemeFactory theme)
        {
            AppTheme = theme;
        }

        /// <summary>
        /// Apply the theme in the form and all its controls.
        /// Note : it just works for three levels of controls ie.(ParentControl=>ChildControls=>ChildChildControls).
        /// </summary>
        /// <param name="form">The form want to apply theme.</param>
        public static void SetupUI(Form form)
        {
            form.BackColor = AppTheme.BackgroundColor;
            SetupControl(form);
            foreach (Control control in form.Controls)
            {
                SetupControl(control);
                foreach (Control c in control.Controls)
                {
                    SetupControl(c);
                }
            }
        }

        /// <summary>
        /// Apply the default app theme into control and its child controls.
        /// </summary>
        /// <param name="control">The control you want to apply theme on.</param>
        private static void SetupControl(Control control)
        {
            if (control.HasChildren == false) return;

            foreach (Control subControl in control.Controls)
            {
                switch (subControl.GetType().ToString())
                {
                    case "System.Windows.Forms.Button":
                        subControl.GetType().GetProperty("ForeColor").SetValue(subControl, AppTheme.ButtonForeColor);
                        subControl.GetType().GetProperty("BackColor").SetValue(subControl, AppTheme.ButtonBackColor);
                        subControl.GetType().GetProperty("Font").SetValue(subControl, AppTheme.ButtonsFont);
                        subControl.GetType().GetProperty("FlatStyle").SetValue(subControl, AppTheme.ButtonFlatStyle);
                        ((Button)subControl).FlatAppearance.MouseOverBackColor =  AppTheme.HoverColor;
                        ((Button)subControl).FlatAppearance.BorderSize =  AppTheme.ButtonBorderSize;
                        break;
                    case "System.Windows.Forms.Label":
                        subControl.GetType().GetProperty("ForeColor").SetValue(subControl, AppTheme.ButtonForeColor);
                        subControl.GetType().GetProperty("BackColor").SetValue(subControl, AppTheme.ButtonBackColor);
                        break;
                    case "System.Windows.Forms.DataGridView":
                        ((DataGridView)subControl).EnableHeadersVisualStyles = false;
                        ((DataGridView)subControl).GridColor = AppTheme.DGVGridColor;
                        ((DataGridView)subControl).ColumnHeadersDefaultCellStyle.BackColor = AppTheme.DGVColumnHeaderBackColor;
                        ((DataGridView)subControl).ColumnHeadersDefaultCellStyle.ForeColor = AppTheme.DGVColumnHeaderForeColor;
                        ((DataGridView)subControl).BackgroundColor = AppTheme.DGVBackgroundColor;
                        ((DataGridView)subControl).ColumnHeadersBorderStyle = AppTheme.DGVHeaderBorderStyle;
                        ((DataGridView)subControl).RowHeadersDefaultCellStyle.BackColor = AppTheme.DGVRowBackgroundColor;
                        ((DataGridView)subControl).RowHeadersDefaultCellStyle.SelectionBackColor = AppTheme.SelectionColor;
                        ((DataGridView)subControl).RowHeadersDefaultCellStyle.ForeColor  = AppTheme.DGVRowForeColor;
                        ((DataGridView)subControl).RowHeadersDefaultCellStyle.SelectionForeColor = AppTheme.DGVRowSelectionForeColor;
                        break;
                    case "System.Windows.Forms.GroupBox":
                        subControl.GetType().GetProperty("ForeColor").SetValue(subControl, AppTheme.HeadersForeColor);
                        subControl.GetType().GetProperty("Font").SetValue(subControl, AppTheme.HeadersFont);
                        break;
                    default:
                        break;
                }
            }
        }

    }

}
