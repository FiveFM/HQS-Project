
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
            this.lbGetal1.Location = new System.Drawing.Point(32, 37);
            this.lbGetal1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbGetal1.Name = "lbGetal1";
            this.lbGetal1.Size = new System.Drawing.Size(41, 13);
            this.lbGetal1.TabIndex = 0;
            this.lbGetal1.Text = "Getal 1";
            // 
            // lbGetal2
            // 
            this.lbGetal2.AutoSize = true;
            this.lbGetal2.Location = new System.Drawing.Point(32, 63);
            this.lbGetal2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbGetal2.Name = "lbGetal2";
            this.lbGetal2.Size = new System.Drawing.Size(41, 13);
            this.lbGetal2.TabIndex = 1;
            this.lbGetal2.Text = "Getal 2";
            // 
            // lbUitkomst
            // 
            this.lbUitkomst.AutoSize = true;
            this.lbUitkomst.Location = new System.Drawing.Point(32, 86);
            this.lbUitkomst.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbUitkomst.Name = "lbUitkomst";
            this.lbUitkomst.Size = new System.Drawing.Size(48, 13);
            this.lbUitkomst.TabIndex = 2;
            this.lbUitkomst.Text = "Uitkomst";
            // 
            // txtGetal1
            // 
            this.txtGetal1.Location = new System.Drawing.Point(86, 37);
            this.txtGetal1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtGetal1.Name = "txtGetal1";
            this.txtGetal1.Size = new System.Drawing.Size(107, 20);
            this.txtGetal1.TabIndex = 3;
            // 
            // txtGetal2
            // 
            this.txtGetal2.Location = new System.Drawing.Point(86, 59);
            this.txtGetal2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtGetal2.Name = "txtGetal2";
            this.txtGetal2.Size = new System.Drawing.Size(107, 20);
            this.txtGetal2.TabIndex = 4;
            this.txtGetal2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtUitkomst
            // 
            this.txtUitkomst.Location = new System.Drawing.Point(86, 82);
            this.txtUitkomst.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtUitkomst.Name = "txtUitkomst";
            this.txtUitkomst.Size = new System.Drawing.Size(107, 20);
            this.txtUitkomst.TabIndex = 5;
            // 
            // txtSom
            // 
            this.txtSom.Location = new System.Drawing.Point(86, 105);
            this.txtSom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSom.Name = "txtSom";
            this.txtSom.Size = new System.Drawing.Size(107, 20);
            this.txtSom.TabIndex = 6;
            // 
            // btnBereken
            // 
            this.btnBereken.Location = new System.Drawing.Point(86, 136);
            this.btnBereken.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBereken.Name = "btnBereken";
            this.btnBereken.Size = new System.Drawing.Size(106, 19);
            this.btnBereken.TabIndex = 8;
            this.btnBereken.Text = "Bereken";
            this.btnBereken.UseVisualStyleBackColor = true;
            this.btnBereken.Click += new System.EventHandler(this.btnBereken_Click);
            // 
            // lbSom
            // 
            this.lbSom.AutoSize = true;
            this.lbSom.Location = new System.Drawing.Point(46, 109);
            this.lbSom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSom.Name = "lbSom";
            this.lbSom.Size = new System.Drawing.Size(28, 13);
            this.lbSom.TabIndex = 9;
            this.lbSom.Text = "Som";
            // 
            // lbActie
            // 
            this.lbActie.AutoSize = true;
            this.lbActie.Location = new System.Drawing.Point(266, 21);
            this.lbActie.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbActie.Name = "lbActie";
            this.lbActie.Size = new System.Drawing.Size(31, 13);
            this.lbActie.TabIndex = 10;
            this.lbActie.Text = "Actie";
            this.lbActie.Click += new System.EventHandler(this.lbActie_Click);
            // 
            // RadioOptellen
            // 
            this.RadioOptellen.AutoSize = true;
            this.RadioOptellen.Location = new System.Drawing.Point(268, 37);
            this.RadioOptellen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RadioOptellen.Name = "RadioOptellen";
            this.RadioOptellen.Size = new System.Drawing.Size(64, 17);
            this.RadioOptellen.TabIndex = 11;
            this.RadioOptellen.TabStop = true;
            this.RadioOptellen.Text = "Optellen";
            this.RadioOptellen.UseVisualStyleBackColor = true;
            this.RadioOptellen.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioAftrekken
            // 
            this.radioAftrekken.AutoSize = true;
            this.radioAftrekken.Location = new System.Drawing.Point(268, 59);
            this.radioAftrekken.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioAftrekken.Name = "radioAftrekken";
            this.radioAftrekken.Size = new System.Drawing.Size(71, 17);
            this.radioAftrekken.TabIndex = 12;
            this.radioAftrekken.TabStop = true;
            this.radioAftrekken.Text = "Aftrekken";
            this.radioAftrekken.UseVisualStyleBackColor = true;
            // 
            // radioVermenigvuldigen
            // 
            this.radioVermenigvuldigen.AutoSize = true;
            this.radioVermenigvuldigen.Location = new System.Drawing.Point(268, 82);
            this.radioVermenigvuldigen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioVermenigvuldigen.Name = "radioVermenigvuldigen";
            this.radioVermenigvuldigen.Size = new System.Drawing.Size(109, 17);
            this.radioVermenigvuldigen.TabIndex = 13;
            this.radioVermenigvuldigen.TabStop = true;
            this.radioVermenigvuldigen.Text = "Vermenigvuldigen";
            this.radioVermenigvuldigen.UseVisualStyleBackColor = true;
            // 
            // radioDelen
            // 
            this.radioDelen.AutoSize = true;
            this.radioDelen.Location = new System.Drawing.Point(268, 106);
            this.radioDelen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioDelen.Name = "radioDelen";
            this.radioDelen.Size = new System.Drawing.Size(53, 17);
            this.radioDelen.TabIndex = 14;
            this.radioDelen.TabStop = true;
            this.radioDelen.Text = "Delen";
            this.radioDelen.UseVisualStyleBackColor = true;
            // 
            // radioKwadraad
            // 
            this.radioKwadraad.AutoSize = true;
            this.radioKwadraad.Location = new System.Drawing.Point(268, 127);
            this.radioKwadraad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioKwadraad.Name = "radioKwadraad";
            this.radioKwadraad.Size = new System.Drawing.Size(73, 17);
            this.radioKwadraad.TabIndex = 15;
            this.radioKwadraad.TabStop = true;
            this.radioKwadraad.Text = "Kwadraad";
            this.radioKwadraad.UseVisualStyleBackColor = true;
            // 
            // radioWortel
            // 
            this.radioWortel.AutoSize = true;
            this.radioWortel.Location = new System.Drawing.Point(268, 149);
            this.radioWortel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioWortel.Name = "radioWortel";
            this.radioWortel.Size = new System.Drawing.Size(56, 17);
            this.radioWortel.TabIndex = 16;
            this.radioWortel.TabStop = true;
            this.radioWortel.Text = "Wortel";
            this.radioWortel.UseVisualStyleBackColor = true;
            // 
            // lbReeksen
            // 
            this.lbReeksen.AutoSize = true;
            this.lbReeksen.Location = new System.Drawing.Point(46, 353);
            this.lbReeksen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbReeksen.Name = "lbReeksen";
            this.lbReeksen.Size = new System.Drawing.Size(50, 13);
            this.lbReeksen.TabIndex = 17;
            this.lbReeksen.Text = "Reeksen";
            // 
            // btnToon
            // 
            this.btnToon.Location = new System.Drawing.Point(48, 448);
            this.btnToon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnToon.Name = "btnToon";
            this.btnToon.Size = new System.Drawing.Size(175, 27);
            this.btnToon.TabIndex = 21;
            this.btnToon.Text = "Toon";
            this.btnToon.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(268, 288);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(370, 188);
            this.richTextBox1.TabIndex = 22;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // radioEven
            // 
            this.radioEven.AutoSize = true;
            this.radioEven.Location = new System.Drawing.Point(48, 383);
            this.radioEven.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioEven.Name = "radioEven";
            this.radioEven.Size = new System.Drawing.Size(153, 17);
            this.radioEven.TabIndex = 23;
            this.radioEven.TabStop = true;
            this.radioEven.Text = "Even getallen (25 Getallen)";
            this.radioEven.UseVisualStyleBackColor = true;
            // 
            // radioFionacci
            // 
            this.radioFionacci.AutoSize = true;
            this.radioFionacci.Location = new System.Drawing.Point(48, 405);
            this.radioFionacci.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioFionacci.Name = "radioFionacci";
            this.radioFionacci.Size = new System.Drawing.Size(163, 17);
            this.radioFionacci.TabIndex = 24;
            this.radioFionacci.TabStop = true;
            this.radioFionacci.Text = "Fibonacci reeks (10 Getallen)";
            this.radioFionacci.UseVisualStyleBackColor = true;
            // 
            // radioPriem
            // 
            this.radioPriem.AutoSize = true;
            this.radioPriem.Location = new System.Drawing.Point(48, 427);
            this.radioPriem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioPriem.Name = "radioPriem";
            this.radioPriem.Size = new System.Drawing.Size(156, 17);
            this.radioPriem.TabIndex = 25;
            this.radioPriem.TabStop = true;
            this.radioPriem.Text = "Priem Getallen (10 Getallen)";
            this.radioPriem.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(652, 509);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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

