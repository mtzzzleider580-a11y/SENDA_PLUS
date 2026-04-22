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
            this.label1 = new System.Windows.Forms.Label();
            this.btnCrearEvento = new MaterialSkin.Controls.MaterialButton();
            this.btnCerrarSesión = new MaterialSkin.Controls.MaterialButton();
            this.agregarbtn = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(315, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // btnCrearEvento
            // 
            this.btnCrearEvento.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCrearEvento.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCrearEvento.Depth = 0;
            this.btnCrearEvento.HighEmphasis = true;
            this.btnCrearEvento.Icon = null;
            this.btnCrearEvento.Location = new System.Drawing.Point(307, 122);
            this.btnCrearEvento.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCrearEvento.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCrearEvento.Name = "btnCrearEvento";
            this.btnCrearEvento.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCrearEvento.Size = new System.Drawing.Size(127, 36);
            this.btnCrearEvento.TabIndex = 2;
            this.btnCrearEvento.Text = "Crear Evento";
            this.btnCrearEvento.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCrearEvento.UseAccentColor = false;
            this.btnCrearEvento.UseVisualStyleBackColor = true;
            this.btnCrearEvento.Click += new System.EventHandler(this.btnCrearEvento_Click);
            // 
            // btnCerrarSesión
            // 
            this.btnCerrarSesión.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCerrarSesión.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCerrarSesión.Depth = 0;
            this.btnCerrarSesión.HighEmphasis = true;
            this.btnCerrarSesión.Icon = null;
            this.btnCerrarSesión.Location = new System.Drawing.Point(307, 277);
            this.btnCerrarSesión.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCerrarSesión.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCerrarSesión.Name = "btnCerrarSesión";
            this.btnCerrarSesión.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCerrarSesión.Size = new System.Drawing.Size(131, 36);
            this.btnCerrarSesión.TabIndex = 5;
            this.btnCerrarSesión.Text = "Cerrar Sesión";
            this.btnCerrarSesión.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCerrarSesión.UseAccentColor = false;
            this.btnCerrarSesión.UseVisualStyleBackColor = true;
            this.btnCerrarSesión.Click += new System.EventHandler(this.btnCerrarSesión_Click);
            // 
            // agregarbtn
            // 
            this.agregarbtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.agregarbtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.agregarbtn.Depth = 0;
            this.agregarbtn.HighEmphasis = true;
            this.agregarbtn.Icon = null;
            this.agregarbtn.Location = new System.Drawing.Point(294, 168);
            this.agregarbtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.agregarbtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.agregarbtn.Name = "agregarbtn";
            this.agregarbtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.agregarbtn.Size = new System.Drawing.Size(158, 36);
            this.agregarbtn.TabIndex = 6;
            this.agregarbtn.Text = "Agregar Invitado";
            this.agregarbtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.agregarbtn.UseAccentColor = false;
            this.agregarbtn.UseVisualStyleBackColor = true;
            this.agregarbtn.Click += new System.EventHandler(this.agregarbtn_Click);
            // 
            // Lider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.agregarbtn);
            this.Controls.Add(this.btnCerrarSesión);
            this.Controls.Add(this.btnCrearEvento);
            this.Controls.Add(this.label1);
            this.Name = "Lider";
            this.Text = "Lider";
            this.Load += new System.EventHandler(this.Lider_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialButton btnCrearEvento;
        private MaterialSkin.Controls.MaterialButton btnCerrarSesión;
        private MaterialSkin.Controls.MaterialButton agregarbtn;
    }
}