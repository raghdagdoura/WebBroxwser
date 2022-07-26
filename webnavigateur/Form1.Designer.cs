﻿
namespace webnavigateur
{
  partial class MainForm
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
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.accueilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.webBrowser = new System.Windows.Forms.WebBrowser();
      this.buttonNext = new System.Windows.Forms.Button();
      this.buttonRefresh = new System.Windows.Forms.Button();
      this.buttonStop = new System.Windows.Forms.Button();
      this.buttonForward = new System.Windows.Forms.Button();
      this.AddressBar = new System.Windows.Forms.TextBox();
      this.History = new System.Windows.Forms.ListBox();
      this.Favoris = new System.Windows.Forms.ListBox();
      this.buttonfav = new System.Windows.Forms.Button();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accueilToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(1084, 24);
      this.menuStrip1.TabIndex = 0;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // accueilToolStripMenuItem
      // 
      this.accueilToolStripMenuItem.Name = "accueilToolStripMenuItem";
      this.accueilToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
      this.accueilToolStripMenuItem.Text = "Accueil";
      this.accueilToolStripMenuItem.Click += new System.EventHandler(this.accueilToolStripMenuItem_Click);
      // 
      // webBrowser
      // 
      this.webBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.webBrowser.Location = new System.Drawing.Point(139, 98);
      this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
      this.webBrowser.Name = "webBrowser";
      this.webBrowser.Size = new System.Drawing.Size(770, 435);
      this.webBrowser.TabIndex = 1;
      this.webBrowser.Url = new System.Uri("https://google.fr", System.UriKind.Absolute);
      this.webBrowser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser_DocumentCompleted);
      // 
      // buttonNext
      // 
      this.buttonNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.buttonNext.Location = new System.Drawing.Point(834, 69);
      this.buttonNext.Name = "buttonNext";
      this.buttonNext.Size = new System.Drawing.Size(75, 23);
      this.buttonNext.TabIndex = 2;
      this.buttonNext.Text = "Suivant";
      this.buttonNext.UseVisualStyleBackColor = true;
      this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
      // 
      // buttonRefresh
      // 
      this.buttonRefresh.Location = new System.Drawing.Point(229, 69);
      this.buttonRefresh.Name = "buttonRefresh";
      this.buttonRefresh.Size = new System.Drawing.Size(75, 23);
      this.buttonRefresh.TabIndex = 3;
      this.buttonRefresh.Text = "rafraîchir";
      this.buttonRefresh.UseVisualStyleBackColor = true;
      this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
      // 
      // buttonStop
      // 
      this.buttonStop.Location = new System.Drawing.Point(139, 69);
      this.buttonStop.Name = "buttonStop";
      this.buttonStop.Size = new System.Drawing.Size(75, 23);
      this.buttonStop.TabIndex = 4;
      this.buttonStop.Text = "Stop";
      this.buttonStop.UseVisualStyleBackColor = true;
      this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
      // 
      // buttonForward
      // 
      this.buttonForward.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.buttonForward.Location = new System.Drawing.Point(741, 69);
      this.buttonForward.Name = "buttonForward";
      this.buttonForward.Size = new System.Drawing.Size(75, 23);
      this.buttonForward.TabIndex = 5;
      this.buttonForward.Text = "Précédent";
      this.buttonForward.UseVisualStyleBackColor = true;
      this.buttonForward.Click += new System.EventHandler(this.buttonForward_Click);
      // 
      // AddressBar
      // 
      this.AddressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.AddressBar.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.AddressBar.Location = new System.Drawing.Point(139, 27);
      this.AddressBar.Name = "AddressBar";
      this.AddressBar.Size = new System.Drawing.Size(770, 29);
      this.AddressBar.TabIndex = 6;
      this.AddressBar.TextChanged += new System.EventHandler(this.AddressBar_TextChanged);
      this.AddressBar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddressBar_KeyDown);
      // 
      // History
      // 
      this.History.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
      this.History.FormattingEnabled = true;
      this.History.Location = new System.Drawing.Point(0, 31);
      this.History.Name = "History";
      this.History.Size = new System.Drawing.Size(133, 498);
      this.History.TabIndex = 7;
      this.History.SelectedIndexChanged += new System.EventHandler(this.History_SelectedIndexChanged);
      // 
      // Favoris
      // 
      this.Favoris.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.Favoris.FormattingEnabled = true;
      this.Favoris.Location = new System.Drawing.Point(915, 31);
      this.Favoris.Name = "Favoris";
      this.Favoris.Size = new System.Drawing.Size(140, 498);
      this.Favoris.TabIndex = 8;
      this.Favoris.SelectedIndexChanged += new System.EventHandler(this.Favoris_SelectedIndexChanged);
      // 
      // buttonfav
      // 
      this.buttonfav.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.buttonfav.Location = new System.Drawing.Point(915, 2);
      this.buttonfav.Name = "buttonfav";
      this.buttonfav.Size = new System.Drawing.Size(140, 23);
      this.buttonfav.TabIndex = 9;
      this.buttonfav.Text = "Add Fav";
      this.buttonfav.UseVisualStyleBackColor = true;
      this.buttonfav.Click += new System.EventHandler(this.buttonfav_Click);
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1084, 561);
      this.Controls.Add(this.buttonfav);
      this.Controls.Add(this.Favoris);
      this.Controls.Add(this.History);
      this.Controls.Add(this.AddressBar);
      this.Controls.Add(this.buttonForward);
      this.Controls.Add(this.buttonStop);
      this.Controls.Add(this.buttonRefresh);
      this.Controls.Add(this.buttonNext);
      this.Controls.Add(this.webBrowser);
      this.Controls.Add(this.menuStrip1);
      this.MainMenuStrip = this.menuStrip1;
      this.MaximumSize = new System.Drawing.Size(1100, 600);
      this.Name = "MainForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Web Navigateur";
      this.Load += new System.EventHandler(this.MainForm_Load);
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem accueilToolStripMenuItem;
    private System.Windows.Forms.WebBrowser webBrowser;
    private System.Windows.Forms.Button buttonNext;
    private System.Windows.Forms.Button buttonRefresh;
    private System.Windows.Forms.Button buttonStop;
    private System.Windows.Forms.Button buttonForward;
    private System.Windows.Forms.TextBox AddressBar;
    private System.Windows.Forms.ListBox History;
    private System.Windows.Forms.ListBox Favoris;
    private System.Windows.Forms.Button buttonfav;
  }
}

