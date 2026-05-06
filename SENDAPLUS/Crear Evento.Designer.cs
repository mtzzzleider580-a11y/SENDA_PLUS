using MaterialSkin.Controls;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SENDAPLUS
{
    partial class Crear_Evento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private MaterialLabel lblNombredelevento;
        private MaterialLabel lblTipodeevento;
        private MaterialLabel lblFechayhoradeinicio;
        private MaterialLabel lblFechayhorafin;
        private MaterialTextBox materialTextBox1;
        private MaterialComboBox materialComboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private MaterialButton btnAgregarInvitados;
        private MaterialButton btnVolver;
        private MaterialLabel lblEstado;
        private MaterialComboBox materialComboBox2;
        private MaterialButton btnGuardarevento;
        private MaterialLabel materialLabel1;
        private MaterialTextBox txtconsultarevento;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreEvento;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoEvento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lugar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private MaterialButton btActualizarEvento;
        private MaterialLabel lblLugar;
        private MaterialTextBox txtLugar;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            this.lblNombredelevento = new MaterialSkin.Controls.MaterialLabel();
            this.lblTipodeevento = new MaterialSkin.Controls.MaterialLabel();
            this.lblFechayhoradeinicio = new MaterialSkin.Controls.MaterialLabel();
            this.lblFechayhorafin = new MaterialSkin.Controls.MaterialLabel();
            this.materialTextBox1 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialComboBox1 = new MaterialSkin.Controls.MaterialComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.btnAgregarInvitados = new MaterialSkin.Controls.MaterialButton();
            this.btnVolver = new MaterialSkin.Controls.MaterialButton();
            this.lblEstado = new MaterialSkin.Controls.MaterialLabel();
            this.materialComboBox2 = new MaterialSkin.Controls.MaterialComboBox();
            this.btnGuardarevento = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtconsultarevento = new MaterialSkin.Controls.MaterialTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreEvento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoEvento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lugar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btActualizarEvento = new MaterialSkin.Controls.MaterialButton();
            this.lblLugar = new MaterialSkin.Controls.MaterialLabel();
            this.txtLugar = new MaterialSkin.Controls.MaterialTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombredelevento
            // 
            this.lblNombredelevento.AutoSize = true;
            this.lblNombredelevento.Depth = 0;
            this.lblNombredelevento.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblNombredelevento.Location = new System.Drawing.Point(20, 109);
            this.lblNombredelevento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
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
            this.lblTipodeevento.Location = new System.Drawing.Point(20, 189);
            this.lblTipodeevento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
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
            this.lblFechayhoradeinicio.Location = new System.Drawing.Point(23, 250);
            this.lblFechayhoradeinicio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
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
            this.lblFechayhorafin.Location = new System.Drawing.Point(25, 308);
            this.lblFechayhorafin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
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
            this.materialTextBox1.Location = new System.Drawing.Point(174, 78);
            this.materialTextBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.materialTextBox1.MaxLength = 50;
            this.materialTextBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox1.Multiline = false;
            this.materialTextBox1.Name = "materialTextBox1";
            this.materialTextBox1.Size = new System.Drawing.Size(179, 50);
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
            this.materialComboBox1.Items.AddRange(new object[] {
            "Academico",
            "Cultural",
            "Deportivo"});
            this.materialComboBox1.Location = new System.Drawing.Point(174, 159);
            this.materialComboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.materialComboBox1.MaxDropDownItems = 4;
            this.materialComboBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBox1.Name = "materialComboBox1";
            this.materialComboBox1.Size = new System.Drawing.Size(179, 49);
            this.materialComboBox1.StartIndex = 0;
            this.materialComboBox1.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(192, 250);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(141, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(192, 307);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(141, 20);
            this.dateTimePicker2.TabIndex = 7;
            // 
            // btnAgregarInvitados
            // 
            this.btnAgregarInvitados.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAgregarInvitados.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAgregarInvitados.Depth = 0;
            this.btnAgregarInvitados.HighEmphasis = true;
            this.btnAgregarInvitados.Icon = null;
            this.btnAgregarInvitados.Location = new System.Drawing.Point(371, 463);
            this.btnAgregarInvitados.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAgregarInvitados.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgregarInvitados.Name = "btnAgregarInvitados";
            this.btnAgregarInvitados.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAgregarInvitados.Size = new System.Drawing.Size(171, 36);
            this.btnAgregarInvitados.TabIndex = 8;
            this.btnAgregarInvitados.Text = " Agregar Invitados";
            this.btnAgregarInvitados.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAgregarInvitados.UseAccentColor = false;
            this.btnAgregarInvitados.UseVisualStyleBackColor = true;
            this.btnAgregarInvitados.Click += new System.EventHandler(this.btnAgregarInvitados_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnVolver.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnVolver.Depth = 0;
            this.btnVolver.HighEmphasis = true;
            this.btnVolver.Icon = null;
            this.btnVolver.Location = new System.Drawing.Point(869, 469);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnVolver.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnVolver.Size = new System.Drawing.Size(76, 36);
            this.btnVolver.TabIndex = 15;
            this.btnVolver.Text = "Volver";
            this.btnVolver.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnVolver.UseAccentColor = false;
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Depth = 0;
            this.lblEstado.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblEstado.Location = new System.Drawing.Point(20, 421);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
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
            this.materialComboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBox2.FormattingEnabled = true;
            this.materialComboBox2.IntegralHeight = false;
            this.materialComboBox2.ItemHeight = 43;
            this.materialComboBox2.Items.AddRange(new object[] {
            "Activo",
            "Desactivado"});
            this.materialComboBox2.Location = new System.Drawing.Point(192, 401);
            this.materialComboBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.materialComboBox2.MaxDropDownItems = 4;
            this.materialComboBox2.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBox2.Name = "materialComboBox2";
            this.materialComboBox2.Size = new System.Drawing.Size(141, 49);
            this.materialComboBox2.StartIndex = 0;
            this.materialComboBox2.TabIndex = 19;
            // 
            // btnGuardarevento
            // 
            this.btnGuardarevento.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGuardarevento.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnGuardarevento.Depth = 0;
            this.btnGuardarevento.HighEmphasis = true;
            this.btnGuardarevento.Icon = null;
            this.btnGuardarevento.Location = new System.Drawing.Point(103, 463);
            this.btnGuardarevento.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGuardarevento.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGuardarevento.Name = "btnGuardarevento";
            this.btnGuardarevento.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnGuardarevento.Size = new System.Drawing.Size(148, 36);
            this.btnGuardarevento.TabIndex = 20;
            this.btnGuardarevento.Text = "Guardar evento";
            this.btnGuardarevento.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnGuardarevento.UseAccentColor = false;
            this.btnGuardarevento.UseVisualStyleBackColor = true;
            this.btnGuardarevento.Click += new System.EventHandler(this.btnGuardarevento_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(517, 95);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(207, 19);
            this.materialLabel1.TabIndex = 23;
            this.materialLabel1.Text = "Ingresa el nombre del evento:";
            // 
            // txtconsultarevento
            // 
            this.txtconsultarevento.AnimateReadOnly = false;
            this.txtconsultarevento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtconsultarevento.Depth = 0;
            this.txtconsultarevento.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtconsultarevento.LeadingIcon = null;
            this.txtconsultarevento.Location = new System.Drawing.Point(752, 70);
            this.txtconsultarevento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtconsultarevento.MaxLength = 50;
            this.txtconsultarevento.MouseState = MaterialSkin.MouseState.OUT;
            this.txtconsultarevento.Multiline = false;
            this.txtconsultarevento.Name = "txtconsultarevento";
            this.txtconsultarevento.Size = new System.Drawing.Size(157, 50);
            this.txtconsultarevento.TabIndex = 22;
            this.txtconsultarevento.Text = "";
            this.txtconsultarevento.TrailingIcon = null;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Snow;
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
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(385, 124);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(687, 286);
            this.dataGridView1.TabIndex = 21;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 8;
            this.ID.Name = "ID";
            // 
            // NombreEvento
            // 
            this.NombreEvento.HeaderText = "Nombre..Evento";
            this.NombreEvento.MinimumWidth = 8;
            this.NombreEvento.Name = "NombreEvento";
            // 
            // TipoEvento
            // 
            this.TipoEvento.HeaderText = "Tipo..Evento";
            this.TipoEvento.MinimumWidth = 8;
            this.TipoEvento.Name = "TipoEvento";
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.MinimumWidth = 8;
            this.Fecha.Name = "Fecha";
            // 
            // Hora
            // 
            this.Hora.HeaderText = "Hora";
            this.Hora.MinimumWidth = 8;
            this.Hora.Name = "Hora";
            // 
            // Lugar
            // 
            this.Lugar.HeaderText = "Lugar";
            this.Lugar.MinimumWidth = 8;
            this.Lugar.Name = "Lugar";
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.MinimumWidth = 8;
            this.Estado.Name = "Estado";
            // 
            // btActualizarEvento
            // 
            this.btActualizarEvento.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btActualizarEvento.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btActualizarEvento.Depth = 0;
            this.btActualizarEvento.HighEmphasis = true;
            this.btActualizarEvento.Icon = null;
            this.btActualizarEvento.Location = new System.Drawing.Point(630, 463);
            this.btActualizarEvento.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btActualizarEvento.MouseState = MaterialSkin.MouseState.HOVER;
            this.btActualizarEvento.Name = "btActualizarEvento";
            this.btActualizarEvento.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btActualizarEvento.Size = new System.Drawing.Size(168, 36);
            this.btActualizarEvento.TabIndex = 24;
            this.btActualizarEvento.Text = "Actualizar Evento";
            this.btActualizarEvento.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btActualizarEvento.UseAccentColor = false;
            this.btActualizarEvento.UseVisualStyleBackColor = true;
            this.btActualizarEvento.Click += new System.EventHandler(this.btActualizarEvento_Click);
            // 
            // lblLugar
            // 
            this.lblLugar.AutoSize = true;
            this.lblLugar.Depth = 0;
            this.lblLugar.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblLugar.Location = new System.Drawing.Point(25, 371);
            this.lblLugar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLugar.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblLugar.Name = "lblLugar";
            this.lblLugar.Size = new System.Drawing.Size(42, 19);
            this.lblLugar.TabIndex = 25;
            this.lblLugar.Text = "Lugar";
            // 
            // txtLugar
            // 
            this.txtLugar.AnimateReadOnly = false;
            this.txtLugar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLugar.Depth = 0;
            this.txtLugar.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtLugar.LeadingIcon = null;
            this.txtLugar.Location = new System.Drawing.Point(192, 350);
            this.txtLugar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLugar.MaxLength = 50;
            this.txtLugar.MouseState = MaterialSkin.MouseState.OUT;
            this.txtLugar.Multiline = false;
            this.txtLugar.Name = "txtLugar";
            this.txtLugar.Size = new System.Drawing.Size(140, 50);
            this.txtLugar.TabIndex = 26;
            this.txtLugar.Text = "";
            this.txtLugar.TrailingIcon = null;
            // 
            // Crear_Evento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1094, 530);
            this.Controls.Add(this.txtLugar);
            this.Controls.Add(this.lblLugar);
            this.Controls.Add(this.btActualizarEvento);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.txtconsultarevento);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnGuardarevento);
            this.Controls.Add(this.materialComboBox2);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnAgregarInvitados);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.materialComboBox1);
            this.Controls.Add(this.materialTextBox1);
            this.Controls.Add(this.lblFechayhorafin);
            this.Controls.Add(this.lblFechayhoradeinicio);
            this.Controls.Add(this.lblTipodeevento);
            this.Controls.Add(this.lblNombredelevento);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Crear_Evento";
            this.Padding = new System.Windows.Forms.Padding(2, 42, 2, 2);
            this.Text = "CREAR EVENTO";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}