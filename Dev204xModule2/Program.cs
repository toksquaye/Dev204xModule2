using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


//For this assignment, you will create the pattern of a chess board that is 8 x 8.  Use X and O to represent the squares.
//1.Create the appropriate nested looping structure to output the characters in an 8 x 8 grid on the screen using Console.Write() or Console.WriteLine() as appropriate.
//2.Include a decision structure to ensure that alternate rows start with opposite characters as a real chess board alternates the colors among rows.


//This is what your output should look like.

//XOXOXOXO
//OXOXOXOX
//XOXOXOXO
//OXOXOXOX
//XOXOXOXO
//OXOXOXOX
//XOXOXOXO
//OXOXOXOX

namespace Dev204xModule2
{
    class Program
    {
        static void Main(string[] args)
        {
            char prev_row_start = 'O';
            char current_char = 'O';
            for(int row = 0; row < 8; row++) //for the 8 rows, do the following
            {
                if (prev_row_start.Equals('X')) //if previous row started with X
                {
                    prev_row_start = current_char = 'O'; //then start this one with O
                }
                else
                {
                    prev_row_start = current_char = 'X'; //else start this one with X
                }

                for(int col = 0; col < 8; col++)
                {
                    Console.Write(current_char);
                    current_char = current_char.Equals('X') ? 'O' : 'X'; //flip the current character
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
