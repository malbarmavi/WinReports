namespace WinReports
  {
  partial class WinReports
    {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose ( bool disposing )
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
    private void InitializeComponent ()
      {
      this.components = new System.ComponentModel.Container();
      this.WebView = new System.Windows.Forms.WebBrowser();
      this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.contextMenu.SuspendLayout();
      this.SuspendLayout();
      // 
      // WebView
      // 
      this.WebView.AllowNavigation = false;
      this.WebView.AllowWebBrowserDrop = false;
      this.WebView.ContextMenuStrip = this.contextMenu;
      this.WebView.Dock = System.Windows.Forms.DockStyle.Fill;
      this.WebView.IsWebBrowserContextMenuEnabled = false;
      this.WebView.Location = new System.Drawing.Point(0, 0);
      this.WebView.MinimumSize = new System.Drawing.Size(20, 20);
      this.WebView.Name = "WebView";
      this.WebView.Size = new System.Drawing.Size(802, 641);
      this.WebView.TabIndex = 0;
      this.WebView.WebBrowserShortcutsEnabled = false;
      // 
      // contextMenu
      // 
      this.contextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
      this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
      this.contextMenu.Name = "contextMenu";
      this.contextMenu.Size = new System.Drawing.Size(126, 30);
      // 
      // aboutToolStripMenuItem
      // 
      this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
      this.aboutToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
      this.aboutToolStripMenuItem.Text = "About";
      this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
      // 
      // WinReports
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(802, 641);
      this.Controls.Add(this.WebView);
      this.Name = "WinReports";
      this.Text = "WinReports";
      this.Load += new System.EventHandler(this.WinReports_Load);
      this.contextMenu.ResumeLayout(false);
      this.ResumeLayout(false);

      }

    #endregion
    public System.Windows.Forms.WebBrowser WebView;
    private System.Windows.Forms.ContextMenuStrip contextMenu;
    private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
  }

