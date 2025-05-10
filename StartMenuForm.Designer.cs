namespace language_app
{
    partial class StartMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartMenuForm));
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.btnGoToLearn = new System.Windows.Forms.Button();
            this.btnGoToManage = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // btnGoToLearn
            // 
            this.btnGoToLearn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGoToLearn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(96)))), ((int)(((byte)(127)))));
            this.btnGoToLearn.FlatAppearance.BorderSize = 0;
            this.btnGoToLearn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoToLearn.Font = new System.Drawing.Font("Franklin Gothic Medium", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGoToLearn.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnGoToLearn.Location = new System.Drawing.Point(268, 67);
            this.btnGoToLearn.MaximumSize = new System.Drawing.Size(231, 92);
            this.btnGoToLearn.Name = "btnGoToLearn";
            this.btnGoToLearn.Size = new System.Drawing.Size(231, 92);
            this.btnGoToLearn.TabIndex = 0;
            this.btnGoToLearn.Text = "Изучение";
            this.btnGoToLearn.UseVisualStyleBackColor = false;
            this.btnGoToLearn.Click += new System.EventHandler(this.btnGoToLearn_Click);
            // 
            // btnGoToManage
            // 
            this.btnGoToManage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGoToManage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(96)))), ((int)(((byte)(127)))));
            this.btnGoToManage.FlatAppearance.BorderSize = 0;
            this.btnGoToManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoToManage.Font = new System.Drawing.Font("Franklin Gothic Medium", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGoToManage.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnGoToManage.Location = new System.Drawing.Point(268, 183);
            this.btnGoToManage.MaximumSize = new System.Drawing.Size(231, 92);
            this.btnGoToManage.Name = "btnGoToManage";
            this.btnGoToManage.Size = new System.Drawing.Size(231, 89);
            this.btnGoToManage.TabIndex = 1;
            this.btnGoToManage.Text = "Карточки";
            this.btnGoToManage.UseVisualStyleBackColor = false;
            this.btnGoToManage.Click += new System.EventHandler(this.btnGoToManage_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(96)))), ((int)(((byte)(127)))));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Franklin Gothic Medium", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnExit.Location = new System.Drawing.Point(268, 298);
            this.btnExit.MaximumSize = new System.Drawing.Size(231, 86);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(231, 86);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Выйти";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // StartMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(216)))), ((int)(((byte)(201)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnGoToManage);
            this.Controls.Add(this.btnGoToLearn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "StartMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Study Flashcards";
            this.Load += new System.EventHandler(this.StartMenuForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Button btnGoToManage;
        private System.Windows.Forms.Button btnGoToLearn;
        private System.Windows.Forms.Button btnExit;
    }
}