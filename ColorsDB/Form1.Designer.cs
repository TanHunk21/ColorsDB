namespace ColorsDB
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
            this.label1 = new System.Windows.Forms.Label();
            this.listColors = new System.Windows.Forms.ListBox();
            this.listColorNames = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Colors";
            // 
            // listColors
            // 
            this.listColors.FormattingEnabled = true;
            this.listColors.Location = new System.Drawing.Point(109, 102);
            this.listColors.Name = "listColors";
            this.listColors.Size = new System.Drawing.Size(120, 95);
            this.listColors.TabIndex = 1;
            this.listColors.SelectedIndexChanged += new System.EventHandler(this.listColors_SelectedIndexChanged);
            // 
            // listColorNames
            // 
            this.listColorNames.FormattingEnabled = true;
            this.listColorNames.Location = new System.Drawing.Point(326, 102);
            this.listColorNames.Name = "listColorNames";
            this.listColorNames.Size = new System.Drawing.Size(120, 95);
            this.listColorNames.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(326, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Shades";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listColorNames);
            this.Controls.Add(this.listColors);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listColors;
        private System.Windows.Forms.ListBox listColorNames;
        private System.Windows.Forms.Label label2;
    }
}

