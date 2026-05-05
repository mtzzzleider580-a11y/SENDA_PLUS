namespace SENDAPLUS
{
    partial class FormInvitado
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbMes = new MaterialSkin.Controls.MaterialComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lugar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCerrarsesión = new MaterialSkin.Controls.MaterialButton();
            this.btnfiltrar = new MaterialSkin.Controls.MaterialButton();
            this.btnConsultar = new MaterialSkin.Controls.MaterialButton();
            this.btnDetalles = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmbMes
            // 
            this.cmbMes.AutoResize = false;
            this.cmbMes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbMes.Depth = 0;
            this.cmbMes.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbMes.DropDownHeight = 174;
            this.cmbMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMes.DropDownWidth = 121;
            this.cmbMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbMes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbMes.FormattingEnabled = true;
            this.cmbMes.IntegralHeight = false;
            this.cmbMes.ItemHeight = 43;
            this.cmbMes.Location = new System.Drawing.Point(1165, 192);
            this.cmbMes.MaxDropDownItems = 4;
            this.cmbMes.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbMes.Name = "cmbMes";
            this.cmbMes.Size = new System.Drawing.Size(121, 49);
            this.cmbMes.StartIndex = 0;
            this.cmbMes.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Algerian", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Tipo,
            this.Fecha,
            this.HoraInicio,
            this.HoraFin,
            this.Lugar,
            this.Estado});
            this.dataGridView1.Location = new System.Drawing.Point(11, 261);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1364, 415);
            this.dataGridView1.TabIndex = 4;
            // 
            // Nombre
            // 
            this.Nombre.FillWeight = 81.08108F;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 8;
            this.Nombre.Name = "Nombre";
            // 
            // Tipo
            // 
            this.Tipo.FillWeight = 90.12113F;
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.MinimumWidth = 8;
            this.Tipo.Name = "Tipo";
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.MinimumWidth = 8;
            this.Fecha.Name = "Fecha";
            // 
            // HoraInicio
            // 
            this.HoraInicio.FillWeight = 97.93956F;
            this.HoraInicio.HeaderText = "Hora Inicio";
            this.HoraInicio.MinimumWidth = 8;
            this.HoraInicio.Name = "HoraInicio";
            // 
            // HoraFin
            // 
            this.HoraFin.FillWeight = 104.7014F;
            this.HoraFin.HeaderText = "Hora Fin";
            this.HoraFin.MinimumWidth = 8;
            this.HoraFin.Name = "HoraFin";
            // 
            // Lugar
            // 
            this.Lugar.FillWeight = 110.5495F;
            this.Lugar.HeaderText = "Lugar";
            this.Lugar.MinimumWidth = 8;
            this.Lugar.Name = "Lugar";
            // 
            // Estado
            // 
            this.Estado.FillWeight = 115.6073F;
            this.Estado.HeaderText = "Estado";
            this.Estado.MinimumWidth = 8;
            this.Estado.Name = "Estado";
            // 
            // btnCerrarsesión
            // 
            this.btnCerrarsesión.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCerrarsesión.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCerrarsesión.Depth = 0;
            this.btnCerrarsesión.HighEmphasis = true;
            this.btnCerrarsesión.Icon = null;
            this.btnCerrarsesión.Location = new System.Drawing.Point(1219, 725);
            this.btnCerrarsesión.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCerrarsesión.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCerrarsesión.Name = "btnCerrarsesión";
            this.btnCerrarsesión.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCerrarsesión.Size = new System.Drawing.Size(131, 36);
            this.btnCerrarsesión.TabIndex = 5;
            this.btnCerrarsesión.Text = "Cerrar Sesión";
            this.btnCerrarsesión.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCerrarsesión.UseAccentColor = false;
            this.btnCerrarsesión.UseVisualStyleBackColor = true;
            this.btnCerrarsesión.Click += new System.EventHandler(this.btnCerrarsesión_Click);
            // 
            // btnfiltrar
            // 
            this.btnfiltrar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnfiltrar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnfiltrar.Depth = 0;
            this.btnfiltrar.HighEmphasis = true;
            this.btnfiltrar.Icon = null;
            this.btnfiltrar.Location = new System.Drawing.Point(984, 205);
            this.btnfiltrar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnfiltrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnfiltrar.Name = "btnfiltrar";
            this.btnfiltrar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnfiltrar.Size = new System.Drawing.Size(145, 36);
            this.btnfiltrar.TabIndex = 6;
            this.btnfiltrar.Text = "filtrar por mes";
            this.btnfiltrar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnfiltrar.UseAccentColor = false;
            this.btnfiltrar.UseVisualStyleBackColor = true;
            this.btnfiltrar.Click += new System.EventHandler(this.btnfiltrar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnConsultar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnConsultar.Depth = 0;
            this.btnConsultar.HighEmphasis = true;
            this.btnConsultar.Icon = null;
            this.btnConsultar.Location = new System.Drawing.Point(11, 205);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnConsultar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnConsultar.Size = new System.Drawing.Size(174, 36);
            this.btnConsultar.TabIndex = 7;
            this.btnConsultar.Text = "CONSULTAR EVENTOS";
            this.btnConsultar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnConsultar.UseAccentColor = false;
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnDetalles
            // 
            this.btnDetalles.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDetalles.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDetalles.Depth = 0;
            this.btnDetalles.HighEmphasis = true;
            this.btnDetalles.Icon = null;
            this.btnDetalles.Location = new System.Drawing.Point(626, 699);
            this.btnDetalles.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDetalles.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDetalles.Name = "btnDetalles";
            this.btnDetalles.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDetalles.Size = new System.Drawing.Size(212, 36);
            this.btnDetalles.TabIndex = 8;
            this.btnDetalles.Text = "VER DETALLES DEL EVENTO";
            this.btnDetalles.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDetalles.UseAccentColor = false;
            this.btnDetalles.UseVisualStyleBackColor = true;
            this.btnDetalles.Click += new System.EventHandler(this.btnDetalles_Click);
            // 
            // FormInvitado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 34F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.btnDetalles);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnfiltrar);
            this.Controls.Add(this.btnCerrarsesión);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmbMes);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Algerian", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.Name = "FormInvitado";
            this.Padding = new System.Windows.Forms.Padding(8, 128, 8, 6);
            this.Text = "                                                                                 " +
    "                                         Bienvenido Invitado";
            this.Load += new System.EventHandler(this.FormInvitado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialComboBox cmbMes;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialButton btnCerrarsesión;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lugar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private MaterialSkin.Controls.MaterialButton btnfiltrar;
        private MaterialSkin.Controls.MaterialButton btnConsultar;
        private MaterialSkin.Controls.MaterialButton btnDetalles;
    }
}