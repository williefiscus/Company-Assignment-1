using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company_Assignment_1
{
    class WordList
    {
        
        #region Field
        String word;

        List<String> words;

        #endregion Field

        #region Constructor
        public WordList()
        {
            List<String> words = new List<string>();
        }

        #endregion Constructor

        public void AddWord(string word)
        {
            words.Add(word);
        }

        
    }
}
