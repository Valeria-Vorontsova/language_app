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
        public string Word { get; set; }
        public string Translation { get; set; }
        [Browsable(false)]
        public Wordcard(string word, string translation)
        {
            Word = word ?? throw new ArgumentNullException(nameof(word));
            Translation = translation ?? throw new ArgumentNullException(nameof(translation));
        }
    }
}
