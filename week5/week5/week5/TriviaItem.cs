using System;
using System.Collections.Generic;
using System.Text;

namespace week5
{
    class TriviaItem
    {
        //attributes
        public string Question { get; private set; }
        public string Answer { get; private set; }

        public TriviaItem(string question, string answer)
        {
            Question = question;
            Answer = answer;
        }
        //methods
        public bool CheckAnswer(string answer)
        {
            bool result = false;
            if(answer == this.Answer)
            {
                result = true;
            }
            return result;
        }
        //Display Trivia Item

    }
}
