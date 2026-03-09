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
using WindowsFormsApp1;

namespace BiblioFusionWithTabs
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            var connectionForm = new Form_connexion();
            connectionForm.ShowDialog();
            var mainMenuStrip = new MainMenustrip();
            var mainTabControl = new MainTabControl();
            var labelFont = new Font(Name, 16, FontStyle.Bold);
            var tabFont = new Font(Name, 12, FontStyle.Regular);
            mainTabControl.TabPages.AddRange(new TabPage[] { new TabPage("Tableau De Bord"), new TabPage("Rechercher"), new TabPage("Scanner"), new TabPage("Statistiques") });

            mainTabControl.TabPages[0].BackColor = Color.LightSteelBlue;
            mainTabControl.TabPages[1].BackColor = Color.LightSteelBlue;
            mainTabControl.TabPages[2].BackColor = Color.LightSteelBlue;
            mainTabControl.TabPages[3].BackColor = Color.LightSteelBlue;

            mainTabControl.TabPages[0].Controls.AddRange(new Control[]
            {

                new Label() { Text = "Retards", AutoSize = true, Font = labelFont, Location = new Point(30, 20)},
                new ListView() { Columns = { "Titre", "Nom", "Date" }, Location = new Point(30, 60), Size = new Size(200, 400)},
                new Label() { Text = "Retours", AutoSize = true, Font = labelFont, Location = new Point(285, 20) },
                new ListView() { Columns = { "Titre", "Nom", "Date" }, Location = new Point(285, 60), Size = new Size(200, 400)},
                new Label() { Text = "Réservations", AutoSize = true, Font = labelFont, Location = new Point(540, 20) },
                new ListView() { Columns = { "Titre", "Nom", "Date de retour" }, Location = new Point(540, 60), Size = new Size(200, 400)},
            });


            mainTabControl.TabPages[1].Controls.AddRange(new Control[]
            {

            });

            mainTabControl.TabPages[2].Controls.AddRange(new Control[]
            {

            });

            mainTabControl.TabPages[3].Controls.AddRange(new Control[]
            {

            });

            Controls.AddRange(new Control[] { mainTabControl , mainMenuStrip });

        }
    }
}
