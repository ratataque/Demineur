using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Demineur
{
    class Grille
    {
        private FormDsDemineur FenetreMere;
        private string NiveauDeJeu;
        private int LargeurEmplacement = 30;
        private int NbreDeCasesHorizontales; 
        private int NbreDeCasesVerticales;
        private int NbreDeMines;
        private int NbreDeMinesRestantes;
        private int NbreDeMinesReellementTrouvees;
        private List <Cellule> ListeDesCellules = new List<Cellule>();

        public Grille(string niveau, FormDsDemineur mere)
        {
            FenetreMere = mere;
            NiveauDeJeu = niveau;

            commenceLeJeu(niveau);

        }

        private void commenceLeJeu(String niveau)
        {
            initialisationDesVariables();

            dessinerLePlateau();

            poserLesMines();

            placerLesIndices();

        }

        private void initialisationDesVariables()
        {
            int debutant = 81, intermediare = 256, expert = 484;
            switch (NiveauDeJeu)
            {
                case "debutant":                   // si le niveau de jeu est debutant, initialise les variables de la grille et des mines en fonction
                    NbreDeCasesHorizontales = (int)Math.Sqrt(debutant);
                    NbreDeCasesVerticales = (int)Math.Sqrt(debutant);
                    NbreDeMines = 10;
                    break;

                case "intermediaire":
                    NbreDeCasesHorizontales = (int)Math.Sqrt(intermediare);
                    NbreDeCasesVerticales = (int)Math.Sqrt(intermediare);
                    NbreDeMines = 40;
                    break;

                case "expert":
                    NbreDeCasesHorizontales = (int)Math.Sqrt(expert);
                    NbreDeCasesVerticales = (int)Math.Sqrt(expert);
                    NbreDeMines = 80;
                    break;

                default:
                    break;
            }

            NbreDeMinesReellementTrouvees = 0;   // zéro mines touvé à l'initialisation du jeu

            NbreDeMinesRestantes = NbreDeMines;  // reste toutes les mines à l'initialisation du jeu

        }

        private void dessinerLePlateau()
        {
            
            // top vas être la taille y combiné de la barre menu ainsi que le panel avec le chrono et les mines restantes, puis le label msg
            int top = FenetreMere.barreMenu.Height + FenetreMere.pnl_haut.Height + FenetreMere.lbl_message.Height;

            FenetreMere.pnl_plateau.Location = new Point(0, top);  // on place la grille sous le tout
            FenetreMere.pnl_plateau.Width = NbreDeCasesHorizontales * LargeurEmplacement;
            FenetreMere.pnl_plateau.Height = NbreDeCasesVerticales * LargeurEmplacement;

            FenetreMere.Height = top + FenetreMere.pnl_plateau.Height + LargeurEmplacement + 10 ;
            FenetreMere.Width =FenetreMere.pnl_plateau.Width + 16;

            int count = 1;
            for (int i = 0; i < NbreDeCasesVerticales; i++)
            {
                for (int j = 0; j < NbreDeCasesHorizontales; j++)
                {
                    Cellule cel = new Cellule();
                    cel.Name = count.ToString();
                    cel.setPosition(count,NbreDeCasesVerticales, NbreDeCasesHorizontales);
                    //cel.Text = cel.getPostion();
                    cel.Width = LargeurEmplacement;
                    cel.Height = LargeurEmplacement;
                    cel.Location = new Point(j * LargeurEmplacement, i * LargeurEmplacement);
                    ListeDesCellules.Add(cel);
                    FenetreMere.pnl_plateau.Controls.Add(cel);
                    cel.MouseClick += new MouseEventHandler(this.CelluleClick);     // 
                    cel.MouseUp += new MouseEventHandler(this.celluleMouseDown);
                    count++;

                }
            }

        }

        private void poserLesMines()
        {

            Random rnd = new Random();
            List<int> lstmine = new List<int>();
            int num;

            while ( lstmine.Count < NbreDeMines)
            {
                num = rnd.Next(0, NbreDeCasesHorizontales * NbreDeCasesVerticales);
                if (!ListeDesCellules[num].estMinee())
                {
                    lstmine.Add(num);
                    ListeDesCellules[num].miner();
                }
            }
        }

        private void placerIndiceDansLaCellule(int index)
        {
            List<int> lstmine = new List<int>();
            List<int> lstpos = new List<int>();
            lstpos = getCelluleAutour(index);

            if (!ListeDesCellules[index].estMinee())
            {
                for (int j = 0; j < lstpos.Count(); j++)
                {
                    int pos = lstpos[j];
                    Cellule current = ListeDesCellules[pos];
                    if (current.estMinee())
                    {
                        lstmine.Add(pos);
                    }
                }
                ListeDesCellules[index].setIndice(lstmine.Count);
            }

        }

        private void placerLesIndices()
        {
            for (int j = 0; j < ListeDesCellules.Count; j++)
            {
                placerIndiceDansLaCellule(j);
            }

        }

        private void traitementMineTrouvee(Cellule cellule)
        {
            if (cellule.BackgroundImage != null & NbreDeMinesRestantes >= 0)
            {
                NbreDeMinesReellementTrouvees++;
                if (NbreDeMinesReellementTrouvees >= NbreDeMines)
                {
                    if (checkSifini(ListeDesCellules))
                    {
                        annoncerVictoire();
                    }
                }
            }
            else if (cellule.BackgroundImage == null)
            {
                NbreDeMinesReellementTrouvees--;
            }
        }

        private void traitementMinePeutEtre(Cellule cellule)
        {
            if (cellule.BackgroundImage == null & cellule.Text == "")
            {
                if (NbreDeMinesRestantes > 0)
                {
                    NbreDeMinesRestantes--;
                    FenetreMere.lbl_nombreDeMinesRestantes.Text = (NbreDeMinesRestantes).ToString();
                    cellule.BackgroundImageLayout = ImageLayout.Stretch;
                    cellule.BackgroundImage = Demineur.Properties.Resources.flag;
                }
            }
            else if (cellule.BackgroundImage != null)
            {
                NbreDeMinesRestantes++;
                FenetreMere.lbl_nombreDeMinesRestantes.Text = (NbreDeMinesRestantes).ToString();
                cellule.BackgroundImage = null;
            }
        }
        
        private void annoncerVictoire()
        {
            FenetreMere.lbl_message.Text = "Bien joué chacal";
            FenetreMere.chrono.Stop();
            for (int i = 0; i < ListeDesCellules.Count(); i++)
            {
                ListeDesCellules[i].Enabled = false;
            }
        }

        

        private void CelluleClick(object sender, EventArgs e)
        {

            Cellule cel = (Cellule)sender;

            if (cel.estMinee())
            {
                annoncerEchec();
                cel.afficherMineRouge();
                FenetreMere.chrono.Stop();

                for (int i = 0; i < ListeDesCellules.Count(); i++)
                {
                    ListeDesCellules[i].Enabled = false;
                }
            }
            else if (cel.estVide())
            {
                cel.vider();
                cel.decouvre();

                int num = Convert.ToInt32(cel.Name);
                
                List<int> lstpos = new List<int>();
                lstpos = getCelluleAutour(num - 1);

                for (int i = 0; i < lstpos.Count(); i++)
                {
                    int pos = lstpos[i];
                    CelluleClick(ListeDesCellules[pos], e);
                }
            }
            else
            {
                cel.afficherIndice();
                cel.decouvre();

                if (checkSifini(ListeDesCellules))
                {
                    annoncerVictoire();
                }

                if (cel.BackgroundImage != null)
                {
                    cel.BackgroundImage = null;
                    NbreDeMinesRestantes++;
                    FenetreMere.lbl_nombreDeMinesRestantes.Text = (NbreDeMinesRestantes).ToString();
                }
            }
        }

        private void celluleMouseDown(object sender, MouseEventArgs e)
        {
            Cellule cel = (Cellule)sender;

            if (cel.estMinee() & ((cel.background != "minerouge") & (cel.background != "minenoire")))
            {
                traitementMinePeutEtre(cel);
                traitementMineTrouvee(cel);
            }
            else if (!cel.estMinee())
            {
                traitementMinePeutEtre(cel);
            }
        }

        private void annoncerEchec()
        {
            FenetreMere.lbl_message.Text = "t'as perdu chacal";
            afficherLaGrille();
        }

        public void afficherLaGrille()
        {
            for (int i = 0; i < ListeDesCellules.Count; i++)
            {
                if (ListeDesCellules[i].estMinee())
                {   
                    ListeDesCellules[i].afficherMineNoire();
                }
            }
        }

        private void affecterGroupe(int index, int groupe)
        {

        }

        private void grouperLesCellulesVides()
        {

        }

        private List<int> getCelluleAutour(int index)
        {
            List<int> lst = new List<int>();
            switch (ListeDesCellules[index].getPostion())
            {

                case "coinHautGauche":
                    lst.Clear();
                    for (int j = 0; j < 2; j++)
                    {
                        for (int k = 0; k < 2; k++)
                        {
                            lst.Add(index + NbreDeCasesHorizontales * j + k);    
                        }
                    }
                    return lst;
                    break;

                case "coinHautDroite":
                    lst.Clear();
                    for (int j = 0; j < 2; j++)
                    {
                        for (int k = -1; k < 1; k++)
                        {
                            lst.Add(index + NbreDeCasesHorizontales * j + k); 
                        }
                    }
                    return lst;
                    break;

                case "coinBasGauche":
                    lst.Clear();
                    for (int j = -1; j < 1; j++)
                    {
                        for (int k = 0; k < 2; k++)
                        {
                            lst.Add(index + NbreDeCasesHorizontales * j + k);
                        }
                    }
                    return lst;
                    break;

                case "coinBasDroite":
                    lst.Clear();
                    for (int j = -1; j < 1; j++)
                    {
                        for (int k = -1; k < 1; k++)
                        {
                            lst.Add(index + NbreDeCasesHorizontales * j + k);
                        }
                    }
                    return lst;
                    break;

                case "haut":
                    lst.Clear();
                    for (int j = 0; j < 2; j++)
                    {
                        for (int k = -1; k < 2; k++)
                        {
                            lst.Add(index + NbreDeCasesHorizontales * j + k);
                        }
                    }
                    return lst;
                    break;

                case "gauche":
                    lst.Clear();
                    for (int j = -1; j < 2; j++)
                    {
                        for (int k = 0; k < 2; k++)
                        {
                            lst.Add(index + NbreDeCasesHorizontales * j + k);
                        }
                    }
                    return lst;
                    break;

                case "droite":
                    lst.Clear();
                    for (int j = -1; j < 2; j++)
                    {
                        for (int k = -1; k < 1; k++)
                        {
                            lst.Add(index + NbreDeCasesHorizontales * j + k);
                        }
                    }
                    return lst;
                    break;

                case "bas":
                    lst.Clear();
                    for (int j = -1; j < 1; j++)
                    {
                        for (int k = -1; k < 2; k++)
                        {
                            lst.Add(index + NbreDeCasesHorizontales * j + k);
                        }
                    }
                    return lst;
                    break;

                default:
                    lst.Clear();
                    for (int j = -1; j < 2; j++)
                    {
                        for (int k = -1; k < 2; k++)
                        {
                            lst.Add(index + NbreDeCasesHorizontales * j + k);
                        }
                    }
                    return lst;
                    break;
            }
        }

        private bool checkSifini(List<Cellule> lst)
        {
            bool state = true;
            for (int i = 0; i < lst.Count(); i++)
            {
                if (lst[i].BackgroundImage == null)
                {
                    if (!lst[i].estDecouvert())
                    {
                        state = false;
                    }
                }
            }

            return state;
        }
    }   
}
