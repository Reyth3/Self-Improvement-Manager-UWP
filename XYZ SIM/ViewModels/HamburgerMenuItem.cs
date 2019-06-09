using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace XYZ_SIM.ViewModels
{
    public class HamburgerMenuItem
    {
        public string Text { get; set; }
        public char Icon { get; set; }
        public Type DestinationPage { get; set; }
        public Action DestinationAction { get; set; }

        public HamburgerMenuItem(string text, char glyph, Type page = null, Action action = null)
        {
            Text = text;
            Icon = glyph;
            DestinationPage = page;
            DestinationAction = action;
        }
    }
}
