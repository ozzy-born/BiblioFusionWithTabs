using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ConnexionForm : Form
    {
        public ConnexionForm()
        {
            InitializeComponent();
            Label titleLabel = new Label()
            {
                Text = "BiblioFusion",
                Font = new Font(Name, 24, FontStyle.Bold)
            };
        }
    }
}
