using System;
using System.Collections.Generic;

namespace language_app
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabManage = new System.Windows.Forms.TabPage();
            this.txtTranslation = new System.Windows.Forms.TextBox();
            this.txtWord = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvCards = new System.Windows.Forms.DataGridView();
            this.clmn_Word = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmn_Translation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabLearn = new System.Windows.Forms.TabPage();
            this.lblRes = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnNextWord = new System.Windows.Forms.Button();
            this.txtTransAdd = new System.Windows.Forms.TextBox();
            this.lblWord = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabManage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCards)).BeginInit();
            this.tabLearn.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabManage);
            this.tabControl1.Controls.Add(this.tabLearn);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(813, 434);
            this.tabControl1.TabIndex = 0;
            // 
            // tabManage
            // 
            this.tabManage.Controls.Add(this.txtTranslation);
            this.tabManage.Controls.Add(this.txtWord);
            this.tabManage.Controls.Add(this.btnDelete);
            this.tabManage.Controls.Add(this.btnAdd);
            this.tabManage.Controls.Add(this.dgvCards);
            this.tabManage.Location = new System.Drawing.Point(4, 25);
            this.tabManage.Name = "tabManage";
            this.tabManage.Padding = new System.Windows.Forms.Padding(3);
            this.tabManage.Size = new System.Drawing.Size(805, 405);
            this.tabManage.TabIndex = 0;
            this.tabManage.Text = "Управление";
            this.tabManage.UseVisualStyleBackColor = true;
            this.tabManage.Click += new System.EventHandler(this.tabManage_Click);
            // 
            // txtTranslation
            // 
            this.txtTranslation.Location = new System.Drawing.Point(461, 243);
            this.txtTranslation.Multiline = true;
            this.txtTranslation.Name = "txtTranslation";
            this.txtTranslation.Size = new System.Drawing.Size(168, 36);
            this.txtTranslation.TabIndex = 4;
            // 
            // txtWord
            // 
            this.txtWord.Location = new System.Drawing.Point(176, 243);
            this.txtWord.Multiline = true;
            this.txtWord.Name = "txtWord";
            this.txtWord.Size = new System.Drawing.Size(160, 36);
            this.txtWord.TabIndex = 3;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(461, 285);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(168, 69);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(176, 285);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(160, 69);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvCards
            // 
            this.dgvCards.AllowUserToAddRows = false;
            this.dgvCards.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCards.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCards.BackgroundColor = System.Drawing.Color.Orange;
            this.dgvCards.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCards.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmn_Word,
            this.clmn_Translation});
            this.dgvCards.Location = new System.Drawing.Point(80, 38);
            this.dgvCards.Name = "dgvCards";
            this.dgvCards.RowHeadersWidth = 51;
            this.dgvCards.RowTemplate.Height = 24;
            this.dgvCards.Size = new System.Drawing.Size(651, 189);
            this.dgvCards.TabIndex = 0;
            this.dgvCards.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // clmn_Word
            // 
            this.clmn_Word.HeaderText = "Слово";
            this.clmn_Word.MinimumWidth = 6;
            this.clmn_Word.Name = "clmn_Word";
            // 
            // clmn_Translation
            // 
            this.clmn_Translation.HeaderText = "Перевод";
            this.clmn_Translation.MinimumWidth = 6;
            this.clmn_Translation.Name = "clmn_Translation";
            // 
            // tabLearn
            // 
            this.tabLearn.Controls.Add(this.lblRes);
            this.tabLearn.Controls.Add(this.btnCheck);
            this.tabLearn.Controls.Add(this.btnNextWord);
            this.tabLearn.Controls.Add(this.txtTransAdd);
            this.tabLearn.Controls.Add(this.lblWord);
            this.tabLearn.Location = new System.Drawing.Point(4, 25);
            this.tabLearn.Name = "tabLearn";
            this.tabLearn.Padding = new System.Windows.Forms.Padding(3);
            this.tabLearn.Size = new System.Drawing.Size(805, 405);
            this.tabLearn.TabIndex = 1;
            this.tabLearn.Text = "Изучение";
            this.tabLearn.UseVisualStyleBackColor = true;
            this.tabLearn.Click += new System.EventHandler(this.tabLearn_Click);
            // 
            // lblRes
            // 
            this.lblRes.AutoSize = true;
            this.lblRes.Location = new System.Drawing.Point(667, 58);
            this.lblRes.Name = "lblRes";
            this.lblRes.Size = new System.Drawing.Size(45, 16);
            this.lblRes.TabIndex = 4;
            this.lblRes.Text = "Result";
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(132, 242);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(203, 66);
            this.btnCheck.TabIndex = 3;
            this.btnCheck.Text = "Проверить";
            this.btnCheck.UseVisualStyleBackColor = true;
            // 
            // btnNextWord
            // 
            this.btnNextWord.Location = new System.Drawing.Point(532, 242);
            this.btnNextWord.Name = "btnNextWord";
            this.btnNextWord.Size = new System.Drawing.Size(205, 66);
            this.btnNextWord.TabIndex = 2;
            this.btnNextWord.Text = "Следующее слово";
            this.btnNextWord.UseVisualStyleBackColor = true;
            this.btnNextWord.Click += new System.EventHandler(this.btnNextWord_Click);
            // 
            // txtTransAdd
            // 
            this.txtTransAdd.Location = new System.Drawing.Point(247, 152);
            this.txtTransAdd.Multiline = true;
            this.txtTransAdd.Name = "txtTransAdd";
            this.txtTransAdd.Size = new System.Drawing.Size(344, 56);
            this.txtTransAdd.TabIndex = 1;
            // 
            // lblWord
            // 
            this.lblWord.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWord.AutoSize = true;
            this.lblWord.Font = new System.Drawing.Font("Javanese Text", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWord.Location = new System.Drawing.Point(350, 58);
            this.lblWord.Name = "lblWord";
            this.lblWord.Size = new System.Drawing.Size(130, 91);
            this.lblWord.TabIndex = 0;
            this.lblWord.Text = "word";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(829, 450);
            this.Controls.Add(this.tabControl1);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::language_app.Properties.Settings.Default, "Управление", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = global::language_app.Properties.Settings.Default.Управление;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabManage.ResumeLayout(false);
            this.tabManage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCards)).EndInit();
            this.tabLearn.ResumeLayout(false);
            this.tabLearn.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabManage;
        private System.Windows.Forms.TabPage tabLearn;
        private System.Windows.Forms.DataGridView dgvCards;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtTranslation;
        private System.Windows.Forms.TextBox txtWord;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnNextWord;
        private System.Windows.Forms.TextBox txtTransAdd;
        private System.Windows.Forms.Label lblWord;
        private System.Windows.Forms.Label lblRes;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_Word;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_Translation;
    }
}

