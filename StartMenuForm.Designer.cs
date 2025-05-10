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
            this.btnGoToLearn.Location = new System.Drawing.Point(268, 67);
            this.btnGoToLearn.Name = "btnGoToLearn";
            this.btnGoToLearn.Size = new System.Drawing.Size(231, 92);
            this.btnGoToLearn.TabIndex = 0;
            this.btnGoToLearn.Text = "Изучение";
            this.btnGoToLearn.UseVisualStyleBackColor = true;
            this.btnGoToLearn.Click += new System.EventHandler(this.btnGoToLearn_Click);
            // 
            // btnGoToManage
            // 
            this.btnGoToManage.Location = new System.Drawing.Point(268, 183);
            this.btnGoToManage.Name = "btnGoToManage";
            this.btnGoToManage.Size = new System.Drawing.Size(231, 89);
            this.btnGoToManage.TabIndex = 1;
            this.btnGoToManage.Text = "Карточки";
            this.btnGoToManage.UseVisualStyleBackColor = true;
            this.btnGoToManage.Click += new System.EventHandler(this.btnGoToManage_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(268, 298);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(231, 89);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Выйти";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // StartMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnGoToManage);
            this.Controls.Add(this.btnGoToLearn);
            this.Name = "StartMenuForm";
            this.Text = "Form2";
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