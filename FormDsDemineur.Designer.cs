
namespace Demineur
{
    partial class FormDsDemineur
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.barreMenu = new System.Windows.Forms.MenuStrip();
            this.menuNiveau = new System.Windows.Forms.ToolStripMenuItem();
            this.sousMenuDebutant = new System.Windows.Forms.ToolStripMenuItem();
            this.sousMenuIntermediare = new System.Windows.Forms.ToolStripMenuItem();
            this.sousMenuExpert = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPi = new System.Windows.Forms.ToolStripMenuItem();
            this.sousMenuAide = new System.Windows.Forms.ToolStripMenuItem();
            this.sousMenuApropos = new System.Windows.Forms.ToolStripMenuItem();
            this.pnl_haut = new System.Windows.Forms.Panel();
            this.lbl_chronometre = new System.Windows.Forms.Label();
            this.lbl_nombreDeMinesRestantes = new System.Windows.Forms.Label();
            this.pnl_plateau = new System.Windows.Forms.Panel();
            this.lbl_message = new System.Windows.Forms.Label();
            this.chrono = new System.Windows.Forms.Timer(this.components);
            this.barreMenu.SuspendLayout();
            this.pnl_haut.SuspendLayout();
            this.SuspendLayout();
            // 
            // barreMenu
            // 
            this.barreMenu.AutoSize = false;
            this.barreMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.barreMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuNiveau,
            this.menuPi});
            this.barreMenu.Location = new System.Drawing.Point(0, 0);
            this.barreMenu.Name = "barreMenu";
            this.barreMenu.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.barreMenu.Size = new System.Drawing.Size(624, 31);
            this.barreMenu.TabIndex = 0;
            // 
            // menuNiveau
            // 
            this.menuNiveau.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sousMenuDebutant,
            this.sousMenuIntermediare,
            this.sousMenuExpert});
            this.menuNiveau.Name = "menuNiveau";
            this.menuNiveau.Size = new System.Drawing.Size(76, 27);
            this.menuNiveau.Text = "Niveaux";
            // 
            // sousMenuDebutant
            // 
            this.sousMenuDebutant.Name = "sousMenuDebutant";
            this.sousMenuDebutant.Size = new System.Drawing.Size(177, 26);
            this.sousMenuDebutant.Text = "Débutant";
            this.sousMenuDebutant.Click += new System.EventHandler(this.sousMenuDebutant_Click);
            // 
            // sousMenuIntermediare
            // 
            this.sousMenuIntermediare.Name = "sousMenuIntermediare";
            this.sousMenuIntermediare.Size = new System.Drawing.Size(177, 26);
            this.sousMenuIntermediare.Text = "Intermédiare";
            this.sousMenuIntermediare.Click += new System.EventHandler(this.sousMenuIntermediare_Click);
            // 
            // sousMenuExpert
            // 
            this.sousMenuExpert.Name = "sousMenuExpert";
            this.sousMenuExpert.Size = new System.Drawing.Size(177, 26);
            this.sousMenuExpert.Text = "Expert";
            this.sousMenuExpert.Click += new System.EventHandler(this.sousMenuExpert_Click);
            // 
            // menuPi
            // 
            this.menuPi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sousMenuAide,
            this.sousMenuApropos});
            this.menuPi.Name = "menuPi";
            this.menuPi.Size = new System.Drawing.Size(30, 27);
            this.menuPi.Text = "?";
            // 
            // sousMenuAide
            // 
            this.sousMenuAide.Name = "sousMenuAide";
            this.sousMenuAide.Size = new System.Drawing.Size(152, 26);
            this.sousMenuAide.Text = "Aide";
            this.sousMenuAide.Click += new System.EventHandler(this.sousMenuAide_Click);
            // 
            // sousMenuApropos
            // 
            this.sousMenuApropos.Name = "sousMenuApropos";
            this.sousMenuApropos.Size = new System.Drawing.Size(152, 26);
            this.sousMenuApropos.Text = "A Propos";
            // 
            // pnl_haut
            // 
            this.pnl_haut.Controls.Add(this.lbl_chronometre);
            this.pnl_haut.Controls.Add(this.lbl_nombreDeMinesRestantes);
            this.pnl_haut.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_haut.Location = new System.Drawing.Point(0, 31);
            this.pnl_haut.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_haut.Name = "pnl_haut";
            this.pnl_haut.Padding = new System.Windows.Forms.Padding(13, 12, 13, 0);
            this.pnl_haut.Size = new System.Drawing.Size(624, 92);
            this.pnl_haut.TabIndex = 1;
            // 
            // lbl_chronometre
            // 
            this.lbl_chronometre.AutoSize = true;
            this.lbl_chronometre.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_chronometre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_chronometre.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbl_chronometre.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_chronometre.ForeColor = System.Drawing.Color.LawnGreen;
            this.lbl_chronometre.Location = new System.Drawing.Point(458, 12);
            this.lbl_chronometre.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_chronometre.Name = "lbl_chronometre";
            this.lbl_chronometre.Size = new System.Drawing.Size(153, 60);
            this.lbl_chronometre.TabIndex = 3;
            this.lbl_chronometre.Text = "00:00";
            this.lbl_chronometre.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_nombreDeMinesRestantes
            // 
            this.lbl_nombreDeMinesRestantes.AutoSize = true;
            this.lbl_nombreDeMinesRestantes.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_nombreDeMinesRestantes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_nombreDeMinesRestantes.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbl_nombreDeMinesRestantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombreDeMinesRestantes.ForeColor = System.Drawing.Color.Red;
            this.lbl_nombreDeMinesRestantes.Location = new System.Drawing.Point(13, 12);
            this.lbl_nombreDeMinesRestantes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_nombreDeMinesRestantes.Name = "lbl_nombreDeMinesRestantes";
            this.lbl_nombreDeMinesRestantes.Size = new System.Drawing.Size(83, 60);
            this.lbl_nombreDeMinesRestantes.TabIndex = 2;
            this.lbl_nombreDeMinesRestantes.Text = "00";
            // 
            // pnl_plateau
            // 
            this.pnl_plateau.Location = new System.Drawing.Point(107, 240);
            this.pnl_plateau.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_plateau.Name = "pnl_plateau";
            this.pnl_plateau.Size = new System.Drawing.Size(267, 123);
            this.pnl_plateau.TabIndex = 2;
            // 
            // lbl_message
            // 
            this.lbl_message.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_message.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lbl_message.Location = new System.Drawing.Point(0, 123);
            this.lbl_message.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_message.Name = "lbl_message";
            this.lbl_message.Size = new System.Drawing.Size(624, 18);
            this.lbl_message.TabIndex = 3;
            this.lbl_message.Text = "-";
            this.lbl_message.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FormDsDemineur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 606);
            this.Controls.Add(this.lbl_message);
            this.Controls.Add(this.pnl_plateau);
            this.Controls.Add(this.pnl_haut);
            this.Controls.Add(this.barreMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.barreMenu;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormDsDemineur";
            this.Text = "Démineur";
            this.barreMenu.ResumeLayout(false);
            this.barreMenu.PerformLayout();
            this.pnl_haut.ResumeLayout(false);
            this.pnl_haut.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem menuNiveau;
        private System.Windows.Forms.ToolStripMenuItem sousMenuDebutant;
        private System.Windows.Forms.ToolStripMenuItem sousMenuIntermediare;
        private System.Windows.Forms.ToolStripMenuItem sousMenuExpert;
        private System.Windows.Forms.ToolStripMenuItem menuPi;
        private System.Windows.Forms.ToolStripMenuItem sousMenuAide;
        private System.Windows.Forms.ToolStripMenuItem sousMenuApropos;
        private System.Windows.Forms.Label lbl_chronometre;
        public System.Windows.Forms.Timer chrono;
        public System.Windows.Forms.Panel pnl_plateau;
        public System.Windows.Forms.MenuStrip barreMenu;
        public System.Windows.Forms.Panel pnl_haut;
        public System.Windows.Forms.Label lbl_message;
        public System.Windows.Forms.Label lbl_nombreDeMinesRestantes;
    }
}

