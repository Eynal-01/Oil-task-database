namespace Oil_task_database
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
            this.OilscomboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.WithMoneyRadioBtn = new System.Windows.Forms.RadioButton();
            this.WithLiterRadioBtn = new System.Windows.Forms.RadioButton();
            this.MoneyTxtb = new System.Windows.Forms.TextBox();
            this.LiterTxtb = new System.Windows.Forms.TextBox();
            this.OilBuyLbl = new System.Windows.Forms.Label();
            this.MustPayLbl = new System.Windows.Forms.Label();
            this.OilQuantityLbl = new System.Windows.Forms.Label();
            this.OilNameLbl = new System.Windows.Forms.Label();
            this.PayLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PriceLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OilscomboBox
            // 
            this.OilscomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OilscomboBox.FormattingEnabled = true;
            this.OilscomboBox.Location = new System.Drawing.Point(87, 34);
            this.OilscomboBox.Name = "OilscomboBox";
            this.OilscomboBox.Size = new System.Drawing.Size(141, 28);
            this.OilscomboBox.TabIndex = 0;
            this.OilscomboBox.SelectedIndexChanged += new System.EventHandler(this.OilscomboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Oil type";
            // 
            // WithMoneyRadioBtn
            // 
            this.WithMoneyRadioBtn.AutoSize = true;
            this.WithMoneyRadioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WithMoneyRadioBtn.Location = new System.Drawing.Point(279, 29);
            this.WithMoneyRadioBtn.Name = "WithMoneyRadioBtn";
            this.WithMoneyRadioBtn.Size = new System.Drawing.Size(120, 24);
            this.WithMoneyRadioBtn.TabIndex = 2;
            this.WithMoneyRadioBtn.TabStop = true;
            this.WithMoneyRadioBtn.Text = "With money";
            this.WithMoneyRadioBtn.UseVisualStyleBackColor = true;
            this.WithMoneyRadioBtn.CheckedChanged += new System.EventHandler(this.WithMoneyRadioBtn_CheckedChanged);
            // 
            // WithLiterRadioBtn
            // 
            this.WithLiterRadioBtn.AutoSize = true;
            this.WithLiterRadioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WithLiterRadioBtn.Location = new System.Drawing.Point(279, 59);
            this.WithLiterRadioBtn.Name = "WithLiterRadioBtn";
            this.WithLiterRadioBtn.Size = new System.Drawing.Size(98, 24);
            this.WithLiterRadioBtn.TabIndex = 2;
            this.WithLiterRadioBtn.TabStop = true;
            this.WithLiterRadioBtn.Text = "With liter";
            this.WithLiterRadioBtn.UseVisualStyleBackColor = true;
            this.WithLiterRadioBtn.CheckedChanged += new System.EventHandler(this.WithLiterRadioBtn_CheckedChanged);
            // 
            // MoneyTxtb
            // 
            this.MoneyTxtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoneyTxtb.Location = new System.Drawing.Point(405, 29);
            this.MoneyTxtb.Name = "MoneyTxtb";
            this.MoneyTxtb.Size = new System.Drawing.Size(86, 26);
            this.MoneyTxtb.TabIndex = 3;
            this.MoneyTxtb.TextChanged += new System.EventHandler(this.MoneyTxtb_TextChanged);
            // 
            // LiterTxtb
            // 
            this.LiterTxtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LiterTxtb.Location = new System.Drawing.Point(405, 59);
            this.LiterTxtb.Name = "LiterTxtb";
            this.LiterTxtb.Size = new System.Drawing.Size(86, 26);
            this.LiterTxtb.TabIndex = 3;
            this.LiterTxtb.TextChanged += new System.EventHandler(this.LiterTxtb_TextChanged);
            // 
            // OilBuyLbl
            // 
            this.OilBuyLbl.AutoSize = true;
            this.OilBuyLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OilBuyLbl.Location = new System.Drawing.Point(118, 196);
            this.OilBuyLbl.Name = "OilBuyLbl";
            this.OilBuyLbl.Size = new System.Drawing.Size(102, 20);
            this.OilBuyLbl.TabIndex = 4;
            this.OilBuyLbl.Text = "You bought";
            // 
            // MustPayLbl
            // 
            this.MustPayLbl.AutoSize = true;
            this.MustPayLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MustPayLbl.Location = new System.Drawing.Point(118, 232);
            this.MustPayLbl.Name = "MustPayLbl";
            this.MustPayLbl.Size = new System.Drawing.Size(133, 20);
            this.MustPayLbl.TabIndex = 4;
            this.MustPayLbl.Text = "You must pay : ";
            // 
            // OilQuantityLbl
            // 
            this.OilQuantityLbl.AutoSize = true;
            this.OilQuantityLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OilQuantityLbl.Location = new System.Drawing.Point(248, 196);
            this.OilQuantityLbl.Name = "OilQuantityLbl";
            this.OilQuantityLbl.Size = new System.Drawing.Size(0, 20);
            this.OilQuantityLbl.TabIndex = 5;
            // 
            // OilNameLbl
            // 
            this.OilNameLbl.AutoSize = true;
            this.OilNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OilNameLbl.Location = new System.Drawing.Point(295, 196);
            this.OilNameLbl.Name = "OilNameLbl";
            this.OilNameLbl.Size = new System.Drawing.Size(39, 20);
            this.OilNameLbl.TabIndex = 5;
            this.OilNameLbl.Text = "liter";
            // 
            // PayLbl
            // 
            this.PayLbl.AutoSize = true;
            this.PayLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PayLbl.Location = new System.Drawing.Point(258, 238);
            this.PayLbl.Name = "PayLbl";
            this.PayLbl.Size = new System.Drawing.Size(0, 20);
            this.PayLbl.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Price";
            // 
            // PriceLbl
            // 
            this.PriceLbl.AutoSize = true;
            this.PriceLbl.Location = new System.Drawing.Point(100, 98);
            this.PriceLbl.Name = "PriceLbl";
            this.PriceLbl.Size = new System.Drawing.Size(0, 13);
            this.PriceLbl.TabIndex = 8;
            this.PriceLbl.TextChanged += new System.EventHandler(this.PriceLbl_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 261);
            this.Controls.Add(this.PriceLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PayLbl);
            this.Controls.Add(this.OilNameLbl);
            this.Controls.Add(this.OilQuantityLbl);
            this.Controls.Add(this.MustPayLbl);
            this.Controls.Add(this.OilBuyLbl);
            this.Controls.Add(this.LiterTxtb);
            this.Controls.Add(this.MoneyTxtb);
            this.Controls.Add(this.WithLiterRadioBtn);
            this.Controls.Add(this.WithMoneyRadioBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OilscomboBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox OilscomboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton WithMoneyRadioBtn;
        private System.Windows.Forms.RadioButton WithLiterRadioBtn;
        private System.Windows.Forms.TextBox MoneyTxtb;
        private System.Windows.Forms.TextBox LiterTxtb;
        private System.Windows.Forms.Label OilBuyLbl;
        private System.Windows.Forms.Label MustPayLbl;
        private System.Windows.Forms.Label OilQuantityLbl;
        private System.Windows.Forms.Label OilNameLbl;
        private System.Windows.Forms.Label PayLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label PriceLbl;
    }
}

