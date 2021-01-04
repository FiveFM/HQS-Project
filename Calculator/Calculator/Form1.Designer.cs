
namespace Calculator
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
            this.lbGetal1 = new System.Windows.Forms.Label();
            this.lbGetal2 = new System.Windows.Forms.Label();
            this.lbUitkomst = new System.Windows.Forms.Label();
            this.txtGetal1 = new System.Windows.Forms.TextBox();
            this.txtGetal2 = new System.Windows.Forms.TextBox();
            this.txtUitkomst = new System.Windows.Forms.TextBox();
            this.txtSom = new System.Windows.Forms.TextBox();
            this.btnBereken = new System.Windows.Forms.Button();
            this.lbSom = new System.Windows.Forms.Label();
            this.lbActie = new System.Windows.Forms.Label();
            this.RadioOptellen = new System.Windows.Forms.RadioButton();
            this.radioAftrekken = new System.Windows.Forms.RadioButton();
            this.radioVermenigvuldigen = new System.Windows.Forms.RadioButton();
            this.radioDelen = new System.Windows.Forms.RadioButton();
            this.radioKwadraad = new System.Windows.Forms.RadioButton();
            this.radioWortel = new System.Windows.Forms.RadioButton();
            this.lbReeksen = new System.Windows.Forms.Label();
            this.btnToon = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.radioEven = new System.Windows.Forms.RadioButton();
            this.radioFionacci = new System.Windows.Forms.RadioButton();
            this.radioPriem = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lbGetal1
            // 
            this.lbGetal1.AutoSize = true;
            this.lbGetal1.Location = new System.Drawing.Point(43, 45);
            this.lbGetal1.Name = "lbGetal1";
            this.lbGetal1.Size = new System.Drawing.Size(54, 17);
            this.lbGetal1.TabIndex = 0;
            this.lbGetal1.Text = "Getal 1";
            // 
            // lbGetal2
            // 
            this.lbGetal2.AutoSize = true;
            this.lbGetal2.Location = new System.Drawing.Point(43, 78);
            this.lbGetal2.Name = "lbGetal2";
            this.lbGetal2.Size = new System.Drawing.Size(54, 17);
            this.lbGetal2.TabIndex = 1;
            this.lbGetal2.Text = "Getal 2";
            // 
            // lbUitkomst
            // 
            this.lbUitkomst.AutoSize = true;
            this.lbUitkomst.Location = new System.Drawing.Point(43, 106);
            this.lbUitkomst.Name = "lbUitkomst";
            this.lbUitkomst.Size = new System.Drawing.Size(62, 17);
            this.lbUitkomst.TabIndex = 2;
            this.lbUitkomst.Text = "Uitkomst";
            // 
            // txtGetal1
            // 
            this.txtGetal1.Location = new System.Drawing.Point(115, 45);
            this.txtGetal1.Name = "txtGetal1";
            this.txtGetal1.Size = new System.Drawing.Size(141, 22);
            this.txtGetal1.TabIndex = 3;
            // 
            // txtGetal2
            // 
            this.txtGetal2.Location = new System.Drawing.Point(115, 73);
            this.txtGetal2.Name = "txtGetal2";
            this.txtGetal2.Size = new System.Drawing.Size(141, 22);
            this.txtGetal2.TabIndex = 4;
            this.txtGetal2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtUitkomst
            // 
            this.txtUitkomst.Location = new System.Drawing.Point(115, 101);
            this.txtUitkomst.Name = "txtUitkomst";
            this.txtUitkomst.Size = new System.Drawing.Size(141, 22);
            this.txtUitkomst.TabIndex = 5;
            // 
            // txtSom
            // 
            this.txtSom.Location = new System.Drawing.Point(115, 129);
            this.txtSom.Name = "txtSom";
            this.txtSom.Size = new System.Drawing.Size(141, 22);
            this.txtSom.TabIndex = 6;
            // 
            // btnBereken
            // 
            this.btnBereken.Location = new System.Drawing.Point(115, 168);
            this.btnBereken.Name = "btnBereken";
            this.btnBereken.Size = new System.Drawing.Size(141, 23);
            this.btnBereken.TabIndex = 8;
            this.btnBereken.Text = "Bereken";
            this.btnBereken.UseVisualStyleBackColor = true;
            // 
            // lbSom
            // 
            this.lbSom.AutoSize = true;
            this.lbSom.Location = new System.Drawing.Point(61, 134);
            this.lbSom.Name = "lbSom";
            this.lbSom.Size = new System.Drawing.Size(36, 17);
            this.lbSom.TabIndex = 9;
            this.lbSom.Text = "Som";
            // 
            // lbActie
            // 
            this.lbActie.AutoSize = true;
            this.lbActie.Location = new System.Drawing.Point(355, 26);
            this.lbActie.Name = "lbActie";
            this.lbActie.Size = new System.Drawing.Size(39, 17);
            this.lbActie.TabIndex = 10;
            this.lbActie.Text = "Actie";
            this.lbActie.Click += new System.EventHandler(this.lbActie_Click);
            // 
            // RadioOptellen
            // 
            this.RadioOptellen.AutoSize = true;
            this.RadioOptellen.Location = new System.Drawing.Point(358, 46);
            this.RadioOptellen.Name = "RadioOptellen";
            this.RadioOptellen.Size = new System.Drawing.Size(82, 21);
            this.RadioOptellen.TabIndex = 11;
            this.RadioOptellen.TabStop = true;
            this.RadioOptellen.Text = "Optellen";
            this.RadioOptellen.UseVisualStyleBackColor = true;
            this.RadioOptellen.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioAftrekken
            // 
            this.radioAftrekken.AutoSize = true;
            this.radioAftrekken.Location = new System.Drawing.Point(358, 73);
            this.radioAftrekken.Name = "radioAftrekken";
            this.radioAftrekken.Size = new System.Drawing.Size(89, 21);
            this.radioAftrekken.TabIndex = 12;
            this.radioAftrekken.TabStop = true;
            this.radioAftrekken.Text = "Aftrekken";
            this.radioAftrekken.UseVisualStyleBackColor = true;
            // 
            // radioVermenigvuldigen
            // 
            this.radioVermenigvuldigen.AutoSize = true;
            this.radioVermenigvuldigen.Location = new System.Drawing.Point(358, 101);
            this.radioVermenigvuldigen.Name = "radioVermenigvuldigen";
            this.radioVermenigvuldigen.Size = new System.Drawing.Size(142, 21);
            this.radioVermenigvuldigen.TabIndex = 13;
            this.radioVermenigvuldigen.TabStop = true;
            this.radioVermenigvuldigen.Text = "Vermenigvuldigen";
            this.radioVermenigvuldigen.UseVisualStyleBackColor = true;
            // 
            // radioDelen
            // 
            this.radioDelen.AutoSize = true;
            this.radioDelen.Location = new System.Drawing.Point(358, 130);
            this.radioDelen.Name = "radioDelen";
            this.radioDelen.Size = new System.Drawing.Size(66, 21);
            this.radioDelen.TabIndex = 14;
            this.radioDelen.TabStop = true;
            this.radioDelen.Text = "Delen";
            this.radioDelen.UseVisualStyleBackColor = true;
            // 
            // radioKwadraad
            // 
            this.radioKwadraad.AutoSize = true;
            this.radioKwadraad.Location = new System.Drawing.Point(358, 156);
            this.radioKwadraad.Name = "radioKwadraad";
            this.radioKwadraad.Size = new System.Drawing.Size(92, 21);
            this.radioKwadraad.TabIndex = 15;
            this.radioKwadraad.TabStop = true;
            this.radioKwadraad.Text = "Kwadraad";
            this.radioKwadraad.UseVisualStyleBackColor = true;
            // 
            // radioWortel
            // 
            this.radioWortel.AutoSize = true;
            this.radioWortel.Location = new System.Drawing.Point(358, 183);
            this.radioWortel.Name = "radioWortel";
            this.radioWortel.Size = new System.Drawing.Size(70, 21);
            this.radioWortel.TabIndex = 16;
            this.radioWortel.TabStop = true;
            this.radioWortel.Text = "Wortel";
            this.radioWortel.UseVisualStyleBackColor = true;
            // 
            // lbReeksen
            // 
            this.lbReeksen.AutoSize = true;
            this.lbReeksen.Location = new System.Drawing.Point(61, 434);
            this.lbReeksen.Name = "lbReeksen";
            this.lbReeksen.Size = new System.Drawing.Size(64, 17);
            this.lbReeksen.TabIndex = 17;
            this.lbReeksen.Text = "Reeksen";
            // 
            // btnToon
            // 
            this.btnToon.Location = new System.Drawing.Point(64, 552);
            this.btnToon.Name = "btnToon";
            this.btnToon.Size = new System.Drawing.Size(233, 33);
            this.btnToon.TabIndex = 21;
            this.btnToon.Text = "Toon";
            this.btnToon.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(358, 355);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(492, 230);
            this.richTextBox1.TabIndex = 22;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // radioEven
            // 
            this.radioEven.AutoSize = true;
            this.radioEven.Location = new System.Drawing.Point(64, 471);
            this.radioEven.Name = "radioEven";
            this.radioEven.Size = new System.Drawing.Size(202, 21);
            this.radioEven.TabIndex = 23;
            this.radioEven.TabStop = true;
            this.radioEven.Text = "Even getallen (25 Getallen)";
            this.radioEven.UseVisualStyleBackColor = true;
            // 
            // radioFionacci
            // 
            this.radioFionacci.AutoSize = true;
            this.radioFionacci.Location = new System.Drawing.Point(64, 498);
            this.radioFionacci.Name = "radioFionacci";
            this.radioFionacci.Size = new System.Drawing.Size(215, 21);
            this.radioFionacci.TabIndex = 24;
            this.radioFionacci.TabStop = true;
            this.radioFionacci.Text = "Fibonacci reeks (10 Getallen)";
            this.radioFionacci.UseVisualStyleBackColor = true;
            // 
            // radioPriem
            // 
            this.radioPriem.AutoSize = true;
            this.radioPriem.Location = new System.Drawing.Point(64, 525);
            this.radioPriem.Name = "radioPriem";
            this.radioPriem.Size = new System.Drawing.Size(209, 21);
            this.radioPriem.TabIndex = 25;
            this.radioPriem.TabStop = true;
            this.radioPriem.Text = "Priem Getallen (10 Getallen)";
            this.radioPriem.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(870, 627);
            this.Controls.Add(this.radioPriem);
            this.Controls.Add(this.radioFionacci);
            this.Controls.Add(this.radioEven);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnToon);
            this.Controls.Add(this.lbReeksen);
            this.Controls.Add(this.radioWortel);
            this.Controls.Add(this.radioKwadraad);
            this.Controls.Add(this.radioDelen);
            this.Controls.Add(this.radioVermenigvuldigen);
            this.Controls.Add(this.radioAftrekken);
            this.Controls.Add(this.RadioOptellen);
            this.Controls.Add(this.lbActie);
            this.Controls.Add(this.lbSom);
            this.Controls.Add(this.btnBereken);
            this.Controls.Add(this.txtSom);
            this.Controls.Add(this.txtUitkomst);
            this.Controls.Add(this.txtGetal2);
            this.Controls.Add(this.txtGetal1);
            this.Controls.Add(this.lbUitkomst);
            this.Controls.Add(this.lbGetal2);
            this.Controls.Add(this.lbGetal1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbGetal1;
        private System.Windows.Forms.Label lbGetal2;
        private System.Windows.Forms.Label lbUitkomst;
        private System.Windows.Forms.TextBox txtGetal1;
        private System.Windows.Forms.TextBox txtGetal2;
        private System.Windows.Forms.TextBox txtUitkomst;
        private System.Windows.Forms.TextBox txtSom;
        private System.Windows.Forms.Button btnBereken;
        private System.Windows.Forms.Label lbSom;
        private System.Windows.Forms.Label lbActie;
        private System.Windows.Forms.RadioButton RadioOptellen;
        private System.Windows.Forms.RadioButton radioAftrekken;
        private System.Windows.Forms.RadioButton radioVermenigvuldigen;
        private System.Windows.Forms.RadioButton radioDelen;
        private System.Windows.Forms.RadioButton radioKwadraad;
        private System.Windows.Forms.RadioButton radioWortel;
        private System.Windows.Forms.Label lbReeksen;
        private System.Windows.Forms.Button btnToon;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RadioButton radioEven;
        private System.Windows.Forms.RadioButton radioFionacci;
        private System.Windows.Forms.RadioButton radioPriem;
    }
}

