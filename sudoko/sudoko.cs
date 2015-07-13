using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//
//  Sodoko game. Great Fun, both playing and writing.
//  Gameboard is made up of 81 buttons organized within
//  a TableLayoutPanel control. The user selects a number
//  then guesses where it goes in the gameboard.
//
namespace sudoko
{
    enum celAttributes { Init, Set, Hidden, chossen };
    class sudoko
    {
        public int [,] cel  {get; set;}
        public Random r = new Random(System.DateTime.Now.Second);
        public bool makeQuess;
        public string quess;
        int[] scramble = { 6, 1, 5, 7, 2, 8, 3, 0 , 4};
        public celAttributes [] attr = new celAttributes[81];

        public sudoko()
        {
            this.cel = new int[9,9];
            for (int i=0; i < 9; i++)
            {
                for (int j=0; j < 9; j++)
                {
                   
                    this.cel[i,j] = 0;
                    attr[((i*9)+j)] = celAttributes.Init;
                }
            }
            makeQuess = false;
            quess = "";
        }

        public void initGame()
        {
            int i = 0, j = 0, fudge;
            int ii, jj;
            fudge = r.Next(0, 8);
            for (i = 0; i < 9; i++)
            {
                ii = scramble[i];
                fudge++;
                for (j = 0; j < 9; j++)
                {
                    jj = scramble[j];
                    cel[ii, jj] = ((j + fudge) % 9) + 1;
                }
            }
        }
    }
}

