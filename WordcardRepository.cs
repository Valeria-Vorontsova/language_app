using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace language_app
{
    public class WordcardRepository
    {
        private List<Wordcard> _wordcards;
        private readonly string _filePath;
        public WordcardRepository(string fileName)
        {
            _filePath = Path.Combine(Application.StartupPath, fileName);
            Load();
        }
        public void Add(Wordcard card)
        {
            if (card == null) 
                throw new ArgumentNullException(nameof(card));

            if (_wordcards == null)
                _wordcards = new List<Wordcard>();
            _wordcards.Add(card);
            Save();
        }
        public void Delete(int index)
        {
            if (index >= 0 && index < _wordcards.Count)
            {
                _wordcards.RemoveAt(index);
            }
            Save();
        }
        public List<Wordcard> GetAll() => _wordcards;
        private void Load()
        {
            if (File.Exists(_filePath))
            {
                string json = File.ReadAllText(_filePath);
                _wordcards = JsonConvert.DeserializeObject<List<Wordcard>>(json) ?? new List<Wordcard>();
            }
            else
            {
                new List<Wordcard>();
            }
        }
        private void Save()
        {
            string json = JsonConvert.SerializeObject(_wordcards, Formatting.Indented);
            File.WriteAllText(_filePath, json);
        }
    }  
}
