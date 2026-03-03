using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

        //Ancien MenuStrip
        /*
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
        }*/
        public void OptionsMenu()
        {
            var options = new ToolStripMenuItem("Options");

            var livreJouetMenu = new ToolStripMenuItem("Géstionnaire de Livres / Jouets");
            var ajoutLivreJouet = new ToolStripMenuItem("Ajouter un Livre / Jouet");
            var supprLivreJouet = new ToolStripMenuItem("Supprimer un Livre / Jouet");

            var categorieMenu = new ToolStripMenuItem("Géstionnaire de Catégories");
            var ajoutCategorie = new ToolStripMenuItem("Ajouter une Catégorie");
            var supprCategorie = new ToolStripMenuItem("Supprimer une Catégorie");

            var adherantMenu = new ToolStripMenuItem("Géstionnaire d'Adhérants");
            var ajoutAdherant = new ToolStripMenuItem("Ajouter un Adhérant");
            var supprAdherant = new ToolStripMenuItem("Supprimer un Adhérant");

            var adminMenu = new ToolStripMenuItem("Géstionnaire d'Administateurs");
            var ajoutAdmin = new ToolStripMenuItem("Ajouter un Administateur");
            var supprAdmin = new ToolStripMenuItem("Supprimer un Administateur");
            var gestionAdmin = new ToolStripMenuItem("Gérer les comptes Administrateurs existants");

            livreJouetMenu.DropDownItems.AddRange(new ToolStripMenuItem[] { ajoutLivreJouet, supprLivreJouet });
            categorieMenu.DropDownItems.AddRange(new ToolStripMenuItem[] { ajoutCategorie, supprCategorie });
            adherantMenu.DropDownItems.AddRange(new ToolStripMenuItem[] { ajoutAdherant, supprAdherant });
            adminMenu.DropDownItems.AddRange(new ToolStripMenuItem[] { ajoutAdmin, supprAdmin, gestionAdmin });

            options.DropDownItems.AddRange(new ToolStripMenuItem[] { livreJouetMenu, categorieMenu, adherantMenu, adminMenu });

            Items.Add(options);
        }
        public void LogOut()
        {
            var deconnexion = new ToolStripMenuItem("Déconnexion");
            Items.Add(deconnexion);
        }
    }
}
