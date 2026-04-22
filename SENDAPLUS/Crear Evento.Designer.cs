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
        private MaterialTextBox txtnombrevento;
        private MaterialComboBox combotipoe;
        private System.Windows.Forms.DateTimePicker datefechaini;
        private System.Windows.Forms.DateTimePicker datefechafin;
        private MaterialButton btnVolver;
        private MaterialLabel lblEstado;
        private MaterialComboBox comboestado;
        private MaterialButton btnGuardarevento;
        private MaterialLabel materialLabel1;
        private MaterialTextBox txtconsultarevento;
        private System.Windows.Forms.DataGridView dataEVENTOSv;
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
            this.txtnombrevento = new MaterialSkin.Controls.MaterialTextBox();
            this.combotipoe = new MaterialSkin.Controls.MaterialComboBox();
            this.datefechaini = new System.Windows.Forms.DateTimePicker();
            this.datefechafin = new System.Windows.Forms.DateTimePicker();
            this.btnVolver = new MaterialSkin.Controls.MaterialButton();
            this.lblEstado = new MaterialSkin.Controls.MaterialLabel();
            this.comboestado = new MaterialSkin.Controls.MaterialComboBox();
            this.btnGuardarevento = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtconsultarevento = new MaterialSkin.Controls.MaterialTextBox();
            this.dataEVENTOSv = new System.Windows.Forms.DataGridView();
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
            this.txtcargarevento = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataEVENTOSv)).BeginInit();
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
            this.lblFechayhorafin.Location = new System.Drawing.Point(25, 283);
            this.lblFechayhorafin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFechayhorafin.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFechayhorafin.Name = "lblFechayhorafin";
            this.lblFechayhorafin.Size = new System.Drawing.Size(115, 19);
            this.lblFechayhorafin.TabIndex = 3;
            this.lblFechayhorafin.Text = "Fecha y hora fin";
            // 
            // txtnombrevento
            // 
            this.txtnombrevento.AnimateReadOnly = false;
            this.txtnombrevento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtnombrevento.Depth = 0;
            this.txtnombrevento.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtnombrevento.LeadingIcon = null;
            this.txtnombrevento.Location = new System.Drawing.Point(174, 78);
            this.txtnombrevento.Margin = new System.Windows.Forms.Padding(2);
            this.txtnombrevento.MaxLength = 50;
            this.txtnombrevento.MouseState = MaterialSkin.MouseState.OUT;
            this.txtnombrevento.Multiline = false;
            this.txtnombrevento.Name = "txtnombrevento";
            this.txtnombrevento.Size = new System.Drawing.Size(179, 50);
            this.txtnombrevento.TabIndex = 4;
            this.txtnombrevento.Text = "";
            this.txtnombrevento.TrailingIcon = null;
            this.txtnombrevento.TextChanged += new System.EventHandler(this.txtnombrevento_TextChanged);
            // 
            // combotipoe
            // 
            this.combotipoe.AutoResize = false;
            this.combotipoe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.combotipoe.Depth = 0;
            this.combotipoe.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.combotipoe.DropDownHeight = 174;
            this.combotipoe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combotipoe.DropDownWidth = 121;
            this.combotipoe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.combotipoe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.combotipoe.FormattingEnabled = true;
            this.combotipoe.IntegralHeight = false;
            this.combotipoe.ItemHeight = 43;
            this.combotipoe.Items.AddRange(new object[] {
            "Academico",
            "Cultural",
            "Deportivo"});
            this.combotipoe.Location = new System.Drawing.Point(174, 159);
            this.combotipoe.Margin = new System.Windows.Forms.Padding(2);
            this.combotipoe.MaxDropDownItems = 4;
            this.combotipoe.MouseState = MaterialSkin.MouseState.OUT;
            this.combotipoe.Name = "combotipoe";
            this.combotipoe.Size = new System.Drawing.Size(179, 49);
            this.combotipoe.StartIndex = 0;
            this.combotipoe.TabIndex = 5;
            this.combotipoe.SelectedIndexChanged += new System.EventHandler(this.materialComboBox1_SelectedIndexChanged_1);
            // 
            // datefechaini
            // 
            this.datefechaini.CustomFormat = "dd/MM/yyyy HH:mm";
            this.datefechaini.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datefechaini.Location = new System.Drawing.Point(192, 250);
            this.datefechaini.Margin = new System.Windows.Forms.Padding(2);
            this.datefechaini.Name = "datefechaini";
            this.datefechaini.Size = new System.Drawing.Size(141, 20);
            this.datefechaini.TabIndex = 6;
            // 
            // datefechafin
            // 
            this.datefechafin.CustomFormat = "dd/MM/yyyy HH:mm";
            this.datefechafin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datefechafin.Location = new System.Drawing.Point(192, 283);
            this.datefechafin.Margin = new System.Windows.Forms.Padding(2);
            this.datefechafin.Name = "datefechafin";
            this.datefechafin.Size = new System.Drawing.Size(141, 20);
            this.datefechafin.TabIndex = 7;
            // 
            // btnVolver
            // 
            this.btnVolver.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnVolver.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnVolver.Depth = 0;
            this.btnVolver.HighEmphasis = true;
            this.btnVolver.Icon = null;
            this.btnVolver.Location = new System.Drawing.Point(929, 463);
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
            this.lblEstado.Location = new System.Drawing.Point(20, 410);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEstado.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(50, 19);
            this.lblEstado.TabIndex = 18;
            this.lblEstado.Text = "Estado";
            // 
            // comboestado
            // 
            this.comboestado.AutoResize = false;
            this.comboestado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboestado.Depth = 0;
            this.comboestado.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboestado.DropDownHeight = 174;
            this.comboestado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboestado.DropDownWidth = 121;
            this.comboestado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.comboestado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.comboestado.FormattingEnabled = true;
            this.comboestado.IntegralHeight = false;
            this.comboestado.ItemHeight = 43;
            this.comboestado.Items.AddRange(new object[] {
            "Activo",
            "Desactivado"});
            this.comboestado.Location = new System.Drawing.Point(192, 391);
            this.comboestado.Margin = new System.Windows.Forms.Padding(2);
            this.comboestado.MaxDropDownItems = 4;
            this.comboestado.MouseState = MaterialSkin.MouseState.OUT;
            this.comboestado.Name = "comboestado";
            this.comboestado.Size = new System.Drawing.Size(141, 49);
            this.comboestado.StartIndex = 0;
            this.comboestado.TabIndex = 19;
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
            this.txtconsultarevento.Margin = new System.Windows.Forms.Padding(2);
            this.txtconsultarevento.MaxLength = 50;
            this.txtconsultarevento.MouseState = MaterialSkin.MouseState.OUT;
            this.txtconsultarevento.Multiline = false;
            this.txtconsultarevento.Name = "txtconsultarevento";
            this.txtconsultarevento.Size = new System.Drawing.Size(157, 50);
            this.txtconsultarevento.TabIndex = 22;
            this.txtconsultarevento.Text = "";
            this.txtconsultarevento.TrailingIcon = null;
            this.txtconsultarevento.TextChanged += new System.EventHandler(this.txtconsultarevento_TextChanged);
            // 
            // dataEVENTOSv
            // 
            this.dataEVENTOSv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataEVENTOSv.BackgroundColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataEVENTOSv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataEVENTOSv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataEVENTOSv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NombreEvento,
            this.TipoEvento,
            this.Fecha,
            this.Hora,
            this.Lugar,
            this.Estado});
            this.dataEVENTOSv.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataEVENTOSv.Location = new System.Drawing.Point(385, 124);
            this.dataEVENTOSv.Margin = new System.Windows.Forms.Padding(2);
            this.dataEVENTOSv.Name = "dataEVENTOSv";
            this.dataEVENTOSv.RowHeadersWidth = 62;
            this.dataEVENTOSv.RowTemplate.Height = 28;
            this.dataEVENTOSv.Size = new System.Drawing.Size(687, 286);
            this.dataEVENTOSv.TabIndex = 21;
            this.dataEVENTOSv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataEVENTOSv_CellClick);
            this.dataEVENTOSv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            this.btActualizarEvento.Location = new System.Drawing.Point(385, 469);
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
            this.lblLugar.Location = new System.Drawing.Point(20, 335);
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
            this.txtLugar.Location = new System.Drawing.Point(192, 318);
            this.txtLugar.Margin = new System.Windows.Forms.Padding(2);
            this.txtLugar.MaxLength = 50;
            this.txtLugar.MouseState = MaterialSkin.MouseState.OUT;
            this.txtLugar.Multiline = false;
            this.txtLugar.Name = "txtLugar";
            this.txtLugar.Size = new System.Drawing.Size(140, 50);
            this.txtLugar.TabIndex = 26;
            this.txtLugar.Text = "";
            this.txtLugar.TrailingIcon = null;
            this.txtLugar.TextChanged += new System.EventHandler(this.txtLugar_TextChanged);
            // 
            // txtcargarevento
            // 
            this.txtcargarevento.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.txtcargarevento.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.txtcargarevento.Depth = 0;
            this.txtcargarevento.HighEmphasis = true;
            this.txtcargarevento.Icon = null;
            this.txtcargarevento.Location = new System.Drawing.Point(582, 469);
            this.txtcargarevento.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtcargarevento.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtcargarevento.Name = "txtcargarevento";
            this.txtcargarevento.NoAccentTextColor = System.Drawing.Color.Empty;
            this.txtcargarevento.Size = new System.Drawing.Size(138, 36);
            this.txtcargarevento.TabIndex = 27;
            this.txtcargarevento.Text = "Cargar Evento";
            this.txtcargarevento.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.txtcargarevento.UseAccentColor = false;
            this.txtcargarevento.UseVisualStyleBackColor = true;
            this.txtcargarevento.Click += new System.EventHandler(this.txtcargarevento_Click);
            // 
            // Crear_Evento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1010, 512);
            this.Controls.Add(this.txtcargarevento);
            this.Controls.Add(this.txtLugar);
            this.Controls.Add(this.lblLugar);
            this.Controls.Add(this.btActualizarEvento);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.txtconsultarevento);
            this.Controls.Add(this.dataEVENTOSv);
            this.Controls.Add(this.btnGuardarevento);
            this.Controls.Add(this.comboestado);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.datefechafin);
            this.Controls.Add(this.datefechaini);
            this.Controls.Add(this.combotipoe);
            this.Controls.Add(this.txtnombrevento);
            this.Controls.Add(this.lblFechayhorafin);
            this.Controls.Add(this.lblFechayhoradeinicio);
            this.Controls.Add(this.lblTipodeevento);
            this.Controls.Add(this.lblNombredelevento);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Crear_Evento";
            this.Padding = new System.Windows.Forms.Padding(2, 42, 2, 2);
            this.Text = "CREAR EVENTO";
            this.Load += new System.EventHandler(this.Crear_Evento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataEVENTOSv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialButton txtcargarevento;
    }
}