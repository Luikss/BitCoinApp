
namespace BitCoinApp
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
            this.currencyCombo = new System.Windows.Forms.ComboBox();
            this.btnGetRates = new System.Windows.Forms.Button();
            this.amountOfCoinBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // currencyCombo
            // 
            this.currencyCombo.FormattingEnabled = true;
            this.currencyCombo.Items.AddRange(new object[] {
            "EUR",
            "USD",
            "GBP"});
            this.currencyCombo.Location = new System.Drawing.Point(68, 109);
            this.currencyCombo.Name = "currencyCombo";
            this.currencyCombo.Size = new System.Drawing.Size(121, 21);
            this.currencyCombo.TabIndex = 0;
            this.currencyCombo.Text = "Select Currency";
            // 
            // btnGetRates
            // 
            this.btnGetRates.Location = new System.Drawing.Point(228, 109);
            this.btnGetRates.Name = "btnGetRates";
            this.btnGetRates.Size = new System.Drawing.Size(75, 23);
            this.btnGetRates.TabIndex = 1;
            this.btnGetRates.Text = "Get Rates";
            this.btnGetRates.UseVisualStyleBackColor = true;
            this.btnGetRates.Click += new System.EventHandler(this.btnGetRates_Click);
            // 
            // amountOfCoinBox
            // 
            this.amountOfCoinBox.Location = new System.Drawing.Point(68, 193);
            this.amountOfCoinBox.Name = "amountOfCoinBox";
            this.amountOfCoinBox.Size = new System.Drawing.Size(100, 20);
            this.amountOfCoinBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(72, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Amount of BitCoins";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.BackColor = System.Drawing.Color.Transparent;
            this.resultLabel.Location = new System.Drawing.Point(72, 239);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(37, 13);
            this.resultLabel.TabIndex = 4;
            this.resultLabel.Text = "Result";
            this.resultLabel.Visible = false;
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(68, 256);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(100, 20);
            this.resultTextBox.TabIndex = 5;
            this.resultTextBox.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.amountOfCoinBox);
            this.Controls.Add(this.btnGetRates);
            this.Controls.Add(this.currencyCombo);
            this.Name = "Form1";
            this.Text = "BitCoin Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox currencyCombo;
        private System.Windows.Forms.Button btnGetRates;
        private System.Windows.Forms.TextBox amountOfCoinBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.TextBox resultTextBox;
    }
}

