
namespace GUI
{
    partial class Frmlogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmlogin));
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnCloseForm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTop = new System.Windows.Forms.Panel();
            this.labelErrorMessage = new System.Windows.Forms.Label();
            this.picBoxError = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.picEyeClosed = new System.Windows.Forms.PictureBox();
            this.rjTextBox1 = new CustomControls.RJControls.RJTextBox();
            this.btnLogin = new GUI.Controles.CustomButton();
            this.rjTextBox2 = new CustomControls.RJControls.RJTextBox();
            this.picEyeOpen = new System.Windows.Forms.PictureBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEyeClosed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEyeOpen)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnMinimizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.BackgroundImage")));
            this.btnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(218)))), ((int)(((byte)(220)))));
            this.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(224)))), ((int)(((byte)(227)))));
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnMinimizar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMinimizar.Location = new System.Drawing.Point(460, 4);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnMinimizar.Size = new System.Drawing.Size(24, 19);
            this.btnMinimizar.TabIndex = 18;
            this.btnMinimizar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMinimizar.UseVisualStyleBackColor = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnCloseForm
            // 
            this.btnCloseForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnCloseForm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCloseForm.BackgroundImage")));
            this.btnCloseForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCloseForm.FlatAppearance.BorderSize = 0;
            this.btnCloseForm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCloseForm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(43)))), ((int)(((byte)(75)))));
            this.btnCloseForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCloseForm.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCloseForm.Location = new System.Drawing.Point(487, 4);
            this.btnCloseForm.Name = "btnCloseForm";
            this.btnCloseForm.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnCloseForm.Size = new System.Drawing.Size(33, 19);
            this.btnCloseForm.TabIndex = 17;
            this.btnCloseForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCloseForm.UseVisualStyleBackColor = false;
            this.btnCloseForm.Click += new System.EventHandler(this.btnCloseForm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(213, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 32);
            this.label1.TabIndex = 16;
            this.label1.Text = "LOGIN";
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.panelTop.Controls.Add(this.btnCloseForm);
            this.panelTop.Controls.Add(this.btnMinimizar);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(525, 27);
            this.panelTop.TabIndex = 20;
            this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // labelErrorMessage
            // 
            this.labelErrorMessage.AutoSize = true;
            this.labelErrorMessage.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.labelErrorMessage.ForeColor = System.Drawing.Color.Brown;
            this.labelErrorMessage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelErrorMessage.Location = new System.Drawing.Point(74, 212);
            this.labelErrorMessage.Name = "labelErrorMessage";
            this.labelErrorMessage.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.labelErrorMessage.Size = new System.Drawing.Size(90, 17);
            this.labelErrorMessage.TabIndex = 21;
            this.labelErrorMessage.Text = "ErrorMessage";
            this.labelErrorMessage.Visible = false;
            // 
            // picBoxError
            // 
            this.picBoxError.Image = ((System.Drawing.Image)(resources.GetObject("picBoxError.Image")));
            this.picBoxError.Location = new System.Drawing.Point(60, 212);
            this.picBoxError.Name = "picBoxError";
            this.picBoxError.Size = new System.Drawing.Size(17, 17);
            this.picBoxError.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxError.TabIndex = 22;
            this.picBoxError.TabStop = false;
            this.picBoxError.Visible = false;
            // 
            // picEyeClosed
            // 
            this.picEyeClosed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.picEyeClosed.Image = ((System.Drawing.Image)(resources.GetObject("picEyeClosed.Image")));
            this.picEyeClosed.Location = new System.Drawing.Point(425, 171);
            this.picEyeClosed.Name = "picEyeClosed";
            this.picEyeClosed.Size = new System.Drawing.Size(30, 27);
            this.picEyeClosed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picEyeClosed.TabIndex = 23;
            this.picEyeClosed.TabStop = false;
            this.picEyeClosed.Click += new System.EventHandler(this.picEyeClosed_Click);
            // 
            // rjTextBox1
            // 
            this.rjTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rjTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.rjTextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.rjTextBox1.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.rjTextBox1.BorderRadius = 15;
            this.rjTextBox1.BorderSize = 2;
            this.rjTextBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox1.ForeColor = System.Drawing.Color.DarkGray;
            this.rjTextBox1.Location = new System.Drawing.Point(60, 96);
            this.rjTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBox1.Multiline = false;
            this.rjTextBox1.Name = "rjTextBox1";
            this.rjTextBox1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjTextBox1.PasswordChar = false;
            this.rjTextBox1.PlaceholderColor = System.Drawing.Color.DimGray;
            this.rjTextBox1.PlaceholderText = "Usuario";
            this.rjTextBox1.Size = new System.Drawing.Size(400, 36);
            this.rjTextBox1.TabIndex = 43;
            this.rjTextBox1.Texts = "";
            this.rjTextBox1.UnderlinedStyle = false;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnLogin.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnLogin.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnLogin.BorderRadius = 10;
            this.btnLogin.BorderSize = 0;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnLogin.ForeColor = System.Drawing.Color.LightGray;
            this.btnLogin.Location = new System.Drawing.Point(56, 260);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(411, 45);
            this.btnLogin.TabIndex = 45;
            this.btnLogin.Text = "ACCEDER";
            this.btnLogin.TextColor = System.Drawing.Color.LightGray;
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // rjTextBox2
            // 
            this.rjTextBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rjTextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.rjTextBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.rjTextBox2.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.rjTextBox2.BorderRadius = 15;
            this.rjTextBox2.BorderSize = 2;
            this.rjTextBox2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox2.ForeColor = System.Drawing.Color.DarkGray;
            this.rjTextBox2.Location = new System.Drawing.Point(60, 169);
            this.rjTextBox2.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBox2.Multiline = false;
            this.rjTextBox2.Name = "rjTextBox2";
            this.rjTextBox2.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjTextBox2.PasswordChar = true;
            this.rjTextBox2.PlaceholderColor = System.Drawing.Color.DimGray;
            this.rjTextBox2.PlaceholderText = "Contraseña";
            this.rjTextBox2.Size = new System.Drawing.Size(400, 36);
            this.rjTextBox2.TabIndex = 44;
            this.rjTextBox2.Texts = "";
            this.rjTextBox2.UnderlinedStyle = false;
            // 
            // picEyeOpen
            // 
            this.picEyeOpen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.picEyeOpen.Image = ((System.Drawing.Image)(resources.GetObject("picEyeOpen.Image")));
            this.picEyeOpen.Location = new System.Drawing.Point(425, 171);
            this.picEyeOpen.Name = "picEyeOpen";
            this.picEyeOpen.Size = new System.Drawing.Size(30, 27);
            this.picEyeOpen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picEyeOpen.TabIndex = 24;
            this.picEyeOpen.TabStop = false;
            this.picEyeOpen.Visible = false;
            this.picEyeOpen.Click += new System.EventHandler(this.picEyeOpen_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this;
            // 
            // Frmlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(525, 345);
            this.Controls.Add(this.picEyeOpen);
            this.Controls.Add(this.rjTextBox1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.picEyeClosed);
            this.Controls.Add(this.picBoxError);
            this.Controls.Add(this.labelErrorMessage);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rjTextBox2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frmlogin";
            this.Text = "Frmlogin";
            this.panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEyeClosed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEyeOpen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnCloseForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label labelErrorMessage;
        private System.Windows.Forms.PictureBox picBoxError;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox picEyeClosed;
        private Controles.CustomButton btnLogin;
        private CustomControls.RJControls.RJTextBox rjTextBox1;
        private CustomControls.RJControls.RJTextBox rjTextBox2;
        private System.Windows.Forms.PictureBox picEyeOpen;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}