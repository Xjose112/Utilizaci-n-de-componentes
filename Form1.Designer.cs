namespace AppReutilizacion
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private AxWMPLib.AxWindowsMediaPlayer mediaPlayer;
        private System.Windows.Forms.TextBox textBoxPDF;
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.Button btnAbrirMedia;
        private System.Windows.Forms.Button btnAbrirPDF;
        private System.Windows.Forms.Button btnNavegarWeb;
        private System.Windows.Forms.Button btnReproducirURL;
        private System.Windows.Forms.TextBox textBoxURL;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.mediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.textBoxPDF = new System.Windows.Forms.TextBox();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.btnAbrirMedia = new System.Windows.Forms.Button();
            this.btnAbrirPDF = new System.Windows.Forms.Button();
            this.btnNavegarWeb = new System.Windows.Forms.Button();
            this.btnReproducirURL = new System.Windows.Forms.Button();
            this.textBoxURL = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.mediaPlayer)).BeginInit();
            this.SuspendLayout();

            // 
            // mediaPlayer
            // 
            this.mediaPlayer.Enabled = true;
            this.mediaPlayer.Location = new System.Drawing.Point(12, 12);
            this.mediaPlayer.Name = "mediaPlayer";
            this.mediaPlayer.Size = new System.Drawing.Size(300, 250);
            this.mediaPlayer.TabIndex = 0;

            // 
            // textBoxPDF
            // 
            this.textBoxPDF.Location = new System.Drawing.Point(330, 12);
            this.textBoxPDF.Multiline = true;
            this.textBoxPDF.Name = "textBoxPDF";
            this.textBoxPDF.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxPDF.Size = new System.Drawing.Size(300, 250);
            this.textBoxPDF.TabIndex = 1;

            // 
            // webBrowser
            // 
            this.webBrowser.Location = new System.Drawing.Point(12, 280);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(618, 250);
            this.webBrowser.TabIndex = 2;

            // 
            // btnAbrirMedia
            // 
            this.btnAbrirMedia.Location = new System.Drawing.Point(12, 540);
            this.btnAbrirMedia.Name = "btnAbrirMedia";
            this.btnAbrirMedia.Size = new System.Drawing.Size(100, 30);
            this.btnAbrirMedia.TabIndex = 3;
            this.btnAbrirMedia.Text = "Abrir Media";
            this.btnAbrirMedia.UseVisualStyleBackColor = true;
            this.btnAbrirMedia.Click += new System.EventHandler(this.btnAbrirMedia_Click);

            // 
            // btnAbrirPDF
            // 
            this.btnAbrirPDF.Location = new System.Drawing.Point(330, 540);
            this.btnAbrirPDF.Name = "btnAbrirPDF";
            this.btnAbrirPDF.Size = new System.Drawing.Size(100, 30);
            this.btnAbrirPDF.TabIndex = 4;
            this.btnAbrirPDF.Text = "Abrir PDF";
            this.btnAbrirPDF.UseVisualStyleBackColor = true;
            this.btnAbrirPDF.Click += new System.EventHandler(this.btnAbrirPDF_Click);

            // 
            // btnNavegarWeb
            // 
            this.btnNavegarWeb.Location = new System.Drawing.Point(530, 540);
            this.btnNavegarWeb.Name = "btnNavegarWeb";
            this.btnNavegarWeb.Size = new System.Drawing.Size(100, 30);
            this.btnNavegarWeb.TabIndex = 5;
            this.btnNavegarWeb.Text = "Navegar Web";
            this.btnNavegarWeb.UseVisualStyleBackColor = true;
            this.btnNavegarWeb.Click += new System.EventHandler(this.btnNavegarWeb_Click);

            // 
            // btnReproducirURL
            // 
            this.btnReproducirURL.Location = new System.Drawing.Point(150, 540);
            this.btnReproducirURL.Name = "btnReproducirURL";
            this.btnReproducirURL.Size = new System.Drawing.Size(130, 30);
            this.btnReproducirURL.TabIndex = 6;
            this.btnReproducirURL.Text = "Reproducir desde URL";
            this.btnReproducirURL.UseVisualStyleBackColor = true;
            this.btnReproducirURL.Click += new System.EventHandler(this.btnReproducirURL_Click);

            // 
            // textBoxURL
            // 
            this.textBoxURL.Location = new System.Drawing.Point(12, 510);
            this.textBoxURL.Name = "textBoxURL";
            this.textBoxURL.Size = new System.Drawing.Size(268, 20);
            this.textBoxURL.TabIndex = 7;

            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(644, 581);
            this.Controls.Add(this.textBoxURL);
            this.Controls.Add(this.btnReproducirURL);
            this.Controls.Add(this.btnNavegarWeb);
            this.Controls.Add(this.btnAbrirPDF);
            this.Controls.Add(this.btnAbrirMedia);
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.textBoxPDF);
            this.Controls.Add(this.mediaPlayer);
            this.Name = "Form1";
            this.Text = "App Reutilización";
            ((System.ComponentModel.ISupportInitialize)(this.mediaPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
