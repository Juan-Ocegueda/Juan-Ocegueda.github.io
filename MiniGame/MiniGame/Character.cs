using System;
using System.Collections.Generic;
using System.Text;

namespace MiniGame
{
    class Character
    {
        public string CharacterName { get; }
        public string CharacterType { get; }
        private string[] CharacterPhrases = new string[3];

        public Character(string name, string type, string[]phrases)
        {
            CharacterName = name;
            CharacterType = type;
            for(int i = 0; i < phrases.Length; i++)
            {
                CharacterPhrases[i] = phrases[i];
            }
        }

        public string Speak()
        {
            Random r = new Random();
            return CharacterPhrases[r.Next(0, CharacterPhrases.Length)];
        }
        public string Speak(int phrase)
        {
            return CharacterPhrases[phrase];
        }
    }
}
