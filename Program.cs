using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GomokuFounction
{
    public class Board
    {
        public string[,] board = new string[8, 8];
        public Board(int size)
        {
            board = new string[size, size];

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    board[i, j] = "+";
                }
            }
            PrintBoard();
        }
        public void AddPeace(int Player, int x, int y)
        { 
            if (Player == 0)
            {
                board[x, y] = "W";
            }
            else
            {
                board[x, y] = "B";
            }
        }
        public bool CheckYaxis(int Player, int x, int y )
        {
            if (Player == 0)
            {
                board[x, y] = "W";
            }
            else
            {
                board[x, y] = "B";
            }
            int size = board.GetLength(0);
            int MatrixX = x, MatrixY = y;
            bool GameOver = false;
            int Piece = 0, MatchPiece =  0;
            int piece2 = 0;
            for (int i = y; i < size && i > 0; i-- )
            {
                //-Y
                piece2++;
                if (MatrixY < size && MatrixY > 0)
                {
                    MatrixY = MatrixY - 1;
                }
                if (board[x,y] == board[MatrixX, MatrixY])
                {
                    MatchPiece++;
                    if (MatchPiece == 4)
                    {
                        GameOver = true;   
                    }
                    if (piece2 == MatchPiece)
                    {
                        Piece++;
                      
                    }
                }
            }
            // Y plus
            piece2 = 0;
            MatchPiece = 0;
            for (int i = y; i < size; i++)
            {
                piece2++;
                if (MatrixY < size-1 && MatrixY >= 0)
                {
                    MatrixY = MatrixY + 1;
                }
                if (board[x, y] == board[MatrixX, MatrixY])
                {
                    MatchPiece++;
                    if (piece2 == MatchPiece)
                    {
                        Piece++;
                        Console.WriteLine("P-YM " + Piece);
                    }
                }
                if (MatchPiece == 4 && Piece == 4)
                {
                    GameOver = true;
                    Console.WriteLine("P " + Piece + "MPPP  "  + MatchPiece);

                }
            }
            return GameOver;
        }
        public bool CheckXaxis(int Player, int x, int y)
        {
            // Console.WriteLine(x + y);
            // X MINUS
            if (Player == 0)
            {
                board[x, y] = "W";
            }
            else
            {
                board[x, y] = "B";
            }
            int size = board.GetLength(0);
            int MatrixX = x, MatrixY = y;
            bool GameOver = false;
            int Piece = 0, MatchPiece = 0;
            int piece2 = 0;
            for (int i = x; i < size && i > 0; i--)
            {
                piece2++;
                if (MatrixX < size && MatrixX > 0)
                {
                    MatrixX = MatrixX - 1;
                }
                if (board[x, y] == board[MatrixX, MatrixY])
                {
                    MatchPiece++;
                    if (MatchPiece == 4)
                    {
                        GameOver = true;
                    }
                    if (piece2 == MatchPiece)
                    {
                        Piece++;
                       
                    }
                }
            
            }
            //X+
            piece2 = 0;
            MatchPiece = 0;
            for (int i = x; i < size; i++)
            {
                piece2++;
                if (MatrixX < size-1 && MatrixX >= 0)
                {
                    MatrixX = MatrixX + 1;
                }
                if (board[x, y] == board[MatrixX, MatrixY])
                {
                    MatchPiece++;
                    if (piece2 == MatchPiece)
                    {
                        Piece++;
                        
                    }
                }
                if (MatchPiece == 4 && Piece == 4)
                {
                    GameOver = true;
                }
            }
            return GameOver;

        }

        public bool CheckLXYaxis(int Player, int x, int y)
        {
            if (Player == 0)
            {
                board[x, y] = "W";
            }
            else
            {
                board[x, y] = "B";
            }
            Console.WriteLine(x + y);
            int size = board.GetLength(0);
            int MatrixX = x, MatrixY = y;
            bool GameOver = false;
            int Piece = 0, MatchPiece = 0;
            int piece2 = 0;
            for (int i = x; i < size && i > 0; i++)
            {
                piece2++;
                if (MatrixX < size && MatrixX > 0 && MatrixY < size && MatrixY > 0)
                {
                    MatrixX = MatrixX - 1;
                    MatrixY = MatrixY - 1;
                }
                if (board[x, y] == board[MatrixX, MatrixY])
                {
                    MatchPiece++;
                    if (MatchPiece == 4)
                    {
                        GameOver = true;
                    }
                    if (piece2 == MatchPiece)
                    {
                        Piece++;
                    }
                }
            }
            piece2 = 0;
            MatchPiece = 0;
            for (int i = y; i < size - 1; i++)
            {
                piece2++;
                if (MatrixX < size-1 && MatrixX >= 0 && MatrixY < size - 1 && MatrixY >= 0)
                {
                    MatrixX = MatrixX + 1;
                    MatrixY = MatrixY + 1;

                }
                    if (board[x, y] == board[MatrixX, MatrixY])
                    {
                        MatchPiece++;
                        if (piece2 == MatchPiece)
                        {
                            Piece++;
                    }
                    }
                if (MatchPiece == 4 && Piece == 4)
                {
                    GameOver = true;
                }
            }
            return GameOver;
        }
        public bool CheckRXYaxis(int Player , int x, int y)
        {
            if (Player == 0)
            {
                board[x, y] = "W";
            }
            else
            {
                board[x, y] = "B";
            }
            Console.WriteLine(x + y);
            int size = board.GetLength(0);
            int MatrixX = x, MatrixY = y;
            bool GameOver = false;
            int Piece = 0, MatchPiece = 0;
            int piece2 = 0;
            for (int i = x; i < size && i > 0; i--)
            {
                // -x , +y
                piece2++;
                if (MatrixX < size && MatrixX > 0 && MatrixY < size - 1 && MatrixY >= 0)
                {
                    MatrixX = MatrixX - 1;
                    MatrixY = MatrixY + 1;
                }
          
                if (board[x, y] == board[MatrixX, MatrixY])
                {
                    MatchPiece++;
                    if (MatchPiece == 4)
                    {
                        GameOver = true;
                        Console.WriteLine("Gwed" + GameOver);
                        Console.WriteLine("Mp" + MatchPiece);
                    }
                    if (piece2 == MatchPiece)
                    {
                        Piece++;
                        Console.WriteLine("pi" + Piece);
                    }
                }
            }
            // +x , -y
            piece2 = 0;
            MatchPiece = 0;
            for (int i = y; i < size && i > 0; i--)
            {
                piece2++;
                if (MatrixX < size-1 && MatrixX >= 0 && MatrixY < size && MatrixY > 0)
                {
                    MatrixX = MatrixX + 1;
                    MatrixY = MatrixY - 1;
                }
                if (board[x, y] == board[MatrixX, MatrixY])
                {
                    MatchPiece++;
                    if (piece2 == MatchPiece)
                    {
                        Piece++;
                    }
                }
                if (MatchPiece == 4 && Piece == 4)
                {
                    GameOver = true;
                    Console.WriteLine("G" + GameOver);

                }
            }
            return GameOver;
        }
        public static bool PlayerNotWin(int size , int turn)
        {
            bool GameOver = false;
            int a = 0;
            a = size * size;
            if(turn == a)
            {
                GameOver = true;
            }
            return GameOver;
        }
        public void PrintBoard()
        {
            int size = board.GetLength(0);
            Console.WriteLine("-------------------------------------------------------------------");
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write("|");
                    Console.Write(board[i, j]);
                    Console.Write("|");
                    Console.Write("  ");
                }
                Console.WriteLine("\n-------------------------------------------------------------------");
            }
        }
        class Program
        {
            public static void Main(string[] args)
            {
                int turn = 0;
                int size;
                bool Terminate = false;
                int Player = 0;
                int x = 0, y = 0;
                int MatrixX = x, MatrixY = y;
                int a = 0;
                Console.WriteLine("Enter size of the Board:");
                size = Convert.ToInt32(Console.ReadLine());
                Board cb = new Board(size);
                while (Terminate == false)
                {
                    if (Player == 0)
                    {
                        Player = 1;
                        bool position = true;
                        while (position == true)
                        {
                            Console.WriteLine("Player 1st Enter a Position:");
                            Console.WriteLine("Enter a Position of x:");
                            x = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter a position of y:");
                            y = Convert.ToInt32(Console.ReadLine());

                            if (x >= size || y >= size)
                            {
                                Console.WriteLine("Out Of Bounds Input");
                                position = true;
                            }
                            else
                            {
                                position = false;
                                if (cb.board[x, y] == "W" || cb.board[x, y] == "B")
                                {
                                    Console.WriteLine("Player 2 Already Set Position");
                                    position = true;
                                }
                            }
                        }
                        turn++;
                        cb.AddPeace(Player, x, y);
                        cb.PrintBoard();
                    }
                    else
                    {
                        bool position = true;
                        while (position == true)
                        {
                            Player = 0;
                            Console.WriteLine("Player 2nd Enter a Position:");
                            Console.WriteLine("Enter a Position of x:");
                            x = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter a position of y:");
                            y = Convert.ToInt32(Console.ReadLine());
                            if (x >= size || y >= size || x <= -1 || y <= -1)
                            {
                                Console.WriteLine("Out Of Bounds Input");
                                position = true;
                            }
                            else
                            {
                                position = false;
                            }
                            if (cb.board[x, y] == "W" || cb.board[x, y] == "B")
                            {
                                Console.WriteLine("Player 1 Already Set Position");
                                position = true;
                            }
                        }
                        turn++;
                        cb.AddPeace(Player, x, y);
                        cb.PrintBoard();
                    }
                    Console.WriteLine("tur   n        " + turn);
                    if (turn > 8)
                    {
                        Console.WriteLine("tu  rn   " + turn);
                        if (PlayerNotWin(size, turn))
                        {
                            Terminate = true;
                            a = 1;
                        }
                        if (cb.CheckYaxis(Player, x, y))
                        {
                             Terminate = true;
                             Console.WriteLine("Y TRUE");
                        }
                        if (cb.CheckXaxis(Player, x, y))
                        {
                            Terminate = true;
                            Console.WriteLine("X TRUE");
                        }
                        if (cb.CheckLXYaxis(Player, x, y))
                        {
                            Terminate = true;
                            Console.WriteLine("XL TRUE");
                        }
                        if (cb.CheckRXYaxis(Player, x, y))
                        {
                            Terminate = true;
                            Console.WriteLine("XR TRUE");
                        }

                    }
                }
                if(a == 1)
                {
                    Console.WriteLine("Player cannot Won");
                }
                else
                {
                    if (Player == 0)
                    {
                        Console.WriteLine("Player 2nd Won");
                    }
                    else
                    {
                        Console.WriteLine("Player 1st Won");
                    }
                }
              
            }
        }
    }
}
    

