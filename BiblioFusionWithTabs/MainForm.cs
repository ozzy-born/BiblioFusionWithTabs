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

            ConnexionForm formConnexion = new ConnexionForm();
            formConnexion.Show();
            var mainMenuStrip = new MainMenustrip();
            var mainTabControl = new MainTabControl();

            mainTabControl.TabPages.AddRange(new TabPage[]
            { 
                new TabPage("Tableau De Bord"),
                new TabPage("Rechercher"),
                new TabPage("Scanner"),
                new TabPage("Statistiques") 
            });

            mainTabControl.TabPages[0].Controls.AddRange(new Control[]
            {

                (new Label() { Text = "BiblioFusion - Tableau de Bord", AutoSize = true, Font = new Font(Name, 16, FontStyle.Bold), Location = new Point(20, 20) }),
                (new ListView() { Location = new Point(20, 60), Size = new Size(200, 400), View = View.Details, Columns = { "Retard" }, Items = { new ListViewItem(new string[] { "150" }) } }),
                (new ListView() { Location = new Point(270, 60), Size = new Size(200, 400), View = View.Details, Columns = { "Retours" }, Items = { new ListViewItem(new string[] { "150" }) } }),
                (new ListView() { Location = new Point(520, 60), Size = new Size(200, 400), View = View.Details, Columns = { "Réservations" }, Items = { new ListViewItem(new string[] { "150" }) } })

            });
            mainTabControl.TabPages[1].Controls.Add(new Label() { Text = "BiblioFusion - Rechercher", AutoSize = true, Font = new Font(Name, 16, FontStyle.Bold), Location = new Point(20, 20) });
            mainTabControl.TabPages[2].Controls.Add(new Label() { Text = "BiblioFusion - Scanner", AutoSize = true, Font = new Font(Name, 16, FontStyle.Bold), Location = new Point(20, 20) });
            mainTabControl.TabPages[3].Controls.Add(new Label() { Text = "BiblioFusion - Statistiques", AutoSize = true, Font = new Font(Name, 16, FontStyle.Bold), Location = new Point(20, 20) });

            Controls.AddRange(new Control[] { mainTabControl , mainMenuStrip });

        }
    }
}
