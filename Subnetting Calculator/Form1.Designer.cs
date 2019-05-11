namespace Subnetting_Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.firstOctectTxtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.scondOctectTxtBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.thirdOctectTxtBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.fourthOctectTxtBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.maskTxtBox = new System.Windows.Forms.TextBox();
            this.subnettingTypeComboBox = new System.Windows.Forms.ComboBox();
            this.numberRequestedTxtBox = new System.Windows.Forms.TextBox();
            this.calculateBtn = new System.Windows.Forms.Button();
            this.resultTxtBox = new System.Windows.Forms.RichTextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Network Adress: ";
            // 
            // firstOctectTxtBox
            // 
            this.firstOctectTxtBox.Location = new System.Drawing.Point(130, 6);
            this.firstOctectTxtBox.Margin = new System.Windows.Forms.Padding(2);
            this.firstOctectTxtBox.MaxLength = 3;
            this.firstOctectTxtBox.Name = "firstOctectTxtBox";
            this.firstOctectTxtBox.Size = new System.Drawing.Size(31, 20);
            this.firstOctectTxtBox.TabIndex = 1;
            this.firstOctectTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.firstOctectTxtBox_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = ".";
            // 
            // scondOctectTxtBox
            // 
            this.scondOctectTxtBox.Location = new System.Drawing.Point(178, 6);
            this.scondOctectTxtBox.Margin = new System.Windows.Forms.Padding(2);
            this.scondOctectTxtBox.MaxLength = 3;
            this.scondOctectTxtBox.Name = "scondOctectTxtBox";
            this.scondOctectTxtBox.Size = new System.Drawing.Size(31, 20);
            this.scondOctectTxtBox.TabIndex = 3;
            this.scondOctectTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.scondOctectTxtBox_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(213, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = ".";
            // 
            // thirdOctectTxtBox
            // 
            this.thirdOctectTxtBox.Location = new System.Drawing.Point(226, 6);
            this.thirdOctectTxtBox.Margin = new System.Windows.Forms.Padding(2);
            this.thirdOctectTxtBox.MaxLength = 3;
            this.thirdOctectTxtBox.Name = "thirdOctectTxtBox";
            this.thirdOctectTxtBox.Size = new System.Drawing.Size(31, 20);
            this.thirdOctectTxtBox.TabIndex = 5;
            this.thirdOctectTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.thirdOctectTxtBox_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(261, 11);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = ".";
            // 
            // fourthOctectTxtBox
            // 
            this.fourthOctectTxtBox.Location = new System.Drawing.Point(274, 6);
            this.fourthOctectTxtBox.Margin = new System.Windows.Forms.Padding(2);
            this.fourthOctectTxtBox.MaxLength = 3;
            this.fourthOctectTxtBox.Name = "fourthOctectTxtBox";
            this.fourthOctectTxtBox.Size = new System.Drawing.Size(31, 20);
            this.fourthOctectTxtBox.TabIndex = 7;
            this.fourthOctectTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fourthOctectTxtBox_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(309, 11);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(12, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "/";
            // 
            // maskTxtBox
            // 
            this.maskTxtBox.Location = new System.Drawing.Point(322, 6);
            this.maskTxtBox.Margin = new System.Windows.Forms.Padding(2);
            this.maskTxtBox.MaxLength = 2;
            this.maskTxtBox.Name = "maskTxtBox";
            this.maskTxtBox.Size = new System.Drawing.Size(31, 20);
            this.maskTxtBox.TabIndex = 9;
            this.maskTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maskTxtBox_KeyPress);
            // 
            // subnettingTypeComboBox
            // 
            this.subnettingTypeComboBox.FormattingEnabled = true;
            this.subnettingTypeComboBox.Items.AddRange(new object[] {
            "Subnetworks",
            "Hosts"});
            this.subnettingTypeComboBox.Location = new System.Drawing.Point(43, 51);
            this.subnettingTypeComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.subnettingTypeComboBox.Name = "subnettingTypeComboBox";
            this.subnettingTypeComboBox.Size = new System.Drawing.Size(85, 21);
            this.subnettingTypeComboBox.TabIndex = 10;
            // 
            // numberRequestedTxtBox
            // 
            this.numberRequestedTxtBox.Location = new System.Drawing.Point(132, 53);
            this.numberRequestedTxtBox.Margin = new System.Windows.Forms.Padding(2);
            this.numberRequestedTxtBox.MaxLength = 4;
            this.numberRequestedTxtBox.Name = "numberRequestedTxtBox";
            this.numberRequestedTxtBox.Size = new System.Drawing.Size(31, 20);
            this.numberRequestedTxtBox.TabIndex = 11;
            this.numberRequestedTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberRequestedTxtBox_KeyPress);
            // 
            // calculateBtn
            // 
            this.calculateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateBtn.Location = new System.Drawing.Point(139, 374);
            this.calculateBtn.Margin = new System.Windows.Forms.Padding(2);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(112, 29);
            this.calculateBtn.TabIndex = 12;
            this.calculateBtn.Text = "Calculate!";
            this.calculateBtn.UseVisualStyleBackColor = true;
            this.calculateBtn.Click += new System.EventHandler(this.calculateBtn_Click);
            // 
            // resultTxtBox
            // 
            this.resultTxtBox.Location = new System.Drawing.Point(13, 95);
            this.resultTxtBox.Margin = new System.Windows.Forms.Padding(2);
            this.resultTxtBox.Name = "resultTxtBox";
            this.resultTxtBox.ReadOnly = true;
            this.resultTxtBox.Size = new System.Drawing.Size(351, 256);
            this.resultTxtBox.TabIndex = 13;
            this.resultTxtBox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 423);
            this.Controls.Add(this.resultTxtBox);
            this.Controls.Add(this.calculateBtn);
            this.Controls.Add(this.numberRequestedTxtBox);
            this.Controls.Add(this.subnettingTypeComboBox);
            this.Controls.Add(this.maskTxtBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.fourthOctectTxtBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.thirdOctectTxtBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.scondOctectTxtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.firstOctectTxtBox);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Subnetting Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox firstOctectTxtBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox scondOctectTxtBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox thirdOctectTxtBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox fourthOctectTxtBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox maskTxtBox;
        private System.Windows.Forms.ComboBox subnettingTypeComboBox;
        private System.Windows.Forms.TextBox numberRequestedTxtBox;
        private System.Windows.Forms.Button calculateBtn;
        private System.Windows.Forms.RichTextBox resultTxtBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

