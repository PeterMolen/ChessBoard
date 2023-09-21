using System;

namespace ChessBoard
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.OutputEncoding = System.Text.Encoding.Unicode; //to se the symbols in console.

            // "chessSymbols"
            string blackSquare = "\u25A0"; // ◼︎
            string whiteSquare = "\u25A1"; // ◻︎

            Program program = new Program();

            while (true)//looped (pick a number part) && (Error messsage && press 0 to end part)
            {
                Console.WriteLine("välj ett nummer: ");
                bool success = int.TryParse(Console.ReadLine(), out int userInput);
                //tried to implant tryparse even do i did not have to on the assignment.

                if (success) //if success, then it runs in 3 steps.
                {
                    //i tried an instansmethod, (not in the assignment) (step1of3)
                    program.BlackNWhite(userInput, blackSquare, whiteSquare); //runs the metod BlackNWhite

                    if (userInput == 0) //(step 2of3)
                    {
                        break;//end the program if the user types in 0
                    }

                }
                else //(step 3of3)
                {   //invalid choise, asks the user to put in and integer or write 0 to end.
                    Console.WriteLine("fel val. vänligen fyll i ett heltal eller skriv 0 för att avsluta");
                }
            }
        }

        public void BlackNWhite( int userInput, string blackSquare, string whiteSquare)
        { //the instansmethod, that runs that makes the black n white square appear next to eachother
            for (int i = 0; i<userInput; i++)
            {
                for (int j = 0; j < userInput; j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        Console.Write(blackSquare);
                    }
                    else
                    {
                        Console.Write(whiteSquare);
                    }
                }   Console.WriteLine();
            }    
        }       
    }
}