using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demineur
{
    class Cellule : Button
    {
        private string Contenu;
        private int Indice;
        private int Groupe;
        private string Position;
        public string etat;
        public string background;

        public Cellule()
        {
            
        }

        public Boolean estVide()
        {
            if (Indice == 0 & Contenu != "vide")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean estMinee()
        {
            if (Contenu == "M")
            {
                return true;
            }
            else
            {
                return false;
            } 
        }

        public void setIndice(int nbre)
        {
            Indice = nbre;
        }

        public void miner()
        {
            Contenu = "M";
        }

        public void vider()
        {
            Contenu = "vide";
            Visible = false;
        }

        public void afficherIndice()
        {
            Text = Indice.ToString();
        }

        public void afficherMineNoire()
        {
            BackgroundImageLayout = ImageLayout.Stretch;
            BackgroundImage = Demineur.Properties.Resources.minenoir;
            background = "minenoire";
        }

        public void afficherMineRouge()
        {
            BackgroundImageLayout = ImageLayout.Stretch;
            BackgroundImage = Demineur.Properties.Resources.minerouge;
            background = "minerouge";
        }

        public void afficherGroupe()
        {

        }

        public string getContenu()
        {
            return Contenu;
        }

        public void setContenu(string txt)
        {
            Contenu = txt;
        }

        public int getGroupe()
        {
            return 0;
        }

        public void setGroupe(int grp)
        {

        }

        public void afficherPourTester()
        {

        }

        public void setPosition(int index, int nbreCasesVerticales, int nbreCasesHorizontales)
        {
            switch (index)
            {

                case var expression when index == 1:
                    Position = "coinHautGauche";
                    break;

                case var expression when index == nbreCasesHorizontales:
                    Position = "coinHautDroite";
                    break;

                case var expression when index == nbreCasesHorizontales * nbreCasesVerticales - nbreCasesHorizontales + 1:
                    Position = "coinBasGauche";
                    break;

                case var expression when index == nbreCasesVerticales * nbreCasesHorizontales:
                    Position = "coinBasDroite";
                    break;

                case var expression when index <= nbreCasesHorizontales:
                    Position = "haut";
                    break;

                case var expression when ((index % nbreCasesHorizontales) - 1) == 0:
                    Position = "gauche";
                    break;

                case var expression when (index % nbreCasesHorizontales) == 0:
                    Position = "droite";
                    break;

                case var expression when index >= (nbreCasesHorizontales * nbreCasesVerticales - nbreCasesHorizontales):
                    Position = "bas";
                    break;

                default:
                    Position = "centre";
                    break;
            }
        }

        public string getPostion()
        {
            return Position;
        }


        public void decouvre()
        {
            etat = "decouvert";
        }


        public bool estDecouvert()
        {
            if (etat == "decouvert")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
