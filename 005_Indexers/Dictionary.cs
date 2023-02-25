using System;

namespace Indexers
{
    class Dictionary
    {
        private string[] key = new string[5];
        private string[] value = new string[5];
        private string[] enWords = { "book", "pen", "sun", "apple", "table" };
        private string[] ruWords = { "книга", "ручка", "солнце", "яблоко", "стол" };
        private string[] uaWords = { "книга", "ручка", "сонце", "яблуко", "стіл" };

        public Dictionary(string fromLang, string intoLang)
        {
            for (int i = 0; i < key.Length; i++)
            {
                if(fromLang == "EN")
                {
                    key[i] = enWords[i];
                }
                else if (fromLang == "RU")
                {
                    key[i] = ruWords[i];
                }
                else if (fromLang == "UA")
                {
                    key[i] = uaWords[i];
                }

                if (intoLang == "EN")
                {
                    value[i] = enWords[i];
                }
                else if (intoLang == "RU")
                {
                    value[i] = ruWords[i];
                }
                else if (intoLang == "UA")
                {
                    value[i] = uaWords[i];
                }
            }
        }

        public string this[string index]
        {
            get
            {
                for (int i = 0; i < key.Length; i++)
                    if (key[i] == index)
                        return key[i] + " - " + value[i];

                return string.Format("{0} - немає перекладу для цього слова.", index);
            }
        }

        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < key.Length)
                    return key[index] + " - " + value[index];
                else
                    return "Спроба звернення за межі масиву.";
            }
        }
    }
}
