namespace SENDAPLUS
{
    partial class Lider
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnCrearEvento = new MaterialSkin.Controls.MaterialButton();
            this.btnConsultarEvento = new MaterialSkin.Controls.MaterialButton();
            this.btnActualizarEventos = new MaterialSkin.Controls.MaterialButton();
            this.btnCerrarSesión = new MaterialSkin.Controls.MaterialButton();
            this.materialTextBox1 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreEvento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoEvento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lugar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(506, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NombreEvento,
            this.TipoEvento,
            this.Fecha,
            this.Hora,
            this.Lugar,
            this.Estado});
            this.dataGridView1.Location = new System.Drawing.Point(45, 197);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1109, 395);
            this.dataGridView1.TabIndex = 1;
            // 
            // btnCrearEvento
            // 
            this.btnCrearEvento.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCrearEvento.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCrearEvento.Depth = 0;
            this.btnCrearEvento.HighEmphasis = true;
            this.btnCrearEvento.Icon = null;
            this.btnCrearEvento.Location = new System.Drawing.Point(196, 617);
            this.btnCrearEvento.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCrearEvento.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCrearEvento.Name = "btnCrearEvento";
            this.btnCrearEvento.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCrearEvento.Size = new System.Drawing.Size(127, 36);
            this.btnCrearEvento.TabIndex = 2;
            this.btnCrearEvento.Text = "Crear Evento";
            this.btnCrearEvento.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCrearEvento.UseAccentColor = false;
            this.btnCrearEvento.UseVisualStyleBackColor = true;
            // 
            // btnConsultarEvento
            // 
            this.btnConsultarEvento.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnConsultarEvento.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnConsultarEvento.Depth = 0;
            this.btnConsultarEvento.HighEmphasis = true;
            this.btnConsultarEvento.Icon = null;
            this.btnConsultarEvento.Location = new System.Drawing.Point(378, 617);
            this.btnConsultarEvento.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnConsultarEvento.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnConsultarEvento.Name = "btnConsultarEvento";
            this.btnConsultarEvento.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnConsultarEvento.Size = new System.Drawing.Size(166, 36);
            this.btnConsultarEvento.TabIndex = 3;
            this.btnConsultarEvento.Text = "Consultar Evento";
            this.btnConsultarEvento.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnConsultarEvento.UseAccentColor = false;
            this.btnConsultarEvento.UseVisualStyleBackColor = true;
            // 
            // btnActualizarEventos
            // 
            this.btnActualizarEventos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnActualizarEventos.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnActualizarEventos.Depth = 0;
            this.btnActualizarEventos.HighEmphasis = true;
            this.btnActualizarEventos.Icon = null;
            this.btnActualizarEventos.Location = new System.Drawing.Point(599, 617);
            this.btnActualizarEventos.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnActualizarEventos.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnActualizarEventos.Name = "btnActualizarEventos";
            this.btnActualizarEventos.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnActualizarEventos.Size = new System.Drawing.Size(177, 36);
            this.btnActualizarEventos.TabIndex = 4;
            this.btnActualizarEventos.Text = "Actualizar Eventos";
            this.btnActualizarEventos.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnActualizarEventos.UseAccentColor = false;
            this.btnActualizarEventos.UseVisualStyleBackColor = true;
            // 
            // btnCerrarSesión
            // 
            this.btnCerrarSesión.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCerrarSesión.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCerrarSesión.Depth = 0;
            this.btnCerrarSesión.HighEmphasis = true;
            this.btnCerrarSesión.Icon = null;
            this.btnCerrarSesión.Location = new System.Drawing.Point(813, 617);
            this.btnCerrarSesión.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCerrarSesión.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCerrarSesión.Name = "btnCerrarSesión";
            this.btnCerrarSesión.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCerrarSesión.Size = new System.Drawing.Size(131, 36);
            this.btnCerrarSesión.TabIndex = 5;
            this.btnCerrarSesión.Text = "Cerrar Sesión";
            this.btnCerrarSesión.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCerrarSesión.UseAccentColor = false;
            this.btnCerrarSesión.UseVisualStyleBackColor = true;
            // 
            // materialTextBox1
            // 
            this.materialTextBox1.AnimateReadOnly = false;
            this.materialTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox1.Depth = 0;
            this.materialTextBox1.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox1.LeadingIcon = null;
            this.materialTextBox1.Location = new System.Drawing.Point(972, 141);
            this.materialTextBox1.MaxLength = 50;
            this.materialTextBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox1.Multiline = false;
            this.materialTextBox1.Name = "materialTextBox1";
            this.materialTextBox1.Size = new System.Drawing.Size(182, 50);
            this.materialTextBox1.TabIndex = 6;
            this.materialTextBox1.Text = "";
            this.materialTextBox1.TrailingIcon = null;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(809, 152);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(131, 19);
            this.materialLabel1.TabIndex = 7;
            this.materialLabel1.Text = "Ingresa el nombre:";
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 8;
            this.ID.Name = "ID";
            this.ID.Width = 150;
            // 
            // NombreEvento
            // 
            this.NombreEvento.HeaderText = "Nombre..Evento";
            this.NombreEvento.MinimumWidth = 8;
            this.NombreEvento.Name = "NombreEvento";
            this.NombreEvento.Width = 150;
            // 
            // TipoEvento
            // 
            this.TipoEvento.HeaderText = "Tipo..Evento";
            this.TipoEvento.MinimumWidth = 8;
            this.TipoEvento.Name = "TipoEvento";
            this.TipoEvento.Width = 150;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.MinimumWidth = 8;
            this.Fecha.Name = "Fecha";
            this.Fecha.Width = 150;
            // 
            // Hora
            // 
            this.Hora.HeaderText = "Hora";
            this.Hora.MinimumWidth = 8;
            this.Hora.Name = "Hora";
            this.Hora.Width = 150;
            // 
            // Lugar
            // 
            this.Lugar.HeaderText = "Lugar";
            this.Lugar.MinimumWidth = 8;
            this.Lugar.Name = "Lugar";
            this.Lugar.Width = 150;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.MinimumWidth = 8;
            this.Estado.Name = "Estado";
            this.Estado.Width = 150;
            // 
            // Lider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.materialTextBox1);
            this.Controls.Add(this.btnCerrarSesión);
            this.Controls.Add(this.btnActualizarEventos);
            this.Controls.Add(this.btnConsultarEvento);
            this.Controls.Add(this.btnCrearEvento);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Lider";
            this.Padding = new System.Windows.Forms.Padding(4, 98, 4, 5);
            this.Text = "                                                                                 " +
    "             Bienvenido Lider";
            this.Load += new System.EventHandler(this.Lider_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialButton btnCrearEvento;
        private MaterialSkin.Controls.MaterialButton btnConsultarEvento;
        private MaterialSkin.Controls.MaterialButton btnActualizarEventos;
        private MaterialSkin.Controls.MaterialButton btnCerrarSesión;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreEvento;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoEvento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lugar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}