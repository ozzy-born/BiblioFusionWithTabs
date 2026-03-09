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
    public partial class Form_connexion : Form
    {
        public Form_connexion()
        {
            InitializeComponent();

            var labelFont = new Font(Name, 16, FontStyle.Bold);
            var titleFont = new Font(Name, 20, FontStyle.Bold);

            BackColor = Color.LightSteelBlue;

            Controls.AddRange(new Control[]
            {
                new Label() { Text = "BiblioFusion", Location = new Point(100, 10), Font = titleFont, AutoSize = true },
                new Label() { Text = "Utilisateur :", Location = new Point(50, 70), Font = labelFont, AutoSize = true },
                new TextBox() { Name = "Utilisateur", Location = new Point(50, 100), Width = 250 },
                new Label() { Text = "Mot de passe :", Location = new Point(50, 150), Font = labelFont, AutoSize = true },
                new TextBox() { Name = "mdp",Location = new Point(50, 180), Width = 250, UseSystemPasswordChar = true },
                new Button() { Text = "Mot de passe oublié ?", Location = new Point(170, 210), AutoSize = true, FlatStyle = FlatStyle.Flat, ForeColor = Color.Blue },
                new Button() { Text = "Se connecter", Font = labelFont, Location = new Point(50, 250), Size = new Size(250, 50), BackColor = Color.LightGray }
            });
        }
    }
}
