
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
            this.btnFighter = new System.Windows.Forms.Button();
            this.btnRanger = new System.Windows.Forms.Button();
            this.btnWizard = new System.Windows.Forms.Button();
            this.btnRogue = new System.Windows.Forms.Button();
            this.btnCleric = new System.Windows.Forms.Button();
            this.btnTakeAction = new System.Windows.Forms.Button();
            this.lblAction = new System.Windows.Forms.Label();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.rightPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.leftPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // picAvatar
            // 
            this.picAvatar.Location = new System.Drawing.Point(38, 70);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(235, 302);
            this.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAvatar.TabIndex = 0;
            this.picAvatar.TabStop = false;
            // 
            // lblClassName
            // 
            this.lblClassName.AutoSize = true;
            this.lblClassName.Font = new System.Drawing.Font("Ink Free", 18F, System.Drawing.FontStyle.Bold);
            this.lblClassName.Location = new System.Drawing.Point(33, 26);
            this.lblClassName.Name = "lblClassName";
            this.lblClassName.Size = new System.Drawing.Size(94, 37);
            this.lblClassName.TabIndex = 1;
            this.lblClassName.Text = "Name";
            // 
            // lblStats
            // 
            this.lblStats.AutoSize = true;
            this.lblStats.Font = new System.Drawing.Font("Ink Free", 14F);
            this.lblStats.Location = new System.Drawing.Point(309, 70);
            this.lblStats.Name = "lblStats";
            this.lblStats.Size = new System.Drawing.Size(74, 30);
            this.lblStats.TabIndex = 2;
            this.lblStats.Text = "Stats";
            // 
            // btnFighter
            // 
            this.btnFighter.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold);
            this.btnFighter.Location = new System.Drawing.Point(119, 70);
            this.btnFighter.Name = "btnFighter";
            this.btnFighter.Size = new System.Drawing.Size(122, 38);
            this.btnFighter.TabIndex = 3;
            this.btnFighter.Text = "Fighter";
            this.btnFighter.UseVisualStyleBackColor = true;
            this.btnFighter.Click += new System.EventHandler(this.btnFighter_Click);
            // 
            // btnRanger
            // 
            this.btnRanger.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold);
            this.btnRanger.Location = new System.Drawing.Point(119, 114);
            this.btnRanger.Name = "btnRanger";
            this.btnRanger.Size = new System.Drawing.Size(122, 38);
            this.btnRanger.TabIndex = 4;
            this.btnRanger.Text = "Ranger";
            this.btnRanger.UseVisualStyleBackColor = true;
            this.btnRanger.Click += new System.EventHandler(this.btnRanger_Click);
            // 
            // btnWizard
            // 
            this.btnWizard.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold);
            this.btnWizard.Location = new System.Drawing.Point(119, 158);
            this.btnWizard.Name = "btnWizard";
            this.btnWizard.Size = new System.Drawing.Size(122, 38);
            this.btnWizard.TabIndex = 5;
            this.btnWizard.Text = "Wizard";
            this.btnWizard.UseVisualStyleBackColor = true;
            this.btnWizard.Click += new System.EventHandler(this.btnWizard_Click);
            // 
            // btnRogue
            // 
            this.btnRogue.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold);
            this.btnRogue.Location = new System.Drawing.Point(119, 202);
            this.btnRogue.Name = "btnRogue";
            this.btnRogue.Size = new System.Drawing.Size(122, 38);
            this.btnRogue.TabIndex = 6;
            this.btnRogue.Text = "Rogue";
            this.btnRogue.UseVisualStyleBackColor = true;
            this.btnRogue.Click += new System.EventHandler(this.btnRogue_Click);
            // 
            // btnCleric
            // 
            this.btnCleric.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold);
            this.btnCleric.Location = new System.Drawing.Point(119, 246);
            this.btnCleric.Name = "btnCleric";
            this.btnCleric.Size = new System.Drawing.Size(122, 38);
            this.btnCleric.TabIndex = 7;
            this.btnCleric.Text = "Cleric";
            this.btnCleric.UseVisualStyleBackColor = true;
            this.btnCleric.Click += new System.EventHandler(this.btnCleric_Click);
            // 
            // btnTakeAction
            // 
            this.btnTakeAction.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold);
            this.btnTakeAction.Location = new System.Drawing.Point(80, 334);
            this.btnTakeAction.Name = "btnTakeAction";
            this.btnTakeAction.Size = new System.Drawing.Size(201, 38);
            this.btnTakeAction.TabIndex = 8;
            this.btnTakeAction.Text = "Take Action";
            this.btnTakeAction.UseVisualStyleBackColor = true;
            this.btnTakeAction.Click += new System.EventHandler(this.btnTakeAction_Click);
            // 
            // lblAction
            // 
            this.lblAction.AutoSize = true;
            this.lblAction.Font = new System.Drawing.Font("Ink Free", 18F, System.Drawing.FontStyle.Italic);
            this.lblAction.Location = new System.Drawing.Point(31, 381);
            this.lblAction.Name = "lblAction";
            this.lblAction.Size = new System.Drawing.Size(226, 37);
            this.lblAction.TabIndex = 9;
            this.lblAction.Text = "hihihihihihhihihi";
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(237)))));
            this.leftPanel.Controls.Add(this.lblAction);
            this.leftPanel.Controls.Add(this.lblClassName);
            this.leftPanel.Controls.Add(this.lblStats);
            this.leftPanel.Controls.Add(this.picAvatar);
            this.leftPanel.Location = new System.Drawing.Point(10, 10);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(500, 431);
            this.leftPanel.TabIndex = 10;
            // 
            // rightPanel
            // 
            this.rightPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(185)))), ((int)(((byte)(235)))));
            this.rightPanel.Controls.Add(this.btnFighter);
            this.rightPanel.Controls.Add(this.btnTakeAction);
            this.rightPanel.Controls.Add(this.btnRanger);
            this.rightPanel.Controls.Add(this.btnCleric);
            this.rightPanel.Controls.Add(this.btnWizard);
            this.rightPanel.Controls.Add(this.btnRogue);
            this.rightPanel.Location = new System.Drawing.Point(520, 10);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(350, 431);
            this.rightPanel.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 453);
            this.Controls.Add(this.leftPanel);
            this.Controls.Add(this.rightPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.rightPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picAvatar;
        private System.Windows.Forms.Label lblClassName;
        private System.Windows.Forms.Label lblStats;
        private System.Windows.Forms.Button btnFighter;
        private System.Windows.Forms.Button btnRanger;
        private System.Windows.Forms.Button btnWizard;
        private System.Windows.Forms.Button btnRogue;
        private System.Windows.Forms.Button btnCleric;
        private System.Windows.Forms.Button btnTakeAction;
        private System.Windows.Forms.Label lblAction;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Panel rightPanel;
    }
}

