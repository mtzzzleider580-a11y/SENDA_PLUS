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
            this.lblSeleccionarFecha = new MaterialSkin.Controls.MaterialLabel();
            this.lblHoradelevento = new MaterialSkin.Controls.MaterialLabel();
            this.materialTextBox1 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialComboBox1 = new MaterialSkin.Controls.MaterialComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.btnAgregarInvitados = new MaterialSkin.Controls.MaterialButton();
            this.materialCheckedListBox1 = new MaterialSkin.Controls.MaterialCheckedListBox();
            this.materialCheckedListBox2 = new MaterialSkin.Controls.MaterialCheckedListBox();
            this.btnAgregar = new MaterialSkin.Controls.MaterialButton();
            this.btnQuitarInvitacion = new MaterialSkin.Controls.MaterialButton();
            this.btnGuardar = new MaterialSkin.Controls.MaterialButton();
            this.btnCancelarEvento = new MaterialSkin.Controls.MaterialButton();
            this.btnVolver = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // lblNombredelevento
            // 
            this.lblNombredelevento.AutoSize = true;
            this.lblNombredelevento.Depth = 0;
            this.lblNombredelevento.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblNombredelevento.Location = new System.Drawing.Point(45, 57);
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
            this.lblTipodeevento.Location = new System.Drawing.Point(48, 135);
            this.lblTipodeevento.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTipodeevento.Name = "lblTipodeevento";
            this.lblTipodeevento.Size = new System.Drawing.Size(110, 19);
            this.lblTipodeevento.TabIndex = 1;
            this.lblTipodeevento.Text = " Tipo de Evento";
            // 
            // lblSeleccionarFecha
            // 
            this.lblSeleccionarFecha.AutoSize = true;
            this.lblSeleccionarFecha.Depth = 0;
            this.lblSeleccionarFecha.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblSeleccionarFecha.Location = new System.Drawing.Point(48, 224);
            this.lblSeleccionarFecha.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSeleccionarFecha.Name = "lblSeleccionarFecha";
            this.lblSeleccionarFecha.Size = new System.Drawing.Size(134, 19);
            this.lblSeleccionarFecha.TabIndex = 2;
            this.lblSeleccionarFecha.Text = " Seleccionar Fecha";
            // 
            // lblHoradelevento
            // 
            this.lblHoradelevento.AutoSize = true;
            this.lblHoradelevento.Depth = 0;
            this.lblHoradelevento.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblHoradelevento.Location = new System.Drawing.Point(51, 283);
            this.lblHoradelevento.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblHoradelevento.Name = "lblHoradelevento";
            this.lblHoradelevento.Size = new System.Drawing.Size(116, 19);
            this.lblHoradelevento.TabIndex = 3;
            this.lblHoradelevento.Text = " Hora del Evento";
            // 
            // materialTextBox1
            // 
            this.materialTextBox1.AnimateReadOnly = false;
            this.materialTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox1.Depth = 0;
            this.materialTextBox1.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox1.LeadingIcon = null;
            this.materialTextBox1.Location = new System.Drawing.Point(192, 33);
            this.materialTextBox1.MaxLength = 50;
            this.materialTextBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox1.Multiline = false;
            this.materialTextBox1.Name = "materialTextBox1";
            this.materialTextBox1.Size = new System.Drawing.Size(255, 50);
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
            this.materialComboBox1.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBox1.FormattingEnabled = true;
            this.materialComboBox1.IntegralHeight = false;
            this.materialComboBox1.ItemHeight = 43;
            this.materialComboBox1.Location = new System.Drawing.Point(192, 125);
            this.materialComboBox1.MaxDropDownItems = 4;
            this.materialComboBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBox1.Name = "materialComboBox1";
            this.materialComboBox1.Size = new System.Drawing.Size(255, 49);
            this.materialComboBox1.StartIndex = 0;
            this.materialComboBox1.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(192, 216);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(263, 26);
            this.dateTimePicker1.TabIndex = 6;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(192, 283);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(263, 26);
            this.dateTimePicker2.TabIndex = 7;
            // 
            // btnAgregarInvitados
            // 
            this.btnAgregarInvitados.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAgregarInvitados.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAgregarInvitados.Depth = 0;
            this.btnAgregarInvitados.HighEmphasis = true;
            this.btnAgregarInvitados.Icon = null;
            this.btnAgregarInvitados.Location = new System.Drawing.Point(78, 389);
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
            // materialCheckedListBox1
            // 
            this.materialCheckedListBox1.AutoScroll = true;
            this.materialCheckedListBox1.BackColor = System.Drawing.SystemColors.Control;
            this.materialCheckedListBox1.Depth = 0;
            this.materialCheckedListBox1.Location = new System.Drawing.Point(481, 40);
            this.materialCheckedListBox1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckedListBox1.Name = "materialCheckedListBox1";
            this.materialCheckedListBox1.Size = new System.Drawing.Size(341, 330);
            this.materialCheckedListBox1.Striped = false;
            this.materialCheckedListBox1.StripeDarkColor = System.Drawing.Color.Empty;
            this.materialCheckedListBox1.TabIndex = 9;
            // 
            // materialCheckedListBox2
            // 
            this.materialCheckedListBox2.AutoScroll = true;
            this.materialCheckedListBox2.BackColor = System.Drawing.SystemColors.Control;
            this.materialCheckedListBox2.Depth = 0;
            this.materialCheckedListBox2.Location = new System.Drawing.Point(844, 43);
            this.materialCheckedListBox2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckedListBox2.Name = "materialCheckedListBox2";
            this.materialCheckedListBox2.Size = new System.Drawing.Size(322, 327);
            this.materialCheckedListBox2.Striped = false;
            this.materialCheckedListBox2.StripeDarkColor = System.Drawing.Color.Empty;
            this.materialCheckedListBox2.TabIndex = 10;
            // 
            // btnAgregar
            // 
            this.btnAgregar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAgregar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAgregar.Depth = 0;
            this.btnAgregar.HighEmphasis = true;
            this.btnAgregar.Icon = null;
            this.btnAgregar.Location = new System.Drawing.Point(574, 389);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAgregar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAgregar.Size = new System.Drawing.Size(91, 36);
            this.btnAgregar.TabIndex = 11;
            this.btnAgregar.Text = " Agregar";
            this.btnAgregar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAgregar.UseAccentColor = false;
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnQuitarInvitacion
            // 
            this.btnQuitarInvitacion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnQuitarInvitacion.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnQuitarInvitacion.Depth = 0;
            this.btnQuitarInvitacion.HighEmphasis = true;
            this.btnQuitarInvitacion.Icon = null;
            this.btnQuitarInvitacion.Location = new System.Drawing.Point(754, 389);
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
            this.btnGuardar.Location = new System.Drawing.Point(971, 389);
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
            this.btnCancelarEvento.Location = new System.Drawing.Point(464, 573);
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
            this.btnVolver.Location = new System.Drawing.Point(697, 573);
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
            // Crear_Evento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 636);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnCancelarEvento);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnQuitarInvitacion);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.materialCheckedListBox2);
            this.Controls.Add(this.materialCheckedListBox1);
            this.Controls.Add(this.btnAgregarInvitados);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.materialComboBox1);
            this.Controls.Add(this.materialTextBox1);
            this.Controls.Add(this.lblHoradelevento);
            this.Controls.Add(this.lblSeleccionarFecha);
            this.Controls.Add(this.lblTipodeevento);
            this.Controls.Add(this.lblNombredelevento);
            this.Name = "Crear_Evento";
            this.Text = "Crear_Evento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lblNombredelevento;
        private MaterialSkin.Controls.MaterialLabel lblTipodeevento;
        private MaterialSkin.Controls.MaterialLabel lblSeleccionarFecha;
        private MaterialSkin.Controls.MaterialLabel lblHoradelevento;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox1;
        private MaterialSkin.Controls.MaterialComboBox materialComboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private MaterialSkin.Controls.MaterialButton btnAgregarInvitados;
        private MaterialSkin.Controls.MaterialCheckedListBox materialCheckedListBox1;
        private MaterialSkin.Controls.MaterialCheckedListBox materialCheckedListBox2;
        private MaterialSkin.Controls.MaterialButton btnAgregar;
        private MaterialSkin.Controls.MaterialButton btnQuitarInvitacion;
        private MaterialSkin.Controls.MaterialButton btnGuardar;
        private MaterialSkin.Controls.MaterialButton btnCancelarEvento;
        private MaterialSkin.Controls.MaterialButton btnVolver;
    }
}