using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
namespace week5
{
    class Game
    {
        //Attributes
        private Player MyPlayer = new Player();
        private List<TriviaItem> Trivia = new List<TriviaItem>();


        public Game()
        {
            Trivia.Add(new TriviaItem("What Gang in Nuka World loves Caps and lives in the Parlor?", "Operators"));
            Trivia.Add(new TriviaItem("What faction in Fallout 4 has the saying ManKind Redefined?", "Institute"));
            Trivia.Add(new TriviaItem("What is the name of your robotic butler in Fallout 4?", "Codsworth"));
            Trivia.Add(new TriviaItem("Who is the leader of the Brotherhood of Steel in Fallout 4?", "Elder Maxson"));
        }
        
        //methods

        public void Start()
        {
            //splash scree
            WriteLine("Welcome to Fallout 4 Trivia!");
            WriteLine("\nPress any key to begin");
            ReadKey(true);
            Clear();
            RunQuiz();

            //WriteLine($"Your score is: {MyPlayer.PlayerScore}.");
           // WriteLine(Trivia[0].Question);
        }
        public void RunQuiz()
        {
            string answer;
            for(int i =0;i <Trivia.Count;i++ )
            {
                WriteLine(Trivia[i].Question);
                WriteLine("Enter answer:");
                //answer = ReadLine();

                if(Trivia[i].CheckAnswer(ReadLine()))
                {
                    WriteLine("Correct!");
                    MyPlayer.PlayerScore++;
                }

                else
                {
                    WriteLine($"Sorry, but the correct answer is: {Trivia[i].Answer}.");
                }
                
                ReadKey(true);
                Clear();

            }
        }

        



    }
}
