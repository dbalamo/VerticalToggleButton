
namespace CustomUiControls
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.verticalToggleButton3 = new CustomUiControls.VerticalToggleButton();
            this.verticalToggleButton2 = new CustomUiControls.VerticalToggleButton();
            this.verticalToggleButton1 = new CustomUiControls.VerticalToggleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // verticalToggleButton3
            // 
            this.verticalToggleButton3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.verticalToggleButton3.Location = new System.Drawing.Point(312, 270);
            this.verticalToggleButton3.MinimumSize = new System.Drawing.Size(22, 50);
            this.verticalToggleButton3.Name = "verticalToggleButton3";
            this.verticalToggleButton3.OffBackColor = System.Drawing.Color.Gray;
            this.verticalToggleButton3.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.verticalToggleButton3.OnBackColor = System.Drawing.Color.Green;
            this.verticalToggleButton3.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.verticalToggleButton3.Size = new System.Drawing.Size(56, 110);
            this.verticalToggleButton3.TabIndex = 2;
            this.verticalToggleButton3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.verticalToggleButton3.ToggleOnPosition = CustomUiControls.VerticalToggleButton.ToggleOnPositionEnum.TOP;
            this.verticalToggleButton3.UseVisualStyleBackColor = true;
            // 
            // verticalToggleButton2
            // 
            this.verticalToggleButton2.Location = new System.Drawing.Point(312, 110);
            this.verticalToggleButton2.MinimumSize = new System.Drawing.Size(22, 50);
            this.verticalToggleButton2.Name = "verticalToggleButton2";
            this.verticalToggleButton2.OffBackColor = System.Drawing.Color.Gray;
            this.verticalToggleButton2.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.verticalToggleButton2.OnBackColor = System.Drawing.Color.Green;
            this.verticalToggleButton2.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.verticalToggleButton2.Size = new System.Drawing.Size(56, 110);
            this.verticalToggleButton2.TabIndex = 1;
            this.verticalToggleButton2.ToggleOnPosition = CustomUiControls.VerticalToggleButton.ToggleOnPositionEnum.BOTTOM;
            this.verticalToggleButton2.UseVisualStyleBackColor = true;
            // 
            // verticalToggleButton1
            // 
            this.verticalToggleButton1.AutoSize = true;
            this.verticalToggleButton1.Location = new System.Drawing.Point(329, 31);
            this.verticalToggleButton1.MinimumSize = new System.Drawing.Size(22, 50);
            this.verticalToggleButton1.Name = "verticalToggleButton1";
            this.verticalToggleButton1.OffBackColor = System.Drawing.Color.Gray;
            this.verticalToggleButton1.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.verticalToggleButton1.OnBackColor = System.Drawing.Color.Green;
            this.verticalToggleButton1.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.verticalToggleButton1.Size = new System.Drawing.Size(22, 50);
            this.verticalToggleButton1.TabIndex = 0;
            this.verticalToggleButton1.ToggleOnPosition = CustomUiControls.VerticalToggleButton.ToggleOnPositionEnum.BOTTOM;
            this.verticalToggleButton1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "default size toggle :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "custom (BIG) sized toggle :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 322);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(234, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "toggle with OFF position on bottom :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 413);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.verticalToggleButton3);
            this.Controls.Add(this.verticalToggleButton2);
            this.Controls.Add(this.verticalToggleButton1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private VerticalToggleButton verticalToggleButton1;
        private VerticalToggleButton verticalToggleButton2;
        private VerticalToggleButton verticalToggleButton3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

