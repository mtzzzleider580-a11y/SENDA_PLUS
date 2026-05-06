namespace SENDAPLUS
{
    partial class Agrgar_invitados
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
            this.dgvSeleccionados = new System.Windows.Forms.DataGridView();
            this.Evento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvInvitados = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnGuardar = new MaterialSkin.Controls.MaterialButton();
            this.btnQuitarInvitacion = new MaterialSkin.Controls.MaterialButton();
            this.btnAgregarSeleccionado = new MaterialSkin.Controls.MaterialButton();
            this.btnVolver = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeleccionados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvitados)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSeleccionados
            // 
            this.dgvSeleccionados.AllowUserToAddRows = false;
            this.dgvSeleccionados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSeleccionados.BackgroundColor = System.Drawing.Color.Snow;
            this.dgvSeleccionados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSeleccionados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Evento,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dgvSeleccionados.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvSeleccionados.Location = new System.Drawing.Point(854, 128);
            this.dgvSeleccionados.Name = "dgvSeleccionados";
            this.dgvSeleccionados.RowHeadersWidth = 62;
            this.dgvSeleccionados.RowTemplate.Height = 28;
            this.dgvSeleccionados.Size = new System.Drawing.Size(693, 462);
            this.dgvSeleccionados.TabIndex = 22;
            // 
            // Evento
            // 
            this.Evento.HeaderText = "Evento";
            this.Evento.MinimumWidth = 8;
            this.Evento.Name = "Evento";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre de Invitado";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Correo";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dgvInvitados
            // 
            this.dgvInvitados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInvitados.BackgroundColor = System.Drawing.Color.Snow;
            this.dgvInvitados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvitados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nombre,
            this.Correo,
            this.Seleccionar});
            this.dgvInvitados.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvInvitados.Location = new System.Drawing.Point(82, 128);
            this.dgvInvitados.Name = "dgvInvitados";
            this.dgvInvitados.RowHeadersWidth = 62;
            this.dgvInvitados.RowTemplate.Height = 28;
            this.dgvInvitados.Size = new System.Drawing.Size(681, 462);
            this.dgvInvitados.TabIndex = 21;
            // 
            // Id
            // 
            this.Id.HeaderText = "";
            this.Id.MinimumWidth = 8;
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 8;
            this.Nombre.Name = "Nombre";
            // 
            // Correo
            // 
            this.Correo.HeaderText = "Correo";
            this.Correo.MinimumWidth = 8;
            this.Correo.Name = "Correo";
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Seleccionar";
            this.Seleccionar.MinimumWidth = 8;
            this.Seleccionar.Name = "Seleccionar";
            // 
            // btnGuardar
            // 
            this.btnGuardar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGuardar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnGuardar.Depth = 0;
            this.btnGuardar.HighEmphasis = true;
            this.btnGuardar.Icon = null;
            this.btnGuardar.Location = new System.Drawing.Point(765, 645);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGuardar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnGuardar.Size = new System.Drawing.Size(92, 36);
            this.btnGuardar.TabIndex = 20;
            this.btnGuardar.Text = " Guardar";
            this.btnGuardar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnGuardar.UseAccentColor = false;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnQuitarInvitacion
            // 
            this.btnQuitarInvitacion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnQuitarInvitacion.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnQuitarInvitacion.Depth = 0;
            this.btnQuitarInvitacion.HighEmphasis = true;
            this.btnQuitarInvitacion.Icon = null;
            this.btnQuitarInvitacion.Location = new System.Drawing.Point(1026, 645);
            this.btnQuitarInvitacion.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnQuitarInvitacion.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnQuitarInvitacion.Name = "btnQuitarInvitacion";
            this.btnQuitarInvitacion.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnQuitarInvitacion.Size = new System.Drawing.Size(158, 36);
            this.btnQuitarInvitacion.TabIndex = 19;
            this.btnQuitarInvitacion.Text = "Quitar Invitacion";
            this.btnQuitarInvitacion.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnQuitarInvitacion.UseAccentColor = false;
            this.btnQuitarInvitacion.UseVisualStyleBackColor = true;
            this.btnQuitarInvitacion.Click += new System.EventHandler(this.btnQuitarInvitacion_Click);
            // 
            // btnAgregarSeleccionado
            // 
            this.btnAgregarSeleccionado.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAgregarSeleccionado.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAgregarSeleccionado.Depth = 0;
            this.btnAgregarSeleccionado.HighEmphasis = true;
            this.btnAgregarSeleccionado.Icon = null;
            this.btnAgregarSeleccionado.Location = new System.Drawing.Point(342, 645);
            this.btnAgregarSeleccionado.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAgregarSeleccionado.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgregarSeleccionado.Name = "btnAgregarSeleccionado";
            this.btnAgregarSeleccionado.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAgregarSeleccionado.Size = new System.Drawing.Size(199, 36);
            this.btnAgregarSeleccionado.TabIndex = 18;
            this.btnAgregarSeleccionado.Text = "Agregar Seleccionado";
            this.btnAgregarSeleccionado.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAgregarSeleccionado.UseAccentColor = false;
            this.btnAgregarSeleccionado.UseVisualStyleBackColor = true;
            this.btnAgregarSeleccionado.Click += new System.EventHandler(this.btnAgregarSeleccionado_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnVolver.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnVolver.Depth = 0;
            this.btnVolver.HighEmphasis = true;
            this.btnVolver.Icon = null;
            this.btnVolver.Location = new System.Drawing.Point(1244, 645);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnVolver.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnVolver.Size = new System.Drawing.Size(158, 36);
            this.btnVolver.TabIndex = 23;
            this.btnVolver.Text = "Volver";
            this.btnVolver.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnVolver.UseAccentColor = false;
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // Agrgar_invitados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1634, 778);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.dgvSeleccionados);
            this.Controls.Add(this.dgvInvitados);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnQuitarInvitacion);
            this.Controls.Add(this.btnAgregarSeleccionado);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Agrgar_invitados";
            this.Padding = new System.Windows.Forms.Padding(4, 98, 4, 5);
            this.Text = "AGREGAR INVITADOS";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeleccionados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvitados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSeleccionados;
        private System.Windows.Forms.DataGridView dgvInvitados;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccionar;
        private MaterialSkin.Controls.MaterialButton btnGuardar;
        private MaterialSkin.Controls.MaterialButton btnQuitarInvitacion;
        private MaterialSkin.Controls.MaterialButton btnAgregarSeleccionado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Evento;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private MaterialSkin.Controls.MaterialButton btnVolver;
    }
}