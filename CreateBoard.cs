using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeGame
{
    internal class CreateBoard
    {
        char[] position = new char[10] { ' ',' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ',' ' };  

        public  void MakeBoard() 
        {
            Console.WriteLine("{0}    {1}    {2}", position[1], position[2], position[3]);
            Console.WriteLine("{0}    {1}    {2}", position[4], position[5], position[6]);
            Console.WriteLine("{0}    {1}    {2}", position[7], position[8], position[9]);
        }
    }
}
