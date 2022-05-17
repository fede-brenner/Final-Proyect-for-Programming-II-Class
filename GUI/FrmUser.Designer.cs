
namespace GUI
{
    partial class FrmUser
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUser));
            this.labelTituloUsuario = new System.Windows.Forms.Label();
            this.labelTituloMailPersonal = new System.Windows.Forms.Label();
            this.labelTituloContraseña = new System.Windows.Forms.Label();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelTituloMailInstitucional = new System.Windows.Forms.Label();
            this.labelTituloNombre = new System.Windows.Forms.Label();
            this.btnAddUser = new FontAwesome.Sharp.IconButton();
            this.labelTituloApellido = new System.Windows.Forms.Label();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape4 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.labelContraseña = new System.Windows.Forms.Label();
            this.labelMailPersonal = new System.Windows.Forms.Label();
            this.labelApellido = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelInfoUsers = new System.Windows.Forms.Label();
            this.labelMailInstitucional = new System.Windows.Forms.Label();
            this.panelAbmUser = new System.Windows.Forms.Panel();
            this.picBoxError = new System.Windows.Forms.PictureBox();
            this.picBoxSuccesful = new System.Windows.Forms.PictureBox();
            this.btnAgregar = new GUI.Controles.CustomButton();
            this.btnBorrar = new GUI.Controles.CustomButton();
            this.btnModificar = new GUI.Controles.CustomButton();
            this.btnBuscar = new GUI.Controles.CustomButton();
            this.labelErrorMessage = new System.Windows.Forms.Label();
            this.labelSuccesfulMessage = new System.Windows.Forms.Label();
            this.rjTextBox7 = new CustomControls.RJControls.RJTextBox();
            this.rjTextBox8 = new CustomControls.RJControls.RJTextBox();
            this.rjTextBox2 = new CustomControls.RJControls.RJTextBox();
            this.rjTextBox6 = new CustomControls.RJControls.RJTextBox();
            this.rjTextBox5 = new CustomControls.RJControls.RJTextBox();
            this.rjTextBox3 = new CustomControls.RJControls.RJTextBox();
            this.rjTextBox1 = new CustomControls.RJControls.RJTextBox();
            this.rjTextBox4 = new CustomControls.RJControls.RJTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panelAbmUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSuccesful)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTituloUsuario
            // 
            this.labelTituloUsuario.AutoSize = true;
            this.labelTituloUsuario.BackColor = System.Drawing.Color.Transparent;
            this.labelTituloUsuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTituloUsuario.ForeColor = System.Drawing.Color.DarkGray;
            this.labelTituloUsuario.Location = new System.Drawing.Point(23, 20);
            this.labelTituloUsuario.Name = "labelTituloUsuario";
            this.labelTituloUsuario.Size = new System.Drawing.Size(70, 21);
            this.labelTituloUsuario.TabIndex = 0;
            this.labelTituloUsuario.Text = "Usuario:";
            // 
            // labelTituloMailPersonal
            // 
            this.labelTituloMailPersonal.AutoSize = true;
            this.labelTituloMailPersonal.BackColor = System.Drawing.Color.Transparent;
            this.labelTituloMailPersonal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTituloMailPersonal.ForeColor = System.Drawing.Color.DarkGray;
            this.labelTituloMailPersonal.Location = new System.Drawing.Point(23, 140);
            this.labelTituloMailPersonal.Name = "labelTituloMailPersonal";
            this.labelTituloMailPersonal.Size = new System.Drawing.Size(114, 21);
            this.labelTituloMailPersonal.TabIndex = 1;
            this.labelTituloMailPersonal.Text = "Mail Personal:";
            // 
            // labelTituloContraseña
            // 
            this.labelTituloContraseña.AutoSize = true;
            this.labelTituloContraseña.BackColor = System.Drawing.Color.Transparent;
            this.labelTituloContraseña.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTituloContraseña.ForeColor = System.Drawing.Color.DarkGray;
            this.labelTituloContraseña.Location = new System.Drawing.Point(23, 220);
            this.labelTituloContraseña.Name = "labelTituloContraseña";
            this.labelTituloContraseña.Size = new System.Drawing.Size(107, 21);
            this.labelTituloContraseña.TabIndex = 2;
            this.labelTituloContraseña.Text = "Contraseña:";
            // 
            // lineShape2
            // 
            this.lineShape2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 0;
            this.lineShape2.X2 = 0;
            this.lineShape2.Y1 = 0;
            this.lineShape2.Y2 = 1000;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelTituloMailInstitucional);
            this.panel1.Controls.Add(this.labelTituloNombre);
            this.panel1.Controls.Add(this.btnAddUser);
            this.panel1.Controls.Add(this.labelTituloApellido);
            this.panel1.Controls.Add(this.labelTituloUsuario);
            this.panel1.Controls.Add(this.labelTituloContraseña);
            this.panel1.Controls.Add(this.labelTituloMailPersonal);
            this.panel1.Controls.Add(this.shapeContainer2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 650);
            this.panel1.TabIndex = 10;
            // 
            // labelTituloMailInstitucional
            // 
            this.labelTituloMailInstitucional.AutoSize = true;
            this.labelTituloMailInstitucional.BackColor = System.Drawing.Color.Transparent;
            this.labelTituloMailInstitucional.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTituloMailInstitucional.ForeColor = System.Drawing.Color.DarkGray;
            this.labelTituloMailInstitucional.Location = new System.Drawing.Point(23, 180);
            this.labelTituloMailInstitucional.Name = "labelTituloMailInstitucional";
            this.labelTituloMailInstitucional.Size = new System.Drawing.Size(145, 21);
            this.labelTituloMailInstitucional.TabIndex = 19;
            this.labelTituloMailInstitucional.Text = "Mail Institucional:";
            // 
            // labelTituloNombre
            // 
            this.labelTituloNombre.AutoSize = true;
            this.labelTituloNombre.BackColor = System.Drawing.Color.Transparent;
            this.labelTituloNombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTituloNombre.ForeColor = System.Drawing.Color.DarkGray;
            this.labelTituloNombre.Location = new System.Drawing.Point(23, 100);
            this.labelTituloNombre.Name = "labelTituloNombre";
            this.labelTituloNombre.Size = new System.Drawing.Size(77, 21);
            this.labelTituloNombre.TabIndex = 11;
            this.labelTituloNombre.Text = "Nombre:";
            // 
            // btnAddUser
            // 
            this.btnAddUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnAddUser.FlatAppearance.BorderSize = 0;
            this.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUser.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddUser.ForeColor = System.Drawing.Color.DarkGray;
            this.btnAddUser.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.btnAddUser.IconColor = System.Drawing.Color.DarkGray;
            this.btnAddUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddUser.IconSize = 40;
            this.btnAddUser.Location = new System.Drawing.Point(1, 588);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(178, 60);
            this.btnAddUser.TabIndex = 18;
            this.btnAddUser.Text = "AddUser";
            this.btnAddUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddUser.UseVisualStyleBackColor = false;
            this.btnAddUser.Visible = false;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // labelTituloApellido
            // 
            this.labelTituloApellido.AutoSize = true;
            this.labelTituloApellido.BackColor = System.Drawing.Color.Transparent;
            this.labelTituloApellido.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTituloApellido.ForeColor = System.Drawing.Color.DarkGray;
            this.labelTituloApellido.Location = new System.Drawing.Point(23, 60);
            this.labelTituloApellido.Name = "labelTituloApellido";
            this.labelTituloApellido.Size = new System.Drawing.Size(78, 21);
            this.labelTituloApellido.TabIndex = 12;
            this.labelTituloApellido.Text = "Apellido:";
            // 
            // shapeContainer2
            // 
            this.shapeContainer2.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape4,
            this.lineShape2});
            this.shapeContainer2.Size = new System.Drawing.Size(180, 650);
            this.shapeContainer2.TabIndex = 10;
            this.shapeContainer2.TabStop = false;
            // 
            // lineShape4
            // 
            this.lineShape4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lineShape4.Name = "lineShape4";
            this.lineShape4.SelectionColor = System.Drawing.Color.Transparent;
            this.lineShape4.X1 = 179;
            this.lineShape4.X2 = 179;
            this.lineShape4.Y1 = 0;
            this.lineShape4.Y2 = 1000;
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.BackColor = System.Drawing.Color.Transparent;
            this.labelUsuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsuario.ForeColor = System.Drawing.Color.DarkGray;
            this.labelUsuario.Location = new System.Drawing.Point(23, 20);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(69, 21);
            this.labelUsuario.TabIndex = 11;
            this.labelUsuario.Text = "User123";
            // 
            // labelContraseña
            // 
            this.labelContraseña.AutoSize = true;
            this.labelContraseña.BackColor = System.Drawing.Color.Transparent;
            this.labelContraseña.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContraseña.ForeColor = System.Drawing.Color.DarkGray;
            this.labelContraseña.Location = new System.Drawing.Point(23, 220);
            this.labelContraseña.Name = "labelContraseña";
            this.labelContraseña.Size = new System.Drawing.Size(46, 21);
            this.labelContraseña.TabIndex = 13;
            this.labelContraseña.Text = "1234";
            // 
            // labelMailPersonal
            // 
            this.labelMailPersonal.AutoSize = true;
            this.labelMailPersonal.BackColor = System.Drawing.Color.Transparent;
            this.labelMailPersonal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMailPersonal.ForeColor = System.Drawing.Color.DarkGray;
            this.labelMailPersonal.Location = new System.Drawing.Point(23, 140);
            this.labelMailPersonal.Name = "labelMailPersonal";
            this.labelMailPersonal.Size = new System.Drawing.Size(138, 21);
            this.labelMailPersonal.TabIndex = 12;
            this.labelMailPersonal.Text = "User@gmail.com";
            // 
            // labelApellido
            // 
            this.labelApellido.AutoSize = true;
            this.labelApellido.BackColor = System.Drawing.Color.Transparent;
            this.labelApellido.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelApellido.ForeColor = System.Drawing.Color.DarkGray;
            this.labelApellido.Location = new System.Drawing.Point(23, 60);
            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(101, 21);
            this.labelApellido.TabIndex = 14;
            this.labelApellido.Text = "Apellido123";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.BackColor = System.Drawing.Color.Transparent;
            this.labelNombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.ForeColor = System.Drawing.Color.DarkGray;
            this.labelNombre.Location = new System.Drawing.Point(23, 100);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(100, 21);
            this.labelNombre.TabIndex = 13;
            this.labelNombre.Text = "Nombre123";
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panelAbmUser);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(180, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(720, 650);
            this.panel2.TabIndex = 16;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 40;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.dataGridView1.Location = new System.Drawing.Point(24, 290);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.Height = 35;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(672, 93);
            this.dataGridView1.TabIndex = 38;
            this.dataGridView1.Visible = false;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(696, 290);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(24, 93);
            this.panel5.TabIndex = 39;
            this.panel5.Visible = false;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 290);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(24, 93);
            this.panel4.TabIndex = 35;
            this.panel4.Visible = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.labelInfoUsers);
            this.panel3.Controls.Add(this.labelUsuario);
            this.panel3.Controls.Add(this.labelContraseña);
            this.panel3.Controls.Add(this.labelNombre);
            this.panel3.Controls.Add(this.labelMailInstitucional);
            this.panel3.Controls.Add(this.labelMailPersonal);
            this.panel3.Controls.Add(this.labelApellido);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(720, 290);
            this.panel3.TabIndex = 34;
            // 
            // labelInfoUsers
            // 
            this.labelInfoUsers.AutoSize = true;
            this.labelInfoUsers.BackColor = System.Drawing.Color.Transparent;
            this.labelInfoUsers.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfoUsers.ForeColor = System.Drawing.Color.White;
            this.labelInfoUsers.Location = new System.Drawing.Point(23, 264);
            this.labelInfoUsers.Name = "labelInfoUsers";
            this.labelInfoUsers.Size = new System.Drawing.Size(198, 19);
            this.labelInfoUsers.TabIndex = 33;
            this.labelInfoUsers.Text = "Informacion de Usuarios:";
            this.labelInfoUsers.Visible = false;
            // 
            // labelMailInstitucional
            // 
            this.labelMailInstitucional.AutoSize = true;
            this.labelMailInstitucional.BackColor = System.Drawing.Color.Transparent;
            this.labelMailInstitucional.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMailInstitucional.ForeColor = System.Drawing.Color.DarkGray;
            this.labelMailInstitucional.Location = new System.Drawing.Point(23, 180);
            this.labelMailInstitucional.Name = "labelMailInstitucional";
            this.labelMailInstitucional.Size = new System.Drawing.Size(138, 21);
            this.labelMailInstitucional.TabIndex = 32;
            this.labelMailInstitucional.Text = "User@gmail.com";
            // 
            // panelAbmUser
            // 
            this.panelAbmUser.Controls.Add(this.picBoxError);
            this.panelAbmUser.Controls.Add(this.picBoxSuccesful);
            this.panelAbmUser.Controls.Add(this.btnAgregar);
            this.panelAbmUser.Controls.Add(this.btnBorrar);
            this.panelAbmUser.Controls.Add(this.btnModificar);
            this.panelAbmUser.Controls.Add(this.btnBuscar);
            this.panelAbmUser.Controls.Add(this.labelErrorMessage);
            this.panelAbmUser.Controls.Add(this.labelSuccesfulMessage);
            this.panelAbmUser.Controls.Add(this.rjTextBox7);
            this.panelAbmUser.Controls.Add(this.rjTextBox8);
            this.panelAbmUser.Controls.Add(this.rjTextBox2);
            this.panelAbmUser.Controls.Add(this.rjTextBox6);
            this.panelAbmUser.Controls.Add(this.rjTextBox5);
            this.panelAbmUser.Controls.Add(this.rjTextBox3);
            this.panelAbmUser.Controls.Add(this.rjTextBox1);
            this.panelAbmUser.Controls.Add(this.rjTextBox4);
            this.panelAbmUser.Controls.Add(this.label4);
            this.panelAbmUser.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelAbmUser.Location = new System.Drawing.Point(0, 383);
            this.panelAbmUser.Name = "panelAbmUser";
            this.panelAbmUser.Size = new System.Drawing.Size(720, 267);
            this.panelAbmUser.TabIndex = 33;
            this.panelAbmUser.Visible = false;
            // 
            // picBoxError
            // 
            this.picBoxError.Image = ((System.Drawing.Image)(resources.GetObject("picBoxError.Image")));
            this.picBoxError.Location = new System.Drawing.Point(26, 247);
            this.picBoxError.Name = "picBoxError";
            this.picBoxError.Size = new System.Drawing.Size(17, 17);
            this.picBoxError.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxError.TabIndex = 36;
            this.picBoxError.TabStop = false;
            this.picBoxError.Visible = false;
            // 
            // picBoxSuccesful
            // 
            this.picBoxSuccesful.Image = ((System.Drawing.Image)(resources.GetObject("picBoxSuccesful.Image")));
            this.picBoxSuccesful.Location = new System.Drawing.Point(26, 247);
            this.picBoxSuccesful.Name = "picBoxSuccesful";
            this.picBoxSuccesful.Size = new System.Drawing.Size(17, 17);
            this.picBoxSuccesful.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxSuccesful.TabIndex = 34;
            this.picBoxSuccesful.TabStop = false;
            this.picBoxSuccesful.Visible = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnAgregar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnAgregar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAgregar.BorderRadius = 5;
            this.btnAgregar.BorderSize = 0;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAgregar.ForeColor = System.Drawing.Color.Silver;
            this.btnAgregar.Location = new System.Drawing.Point(24, 204);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(122, 40);
            this.btnAgregar.TabIndex = 33;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.TextColor = System.Drawing.Color.Silver;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnBorrar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnBorrar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnBorrar.BorderRadius = 5;
            this.btnBorrar.BorderSize = 0;
            this.btnBorrar.FlatAppearance.BorderSize = 0;
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnBorrar.ForeColor = System.Drawing.Color.Silver;
            this.btnBorrar.Location = new System.Drawing.Point(152, 204);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(122, 40);
            this.btnBorrar.TabIndex = 34;
            this.btnBorrar.Text = "BORRAR";
            this.btnBorrar.TextColor = System.Drawing.Color.Silver;
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnModificar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnModificar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnModificar.BorderRadius = 5;
            this.btnModificar.BorderSize = 0;
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnModificar.ForeColor = System.Drawing.Color.Silver;
            this.btnModificar.Location = new System.Drawing.Point(280, 204);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(122, 40);
            this.btnModificar.TabIndex = 35;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.TextColor = System.Drawing.Color.Silver;
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnBuscar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnBuscar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnBuscar.BorderRadius = 5;
            this.btnBuscar.BorderSize = 0;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnBuscar.ForeColor = System.Drawing.Color.Silver;
            this.btnBuscar.Location = new System.Drawing.Point(408, 204);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(122, 40);
            this.btnBuscar.TabIndex = 36;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.TextColor = System.Drawing.Color.Silver;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // labelErrorMessage
            // 
            this.labelErrorMessage.AutoSize = true;
            this.labelErrorMessage.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.labelErrorMessage.ForeColor = System.Drawing.Color.IndianRed;
            this.labelErrorMessage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelErrorMessage.Location = new System.Drawing.Point(39, 247);
            this.labelErrorMessage.Name = "labelErrorMessage";
            this.labelErrorMessage.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.labelErrorMessage.Size = new System.Drawing.Size(90, 17);
            this.labelErrorMessage.TabIndex = 35;
            this.labelErrorMessage.Text = "ErrorMessage";
            this.labelErrorMessage.Visible = false;
            // 
            // labelSuccesfulMessage
            // 
            this.labelSuccesfulMessage.AutoSize = true;
            this.labelSuccesfulMessage.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.labelSuccesfulMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(180)))), ((int)(((byte)(50)))));
            this.labelSuccesfulMessage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelSuccesfulMessage.Location = new System.Drawing.Point(39, 247);
            this.labelSuccesfulMessage.Name = "labelSuccesfulMessage";
            this.labelSuccesfulMessage.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.labelSuccesfulMessage.Size = new System.Drawing.Size(121, 17);
            this.labelSuccesfulMessage.TabIndex = 33;
            this.labelSuccesfulMessage.Text = "SuccesfulMessage";
            this.labelSuccesfulMessage.Visible = false;
            // 
            // rjTextBox7
            // 
            this.rjTextBox7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rjTextBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.rjTextBox7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.rjTextBox7.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.rjTextBox7.BorderRadius = 15;
            this.rjTextBox7.BorderSize = 2;
            this.rjTextBox7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox7.ForeColor = System.Drawing.Color.DarkGray;
            this.rjTextBox7.Location = new System.Drawing.Point(24, 123);
            this.rjTextBox7.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBox7.Multiline = false;
            this.rjTextBox7.Name = "rjTextBox7";
            this.rjTextBox7.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjTextBox7.PasswordChar = false;
            this.rjTextBox7.PlaceholderColor = System.Drawing.Color.DimGray;
            this.rjTextBox7.PlaceholderText = "Posicion";
            this.rjTextBox7.Size = new System.Drawing.Size(250, 32);
            this.rjTextBox7.TabIndex = 29;
            this.rjTextBox7.Texts = "";
            this.rjTextBox7.UnderlinedStyle = false;
            // 
            // rjTextBox8
            // 
            this.rjTextBox8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rjTextBox8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.rjTextBox8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.rjTextBox8.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.rjTextBox8.BorderRadius = 15;
            this.rjTextBox8.BorderSize = 2;
            this.rjTextBox8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox8.ForeColor = System.Drawing.Color.DarkGray;
            this.rjTextBox8.Location = new System.Drawing.Point(282, 123);
            this.rjTextBox8.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBox8.Multiline = false;
            this.rjTextBox8.Name = "rjTextBox8";
            this.rjTextBox8.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjTextBox8.PasswordChar = false;
            this.rjTextBox8.PlaceholderColor = System.Drawing.Color.DimGray;
            this.rjTextBox8.PlaceholderText = "Telefono";
            this.rjTextBox8.Size = new System.Drawing.Size(250, 32);
            this.rjTextBox8.TabIndex = 30;
            this.rjTextBox8.Texts = "";
            this.rjTextBox8.UnderlinedStyle = false;
            // 
            // rjTextBox2
            // 
            this.rjTextBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rjTextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.rjTextBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.rjTextBox2.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.rjTextBox2.BorderRadius = 15;
            this.rjTextBox2.BorderSize = 2;
            this.rjTextBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox2.ForeColor = System.Drawing.Color.DarkGray;
            this.rjTextBox2.Location = new System.Drawing.Point(24, 83);
            this.rjTextBox2.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBox2.Multiline = false;
            this.rjTextBox2.Name = "rjTextBox2";
            this.rjTextBox2.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjTextBox2.PasswordChar = false;
            this.rjTextBox2.PlaceholderColor = System.Drawing.Color.DimGray;
            this.rjTextBox2.PlaceholderText = "Apellido";
            this.rjTextBox2.Size = new System.Drawing.Size(250, 32);
            this.rjTextBox2.TabIndex = 27;
            this.rjTextBox2.Texts = "";
            this.rjTextBox2.UnderlinedStyle = false;
            // 
            // rjTextBox6
            // 
            this.rjTextBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rjTextBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.rjTextBox6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.rjTextBox6.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.rjTextBox6.BorderRadius = 15;
            this.rjTextBox6.BorderSize = 2;
            this.rjTextBox6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox6.ForeColor = System.Drawing.Color.DarkGray;
            this.rjTextBox6.Location = new System.Drawing.Point(282, 163);
            this.rjTextBox6.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBox6.Multiline = false;
            this.rjTextBox6.Name = "rjTextBox6";
            this.rjTextBox6.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjTextBox6.PasswordChar = false;
            this.rjTextBox6.PlaceholderColor = System.Drawing.Color.DimGray;
            this.rjTextBox6.PlaceholderText = "Email Institucional";
            this.rjTextBox6.Size = new System.Drawing.Size(250, 32);
            this.rjTextBox6.TabIndex = 32;
            this.rjTextBox6.Texts = "";
            this.rjTextBox6.UnderlinedStyle = false;
            // 
            // rjTextBox5
            // 
            this.rjTextBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rjTextBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.rjTextBox5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.rjTextBox5.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.rjTextBox5.BorderRadius = 15;
            this.rjTextBox5.BorderSize = 2;
            this.rjTextBox5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox5.ForeColor = System.Drawing.Color.DarkGray;
            this.rjTextBox5.Location = new System.Drawing.Point(282, 43);
            this.rjTextBox5.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBox5.Multiline = false;
            this.rjTextBox5.Name = "rjTextBox5";
            this.rjTextBox5.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjTextBox5.PasswordChar = false;
            this.rjTextBox5.PlaceholderColor = System.Drawing.Color.DimGray;
            this.rjTextBox5.PlaceholderText = "Contraseña";
            this.rjTextBox5.Size = new System.Drawing.Size(250, 32);
            this.rjTextBox5.TabIndex = 26;
            this.rjTextBox5.Texts = "";
            this.rjTextBox5.UnderlinedStyle = false;
            // 
            // rjTextBox3
            // 
            this.rjTextBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rjTextBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.rjTextBox3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.rjTextBox3.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.rjTextBox3.BorderRadius = 15;
            this.rjTextBox3.BorderSize = 2;
            this.rjTextBox3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox3.ForeColor = System.Drawing.Color.DarkGray;
            this.rjTextBox3.Location = new System.Drawing.Point(282, 83);
            this.rjTextBox3.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBox3.Multiline = false;
            this.rjTextBox3.Name = "rjTextBox3";
            this.rjTextBox3.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjTextBox3.PasswordChar = false;
            this.rjTextBox3.PlaceholderColor = System.Drawing.Color.DimGray;
            this.rjTextBox3.PlaceholderText = "Nombre";
            this.rjTextBox3.Size = new System.Drawing.Size(250, 32);
            this.rjTextBox3.TabIndex = 28;
            this.rjTextBox3.Texts = "";
            this.rjTextBox3.UnderlinedStyle = false;
            // 
            // rjTextBox1
            // 
            this.rjTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rjTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.rjTextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.rjTextBox1.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.rjTextBox1.BorderRadius = 15;
            this.rjTextBox1.BorderSize = 2;
            this.rjTextBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox1.ForeColor = System.Drawing.Color.DarkGray;
            this.rjTextBox1.Location = new System.Drawing.Point(24, 43);
            this.rjTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBox1.Multiline = false;
            this.rjTextBox1.Name = "rjTextBox1";
            this.rjTextBox1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjTextBox1.PasswordChar = false;
            this.rjTextBox1.PlaceholderColor = System.Drawing.Color.DimGray;
            this.rjTextBox1.PlaceholderText = "Usuario";
            this.rjTextBox1.Size = new System.Drawing.Size(250, 32);
            this.rjTextBox1.TabIndex = 25;
            this.rjTextBox1.Texts = "";
            this.rjTextBox1.UnderlinedStyle = false;
            // 
            // rjTextBox4
            // 
            this.rjTextBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rjTextBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.rjTextBox4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.rjTextBox4.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.rjTextBox4.BorderRadius = 15;
            this.rjTextBox4.BorderSize = 2;
            this.rjTextBox4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox4.ForeColor = System.Drawing.Color.DarkGray;
            this.rjTextBox4.Location = new System.Drawing.Point(24, 163);
            this.rjTextBox4.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBox4.Multiline = false;
            this.rjTextBox4.Name = "rjTextBox4";
            this.rjTextBox4.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjTextBox4.PasswordChar = false;
            this.rjTextBox4.PlaceholderColor = System.Drawing.Color.DimGray;
            this.rjTextBox4.PlaceholderText = "Email Personal";
            this.rjTextBox4.Size = new System.Drawing.Size(250, 32);
            this.rjTextBox4.TabIndex = 31;
            this.rjTextBox4.Texts = "";
            this.rjTextBox4.UnderlinedStyle = false;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Aqua Grotesque", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(27, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(247, 24);
            this.label4.TabIndex = 24;
            this.label4.Text = "INGRESE LOS DATOS:";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this.dataGridView1;
            // 
            // FrmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(900, 650);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmUser";
            this.Text = "FrmUser";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panelAbmUser.ResumeLayout(false);
            this.panelAbmUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSuccesful)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelTituloUsuario;
        private System.Windows.Forms.Label labelTituloMailPersonal;
        private System.Windows.Forms.Label labelTituloContraseña;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private System.Windows.Forms.Panel panel1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.Label labelContraseña;
        private System.Windows.Forms.Label labelMailPersonal;
        private System.Windows.Forms.Label labelTituloApellido;
        private System.Windows.Forms.Label labelTituloNombre;
        private System.Windows.Forms.Label labelApellido;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btnAddUser;
        private System.Windows.Forms.Label label4;
        private CustomControls.RJControls.RJTextBox rjTextBox4;
        private CustomControls.RJControls.RJTextBox rjTextBox3;
        private CustomControls.RJControls.RJTextBox rjTextBox1;
        private CustomControls.RJControls.RJTextBox rjTextBox2;
        private CustomControls.RJControls.RJTextBox rjTextBox5;
        private CustomControls.RJControls.RJTextBox rjTextBox6;
        private System.Windows.Forms.Label labelTituloMailInstitucional;
        private System.Windows.Forms.Panel panelAbmUser;
        private System.Windows.Forms.Label labelMailInstitucional;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelInfoUsers;
        private System.Windows.Forms.Panel panel4;
        private CustomControls.RJControls.RJTextBox rjTextBox7;
        private CustomControls.RJControls.RJTextBox rjTextBox8;
        private System.Windows.Forms.PictureBox picBoxSuccesful;
        private System.Windows.Forms.Label labelSuccesfulMessage;
        private System.Windows.Forms.PictureBox picBoxError;
        private System.Windows.Forms.Label labelErrorMessage;
        private Controles.CustomButton btnAgregar;
        private Controles.CustomButton btnBorrar;
        private Controles.CustomButton btnModificar;
        private Controles.CustomButton btnBuscar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel5;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}