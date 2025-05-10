using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static language_app.Program;

namespace language_app
{
    public class Wordcard
    {
        [Browsable(false)]
        public DateTime LastReviewed { get; set; }
        public string Word { get; set; }
        [Browsable(false)]
        public int CorrectAnswers { get; set; }
        public string Translation { get; set; }
        [Browsable(false)]
        public Wordcard(string word, string translation)
        {
            Word = word ?? throw new ArgumentNullException(nameof(word));
            Translation = translation ?? throw new ArgumentNullException(nameof(translation));
            CorrectAnswers = 0;
            LastReviewed = DateTime.MinValue;
        }
    }
}
