using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiblioFusionWithTabs.Controls
{
    internal class MainTabControl : TabControl
    {
        public const string NAME = "MainTabControl";

        public MainTabControl()
        {
            Name = NAME;
            Dock = DockStyle.Fill;
        }
    }
}
