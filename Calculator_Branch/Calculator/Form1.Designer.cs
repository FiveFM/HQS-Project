
namespace Calculator
{
    partial class HQS_Calculator
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
            this.ActionBox = new System.Windows.Forms.GroupBox();
            this.radio1 = new System.Windows.Forms.RadioButton();
            this.radio2 = new System.Windows.Forms.RadioButton();
            this.radio3 = new System.Windows.Forms.RadioButton();
            this.radio4 = new System.Windows.Forms.RadioButton();
            this.radio5 = new System.Windows.Forms.RadioButton();
            this.radio6 = new System.Windows.Forms.RadioButton();
            this.reeksAmount = new System.Windows.Forms.NumericUpDown();
            this.textBoxContextMenuStrip1 = new MaterialSkin.Controls.TextBoxContextMenuStrip();
            this.txtGetal1 = new System.Windows.Forms.TextBox();
            this.txtGetal2 = new System.Windows.Forms.TextBox();
            this.txtSom = new System.Windows.Forms.TextBox();
            this.txtUitkomst = new System.Windows.Forms.TextBox();
            this.btnBereken = new System.Windows.Forms.Button();
            this.btnToon = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.radioPriem = new System.Windows.Forms.RadioButton();
            this.radioEven = new System.Windows.Forms.RadioButton();
            this.radioFionacci = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.tbGenerated = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ActionBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reeksAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // ActionBox
            // 
            this.ActionBox.BackColor = System.Drawing.Color.Transparent;
            this.ActionBox.Controls.Add(this.radio1);
            this.ActionBox.Controls.Add(this.radio2);
            this.ActionBox.Controls.Add(this.radio3);
            this.ActionBox.Controls.Add(this.radio4);
            this.ActionBox.Controls.Add(this.radio5);
            this.ActionBox.Controls.Add(this.radio6);
            this.ActionBox.ForeColor = System.Drawing.Color.Black;
            this.ActionBox.Location = new System.Drawing.Point(117, 8);
            this.ActionBox.Margin = new System.Windows.Forms.Padding(2);
            this.ActionBox.Name = "ActionBox";
            this.ActionBox.Padding = new System.Windows.Forms.Padding(2);
            this.ActionBox.Size = new System.Drawing.Size(348, 184);
            this.ActionBox.TabIndex = 27;
            this.ActionBox.TabStop = false;
            this.ActionBox.Text = "Actie";
            // 
            // radio1
            // 
            this.radio1.AutoSize = true;
            this.radio1.Checked = true;
            this.radio1.Location = new System.Drawing.Point(5, 16);
            this.radio1.Name = "radio1";
            this.radio1.Size = new System.Drawing.Size(64, 17);
            this.radio1.TabIndex = 44;
            this.radio1.TabStop = true;
            this.radio1.Tag = "1";
            this.radio1.Text = "Optellen";
            this.radio1.UseVisualStyleBackColor = true;
            this.radio1.CheckedChanged += new System.EventHandler(this.radioSelect);
            // 
            // radio2
            // 
            this.radio2.AutoSize = true;
            this.radio2.Location = new System.Drawing.Point(5, 39);
            this.radio2.Name = "radio2";
            this.radio2.Size = new System.Drawing.Size(71, 17);
            this.radio2.TabIndex = 45;
            this.radio2.Tag = "2";
            this.radio2.Text = "Aftrekken";
            this.radio2.UseVisualStyleBackColor = true;
            this.radio2.CheckedChanged += new System.EventHandler(this.radioSelect);
            // 
            // radio3
            // 
            this.radio3.AutoSize = true;
            this.radio3.Location = new System.Drawing.Point(5, 62);
            this.radio3.Name = "radio3";
            this.radio3.Size = new System.Drawing.Size(109, 17);
            this.radio3.TabIndex = 46;
            this.radio3.Tag = "3";
            this.radio3.Text = "Vermenigvuldigen";
            this.radio3.UseVisualStyleBackColor = true;
            this.radio3.CheckedChanged += new System.EventHandler(this.radioSelect);
            // 
            // radio4
            // 
            this.radio4.AutoSize = true;
            this.radio4.Location = new System.Drawing.Point(5, 85);
            this.radio4.Name = "radio4";
            this.radio4.Size = new System.Drawing.Size(53, 17);
            this.radio4.TabIndex = 47;
            this.radio4.Tag = "4";
            this.radio4.Text = "Delen";
            this.radio4.UseVisualStyleBackColor = true;
            this.radio4.CheckedChanged += new System.EventHandler(this.radioSelect);
            // 
            // radio5
            // 
            this.radio5.AutoSize = true;
            this.radio5.Location = new System.Drawing.Point(5, 108);
            this.radio5.Name = "radio5";
            this.radio5.Size = new System.Drawing.Size(70, 17);
            this.radio5.TabIndex = 48;
            this.radio5.Tag = "5";
            this.radio5.Text = "Kwadraat";
            this.radio5.UseVisualStyleBackColor = true;
            this.radio5.CheckedChanged += new System.EventHandler(this.radioSelect);
            // 
            // radio6
            // 
            this.radio6.AutoSize = true;
            this.radio6.Location = new System.Drawing.Point(4, 132);
            this.radio6.Name = "radio6";
            this.radio6.Size = new System.Drawing.Size(56, 17);
            this.radio6.TabIndex = 49;
            this.radio6.Tag = "6";
            this.radio6.Text = "Wortel";
            this.radio6.UseVisualStyleBackColor = true;
            this.radio6.CheckedChanged += new System.EventHandler(this.radioSelect);
            // 
            // reeksAmount
            // 
            this.reeksAmount.Location = new System.Drawing.Point(12, 383);
            this.reeksAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.reeksAmount.Name = "reeksAmount";
            this.reeksAmount.Size = new System.Drawing.Size(96, 20);
            this.reeksAmount.TabIndex = 28;
            this.reeksAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // textBoxContextMenuStrip1
            // 
            this.textBoxContextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.textBoxContextMenuStrip1.Depth = 0;
            this.textBoxContextMenuStrip1.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxContextMenuStrip1.Name = "textBoxContextMenuStrip1";
            this.textBoxContextMenuStrip1.Size = new System.Drawing.Size(123, 160);
            // 
            // txtGetal1
            // 
            this.txtGetal1.Location = new System.Drawing.Point(12, 24);
            this.txtGetal1.Name = "txtGetal1";
            this.txtGetal1.Size = new System.Drawing.Size(100, 20);
            this.txtGetal1.TabIndex = 50;
            this.txtGetal1.TextChanged += new System.EventHandler(this.inter_TextChanged);
            // 
            // txtGetal2
            // 
            this.txtGetal2.Location = new System.Drawing.Point(12, 64);
            this.txtGetal2.Name = "txtGetal2";
            this.txtGetal2.Size = new System.Drawing.Size(100, 20);
            this.txtGetal2.TabIndex = 51;
            this.txtGetal2.TextChanged += new System.EventHandler(this.inter_TextChanged);
            // 
            // txtSom
            // 
            this.txtSom.Location = new System.Drawing.Point(12, 103);
            this.txtSom.Name = "txtSom";
            this.txtSom.Size = new System.Drawing.Size(100, 20);
            this.txtSom.TabIndex = 52;
            // 
            // txtUitkomst
            // 
            this.txtUitkomst.Location = new System.Drawing.Point(12, 143);
            this.txtUitkomst.Name = "txtUitkomst";
            this.txtUitkomst.Size = new System.Drawing.Size(100, 20);
            this.txtUitkomst.TabIndex = 53;
            // 
            // btnBereken
            // 
            this.btnBereken.Location = new System.Drawing.Point(12, 169);
            this.btnBereken.Name = "btnBereken";
            this.btnBereken.Size = new System.Drawing.Size(100, 23);
            this.btnBereken.TabIndex = 54;
            this.btnBereken.Text = "Berekenen";
            this.btnBereken.UseVisualStyleBackColor = true;
            this.btnBereken.Click += new System.EventHandler(this.calc_Click);
            // 
            // btnToon
            // 
            this.btnToon.Location = new System.Drawing.Point(9, 409);
            this.btnToon.Name = "btnToon";
            this.btnToon.Size = new System.Drawing.Size(99, 23);
            this.btnToon.TabIndex = 55;
            this.btnToon.Text = "Toon";
            this.btnToon.UseVisualStyleBackColor = true;
            this.btnToon.Click += new System.EventHandler(this.btnToon_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(390, 438);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 56;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.exit_Click);
            // 
            // radioPriem
            // 
            this.radioPriem.AutoSize = true;
            this.radioPriem.BackColor = System.Drawing.Color.Transparent;
            this.radioPriem.Checked = true;
            this.radioPriem.Location = new System.Drawing.Point(12, 314);
            this.radioPriem.Name = "radioPriem";
            this.radioPriem.Size = new System.Drawing.Size(51, 17);
            this.radioPriem.TabIndex = 57;
            this.radioPriem.TabStop = true;
            this.radioPriem.Text = "Priem";
            this.radioPriem.UseVisualStyleBackColor = false;
            // 
            // radioEven
            // 
            this.radioEven.AutoSize = true;
            this.radioEven.Location = new System.Drawing.Point(12, 337);
            this.radioEven.Name = "radioEven";
            this.radioEven.Size = new System.Drawing.Size(50, 17);
            this.radioEven.TabIndex = 58;
            this.radioEven.Text = "Even";
            this.radioEven.UseVisualStyleBackColor = true;
            // 
            // radioFionacci
            // 
            this.radioFionacci.AutoSize = true;
            this.radioFionacci.Location = new System.Drawing.Point(12, 360);
            this.radioFionacci.Name = "radioFionacci";
            this.radioFionacci.Size = new System.Drawing.Size(71, 17);
            this.radioFionacci.TabIndex = 59;
            this.radioFionacci.Text = "Fibonacci";
            this.radioFionacci.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 298);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 60;
            this.label1.Text = "Reeksen";
            // 
            // tbGenerated
            // 
            this.tbGenerated.Location = new System.Drawing.Point(117, 197);
            this.tbGenerated.Multiline = true;
            this.tbGenerated.Name = "tbGenerated";
            this.tbGenerated.Size = new System.Drawing.Size(348, 235);
            this.tbGenerated.TabIndex = 61;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 62;
            this.label2.Text = "Getal 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 62;
            this.label3.Text = "Getal 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 62;
            this.label4.Text = "Som";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 62;
            this.label5.Text = "Uitkomst";
            // 
            // HQS_Calculator
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.ClientSize = new System.Drawing.Size(477, 474);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbGenerated);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioFionacci);
            this.Controls.Add(this.radioEven);
            this.Controls.Add(this.radioPriem);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnToon);
            this.Controls.Add(this.btnBereken);
            this.Controls.Add(this.txtUitkomst);
            this.Controls.Add(this.txtSom);
            this.Controls.Add(this.txtGetal2);
            this.Controls.Add(this.txtGetal1);
            this.Controls.Add(this.reeksAmount);
            this.Controls.Add(this.ActionBox);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HQS_Calculator";
            this.Text = "HQS Calculator";
            this.ActionBox.ResumeLayout(false);
            this.ActionBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reeksAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox ActionBox;
        private System.Windows.Forms.NumericUpDown reeksAmount;
        private MaterialSkin.Controls.TextBoxContextMenuStrip textBoxContextMenuStrip1;
        private System.Windows.Forms.RadioButton radio1;
        private System.Windows.Forms.RadioButton radio2;
        private System.Windows.Forms.RadioButton radio3;
        private System.Windows.Forms.RadioButton radio4;
        private System.Windows.Forms.RadioButton radio5;
        private System.Windows.Forms.RadioButton radio6;
        private System.Windows.Forms.TextBox txtGetal1;
        private System.Windows.Forms.TextBox txtGetal2;
        private System.Windows.Forms.TextBox txtSom;
        private System.Windows.Forms.TextBox txtUitkomst;
        private System.Windows.Forms.Button btnBereken;
        private System.Windows.Forms.Button btnToon;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.RadioButton radioPriem;
        private System.Windows.Forms.RadioButton radioEven;
        private System.Windows.Forms.RadioButton radioFionacci;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbGenerated;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

