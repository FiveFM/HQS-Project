
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
            this.reeksAmount = new System.Windows.Forms.NumericUpDown();
            this.btnExit = new MaterialSkin.Controls.MaterialButton();
            this.btnToon = new MaterialSkin.Controls.MaterialButton();
            this.textBoxContextMenuStrip1 = new MaterialSkin.Controls.TextBoxContextMenuStrip();
            this.radio1 = new MaterialSkin.Controls.MaterialRadioButton();
            this.radio2 = new MaterialSkin.Controls.MaterialRadioButton();
            this.radio3 = new MaterialSkin.Controls.MaterialRadioButton();
            this.radio6 = new MaterialSkin.Controls.MaterialRadioButton();
            this.radio5 = new MaterialSkin.Controls.MaterialRadioButton();
            this.radio4 = new MaterialSkin.Controls.MaterialRadioButton();
            this.txtGetal1 = new MaterialSkin.Controls.MaterialTextBox();
            this.txtGetal2 = new MaterialSkin.Controls.MaterialTextBox();
            this.txtSom = new MaterialSkin.Controls.MaterialTextBox();
            this.txtUitkomst = new MaterialSkin.Controls.MaterialTextBox();
            this.btnBereken = new MaterialSkin.Controls.MaterialButton();
            this.radioPriem = new MaterialSkin.Controls.MaterialRadioButton();
            this.radioEven = new MaterialSkin.Controls.MaterialRadioButton();
            this.radioFionacci = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.tbGenerated = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.ActionBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reeksAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // ActionBox
            // 
            this.ActionBox.BackColor = System.Drawing.Color.Transparent;
            this.ActionBox.Controls.Add(this.radio5);
            this.ActionBox.Controls.Add(this.radio4);
            this.ActionBox.Controls.Add(this.radio1);
            this.ActionBox.Controls.Add(this.radio2);
            this.ActionBox.Controls.Add(this.radio6);
            this.ActionBox.Controls.Add(this.radio3);
            this.ActionBox.ForeColor = System.Drawing.Color.Transparent;
            this.ActionBox.Location = new System.Drawing.Point(144, 65);
            this.ActionBox.Margin = new System.Windows.Forms.Padding(2);
            this.ActionBox.Name = "ActionBox";
            this.ActionBox.Padding = new System.Windows.Forms.Padding(2);
            this.ActionBox.Size = new System.Drawing.Size(286, 271);
            this.ActionBox.TabIndex = 27;
            this.ActionBox.TabStop = false;
            // 
            // reeksAmount
            // 
            this.reeksAmount.Location = new System.Drawing.Point(5, 501);
            this.reeksAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.reeksAmount.Name = "reeksAmount";
            this.reeksAmount.Size = new System.Drawing.Size(181, 20);
            this.reeksAmount.TabIndex = 28;
            this.reeksAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnExit
            // 
            this.btnExit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnExit.Depth = 0;
            this.btnExit.DrawShadows = true;
            this.btnExit.HighEmphasis = true;
            this.btnExit.Icon = null;
            this.btnExit.Location = new System.Drawing.Point(495, 575);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnExit.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(52, 36);
            this.btnExit.TabIndex = 30;
            this.btnExit.Text = "Exit";
            this.btnExit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnExit.UseAccentColor = false;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.exit_Click);
            // 
            // btnToon
            // 
            this.btnToon.Depth = 0;
            this.btnToon.DrawShadows = true;
            this.btnToon.HighEmphasis = true;
            this.btnToon.Icon = null;
            this.btnToon.Location = new System.Drawing.Point(5, 530);
            this.btnToon.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnToon.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnToon.Name = "btnToon";
            this.btnToon.Size = new System.Drawing.Size(190, 36);
            this.btnToon.TabIndex = 31;
            this.btnToon.Text = "Toon";
            this.btnToon.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnToon.UseAccentColor = false;
            this.btnToon.UseVisualStyleBackColor = true;
            this.btnToon.Click += new System.EventHandler(this.btnToon_Click);
            // 
            // textBoxContextMenuStrip1
            // 
            this.textBoxContextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.textBoxContextMenuStrip1.Depth = 0;
            this.textBoxContextMenuStrip1.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxContextMenuStrip1.Name = "textBoxContextMenuStrip1";
            this.textBoxContextMenuStrip1.Size = new System.Drawing.Size(123, 160);
            // 
            // radio1
            // 
            this.radio1.AutoSize = true;
            this.radio1.BackColor = System.Drawing.Color.Transparent;
            this.radio1.Checked = true;
            this.radio1.Depth = 0;
            this.radio1.Location = new System.Drawing.Point(11, 13);
            this.radio1.Margin = new System.Windows.Forms.Padding(0);
            this.radio1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radio1.MouseState = MaterialSkin.MouseState.HOVER;
            this.radio1.Name = "radio1";
            this.radio1.Ripple = true;
            this.radio1.Size = new System.Drawing.Size(93, 37);
            this.radio1.TabIndex = 33;
            this.radio1.TabStop = true;
            this.radio1.Tag = "1";
            this.radio1.Text = "Optellen";
            this.radio1.UseVisualStyleBackColor = false;
            this.radio1.CheckedChanged += new System.EventHandler(this.radioSelect);
            // 
            // radio2
            // 
            this.radio2.AutoSize = true;
            this.radio2.BackColor = System.Drawing.Color.Transparent;
            this.radio2.Depth = 0;
            this.radio2.Location = new System.Drawing.Point(11, 50);
            this.radio2.Margin = new System.Windows.Forms.Padding(0);
            this.radio2.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radio2.MouseState = MaterialSkin.MouseState.HOVER;
            this.radio2.Name = "radio2";
            this.radio2.Ripple = true;
            this.radio2.Size = new System.Drawing.Size(102, 37);
            this.radio2.TabIndex = 34;
            this.radio2.TabStop = true;
            this.radio2.Tag = "2";
            this.radio2.Text = "Aftrekken";
            this.radio2.UseVisualStyleBackColor = false;
            this.radio2.CheckedChanged += new System.EventHandler(this.radioSelect);
            // 
            // radio3
            // 
            this.radio3.AutoSize = true;
            this.radio3.BackColor = System.Drawing.Color.Transparent;
            this.radio3.Depth = 0;
            this.radio3.Location = new System.Drawing.Point(11, 87);
            this.radio3.Margin = new System.Windows.Forms.Padding(0);
            this.radio3.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radio3.MouseState = MaterialSkin.MouseState.HOVER;
            this.radio3.Name = "radio3";
            this.radio3.Ripple = true;
            this.radio3.Size = new System.Drawing.Size(162, 37);
            this.radio3.TabIndex = 35;
            this.radio3.TabStop = true;
            this.radio3.Tag = "3";
            this.radio3.Text = "Vermenigvuldigen";
            this.radio3.UseVisualStyleBackColor = false;
            this.radio3.CheckedChanged += new System.EventHandler(this.radioSelect);
            // 
            // radio6
            // 
            this.radio6.AutoSize = true;
            this.radio6.BackColor = System.Drawing.Color.Transparent;
            this.radio6.Depth = 0;
            this.radio6.Location = new System.Drawing.Point(11, 198);
            this.radio6.Margin = new System.Windows.Forms.Padding(0);
            this.radio6.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radio6.MouseState = MaterialSkin.MouseState.HOVER;
            this.radio6.Name = "radio6";
            this.radio6.Ripple = true;
            this.radio6.Size = new System.Drawing.Size(80, 37);
            this.radio6.TabIndex = 37;
            this.radio6.TabStop = true;
            this.radio6.Tag = "6";
            this.radio6.Text = "Wortel";
            this.radio6.UseVisualStyleBackColor = false;
            this.radio6.CheckedChanged += new System.EventHandler(this.radioSelect);
            // 
            // radio5
            // 
            this.radio5.AutoSize = true;
            this.radio5.BackColor = System.Drawing.Color.Transparent;
            this.radio5.Depth = 0;
            this.radio5.Location = new System.Drawing.Point(11, 161);
            this.radio5.Margin = new System.Windows.Forms.Padding(0);
            this.radio5.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radio5.MouseState = MaterialSkin.MouseState.HOVER;
            this.radio5.Name = "radio5";
            this.radio5.Ripple = true;
            this.radio5.Size = new System.Drawing.Size(103, 37);
            this.radio5.TabIndex = 38;
            this.radio5.TabStop = true;
            this.radio5.Tag = "5";
            this.radio5.Text = "Kwadraat";
            this.radio5.UseVisualStyleBackColor = false;
            this.radio5.CheckedChanged += new System.EventHandler(this.radioSelect);
            // 
            // radio4
            // 
            this.radio4.AutoSize = true;
            this.radio4.BackColor = System.Drawing.Color.Transparent;
            this.radio4.Depth = 0;
            this.radio4.Location = new System.Drawing.Point(11, 124);
            this.radio4.Margin = new System.Windows.Forms.Padding(0);
            this.radio4.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radio4.MouseState = MaterialSkin.MouseState.HOVER;
            this.radio4.Name = "radio4";
            this.radio4.Ripple = true;
            this.radio4.Size = new System.Drawing.Size(74, 37);
            this.radio4.TabIndex = 36;
            this.radio4.TabStop = true;
            this.radio4.Tag = "4";
            this.radio4.Text = "Delen";
            this.radio4.UseVisualStyleBackColor = false;
            this.radio4.CheckedChanged += new System.EventHandler(this.radioSelect);
            // 
            // txtGetal1
            // 
            this.txtGetal1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGetal1.Depth = 0;
            this.txtGetal1.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtGetal1.Hint = "Getal 1";
            this.txtGetal1.Location = new System.Drawing.Point(6, 73);
            this.txtGetal1.MaxLength = 50;
            this.txtGetal1.MouseState = MaterialSkin.MouseState.OUT;
            this.txtGetal1.Multiline = false;
            this.txtGetal1.Name = "txtGetal1";
            this.txtGetal1.Size = new System.Drawing.Size(133, 50);
            this.txtGetal1.TabIndex = 34;
            this.txtGetal1.Text = "";
            this.txtGetal1.TextChanged += new System.EventHandler(this.inter_TextChanged);
            // 
            // txtGetal2
            // 
            this.txtGetal2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGetal2.Depth = 0;
            this.txtGetal2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtGetal2.Hint = "Getal 2";
            this.txtGetal2.Location = new System.Drawing.Point(6, 129);
            this.txtGetal2.MaxLength = 50;
            this.txtGetal2.MouseState = MaterialSkin.MouseState.OUT;
            this.txtGetal2.Multiline = false;
            this.txtGetal2.Name = "txtGetal2";
            this.txtGetal2.Size = new System.Drawing.Size(133, 50);
            this.txtGetal2.TabIndex = 35;
            this.txtGetal2.Text = "";
            this.txtGetal2.TextChanged += new System.EventHandler(this.inter_TextChanged);
            // 
            // txtSom
            // 
            this.txtSom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSom.Depth = 0;
            this.txtSom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtSom.Hint = "Som";
            this.txtSom.Location = new System.Drawing.Point(5, 185);
            this.txtSom.MaxLength = 50;
            this.txtSom.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSom.Multiline = false;
            this.txtSom.Name = "txtSom";
            this.txtSom.ReadOnly = true;
            this.txtSom.Size = new System.Drawing.Size(133, 50);
            this.txtSom.TabIndex = 36;
            this.txtSom.Text = "";
            // 
            // txtUitkomst
            // 
            this.txtUitkomst.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUitkomst.Depth = 0;
            this.txtUitkomst.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtUitkomst.Hint = "Uitkomst";
            this.txtUitkomst.Location = new System.Drawing.Point(5, 241);
            this.txtUitkomst.MaxLength = 50;
            this.txtUitkomst.MouseState = MaterialSkin.MouseState.OUT;
            this.txtUitkomst.Multiline = false;
            this.txtUitkomst.Name = "txtUitkomst";
            this.txtUitkomst.ReadOnly = true;
            this.txtUitkomst.Size = new System.Drawing.Size(133, 50);
            this.txtUitkomst.TabIndex = 37;
            this.txtUitkomst.Text = "";
            // 
            // btnBereken
            // 
            this.btnBereken.Depth = 0;
            this.btnBereken.DrawShadows = true;
            this.btnBereken.HighEmphasis = true;
            this.btnBereken.Icon = null;
            this.btnBereken.Location = new System.Drawing.Point(6, 300);
            this.btnBereken.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBereken.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBereken.Name = "btnBereken";
            this.btnBereken.Size = new System.Drawing.Size(132, 36);
            this.btnBereken.TabIndex = 38;
            this.btnBereken.Text = "Bereken";
            this.btnBereken.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBereken.UseAccentColor = false;
            this.btnBereken.UseVisualStyleBackColor = true;
            this.btnBereken.Click += new System.EventHandler(this.calc_Click);
            // 
            // radioPriem
            // 
            this.radioPriem.AutoSize = true;
            this.radioPriem.Depth = 0;
            this.radioPriem.Location = new System.Drawing.Point(5, 387);
            this.radioPriem.Margin = new System.Windows.Forms.Padding(0);
            this.radioPriem.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radioPriem.MouseState = MaterialSkin.MouseState.HOVER;
            this.radioPriem.Name = "radioPriem";
            this.radioPriem.Ripple = true;
            this.radioPriem.Size = new System.Drawing.Size(136, 37);
            this.radioPriem.TabIndex = 39;
            this.radioPriem.TabStop = true;
            this.radioPriem.Text = "Priem getallen";
            this.radioPriem.UseVisualStyleBackColor = true;
            // 
            // radioEven
            // 
            this.radioEven.AutoSize = true;
            this.radioEven.Depth = 0;
            this.radioEven.Location = new System.Drawing.Point(5, 424);
            this.radioEven.Margin = new System.Windows.Forms.Padding(0);
            this.radioEven.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radioEven.MouseState = MaterialSkin.MouseState.HOVER;
            this.radioEven.Name = "radioEven";
            this.radioEven.Ripple = true;
            this.radioEven.Size = new System.Drawing.Size(129, 37);
            this.radioEven.TabIndex = 40;
            this.radioEven.TabStop = true;
            this.radioEven.Text = "Even getallen";
            this.radioEven.UseVisualStyleBackColor = true;
            // 
            // radioFionacci
            // 
            this.radioFionacci.AutoSize = true;
            this.radioFionacci.Depth = 0;
            this.radioFionacci.Location = new System.Drawing.Point(5, 461);
            this.radioFionacci.Margin = new System.Windows.Forms.Padding(0);
            this.radioFionacci.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radioFionacci.MouseState = MaterialSkin.MouseState.HOVER;
            this.radioFionacci.Name = "radioFionacci";
            this.radioFionacci.Ripple = true;
            this.radioFionacci.Size = new System.Drawing.Size(164, 37);
            this.radioFionacci.TabIndex = 41;
            this.radioFionacci.TabStop = true;
            this.radioFionacci.Text = "Fibonacci getallen";
            this.radioFionacci.UseVisualStyleBackColor = true;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(6, 364);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(60, 20);
            this.materialLabel1.TabIndex = 42;
            this.materialLabel1.Text = "Reeksen";
            // 
            // tbGenerated
            // 
            this.tbGenerated.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tbGenerated.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbGenerated.Depth = 0;
            this.tbGenerated.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbGenerated.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tbGenerated.Hint = "";
            this.tbGenerated.Location = new System.Drawing.Point(199, 387);
            this.tbGenerated.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbGenerated.Name = "tbGenerated";
            this.tbGenerated.ReadOnly = true;
            this.tbGenerated.Size = new System.Drawing.Size(348, 179);
            this.tbGenerated.TabIndex = 43;
            this.tbGenerated.Text = "";
            // 
            // HQS_Calculator
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(559, 624);
            this.Controls.Add(this.tbGenerated);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.radioFionacci);
            this.Controls.Add(this.radioEven);
            this.Controls.Add(this.radioPriem);
            this.Controls.Add(this.btnBereken);
            this.Controls.Add(this.txtUitkomst);
            this.Controls.Add(this.txtSom);
            this.Controls.Add(this.txtGetal2);
            this.Controls.Add(this.txtGetal1);
            this.Controls.Add(this.btnToon);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.reeksAmount);
            this.Controls.Add(this.ActionBox);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HQS_Calculator";
            this.Sizable = false;
            this.Text = "HQS Calculator";
            this.Load += new System.EventHandler(this.HQS_Calculator_Load);
            this.ActionBox.ResumeLayout(false);
            this.ActionBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reeksAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox ActionBox;
        private System.Windows.Forms.NumericUpDown reeksAmount;
        private MaterialSkin.Controls.MaterialButton btnExit;
        private MaterialSkin.Controls.MaterialButton btnToon;
        private MaterialSkin.Controls.TextBoxContextMenuStrip textBoxContextMenuStrip1;
        private MaterialSkin.Controls.MaterialRadioButton radio1;
        private MaterialSkin.Controls.MaterialRadioButton radio2;
        private MaterialSkin.Controls.MaterialRadioButton radio3;
        private MaterialSkin.Controls.MaterialRadioButton radio6;
        private MaterialSkin.Controls.MaterialRadioButton radio5;
        private MaterialSkin.Controls.MaterialRadioButton radio4;
        private MaterialSkin.Controls.MaterialTextBox txtGetal1;
        private MaterialSkin.Controls.MaterialTextBox txtGetal2;
        private MaterialSkin.Controls.MaterialTextBox txtSom;
        private MaterialSkin.Controls.MaterialTextBox txtUitkomst;
        private MaterialSkin.Controls.MaterialButton btnBereken;
        private MaterialSkin.Controls.MaterialRadioButton radioPriem;
        private MaterialSkin.Controls.MaterialRadioButton radioEven;
        private MaterialSkin.Controls.MaterialRadioButton radioFionacci;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialMultiLineTextBox tbGenerated;
    }
}

