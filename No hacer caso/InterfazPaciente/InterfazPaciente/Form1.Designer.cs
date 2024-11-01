namespace InterfazPaciente
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.textBoxname = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.textBoxapellido = new System.Windows.Forms.TextBox();
            this.comboBoxDep = new System.Windows.Forms.ComboBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.maskedTextBoxFecha = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxgenero = new System.Windows.Forms.ComboBox();
            this.labelConsulta = new System.Windows.Forms.Label();
            this.textBoxConsulta = new System.Windows.Forms.TextBox();
            this.labelDep = new System.Windows.Forms.Label();
            this.labelAlergias = new System.Windows.Forms.Label();
            this.checkBoxAlergias = new System.Windows.Forms.CheckBox();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(134, 30);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(0, 13);
            this.linkLabel1.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(144, 11);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(146, 32);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "INGRESO";
            this.lblTitulo.Click += new System.EventHandler(this.lblTitulo_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(29, 63);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(105, 13);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Nombre del paciente";
            // 
            // textBoxname
            // 
            this.textBoxname.Location = new System.Drawing.Point(32, 79);
            this.textBoxname.Name = "textBoxname";
            this.textBoxname.Size = new System.Drawing.Size(379, 20);
            this.textBoxname.TabIndex = 3;
            this.toolTip1.SetToolTip(this.textBoxname, "Ingrese su nombre");
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(32, 120);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(105, 13);
            this.lblApellido.TabIndex = 4;
            this.lblApellido.Text = "Apellido del paciente";
            this.lblApellido.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxapellido
            // 
            this.textBoxapellido.Location = new System.Drawing.Point(32, 136);
            this.textBoxapellido.Name = "textBoxapellido";
            this.textBoxapellido.Size = new System.Drawing.Size(379, 20);
            this.textBoxapellido.TabIndex = 5;
            this.toolTip1.SetToolTip(this.textBoxapellido, "Ingrese su Apellido");
            // 
            // comboBoxDep
            // 
            this.comboBoxDep.FormattingEnabled = true;
            this.comboBoxDep.Items.AddRange(new object[] {
            "Cardiología",
            "Pediatra",
            "Emergencia",
            "Neurología"});
            this.comboBoxDep.Location = new System.Drawing.Point(31, 334);
            this.comboBoxDep.Name = "comboBoxDep";
            this.comboBoxDep.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDep.TabIndex = 6;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(29, 174);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(106, 13);
            this.lblFecha.TabIndex = 7;
            this.lblFecha.Text = "Fecha de nacimiento";
            // 
            // maskedTextBoxFecha
            // 
            this.maskedTextBoxFecha.Location = new System.Drawing.Point(32, 191);
            this.maskedTextBoxFecha.Mask = "00/00/0000";
            this.maskedTextBoxFecha.Name = "maskedTextBoxFecha";
            this.maskedTextBoxFecha.Size = new System.Drawing.Size(121, 20);
            this.maskedTextBoxFecha.TabIndex = 8;
            this.maskedTextBoxFecha.ValidatingType = typeof(System.DateTime);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(274, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Genero";
            // 
            // comboBoxgenero
            // 
            this.comboBoxgenero.FormattingEnabled = true;
            this.comboBoxgenero.Items.AddRange(new object[] {
            "Hombre",
            "Mujer",
            "Prefiero no decirlo"});
            this.comboBoxgenero.Location = new System.Drawing.Point(277, 190);
            this.comboBoxgenero.Name = "comboBoxgenero";
            this.comboBoxgenero.Size = new System.Drawing.Size(132, 21);
            this.comboBoxgenero.TabIndex = 10;
            // 
            // labelConsulta
            // 
            this.labelConsulta.AutoSize = true;
            this.labelConsulta.Location = new System.Drawing.Point(29, 236);
            this.labelConsulta.Name = "labelConsulta";
            this.labelConsulta.Size = new System.Drawing.Size(97, 13);
            this.labelConsulta.TabIndex = 11;
            this.labelConsulta.Text = "Motivo de consulta";
            // 
            // textBoxConsulta
            // 
            this.textBoxConsulta.Location = new System.Drawing.Point(32, 252);
            this.textBoxConsulta.Multiline = true;
            this.textBoxConsulta.Name = "textBoxConsulta";
            this.textBoxConsulta.Size = new System.Drawing.Size(377, 47);
            this.textBoxConsulta.TabIndex = 12;
            this.toolTip1.SetToolTip(this.textBoxConsulta, "Ingrese su motivo de consulta");
            // 
            // labelDep
            // 
            this.labelDep.AutoSize = true;
            this.labelDep.Location = new System.Drawing.Point(28, 318);
            this.labelDep.Name = "labelDep";
            this.labelDep.Size = new System.Drawing.Size(74, 13);
            this.labelDep.TabIndex = 13;
            this.labelDep.Text = "Departamento";
            // 
            // labelAlergias
            // 
            this.labelAlergias.AutoSize = true;
            this.labelAlergias.Location = new System.Drawing.Point(274, 334);
            this.labelAlergias.Name = "labelAlergias";
            this.labelAlergias.Size = new System.Drawing.Size(46, 13);
            this.labelAlergias.TabIndex = 14;
            this.labelAlergias.Text = "Alergías";
            // 
            // checkBoxAlergias
            // 
            this.checkBoxAlergias.AutoSize = true;
            this.checkBoxAlergias.Location = new System.Drawing.Point(322, 335);
            this.checkBoxAlergias.Name = "checkBoxAlergias";
            this.checkBoxAlergias.Size = new System.Drawing.Size(15, 14);
            this.checkBoxAlergias.TabIndex = 15;
            this.checkBoxAlergias.UseVisualStyleBackColor = true;
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(334, 435);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(75, 38);
            this.buttonGuardar.TabIndex = 16;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Location = new System.Drawing.Point(241, 435);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(75, 38);
            this.buttonLimpiar.TabIndex = 17;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // buttonSalir
            // 
            this.buttonSalir.Location = new System.Drawing.Point(27, 435);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(75, 38);
            this.buttonSalir.TabIndex = 18;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(434, 499);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.checkBoxAlergias);
            this.Controls.Add(this.labelAlergias);
            this.Controls.Add(this.labelDep);
            this.Controls.Add(this.textBoxConsulta);
            this.Controls.Add(this.labelConsulta);
            this.Controls.Add(this.comboBoxgenero);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maskedTextBoxFecha);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.comboBoxDep);
            this.Controls.Add(this.textBoxapellido);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.textBoxname);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.linkLabel1);
            this.Name = "Form1";
            this.Text = "Ingreso de Paciente";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox textBoxname;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox textBoxapellido;
        private System.Windows.Forms.ComboBox comboBoxDep;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxFecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxgenero;
        private System.Windows.Forms.Label labelConsulta;
        private System.Windows.Forms.TextBox textBoxConsulta;
        private System.Windows.Forms.Label labelDep;
        private System.Windows.Forms.Label labelAlergias;
        private System.Windows.Forms.CheckBox checkBoxAlergias;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Button buttonLimpiar;
        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

