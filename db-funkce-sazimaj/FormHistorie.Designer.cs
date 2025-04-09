namespace db_funkce_sazimaj
{
    partial class FormHistorie
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
            this.dataGridViewHistorie = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistorie)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewHistorie
            // 
            this.dataGridViewHistorie.AllowUserToAddRows = false;
            this.dataGridViewHistorie.AllowUserToDeleteRows = false;
            this.dataGridViewHistorie.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewHistorie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHistorie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewHistorie.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewHistorie.Name = "dataGridViewHistorie";
            this.dataGridViewHistorie.ReadOnly = true;
            this.dataGridViewHistorie.Size = new System.Drawing.Size(800, 450);
            this.dataGridViewHistorie.TabIndex = 0;
            // 
            // FormHistorie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewHistorie);
            this.Name = "FormHistorie";
            this.Text = "FormHistorie";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistorie)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewHistorie;
    }
}