
namespace WindowsFormsApp17._1
{
    partial class Form1
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
            this.lbCursisten = new System.Windows.Forms.ListBox();
            this.txtVoorNaam = new System.Windows.Forms.TextBox();
            this.txtFamilieNaam = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnToevoegen = new System.Windows.Forms.Button();
            this.btnSluiten = new System.Windows.Forms.Button();
            this.btnVerwijderen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbCursisten
            // 
            this.lbCursisten.FormattingEnabled = true;
            this.lbCursisten.ItemHeight = 16;
            this.lbCursisten.Location = new System.Drawing.Point(44, 22);
            this.lbCursisten.Name = "lbCursisten";
            this.lbCursisten.Size = new System.Drawing.Size(706, 228);
            this.lbCursisten.TabIndex = 0;
            // 
            // txtVoorNaam
            // 
            this.txtVoorNaam.Location = new System.Drawing.Point(304, 269);
            this.txtVoorNaam.Name = "txtVoorNaam";
            this.txtVoorNaam.Size = new System.Drawing.Size(230, 22);
            this.txtVoorNaam.TabIndex = 1;
            // 
            // txtFamilieNaam
            // 
            this.txtFamilieNaam.Location = new System.Drawing.Point(304, 297);
            this.txtFamilieNaam.Name = "txtFamilieNaam";
            this.txtFamilieNaam.Size = new System.Drawing.Size(230, 22);
            this.txtFamilieNaam.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(183, 269);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Voornaam:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 302);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Familienaam:";
            // 
            // btnToevoegen
            // 
            this.btnToevoegen.Location = new System.Drawing.Point(44, 439);
            this.btnToevoegen.Name = "btnToevoegen";
            this.btnToevoegen.Size = new System.Drawing.Size(216, 81);
            this.btnToevoegen.TabIndex = 5;
            this.btnToevoegen.Text = "Toevoegen";
            this.btnToevoegen.UseVisualStyleBackColor = true;
            this.btnToevoegen.Click += new System.EventHandler(this.btnToevoegen_Click);
            // 
            // btnSluiten
            // 
            this.btnSluiten.Location = new System.Drawing.Point(282, 439);
            this.btnSluiten.Name = "btnSluiten";
            this.btnSluiten.Size = new System.Drawing.Size(216, 81);
            this.btnSluiten.TabIndex = 6;
            this.btnSluiten.Text = "Sluiten";
            this.btnSluiten.UseVisualStyleBackColor = true;
            this.btnSluiten.Click += new System.EventHandler(this.btnSluiten_Click);
            // 
            // btnVerwijderen
            // 
            this.btnVerwijderen.Location = new System.Drawing.Point(520, 439);
            this.btnVerwijderen.Name = "btnVerwijderen";
            this.btnVerwijderen.Size = new System.Drawing.Size(216, 81);
            this.btnVerwijderen.TabIndex = 7;
            this.btnVerwijderen.Text = "Verwijderen";
            this.btnVerwijderen.UseVisualStyleBackColor = true;
            this.btnVerwijderen.Click += new System.EventHandler(this.btnVerwijderen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 558);
            this.Controls.Add(this.btnVerwijderen);
            this.Controls.Add(this.btnSluiten);
            this.Controls.Add(this.btnToevoegen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFamilieNaam);
            this.Controls.Add(this.txtVoorNaam);
            this.Controls.Add(this.lbCursisten);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbCursisten;
        private System.Windows.Forms.TextBox txtVoorNaam;
        private System.Windows.Forms.TextBox txtFamilieNaam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnToevoegen;
        private System.Windows.Forms.Button btnSluiten;
        private System.Windows.Forms.Button btnVerwijderen;
    }
}

