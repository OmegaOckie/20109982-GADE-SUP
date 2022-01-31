
namespace _20109982_GADE_SUP
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
            this.heroLabel = new System.Windows.Forms.Label();
            this.mapLabel = new System.Windows.Forms.Label();
            this.enemyRTB = new System.Windows.Forms.RichTextBox();
            this.shopCB = new System.Windows.Forms.ComboBox();
            this.attackButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.buyButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // heroLabel
            // 
            this.heroLabel.AutoSize = true;
            this.heroLabel.Location = new System.Drawing.Point(13, 13);
            this.heroLabel.Name = "heroLabel";
            this.heroLabel.Size = new System.Drawing.Size(54, 13);
            this.heroLabel.TabIndex = 0;
            this.heroLabel.Text = "heroLabel";
            // 
            // mapLabel
            // 
            this.mapLabel.AutoSize = true;
            this.mapLabel.Location = new System.Drawing.Point(237, 13);
            this.mapLabel.Name = "mapLabel";
            this.mapLabel.Size = new System.Drawing.Size(35, 13);
            this.mapLabel.TabIndex = 1;
            this.mapLabel.Text = "label1";
            // 
            // enemyRTB
            // 
            this.enemyRTB.Location = new System.Drawing.Point(13, 342);
            this.enemyRTB.Name = "enemyRTB";
            this.enemyRTB.Size = new System.Drawing.Size(100, 96);
            this.enemyRTB.TabIndex = 2;
            this.enemyRTB.Text = "";
            // 
            // shopCB
            // 
            this.shopCB.FormattingEnabled = true;
            this.shopCB.Location = new System.Drawing.Point(12, 186);
            this.shopCB.Name = "shopCB";
            this.shopCB.Size = new System.Drawing.Size(121, 21);
            this.shopCB.TabIndex = 3;
            // 
            // attackButton
            // 
            this.attackButton.Location = new System.Drawing.Point(13, 313);
            this.attackButton.Name = "attackButton";
            this.attackButton.Size = new System.Drawing.Size(75, 23);
            this.attackButton.TabIndex = 4;
            this.attackButton.Text = "Attack";
            this.attackButton.UseVisualStyleBackColor = true;
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(713, 415);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(75, 23);
            this.loadButton.TabIndex = 5;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(632, 415);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // buyButton
            // 
            this.buyButton.Location = new System.Drawing.Point(140, 186);
            this.buyButton.Name = "buyButton";
            this.buyButton.Size = new System.Drawing.Size(75, 23);
            this.buyButton.TabIndex = 7;
            this.buyButton.Text = "Buy";
            this.buyButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buyButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.attackButton);
            this.Controls.Add(this.shopCB);
            this.Controls.Add(this.enemyRTB);
            this.Controls.Add(this.mapLabel);
            this.Controls.Add(this.heroLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label heroLabel;
        private System.Windows.Forms.Label mapLabel;
        private System.Windows.Forms.RichTextBox enemyRTB;
        private System.Windows.Forms.ComboBox shopCB;
        private System.Windows.Forms.Button attackButton;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button buyButton;
    }
}

