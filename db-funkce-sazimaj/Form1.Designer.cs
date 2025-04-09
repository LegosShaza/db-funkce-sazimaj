namespace db_funkce_sazimaj
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewZapujcky = new System.Windows.Forms.DataGridView();
            this.buttonPridat = new System.Windows.Forms.Button();
            this.buttonVratit = new System.Windows.Forms.Button();
            this.buttonObnovit = new System.Windows.Forms.Button();
            this.buttonHistorie = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewZapujcky)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewZapujcky
            // 
            this.dataGridViewZapujcky.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewZapujcky.Location = new System.Drawing.Point(21, 20);
            this.dataGridViewZapujcky.Name = "dataGridViewZapujcky";
            this.dataGridViewZapujcky.ReadOnly = true;
            this.dataGridViewZapujcky.Size = new System.Drawing.Size(659, 300);
            this.dataGridViewZapujcky.TabIndex = 0;
            // 
            // buttonPridat
            // 
            this.buttonPridat.Location = new System.Drawing.Point(20, 340);
            this.buttonPridat.Name = "buttonPridat";
            this.buttonPridat.Size = new System.Drawing.Size(150, 30);
            this.buttonPridat.TabIndex = 1;
            this.buttonPridat.Text = "Přidat zápůjčku";
            this.buttonPridat.UseVisualStyleBackColor = true;
            this.buttonPridat.Click += new System.EventHandler(this.buttonPridat_Click);
            // 
            // buttonVratit
            // 
            this.buttonVratit.Location = new System.Drawing.Point(190, 340);
            this.buttonVratit.Name = "buttonVratit";
            this.buttonVratit.Size = new System.Drawing.Size(150, 30);
            this.buttonVratit.TabIndex = 2;
            this.buttonVratit.Text = "Označit jako vrácené";
            this.buttonVratit.UseVisualStyleBackColor = true;
            this.buttonVratit.Click += new System.EventHandler(this.buttonVratit_Click);
            // 
            // buttonObnovit
            // 
            this.buttonObnovit.Location = new System.Drawing.Point(360, 340);
            this.buttonObnovit.Name = "buttonObnovit";
            this.buttonObnovit.Size = new System.Drawing.Size(150, 30);
            this.buttonObnovit.TabIndex = 3;
            this.buttonObnovit.Text = "Načíst znovu";
            this.buttonObnovit.UseVisualStyleBackColor = true;
            this.buttonObnovit.Click += new System.EventHandler(this.buttonObnovit_Click);
            // 
            // buttonHistorie
            // 
            this.buttonHistorie.Location = new System.Drawing.Point(530, 340);
            this.buttonHistorie.Name = "buttonHistorie";
            this.buttonHistorie.Size = new System.Drawing.Size(150, 30);
            this.buttonHistorie.TabIndex = 4;
            this.buttonHistorie.Text = "Historie vrácených";
            this.buttonHistorie.UseVisualStyleBackColor = true;
            this.buttonHistorie.Click += new System.EventHandler(this.buttonHistorie_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 391);
            this.Controls.Add(this.buttonHistorie);
            this.Controls.Add(this.buttonObnovit);
            this.Controls.Add(this.buttonVratit);
            this.Controls.Add(this.buttonPridat);
            this.Controls.Add(this.dataGridViewZapujcky);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewZapujcky)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewZapujcky;
        private System.Windows.Forms.Button buttonPridat;
        private System.Windows.Forms.Button buttonVratit;
        private System.Windows.Forms.Button buttonObnovit;
        private System.Windows.Forms.Button buttonHistorie;
    }
}

