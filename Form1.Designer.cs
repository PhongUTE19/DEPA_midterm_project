
namespace DEPA_midterm_project
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
            this.picAvatar = new System.Windows.Forms.PictureBox();
            this.lblClassName = new System.Windows.Forms.Label();
            this.lblStats = new System.Windows.Forms.Label();
            this.btnWarrior = new System.Windows.Forms.Button();
            this.btnArcher = new System.Windows.Forms.Button();
            this.btnWizard = new System.Windows.Forms.Button();
            this.btnAssassin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // picAvatar
            // 
            this.picAvatar.Location = new System.Drawing.Point(12, 115);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(165, 157);
            this.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAvatar.TabIndex = 0;
            this.picAvatar.TabStop = false;
            // 
            // lblClassName
            // 
            this.lblClassName.AutoSize = true;
            this.lblClassName.Location = new System.Drawing.Point(197, 115);
            this.lblClassName.Name = "lblClassName";
            this.lblClassName.Size = new System.Drawing.Size(93, 17);
            this.lblClassName.TabIndex = 1;
            this.lblClassName.Text = "lblClassName";
            // 
            // lblStats
            // 
            this.lblStats.AutoSize = true;
            this.lblStats.Location = new System.Drawing.Point(219, 158);
            this.lblStats.Name = "lblStats";
            this.lblStats.Size = new System.Drawing.Size(54, 17);
            this.lblStats.TabIndex = 2;
            this.lblStats.Text = "lblStats";
            // 
            // btnWarrior
            // 
            this.btnWarrior.Location = new System.Drawing.Point(516, 70);
            this.btnWarrior.Name = "btnWarrior";
            this.btnWarrior.Size = new System.Drawing.Size(75, 23);
            this.btnWarrior.TabIndex = 3;
            this.btnWarrior.Text = "Warrior";
            this.btnWarrior.UseVisualStyleBackColor = true;
            this.btnWarrior.Click += new System.EventHandler(this.btnWarrior_Click);
            // 
            // btnArcher
            // 
            this.btnArcher.Location = new System.Drawing.Point(546, 109);
            this.btnArcher.Name = "btnArcher";
            this.btnArcher.Size = new System.Drawing.Size(75, 23);
            this.btnArcher.TabIndex = 4;
            this.btnArcher.Text = "Archer";
            this.btnArcher.UseVisualStyleBackColor = true;
            this.btnArcher.Click += new System.EventHandler(this.btnArcher_Click);
            // 
            // btnWizard
            // 
            this.btnWizard.Location = new System.Drawing.Point(516, 158);
            this.btnWizard.Name = "btnWizard";
            this.btnWizard.Size = new System.Drawing.Size(75, 23);
            this.btnWizard.TabIndex = 5;
            this.btnWizard.Text = "Wizard";
            this.btnWizard.UseVisualStyleBackColor = true;
            this.btnWizard.Click += new System.EventHandler(this.btnWizard_Click);
            // 
            // btnAssassin
            // 
            this.btnAssassin.Location = new System.Drawing.Point(516, 207);
            this.btnAssassin.Name = "btnAssassin";
            this.btnAssassin.Size = new System.Drawing.Size(75, 23);
            this.btnAssassin.TabIndex = 6;
            this.btnAssassin.Text = "Assassin";
            this.btnAssassin.UseVisualStyleBackColor = true;
            this.btnAssassin.Click += new System.EventHandler(this.btnAssassin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAssassin);
            this.Controls.Add(this.btnWizard);
            this.Controls.Add(this.btnArcher);
            this.Controls.Add(this.btnWarrior);
            this.Controls.Add(this.lblStats);
            this.Controls.Add(this.lblClassName);
            this.Controls.Add(this.picAvatar);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picAvatar;
        private System.Windows.Forms.Label lblClassName;
        private System.Windows.Forms.Label lblStats;
        private System.Windows.Forms.Button btnWarrior;
        private System.Windows.Forms.Button btnArcher;
        private System.Windows.Forms.Button btnWizard;
        private System.Windows.Forms.Button btnAssassin;
    }
}

