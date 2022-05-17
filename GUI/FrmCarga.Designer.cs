
namespace GUI
{
    partial class FrmCarga
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCarga));
            this.label1 = new System.Windows.Forms.Label();
            this.labelNombreApellido = new System.Windows.Forms.Label();
            this.picLogoEnCarga = new System.Windows.Forms.PictureBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picLogoEnCarga)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(85, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 32);
            this.label1.TabIndex = 17;
            this.label1.Text = "BIENVENIDO";
            // 
            // labelNombreApellido
            // 
            this.labelNombreApellido.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreApellido.ForeColor = System.Drawing.Color.DarkGray;
            this.labelNombreApellido.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.labelNombreApellido.Location = new System.Drawing.Point(0, 95);
            this.labelNombreApellido.Name = "labelNombreApellido";
            this.labelNombreApellido.Size = new System.Drawing.Size(350, 24);
            this.labelNombreApellido.TabIndex = 17;
            this.labelNombreApellido.Text = "BEDELIA ADMINISTRADOR";
            this.labelNombreApellido.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // picLogoEnCarga
            // 
            this.picLogoEnCarga.Image = ((System.Drawing.Image)(resources.GetObject("picLogoEnCarga.Image")));
            this.picLogoEnCarga.Location = new System.Drawing.Point(91, 155);
            this.picLogoEnCarga.Name = "picLogoEnCarga";
            this.picLogoEnCarga.Size = new System.Drawing.Size(170, 203);
            this.picLogoEnCarga.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogoEnCarga.TabIndex = 18;
            this.picLogoEnCarga.TabStop = false;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this;
            // 
            // FrmCarga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(350, 400);
            this.Controls.Add(this.picLogoEnCarga);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelNombreApellido);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCarga";
            this.Text = "FrmCarga";
            this.Load += new System.EventHandler(this.FrmCarga_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmCarga_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.picLogoEnCarga)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelNombreApellido;
        private System.Windows.Forms.PictureBox picLogoEnCarga;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}