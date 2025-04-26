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
            this.tabLearn = new System.Windows.Forms.TabPage();
            this.dgvCards = new System.Windows.Forms.DataGridView();
            this.Word = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Translation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Add = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.textWord = new System.Windows.Forms.TextBox();
            this.textTranslation = new System.Windows.Forms.TextBox();
            this.labelWord = new System.Windows.Forms.Label();
            this.textTransAdd = new System.Windows.Forms.TextBox();
            this.buttonNextWord = new System.Windows.Forms.Button();
            this.buttonCheck = new System.Windows.Forms.Button();
            this.labelRes = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabManage.SuspendLayout();
            this.tabLearn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCards)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabManage);
            this.tabControl1.Controls.Add(this.tabLearn);
            this.tabControl1.Location = new System.Drawing.Point(12, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(808, 444);
            this.tabControl1.TabIndex = 0;
            // 
            // tabManage
            // 
            this.tabManage.Controls.Add(this.textTranslation);
            this.tabManage.Controls.Add(this.textWord);
            this.tabManage.Controls.Add(this.Delete);
            this.tabManage.Controls.Add(this.Add);
            this.tabManage.Controls.Add(this.dgvCards);
            this.tabManage.Location = new System.Drawing.Point(4, 25);
            this.tabManage.Name = "tabManage";
            this.tabManage.Padding = new System.Windows.Forms.Padding(3);
            this.tabManage.Size = new System.Drawing.Size(800, 415);
            this.tabManage.TabIndex = 0;
            this.tabManage.Text = "Управление";
            this.tabManage.UseVisualStyleBackColor = true;
            this.tabManage.Click += new System.EventHandler(this.tabManage_Click);
            // 
            // tabLearn
            // 
            this.tabLearn.Controls.Add(this.labelRes);
            this.tabLearn.Controls.Add(this.buttonCheck);
            this.tabLearn.Controls.Add(this.buttonNextWord);
            this.tabLearn.Controls.Add(this.textTransAdd);
            this.tabLearn.Controls.Add(this.labelWord);
            this.tabLearn.Location = new System.Drawing.Point(4, 25);
            this.tabLearn.Name = "tabLearn";
            this.tabLearn.Padding = new System.Windows.Forms.Padding(3);
            this.tabLearn.Size = new System.Drawing.Size(800, 415);
            this.tabLearn.TabIndex = 1;
            this.tabLearn.Text = "Изучение";
            this.tabLearn.UseVisualStyleBackColor = true;
            this.tabLearn.Click += new System.EventHandler(this.tabLearn_Click);
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
            this.Word,
            this.Translation});
            this.dgvCards.Location = new System.Drawing.Point(80, 71);
            this.dgvCards.Name = "dgvCards";
            this.dgvCards.RowHeadersWidth = 51;
            this.dgvCards.RowTemplate.Height = 24;
            this.dgvCards.Size = new System.Drawing.Size(635, 166);
            this.dgvCards.TabIndex = 0;
            this.dgvCards.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // Word
            // 
            this.Word.HeaderText = "Слово";
            this.Word.MinimumWidth = 6;
            this.Word.Name = "Word";
            // 
            // Translation
            // 
            this.Translation.HeaderText = "Перевод";
            this.Translation.MinimumWidth = 6;
            this.Translation.Name = "Translation";
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(218, 298);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(117, 42);
            this.Add.TabIndex = 1;
            this.Add.Text = "Добавить";
            this.Add.UseVisualStyleBackColor = true;
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(461, 299);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(121, 41);
            this.Delete.TabIndex = 2;
            this.Delete.Text = "Удалить";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.button2_Click);
            // 
            // textWord
            // 
            this.textWord.Location = new System.Drawing.Point(190, 243);
            this.textWord.Name = "textWord";
            this.textWord.Size = new System.Drawing.Size(100, 22);
            this.textWord.TabIndex = 3;
            // 
            // textTranslation
            // 
            this.textTranslation.Location = new System.Drawing.Point(461, 243);
            this.textTranslation.Name = "textTranslation";
            this.textTranslation.Size = new System.Drawing.Size(100, 22);
            this.textTranslation.TabIndex = 4;
            // 
            // labelWord
            // 
            this.labelWord.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelWord.Location = new System.Drawing.Point(343, 67);
            this.labelWord.Name = "labelWord";
            this.labelWord.Size = new System.Drawing.Size(132, 48);
            this.labelWord.TabIndex = 0;
            this.labelWord.Text = "word";
            // 
            // textTransAdd
            // 
            this.textTransAdd.Location = new System.Drawing.Point(213, 152);
            this.textTransAdd.Multiline = true;
            this.textTransAdd.Name = "textTransAdd";
            this.textTransAdd.Size = new System.Drawing.Size(344, 56);
            this.textTransAdd.TabIndex = 1;
            // 
            // buttonNextWord
            // 
            this.buttonNextWord.Location = new System.Drawing.Point(172, 287);
            this.buttonNextWord.Name = "buttonNextWord";
            this.buttonNextWord.Size = new System.Drawing.Size(205, 66);
            this.buttonNextWord.TabIndex = 2;
            this.buttonNextWord.Text = "Следующее слово";
            this.buttonNextWord.UseVisualStyleBackColor = true;
            this.buttonNextWord.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonCheck
            // 
            this.buttonCheck.Location = new System.Drawing.Point(415, 287);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(203, 66);
            this.buttonCheck.TabIndex = 3;
            this.buttonCheck.Text = "Проверить";
            this.buttonCheck.UseVisualStyleBackColor = true;
            // 
            // labelRes
            // 
            this.labelRes.AutoSize = true;
            this.labelRes.Location = new System.Drawing.Point(640, 212);
            this.labelRes.Name = "labelRes";
            this.labelRes.Size = new System.Drawing.Size(45, 16);
            this.labelRes.TabIndex = 4;
            this.labelRes.Text = "Result";
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
            this.tabLearn.ResumeLayout(false);
            this.tabLearn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCards)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabManage;
        private System.Windows.Forms.TabPage tabLearn;
        private System.Windows.Forms.DataGridView dgvCards;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.DataGridViewTextBoxColumn Word;
        private System.Windows.Forms.DataGridViewTextBoxColumn Translation;
        private System.Windows.Forms.TextBox textTranslation;
        private System.Windows.Forms.TextBox textWord;
        private System.Windows.Forms.Button buttonCheck;
        private System.Windows.Forms.Button buttonNextWord;
        private System.Windows.Forms.TextBox textTransAdd;
        private System.Windows.Forms.Label labelWord;
        private System.Windows.Forms.Label labelRes;
    }
}

