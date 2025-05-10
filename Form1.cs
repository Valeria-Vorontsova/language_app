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
        private List <Wordcard> wordcards = new List <Wordcard> (); 
        private Random random = new Random ();
        private Wordcard currentCard;

        private readonly WordcardRepository _repository;
        public Form1()
        {
            InitializeComponent();
            
            string exePath = Application.StartupPath;
            string jsonPath = Path.Combine(exePath, "Data", "wordcards.json");
            Directory.CreateDirectory(Path.GetDirectoryName(jsonPath));
            _repository = new WordcardRepository (jsonPath);
            UpdateDataGridView();
        }
        private void UpdateDataGridView()
        {
            // Сбрасываем DataSource и привязываем заново
            dgvCards.DataSource = null;
            dgvCards.Columns.Clear ();
            dgvCards.DataSource = _repository.GetAll();

            dgvCards.Columns["Word"].HeaderText = "Слово";
            dgvCards.Columns["Translation"].HeaderText = "Перевод";

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
            try
            {
                // Проверка 1: Существует ли репозиторий?
                if (_repository == null)
                {
                    MessageBox.Show("Репозиторий не инициализирован!");
                    return;
                }

                // Проверка 2: Существуют ли текстовые поля?
                if (txtWord == null || txtTranslation == null)
                {
                    MessageBox.Show("Текстовые поля не найдены на форме!");
                    return;
                }

                // Проверка 3: Не пустые ли поля?
                if (string.IsNullOrWhiteSpace(txtWord.Text) || string.IsNullOrWhiteSpace(txtTranslation.Text))
                {
                    MessageBox.Show("Введите слово и перевод!");
                    return;
                }
                var newCard = new Wordcard(txtWord.Text, txtTranslation.Text);

                // Проверка 4: Успешно ли создана карточка?
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
            catch (Exception ex)
            {
                MessageBox.Show($"Критическая ошибка: {ex.Message}\n\n{ex.StackTrace}");
            }
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
        }

        private void btnNextWord_Click(object sender, EventArgs e)
        {

        }

        private void tabLearn_Click(object sender, EventArgs e)
        {

        }
    }
}
