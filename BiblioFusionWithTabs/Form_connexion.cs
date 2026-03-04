using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BiblioFusionWithTabs.Controls;

namespace WindowsFormsApp1
{
    public partial class ConnexionForm : Form
    {
        public ConnexionForm()
        {
            InitializeComponent();

            var mainFont = new Font(Name, 30, FontStyle.Regular);

            Label titleLabel = new Label()
            {
                Text = "BiblioFusion",
                AutoSize = true,
                Font = mainFont,
                TextAlign = ContentAlignment.MiddleCenter
            };
            
            Label idLabel = new Label()
            {
                Text = "Identifiant :",
                AutoSize = true,
                Font = mainFont,
                Location = new Point(20, 120)
            };

            Label mdpLabel = new Label()
            {
                Text = "Mot de passe :",
                AutoSize = true,
                Font = mainFont,
                Location = new Point(20, 220)
            };

            TextBox idTextBox = new TextBox
            {
                Location = new Point(20, 170), Size = new Size(300, 30)
            };

            TextBox mdpTextBox = new TextBox
            {
                Location = new Point(20, 170),
                Size = new Size(300, 30)
            };

            Controls.AddRange(new Control[]{ titleLabel, idTextBox, idLabel, mdpTextBox, mdpLabel  });
        }
    }
}
