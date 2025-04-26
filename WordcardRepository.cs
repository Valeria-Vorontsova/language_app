using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace language_app
{
    public class WordcardRepository
    {
        private List<Wordcard> _wordcards;
        private readonly string _filepath = "wordcards.json";
        public WordcardRepository()
        {
            Load();
        }
        public void Add(Wordcard card)
        {
            _wordcards.Add(card);
            Save();
        }

        private void Load()
        {
            if (File.Exists(_filepath))
            {
                string json = File.ReadAllText(_filepath);
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
            File.WriteAllText(_filepath, json);
        }
    }
    

}
