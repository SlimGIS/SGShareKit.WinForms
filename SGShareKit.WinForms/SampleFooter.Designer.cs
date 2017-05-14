namespace SlimGis.ShareKit.Winforms
{
    partial class SampleFooter
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.questionButton = new System.Windows.Forms.Button();
            this.contactButton = new System.Windows.Forms.Button();
            this.learnButton = new System.Windows.Forms.Button();
            this.homeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // questionButton
            // 
            this.questionButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.questionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.questionButton.ForeColor = System.Drawing.Color.White;
            this.questionButton.Image = global::SlimGis.ShareKit.WinForms.Properties.Resources.question;
            this.questionButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.questionButton.Location = new System.Drawing.Point(13, 6);
            this.questionButton.Name = "questionButton";
            this.questionButton.Padding = new System.Windows.Forms.Padding(2);
            this.questionButton.Size = new System.Drawing.Size(144, 38);
            this.questionButton.TabIndex = 0;
            this.questionButton.Text = "Has question";
            this.questionButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.questionButton.UseVisualStyleBackColor = false;
            this.questionButton.Click += new System.EventHandler(this.QuestionButton_Click);
            // 
            // contactButton
            // 
            this.contactButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.contactButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.contactButton.ForeColor = System.Drawing.Color.White;
            this.contactButton.Image = global::SlimGis.ShareKit.WinForms.Properties.Resources.contact;
            this.contactButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.contactButton.Location = new System.Drawing.Point(163, 6);
            this.contactButton.Name = "contactButton";
            this.contactButton.Padding = new System.Windows.Forms.Padding(2);
            this.contactButton.Size = new System.Drawing.Size(133, 38);
            this.contactButton.TabIndex = 1;
            this.contactButton.Text = "Contact us";
            this.contactButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.contactButton.UseVisualStyleBackColor = false;
            this.contactButton.Click += new System.EventHandler(this.ContactButton_Click);
            // 
            // learnButton
            // 
            this.learnButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.learnButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.learnButton.ForeColor = System.Drawing.Color.White;
            this.learnButton.Image = global::SlimGis.ShareKit.WinForms.Properties.Resources.learnmore;
            this.learnButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.learnButton.Location = new System.Drawing.Point(302, 6);
            this.learnButton.Name = "learnButton";
            this.learnButton.Padding = new System.Windows.Forms.Padding(2);
            this.learnButton.Size = new System.Drawing.Size(136, 38);
            this.learnButton.TabIndex = 2;
            this.learnButton.Text = "Learn more";
            this.learnButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.learnButton.UseVisualStyleBackColor = false;
            this.learnButton.Click += new System.EventHandler(this.LearnButton_Click);
            // 
            // homeButton
            // 
            this.homeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.homeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeButton.ForeColor = System.Drawing.Color.White;
            this.homeButton.Image = global::SlimGis.ShareKit.WinForms.Properties.Resources.home;
            this.homeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homeButton.Location = new System.Drawing.Point(444, 6);
            this.homeButton.Name = "homeButton";
            this.homeButton.Padding = new System.Windows.Forms.Padding(2);
            this.homeButton.Size = new System.Drawing.Size(150, 38);
            this.homeButton.TabIndex = 3;
            this.homeButton.Text = "SlimGIS Home";
            this.homeButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.homeButton.UseVisualStyleBackColor = false;
            this.homeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // Footer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.Controls.Add(this.homeButton);
            this.Controls.Add(this.learnButton);
            this.Controls.Add(this.contactButton);
            this.Controls.Add(this.questionButton);
            this.Name = "Footer";
            this.Size = new System.Drawing.Size(852, 53);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button questionButton;
        private System.Windows.Forms.Button contactButton;
        private System.Windows.Forms.Button learnButton;
        private System.Windows.Forms.Button homeButton;
    }
}
