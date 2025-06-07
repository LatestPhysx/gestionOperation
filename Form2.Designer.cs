namespace gestionOperation
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.clientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterClientToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.afficherClientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterOperationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afficherOperationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientToolStripMenuItem,
            this.operationToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(146, 52);
            // 
            // clientToolStripMenuItem
            // 
            this.clientToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterClientToolStripMenuItem,
            this.listeClientToolStripMenuItem});
            this.clientToolStripMenuItem.Name = "clientToolStripMenuItem";
            this.clientToolStripMenuItem.Size = new System.Drawing.Size(145, 24);
            this.clientToolStripMenuItem.Text = "Client";
            // 
            // ajouterClientToolStripMenuItem
            // 
            this.ajouterClientToolStripMenuItem.Name = "ajouterClientToolStripMenuItem";
            this.ajouterClientToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.ajouterClientToolStripMenuItem.Text = "Ajouter Client";
            // 
            // listeClientToolStripMenuItem
            // 
            this.listeClientToolStripMenuItem.Name = "listeClientToolStripMenuItem";
            this.listeClientToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.listeClientToolStripMenuItem.Text = "Liste Client";
            // 
            // operationToolStripMenuItem
            // 
            this.operationToolStripMenuItem.Name = "operationToolStripMenuItem";
            this.operationToolStripMenuItem.Size = new System.Drawing.Size(145, 24);
            this.operationToolStripMenuItem.Text = "Operation";
            this.operationToolStripMenuItem.Click += new System.EventHandler(this.operationToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1294, 30);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientToolStripMenuItem1,
            this.operationsToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(60, 26);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // clientToolStripMenuItem1
            // 
            this.clientToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterClientToolStripMenuItem1,
            this.afficherClientsToolStripMenuItem});
            this.clientToolStripMenuItem1.Name = "clientToolStripMenuItem1";
            this.clientToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.clientToolStripMenuItem1.Text = "Clients";
            this.clientToolStripMenuItem1.Click += new System.EventHandler(this.clientToolStripMenuItem1_Click_1);
            // 
            // ajouterClientToolStripMenuItem1
            // 
            this.ajouterClientToolStripMenuItem1.Name = "ajouterClientToolStripMenuItem1";
            this.ajouterClientToolStripMenuItem1.Size = new System.Drawing.Size(192, 26);
            this.ajouterClientToolStripMenuItem1.Text = "Ajouter Client";
            this.ajouterClientToolStripMenuItem1.Click += new System.EventHandler(this.ajouterClientToolStripMenuItem1_Click);
            // 
            // afficherClientsToolStripMenuItem
            // 
            this.afficherClientsToolStripMenuItem.Name = "afficherClientsToolStripMenuItem";
            this.afficherClientsToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.afficherClientsToolStripMenuItem.Text = "Afficher Clients";
            this.afficherClientsToolStripMenuItem.Click += new System.EventHandler(this.afficherClientsToolStripMenuItem_Click);
            // 
            // operationsToolStripMenuItem
            // 
            this.operationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterOperationToolStripMenuItem,
            this.afficherOperationToolStripMenuItem});
            this.operationsToolStripMenuItem.Name = "operationsToolStripMenuItem";
            this.operationsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.operationsToolStripMenuItem.Text = "Operations";
            // 
            // ajouterOperationToolStripMenuItem
            // 
            this.ajouterOperationToolStripMenuItem.Name = "ajouterOperationToolStripMenuItem";
            this.ajouterOperationToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.ajouterOperationToolStripMenuItem.Text = "Ajouter Operation";
            this.ajouterOperationToolStripMenuItem.Click += new System.EventHandler(this.ajouterOperationToolStripMenuItem_Click);
            // 
            // afficherOperationToolStripMenuItem
            // 
            this.afficherOperationToolStripMenuItem.Name = "afficherOperationToolStripMenuItem";
            this.afficherOperationToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.afficherOperationToolStripMenuItem.Text = "Afficher Operation";
            this.afficherOperationToolStripMenuItem.Click += new System.EventHandler(this.afficherOperationToolStripMenuItem_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1294, 588);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operationToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ajouterClientToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem afficherClientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterOperationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afficherOperationToolStripMenuItem;
    }
}