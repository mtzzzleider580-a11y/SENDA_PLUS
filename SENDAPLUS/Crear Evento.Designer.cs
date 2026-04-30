namespace SENDAPLUS
{
    partial class Crear_Evento
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
            this.lblNombredelevento = new MaterialSkin.Controls.MaterialLabel();
            this.lblTipodeevento = new MaterialSkin.Controls.MaterialLabel();
            this.lblFechayhoradeinicio = new MaterialSkin.Controls.MaterialLabel();
            this.lblFechayhorafin = new MaterialSkin.Controls.MaterialLabel();
            this.materialTextBox1 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialComboBox1 = new MaterialSkin.Controls.MaterialComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.btnAgregarInvitados = new MaterialSkin.Controls.MaterialButton();
            this.btnAgregarSeleccionado = new MaterialSkin.Controls.MaterialButton();
            this.btnQuitarInvitacion = new MaterialSkin.Controls.MaterialButton();
            this.btnGuardar = new MaterialSkin.Controls.MaterialButton();
            this.btnCancelarEvento = new MaterialSkin.Controls.MaterialButton();
            this.btnVolver = new MaterialSkin.Controls.MaterialButton();
            this.dgvInvitados = new System.Windows.Forms.DataGridView();
            this.dgvSeleccionados = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblEstado = new MaterialSkin.Controls.MaterialLabel();
            this.materialComboBox2 = new MaterialSkin.Controls.MaterialComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvitados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeleccionados)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombredelevento
            // 
            this.lblNombredelevento.AutoSize = true;
            this.lblNombredelevento.Depth = 0;
            this.lblNombredelevento.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblNombredelevento.Location = new System.Drawing.Point(30, 122);
            this.lblNombredelevento.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNombredelevento.Name = "lblNombredelevento";
            this.lblNombredelevento.Size = new System.Drawing.Size(134, 19);
            this.lblNombredelevento.TabIndex = 0;
            this.lblNombredelevento.Text = "Nombre del Evento";
            // 
            // lblTipodeevento
            // 
            this.lblTipodeevento.AutoSize = true;
            this.lblTipodeevento.Depth = 0;
            this.lblTipodeevento.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblTipodeevento.Location = new System.Drawing.Point(33, 200);
            this.lblTipodeevento.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTipodeevento.Name = "lblTipodeevento";
            this.lblTipodeevento.Size = new System.Drawing.Size(110, 19);
            this.lblTipodeevento.TabIndex = 1;
            this.lblTipodeevento.Text = " Tipo de Evento";
            // 
            // lblFechayhoradeinicio
            // 
            this.lblFechayhoradeinicio.AutoSize = true;
            this.lblFechayhoradeinicio.Depth = 0;
            this.lblFechayhoradeinicio.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblFechayhoradeinicio.Location = new System.Drawing.Point(33, 289);
            this.lblFechayhoradeinicio.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFechayhoradeinicio.Name = "lblFechayhoradeinicio";
            this.lblFechayhoradeinicio.Size = new System.Drawing.Size(155, 19);
            this.lblFechayhoradeinicio.TabIndex = 2;
            this.lblFechayhoradeinicio.Text = "Fecha y hora de inicio";
            // 
            // lblFechayhorafin
            // 
            this.lblFechayhorafin.AutoSize = true;
            this.lblFechayhorafin.Depth = 0;
            this.lblFechayhorafin.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblFechayhorafin.Location = new System.Drawing.Point(37, 348);
            this.lblFechayhorafin.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFechayhorafin.Name = "lblFechayhorafin";
            this.lblFechayhorafin.Size = new System.Drawing.Size(115, 19);
            this.lblFechayhorafin.TabIndex = 3;
            this.lblFechayhorafin.Text = "Fecha y hora fin";
            // 
            // materialTextBox1
            // 
            this.materialTextBox1.AnimateReadOnly = false;
            this.materialTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox1.Depth = 0;
            this.materialTextBox1.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox1.LeadingIcon = null;
            this.materialTextBox1.Location = new System.Drawing.Point(220, 98);
            this.materialTextBox1.MaxLength = 50;
            this.materialTextBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox1.Multiline = false;
            this.materialTextBox1.Name = "materialTextBox1";
            this.materialTextBox1.Size = new System.Drawing.Size(202, 50);
            this.materialTextBox1.TabIndex = 4;
            this.materialTextBox1.Text = "";
            this.materialTextBox1.TrailingIcon = null;
            // 
            // materialComboBox1
            // 
            this.materialComboBox1.AutoResize = false;
            this.materialComboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBox1.Depth = 0;
            this.materialComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBox1.DropDownHeight = 174;
            this.materialComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBox1.DropDownWidth = 121;
            this.materialComboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBox1.FormattingEnabled = true;
            this.materialComboBox1.IntegralHeight = false;
            this.materialComboBox1.ItemHeight = 43;
            this.materialComboBox1.Location = new System.Drawing.Point(220, 190);
            this.materialComboBox1.MaxDropDownItems = 4;
            this.materialComboBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBox1.Name = "materialComboBox1";
            this.materialComboBox1.Size = new System.Drawing.Size(202, 49);
            this.materialComboBox1.StartIndex = 0;
            this.materialComboBox1.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(220, 281);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(210, 26);
            this.dateTimePicker1.TabIndex = 6;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(220, 348);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(210, 26);
            this.dateTimePicker2.TabIndex = 7;
            // 
            // btnAgregarInvitados
            // 
            this.btnAgregarInvitados.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAgregarInvitados.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAgregarInvitados.Depth = 0;
            this.btnAgregarInvitados.HighEmphasis = true;
            this.btnAgregarInvitados.Icon = null;
            this.btnAgregarInvitados.Location = new System.Drawing.Point(99, 464);
            this.btnAgregarInvitados.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAgregarInvitados.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgregarInvitados.Name = "btnAgregarInvitados";
            this.btnAgregarInvitados.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAgregarInvitados.Size = new System.Drawing.Size(171, 36);
            this.btnAgregarInvitados.TabIndex = 8;
            this.btnAgregarInvitados.Text = " Agregar Invitados";
            this.btnAgregarInvitados.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAgregarInvitados.UseAccentColor = false;
            this.btnAgregarInvitados.UseVisualStyleBackColor = true;
            // 
            // btnAgregarSeleccionado
            // 
            this.btnAgregarSeleccionado.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAgregarSeleccionado.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAgregarSeleccionado.Depth = 0;
            this.btnAgregarSeleccionado.HighEmphasis = true;
            this.btnAgregarSeleccionado.Icon = null;
            this.btnAgregarSeleccionado.Location = new System.Drawing.Point(556, 490);
            this.btnAgregarSeleccionado.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAgregarSeleccionado.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgregarSeleccionado.Name = "btnAgregarSeleccionado";
            this.btnAgregarSeleccionado.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAgregarSeleccionado.Size = new System.Drawing.Size(199, 36);
            this.btnAgregarSeleccionado.TabIndex = 11;
            this.btnAgregarSeleccionado.Text = "Agregar Seleccionado";
            this.btnAgregarSeleccionado.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAgregarSeleccionado.UseAccentColor = false;
            this.btnAgregarSeleccionado.UseVisualStyleBackColor = true;
            // 
            // btnQuitarInvitacion
            // 
            this.btnQuitarInvitacion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnQuitarInvitacion.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnQuitarInvitacion.Depth = 0;
            this.btnQuitarInvitacion.HighEmphasis = true;
            this.btnQuitarInvitacion.Icon = null;
            this.btnQuitarInvitacion.Location = new System.Drawing.Point(1053, 490);
            this.btnQuitarInvitacion.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnQuitarInvitacion.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnQuitarInvitacion.Name = "btnQuitarInvitacion";
            this.btnQuitarInvitacion.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnQuitarInvitacion.Size = new System.Drawing.Size(158, 36);
            this.btnQuitarInvitacion.TabIndex = 12;
            this.btnQuitarInvitacion.Text = "Quitar Invitacion";
            this.btnQuitarInvitacion.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnQuitarInvitacion.UseAccentColor = false;
            this.btnQuitarInvitacion.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGuardar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnGuardar.Depth = 0;
            this.btnGuardar.HighEmphasis = true;
            this.btnGuardar.Icon = null;
            this.btnGuardar.Location = new System.Drawing.Point(868, 490);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGuardar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnGuardar.Size = new System.Drawing.Size(92, 36);
            this.btnGuardar.TabIndex = 13;
            this.btnGuardar.Text = " Guardar";
            this.btnGuardar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnGuardar.UseAccentColor = false;
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnCancelarEvento
            // 
            this.btnCancelarEvento.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancelarEvento.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCancelarEvento.Depth = 0;
            this.btnCancelarEvento.HighEmphasis = true;
            this.btnCancelarEvento.Icon = null;
            this.btnCancelarEvento.Location = new System.Drawing.Point(-1, 598);
            this.btnCancelarEvento.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancelarEvento.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancelarEvento.Name = "btnCancelarEvento";
            this.btnCancelarEvento.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCancelarEvento.Size = new System.Drawing.Size(159, 36);
            this.btnCancelarEvento.TabIndex = 14;
            this.btnCancelarEvento.Text = " Cancelar Evento";
            this.btnCancelarEvento.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCancelarEvento.UseAccentColor = false;
            this.btnCancelarEvento.UseVisualStyleBackColor = true;
            // 
            // btnVolver
            // 
            this.btnVolver.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnVolver.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnVolver.Depth = 0;
            this.btnVolver.HighEmphasis = true;
            this.btnVolver.Icon = null;
            this.btnVolver.Location = new System.Drawing.Point(1202, 598);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnVolver.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnVolver.Size = new System.Drawing.Size(76, 36);
            this.btnVolver.TabIndex = 15;
            this.btnVolver.Text = "Volver";
            this.btnVolver.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnVolver.UseAccentColor = false;
            this.btnVolver.UseVisualStyleBackColor = true;
            // 
            // dgvInvitados
            // 
            this.dgvInvitados.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvInvitados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvitados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nombre,
            this.Correo,
            this.Seleccionar});
            this.dgvInvitados.Location = new System.Drawing.Point(436, 85);
            this.dgvInvitados.Name = "dgvInvitados";
            this.dgvInvitados.RowHeadersWidth = 62;
            this.dgvInvitados.RowTemplate.Height = 28;
            this.dgvInvitados.Size = new System.Drawing.Size(472, 386);
            this.dgvInvitados.TabIndex = 16;
            // 
            // dgvSeleccionados
            // 
            this.dgvSeleccionados.AllowUserToAddRows = false;
            this.dgvSeleccionados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSeleccionados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dgvSeleccionados.Location = new System.Drawing.Point(914, 85);
            this.dgvSeleccionados.Name = "dgvSeleccionados";
            this.dgvSeleccionados.RowHeadersWidth = 62;
            this.dgvSeleccionados.RowTemplate.Height = 28;
            this.dgvSeleccionados.Size = new System.Drawing.Size(358, 386);
            this.dgvSeleccionados.TabIndex = 17;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Column1";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Correo";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "";
            this.Seleccionar.MinimumWidth = 8;
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.Width = 150;
            // 
            // Correo
            // 
            this.Correo.HeaderText = "Correo";
            this.Correo.MinimumWidth = 8;
            this.Correo.Name = "Correo";
            this.Correo.Width = 150;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 8;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 150;
            // 
            // Id
            // 
            this.Id.HeaderText = "";
            this.Id.MinimumWidth = 8;
            this.Id.Name = "Id";
            this.Id.Visible = false;
            this.Id.Width = 150;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Depth = 0;
            this.lblEstado.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblEstado.Location = new System.Drawing.Point(37, 397);
            this.lblEstado.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(50, 19);
            this.lblEstado.TabIndex = 18;
            this.lblEstado.Text = "Estado";
            // 
            // materialComboBox2
            // 
            this.materialComboBox2.AutoResize = false;
            this.materialComboBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBox2.Depth = 0;
            this.materialComboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBox2.DropDownHeight = 174;
            this.materialComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBox2.DropDownWidth = 121;
            this.materialComboBox2.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBox2.FormattingEnabled = true;
            this.materialComboBox2.IntegralHeight = false;
            this.materialComboBox2.ItemHeight = 43;
            this.materialComboBox2.Items.AddRange(new object[] {
            "Activo",
            "Desactivado"});
            this.materialComboBox2.Location = new System.Drawing.Point(212, 397);
            this.materialComboBox2.MaxDropDownItems = 4;
            this.materialComboBox2.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBox2.Name = "materialComboBox2";
            this.materialComboBox2.Size = new System.Drawing.Size(210, 49);
            this.materialComboBox2.StartIndex = 0;
            this.materialComboBox2.TabIndex = 19;
            this.materialComboBox2.SelectedIndexChanged += new System.EventHandler(this.materialComboBox2_SelectedIndexChanged);
            // 
            // Crear_Evento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1292, 636);
            this.Controls.Add(this.materialComboBox2);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.dgvSeleccionados);
            this.Controls.Add(this.dgvInvitados);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnCancelarEvento);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnQuitarInvitacion);
            this.Controls.Add(this.btnAgregarSeleccionado);
            this.Controls.Add(this.btnAgregarInvitados);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.materialComboBox1);
            this.Controls.Add(this.materialTextBox1);
            this.Controls.Add(this.lblFechayhorafin);
            this.Controls.Add(this.lblFechayhoradeinicio);
            this.Controls.Add(this.lblTipodeevento);
            this.Controls.Add(this.lblNombredelevento);
            this.Name = "Crear_Evento";
            this.Text = "Crear_Evento";
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvitados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeleccionados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lblNombredelevento;
        private MaterialSkin.Controls.MaterialLabel lblTipodeevento;
        private MaterialSkin.Controls.MaterialLabel lblFechayhoradeinicio;
        private MaterialSkin.Controls.MaterialLabel lblFechayhorafin;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox1;
        private MaterialSkin.Controls.MaterialComboBox materialComboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private MaterialSkin.Controls.MaterialButton btnAgregarInvitados;
        private MaterialSkin.Controls.MaterialButton btnAgregarSeleccionado;
        private MaterialSkin.Controls.MaterialButton btnQuitarInvitacion;
        private MaterialSkin.Controls.MaterialButton btnGuardar;
        private MaterialSkin.Controls.MaterialButton btnCancelarEvento;
        private MaterialSkin.Controls.MaterialButton btnVolver;
        private System.Windows.Forms.DataGridView dgvInvitados;
        private System.Windows.Forms.DataGridView dgvSeleccionados;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccionar;
        private MaterialSkin.Controls.MaterialLabel lblEstado;
        private MaterialSkin.Controls.MaterialComboBox materialComboBox2;
    }
}