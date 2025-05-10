using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace language_app
{
    public partial class Form1: Form
    {
        private List <Wordcard> _wordcards = new List <Wordcard> ();  
        private Wordcard _currentCard;
        private int _correctInRow;
        private Random random = new Random ();
        private readonly WordcardRepository _repository;
        public Form1()
        {
            InitializeComponent();

            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.ItemSize = new Size(0, 1);  
            tabControl1.SizeMode = TabSizeMode.Fixed;
            tabControl1.Multiline = false;         
            tabControl1.Selecting += (sender, e) => e.Cancel = true;

            string exePath = Application.StartupPath;
            string jsonPath = Path.Combine(exePath, "Data", "wordcards.json");
            Directory.CreateDirectory(Path.GetDirectoryName(jsonPath));
            _repository = new WordcardRepository (jsonPath);
            UpdateDataGridView();
        }
        public bool HasCards()
        {
            return _repository.GetAll()?.Any() == true;
        }
        private void UpdateDataGridView()
        {
            dgvCards.DataSource = null;
            dgvCards.Columns.Clear();

            var data = _repository?.GetAll() ?? new List<Wordcard>();
            dgvCards.DataSource = data;

            if (dgvCards.Columns.Contains("Word"))
            {
                dgvCards.Columns["Word"].HeaderText = "Слово";
            }

            if (dgvCards.Columns.Contains("Translation"))
            {
                dgvCards.Columns["Translation"].HeaderText = "Перевод";
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void tabManage_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
                // Проверка: Не пустые ли поля?
                if (string.IsNullOrWhiteSpace(txtWord.Text) || string.IsNullOrWhiteSpace(txtTranslation.Text))
                {
                    MessageBox.Show("Введите слово и перевод!");
                    return;
                }
                var newCard = new Wordcard(txtWord.Text, txtTranslation.Text);

                // Проверка: Успешно ли создана карточка?
                if (newCard == null)
                {
                    MessageBox.Show("Не удалось создать карточку!");
                    return;
                }
                _repository.Add(newCard);
                //MessageBox.Show($"Карточек теперь: {_repository.GetAll().Count}"); // Проверка
                UpdateDataGridView();
                txtWord.Clear();
                txtTranslation.Clear();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvCards.SelectedRows.Count > 0)
            {
                int index = dgvCards.SelectedRows[0].Index;
                _repository.Delete(index);
                UpdateDataGridView();
            }
            else
            {
                MessageBox.Show("Выберите карту для удаления");
            }

        }
        public void ShowManageTab()
        {
            tabControl1.SelectedTab = tabManage;
            this.Show();
        }
        public void ShowLearnTab()
        {
            tabControl1.SelectedTab = tabLearn;
            this.Show();
            StartLearningSession();
        }
        public void StartLearningSession()
        {
            if (_repository.GetAll().Count == 0)
            {
                MessageBox.Show("Добавьте карточки для обучения!");
                return;
            }
            // очередь обучения
            _wordcards = _repository.GetAll()
                .OrderBy(x => x.CorrectAnswers)
                .ThenBy(x => x.LastReviewed)
                .ToList();

            _correctInRow = 0;
            ShowNextLearningCard();
        }
        private void ShowNextLearningCard()
        {
            if (_wordcards.Count == 0)
            {
                MessageBox.Show("Обучение завершено!");
                return;
            }

            // берем карточку из начала очереди
            _currentCard = _wordcards[0];
            lblWord.Text = _currentCard.Word;
            txtTransAdd.Clear();
            lblRes.Visible = false;
            txtTransAdd.Clear();
            txtTransAdd.Focus();
        }
        private void CheckLearningAnswer()
        {
            if (_currentCard == null)
            {
                MessageBox.Show("Нет активной карточки для проверки!");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtTransAdd.Text))
            {
                MessageBox.Show("Введите ваш перевод!");
                return;
            }

            string userAnswer = txtTransAdd.Text.Trim();
            bool isCorrect = string.Equals(userAnswer, _currentCard.Translation, StringComparison.OrdinalIgnoreCase);

            if (isCorrect)
            {
                _correctInRow++;
                _currentCard.CorrectAnswers++;
                _currentCard.LastReviewed = DateTime.Now;

                lblRes.Text = "Правильно!";
                lblRes.ForeColor = Color.Green;

                if (_wordcards.Count > 0)
                {
                    _wordcards.Remove(_currentCard); 
                }
            }
            else
            {
                _correctInRow = 0;
                lblRes.Text = $"Неверно. Правильно: {_currentCard.Translation}";
                lblRes.ForeColor = Color.Red;
                _wordcards.Remove(_currentCard);
                _wordcards.Add(_currentCard);
            }

            lblRes.Visible = true;
            UpdateProgress();
            ShowNextLearningCard(); 
            lblRes.Visible = true;
            UpdateProgress();
        }
        private void UpdateProgress()
        {
            int total = _repository.GetAll().Count;
            int remaining = _wordcards.Count;
            lblProgress.Text = $"Прогресс: {total - remaining}/{total}";
        }

        private void tabLearn_Click(object sender, EventArgs e)
        {
            StartLearningSession();
        }

        private void lblRes_Click(object sender, EventArgs e)
        {

        }
        private void btnCheck_Click(object sender, EventArgs e)
        {
            CheckLearningAnswer();
        }
        private void txtTransAdd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CheckLearningAnswer();
                e.Handled = e.SuppressKeyPress = true;
            }
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            // Принудительно завершаем процесс
            if (Application.MessageLoop)
            {
                Application.Exit();
            }
            else
            {
                Environment.Exit(1);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (StartMenuForm.Instance != null && !StartMenuForm.Instance.IsDisposed)
            {
                StartMenuForm.Instance.ShowFromChild();
            }
            else
            {
                var menu = new StartMenuForm();
                menu.Show();
            }
        }
        private void btnBack2_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (StartMenuForm.Instance != null && !StartMenuForm.Instance.IsDisposed)
            {
                StartMenuForm.Instance.ShowFromChild();
            }
            else
            {
                var menu = new StartMenuForm();
                menu.Show();
            }
        }

        private void lblProgress_Click(object sender, EventArgs e)
        {

        }

        private void txtTransAdd_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
