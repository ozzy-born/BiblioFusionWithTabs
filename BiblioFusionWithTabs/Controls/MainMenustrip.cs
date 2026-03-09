using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace BiblioFusionWithTabs.Controls
{
    public class MainMenustrip : MenuStrip
    {
        private const string NAME = "MainMenuStrip";
        public MainMenustrip()
        {
            Name = NAME;
            Dock = DockStyle.Top;
            OptionsMenu();
            LogOut();
        }
        /* *ancien code des menus
        public void TableauDeBord()
        {
            var tabDeBord = new ToolStripMenuItem("Tableau De Bord");
            Items.Add(tabDeBord);


        }
        public void Search()
        {
            var rechercher = new ToolStripMenuItem("Rechercher");

            var adherant = new ToolStripMenuItem("Adhérant");
            var livre = new ToolStripMenuItem("Livre");
            var jouet = new ToolStripMenuItem("Jouet");

            rechercher.DropDownItems.AddRange(new ToolStripMenuItem[] { adherant, livre, jouet });

            Items.Add(rechercher);
        }
        public void Scan()
        {
            var scanner = new ToolStripMenuItem("Scanner");

            var smartphone = new ToolStripMenuItem("Smartphone");
            var scannette = new ToolStripMenuItem("Scannette");

            scanner.DropDownItems.AddRange(new ToolStripMenuItem[] { smartphone, scannette });
            Items.Add(scanner);
        }
        public void Stats()
        {
            var statistiques = new ToolStripMenuItem("Statistiques");
            Items.Add(statistiques);
        }
        */

        public void OptionsMenu()
        {
            var options = new ToolStripMenuItem("Options");

            var menuLivreJouet = new ToolStripMenuItem("Livre / Jouet");
            var ajoutLivreJouet = new ToolStripMenuItem("Ajouter un Livre / Jouet");
            var supprLivreJouet = new ToolStripMenuItem("Supprimer un Livre / Jouet");
            var gestionLivreJouet = new ToolStripMenuItem("Gérer les Livres / Jouets Existants");

            var menuCategorie = new ToolStripMenuItem("Catégorie");
            var ajoutCategorie = new ToolStripMenuItem("Ajouter une Catégorie");
            var supprCategorie = new ToolStripMenuItem("Supprimer une Catégorie");
            var gestionCategorie = new ToolStripMenuItem("Gérer les Catégories Existantes");

            var menuAdherant = new ToolStripMenuItem("Adhérant");
            var ajoutAdherant = new ToolStripMenuItem("Ajouter un Adhérant");
            var supprAdherant = new ToolStripMenuItem("Supprimer un Adhérant");
            var gestionAdherant = new ToolStripMenuItem("Gérer les Adhérants Existants");

            var menuAdmin = new ToolStripMenuItem("Administateur");
            var ajoutAdmin = new ToolStripMenuItem("Ajouter un Administateur");
            var supprAdmin = new ToolStripMenuItem("Supprimer un Administateur");
            var gestionAdmin = new ToolStripMenuItem("Gérer les Administateurs Existants");

            menuLivreJouet.DropDownItems.AddRange(new ToolStripMenuItem[] { ajoutLivreJouet, supprLivreJouet, gestionLivreJouet });
            menuCategorie.DropDownItems.AddRange(new ToolStripMenuItem[] { ajoutCategorie, supprCategorie, gestionCategorie });
            menuAdherant.DropDownItems.AddRange(new ToolStripMenuItem[] { ajoutAdherant, supprAdherant, gestionAdherant });
            menuAdmin.DropDownItems.AddRange(new ToolStripMenuItem[] { ajoutAdmin, supprAdmin, gestionAdmin });

            options.DropDownItems.AddRange(new ToolStripMenuItem[] { menuLivreJouet, menuCategorie, menuAdherant, menuAdmin });

            Items.Add(options);
        }
        public void LogOut()
        {
            var deconnexion = new ToolStripMenuItem("Déconnexion");
            deconnexion.BackColor = Color.LightGray;
            deconnexion.ForeColor = Color.Blue;
            deconnexion.Click += (s, e) =>
            {
                var fermeture = MessageBox.Show("Êtes-vous sûr de vouloir vous déconnecter ?", "Confirmation de déconnexion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (fermeture == DialogResult.Yes)
                {
                    Application.Exit();
                }
            };
            Items.Add(deconnexion);
        }
    }
}
