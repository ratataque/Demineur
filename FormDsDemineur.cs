using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demineur
{
    public partial class FormDsDemineur : Form
    {
        private string niveau;
        private int s1 = 0, s2 = 0, m1 = 0, m2 =0;
        string time;
        Grille grille;

        public FormDsDemineur()
        {
            InitializeComponent();

            chrono.Interval = 1000;
            chrono.Tick += new EventHandler(chrono_Tick);
            this.MaximizeBox = false;
        }


        private void sousMenuDebutant_Click(object sender, EventArgs e)
        {
            niveau = "debutant";
            lbl_nombreDeMinesRestantes.Text = "10";
            lbl_chronometre.Text = "00:00"; s1 = 0; s2 = 0; m1 = 0; m2 = 0;
            lbl_message.Text = "--";
            pnl_plateau.Controls.Clear();
            chrono.Start();
            

            grille = new Grille(niveau, this);
        }


        private void sousMenuIntermediare_Click(object sender, EventArgs e)
        {
            niveau = "intermediaire";
            lbl_nombreDeMinesRestantes.Text = "40";
            lbl_chronometre.Text = "00:00"; s1 = 0; s2 = 0; m1 = 0; m2 = 0;
            lbl_message.Text = "--";
            pnl_plateau.Controls.Clear();
            chrono.Start();

            grille = new Grille(niveau, this);
        }

        private void sousMenuExpert_Click(object sender, EventArgs e)
        {
            niveau = "expert";
            lbl_nombreDeMinesRestantes.Text = "80";
            lbl_chronometre.Text = "00:00"; s1 = 0; s2 = 0; m1 = 0; m2 = 0;
            lbl_message.Text = "--";
            pnl_plateau.Controls.Clear();
            chrono.Start();
            
            grille = new Grille(niveau, this);
        }
        private void sousMenuAide_Click(object sender, EventArgs e)
        {
            grille.afficherLaGrille();
        }

        private void chrono_Tick(object sender, EventArgs e)
        {

            s1++;
            
            if (s1 > 9)
            {
                s1 = 0;
                s2++;
            }
            if (s2 > 5)
            {
                s2 = 0;
                m1++;
            }
            if (m1 > 9)
            {
                m1 = 0;
                m2++;
            }
            time = m2.ToString() + m1.ToString() + ":" + s2.ToString() + s1.ToString();

            lbl_chronometre.Text = time;
        }
    }
}
