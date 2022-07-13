namespace WindowsFormsA4_13ConBd
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
            this.CboTipoDocumento = new System.Windows.Forms.ComboBox();
            this.CboEstadoCivil = new System.Windows.Forms.ComboBox();
            this.RbtMasculio = new System.Windows.Forms.RadioButton();
            this.RbtFemenino = new System.Windows.Forms.RadioButton();
            this.TxtApellido = new System.Windows.Forms.TextBox();
            this.TxtDocumento = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.ChkFallecido = new System.Windows.Forms.CheckBox();
            this.LblSexo = new System.Windows.Forms.Label();
            this.LblApellido = new System.Windows.Forms.Label();
            this.LblTipoDocumento = new System.Windows.Forms.Label();
            this.LblEstadoCivil = new System.Windows.Forms.Label();
            this.LblDocumento = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            this.LblFallecido = new System.Windows.Forms.Label();
            this.LstPersonas = new System.Windows.Forms.ListBox();
            this.BtnGrabar = new System.Windows.Forms.Button();
            this.BtnBorrar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CboTipoDocumento
            // 
            this.CboTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboTipoDocumento.FormattingEnabled = true;
            this.CboTipoDocumento.Items.AddRange(new object[] {
            "wwww",
            "dddd",
            "gggg"});
            this.CboTipoDocumento.Location = new System.Drawing.Point(153, 132);
            this.CboTipoDocumento.Name = "CboTipoDocumento";
            this.CboTipoDocumento.Size = new System.Drawing.Size(216, 24);
            this.CboTipoDocumento.TabIndex = 2;
            // 
            // CboEstadoCivil
            // 
            this.CboEstadoCivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboEstadoCivil.FormattingEnabled = true;
            this.CboEstadoCivil.Items.AddRange(new object[] {
            "qqqqq",
            "sssss",
            "vvvvv"});
            this.CboEstadoCivil.Location = new System.Drawing.Point(153, 209);
            this.CboEstadoCivil.Name = "CboEstadoCivil";
            this.CboEstadoCivil.Size = new System.Drawing.Size(216, 24);
            this.CboEstadoCivil.TabIndex = 4;
            // 
            // RbtMasculio
            // 
            this.RbtMasculio.AutoSize = true;
            this.RbtMasculio.Location = new System.Drawing.Point(153, 280);
            this.RbtMasculio.Name = "RbtMasculio";
            this.RbtMasculio.Size = new System.Drawing.Size(89, 20);
            this.RbtMasculio.TabIndex = 6;
            this.RbtMasculio.TabStop = true;
            this.RbtMasculio.Text = "Masculino";
            this.RbtMasculio.UseVisualStyleBackColor = true;
            // 
            // RbtFemenino
            // 
            this.RbtFemenino.AutoSize = true;
            this.RbtFemenino.Location = new System.Drawing.Point(153, 244);
            this.RbtFemenino.Name = "RbtFemenino";
            this.RbtFemenino.Size = new System.Drawing.Size(88, 20);
            this.RbtFemenino.TabIndex = 5;
            this.RbtFemenino.TabStop = true;
            this.RbtFemenino.Text = "Femenino";
            this.RbtFemenino.UseVisualStyleBackColor = true;
            // 
            // TxtApellido
            // 
            this.TxtApellido.Location = new System.Drawing.Point(153, 56);
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new System.Drawing.Size(216, 22);
            this.TxtApellido.TabIndex = 0;
            // 
            // TxtDocumento
            // 
            this.TxtDocumento.Location = new System.Drawing.Point(153, 173);
            this.TxtDocumento.Name = "TxtDocumento";
            this.TxtDocumento.Size = new System.Drawing.Size(216, 22);
            this.TxtDocumento.TabIndex = 3;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(153, 94);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(216, 22);
            this.TxtNombre.TabIndex = 1;
            // 
            // ChkFallecido
            // 
            this.ChkFallecido.AutoSize = true;
            this.ChkFallecido.Location = new System.Drawing.Point(154, 322);
            this.ChkFallecido.Name = "ChkFallecido";
            this.ChkFallecido.Size = new System.Drawing.Size(18, 17);
            this.ChkFallecido.TabIndex = 7;
            this.ChkFallecido.UseVisualStyleBackColor = true;
            // 
            // LblSexo
            // 
            this.LblSexo.AutoSize = true;
            this.LblSexo.Location = new System.Drawing.Point(93, 244);
            this.LblSexo.Name = "LblSexo";
            this.LblSexo.Size = new System.Drawing.Size(38, 16);
            this.LblSexo.TabIndex = 8;
            this.LblSexo.Text = "Sexo";
            this.LblSexo.Click += new System.EventHandler(this.LblSexo_Click);
            // 
            // LblApellido
            // 
            this.LblApellido.AutoSize = true;
            this.LblApellido.Location = new System.Drawing.Point(74, 62);
            this.LblApellido.Name = "LblApellido";
            this.LblApellido.Size = new System.Drawing.Size(57, 16);
            this.LblApellido.TabIndex = 9;
            this.LblApellido.Text = "Apellido";
            this.LblApellido.Click += new System.EventHandler(this.label2_Click);
            // 
            // LblTipoDocumento
            // 
            this.LblTipoDocumento.AutoSize = true;
            this.LblTipoDocumento.Location = new System.Drawing.Point(12, 135);
            this.LblTipoDocumento.Name = "LblTipoDocumento";
            this.LblTipoDocumento.Size = new System.Drawing.Size(119, 16);
            this.LblTipoDocumento.TabIndex = 10;
            this.LblTipoDocumento.Text = "Tipo de Documeto";
            // 
            // LblEstadoCivil
            // 
            this.LblEstadoCivil.AutoSize = true;
            this.LblEstadoCivil.Location = new System.Drawing.Point(53, 209);
            this.LblEstadoCivil.Name = "LblEstadoCivil";
            this.LblEstadoCivil.Size = new System.Drawing.Size(78, 16);
            this.LblEstadoCivil.TabIndex = 11;
            this.LblEstadoCivil.Text = "Estado Civil";
            // 
            // LblDocumento
            // 
            this.LblDocumento.AutoSize = true;
            this.LblDocumento.Location = new System.Drawing.Point(55, 173);
            this.LblDocumento.Name = "LblDocumento";
            this.LblDocumento.Size = new System.Drawing.Size(76, 16);
            this.LblDocumento.TabIndex = 12;
            this.LblDocumento.Text = "Documento";
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Location = new System.Drawing.Point(75, 100);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(56, 16);
            this.LblNombre.TabIndex = 13;
            this.LblNombre.Text = "Nombre";
            // 
            // LblFallecido
            // 
            this.LblFallecido.AutoSize = true;
            this.LblFallecido.Location = new System.Drawing.Point(68, 326);
            this.LblFallecido.Name = "LblFallecido";
            this.LblFallecido.Size = new System.Drawing.Size(63, 16);
            this.LblFallecido.TabIndex = 14;
            this.LblFallecido.Text = "Fallecido";
            this.LblFallecido.Click += new System.EventHandler(this.LblFallecido_Click);
            // 
            // LstPersonas
            // 
            this.LstPersonas.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.LstPersonas.FormattingEnabled = true;
            this.LstPersonas.ItemHeight = 16;
            this.LstPersonas.Location = new System.Drawing.Point(432, 34);
            this.LstPersonas.Name = "LstPersonas";
            this.LstPersonas.Size = new System.Drawing.Size(344, 308);
            this.LstPersonas.TabIndex = 14;
            // 
            // BtnGrabar
            // 
            this.BtnGrabar.Location = new System.Drawing.Point(384, 399);
            this.BtnGrabar.Name = "BtnGrabar";
            this.BtnGrabar.Size = new System.Drawing.Size(75, 23);
            this.BtnGrabar.TabIndex = 11;
            this.BtnGrabar.Text = "Grabar";
            this.BtnGrabar.UseVisualStyleBackColor = true;
            this.BtnGrabar.Click += new System.EventHandler(this.BtnGrabar_Click);
            // 
            // BtnBorrar
            // 
            this.BtnBorrar.Location = new System.Drawing.Point(268, 399);
            this.BtnBorrar.Name = "BtnBorrar";
            this.BtnBorrar.Size = new System.Drawing.Size(75, 23);
            this.BtnBorrar.TabIndex = 10;
            this.BtnBorrar.Text = "Borrar";
            this.BtnBorrar.UseVisualStyleBackColor = true;
            this.BtnBorrar.Click += new System.EventHandler(this.BtnBorrar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(511, 399);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(75, 23);
            this.BtnCancelar.TabIndex = 12;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.Location = new System.Drawing.Point(153, 399);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(75, 23);
            this.BtnEditar.TabIndex = 9;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.UseVisualStyleBackColor = true;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.AllowDrop = true;
            this.BtnSalir.Location = new System.Drawing.Point(632, 399);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(75, 23);
            this.BtnSalir.TabIndex = 13;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.Location = new System.Drawing.Point(44, 399);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(75, 23);
            this.BtnNuevo.TabIndex = 8;
            this.BtnNuevo.Text = "Nuevo";
            this.BtnNuevo.UseVisualStyleBackColor = true;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnNuevo);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnBorrar);
            this.Controls.Add(this.BtnGrabar);
            this.Controls.Add(this.LstPersonas);
            this.Controls.Add(this.LblFallecido);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.LblDocumento);
            this.Controls.Add(this.LblEstadoCivil);
            this.Controls.Add(this.LblTipoDocumento);
            this.Controls.Add(this.LblApellido);
            this.Controls.Add(this.LblSexo);
            this.Controls.Add(this.ChkFallecido);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.TxtDocumento);
            this.Controls.Add(this.TxtApellido);
            this.Controls.Add(this.RbtFemenino);
            this.Controls.Add(this.RbtMasculio);
            this.Controls.Add(this.CboEstadoCivil);
            this.Controls.Add(this.CboTipoDocumento);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CboTipoDocumento;
        private System.Windows.Forms.ComboBox CboEstadoCivil;
        private System.Windows.Forms.RadioButton RbtMasculio;
        private System.Windows.Forms.RadioButton RbtFemenino;
        private System.Windows.Forms.TextBox TxtApellido;
        private System.Windows.Forms.TextBox TxtDocumento;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.CheckBox ChkFallecido;
        private System.Windows.Forms.Label LblSexo;
        private System.Windows.Forms.Label LblApellido;
        private System.Windows.Forms.Label LblTipoDocumento;
        private System.Windows.Forms.Label LblEstadoCivil;
        private System.Windows.Forms.Label LblDocumento;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label LblFallecido;
        private System.Windows.Forms.ListBox LstPersonas;
        private System.Windows.Forms.Button BtnGrabar;
        private System.Windows.Forms.Button BtnBorrar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button BtnNuevo;
    }
}

