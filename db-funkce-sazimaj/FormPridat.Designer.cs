﻿namespace db_funkce_sazimaj
{
    partial class FormPridat
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
            this.textBoxJmeno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPredmet = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerZapujcka = new System.Windows.Forms.DateTimePicker();
            this.buttonUlozit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Jméno:";
            // 
            // textBoxJmeno
            // 
            this.textBoxJmeno.Location = new System.Drawing.Point(120, 20);
            this.textBoxJmeno.Name = "textBoxJmeno";
            this.textBoxJmeno.Size = new System.Drawing.Size(200, 20);
            this.textBoxJmeno.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Předmět: ";
            // 
            // textBoxPredmet
            // 
            this.textBoxPredmet.Location = new System.Drawing.Point(120, 60);
            this.textBoxPredmet.Name = "textBoxPredmet";
            this.textBoxPredmet.Size = new System.Drawing.Size(200, 20);
            this.textBoxPredmet.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Datum zápujčky:";
            // 
            // dateTimePickerZapujcka
            // 
            this.dateTimePickerZapujcka.Location = new System.Drawing.Point(120, 100);
            this.dateTimePickerZapujcka.Name = "dateTimePickerZapujcka";
            this.dateTimePickerZapujcka.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerZapujcka.TabIndex = 5;
            // 
            // buttonUlozit
            // 
            this.buttonUlozit.Location = new System.Drawing.Point(120, 150);
            this.buttonUlozit.Name = "buttonUlozit";
            this.buttonUlozit.Size = new System.Drawing.Size(150, 30);
            this.buttonUlozit.TabIndex = 6;
            this.buttonUlozit.Text = "Uložit";
            this.buttonUlozit.UseVisualStyleBackColor = true;
            this.buttonUlozit.Click += new System.EventHandler(this.buttonUlozit_Click);
            // 
            // FormPridat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 211);
            this.Controls.Add(this.buttonUlozit);
            this.Controls.Add(this.dateTimePickerZapujcka);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxPredmet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxJmeno);
            this.Controls.Add(this.label1);
            this.Name = "FormPridat";
            this.Text = "FormPridat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxJmeno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPredmet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePickerZapujcka;
        private System.Windows.Forms.Button buttonUlozit;
    }
}