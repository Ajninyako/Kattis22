using System;

namespace Kattis
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Problem F Majstor");
            //Console.WriteLine("Please type in your input");

            int R = Int32.Parse(Console.ReadLine());
            if(R>50 & R<1)
            {
                Console.WriteLine("R not in bounds");
            }

            string SvenInput = Console.ReadLine();
            //if(SvenInput.Length +1 == R )
            //{
            //    Console.WriteLine("Sven Input does not line up with R");
            //}
            //conditional to check sven input is the correct length

            int N = Int32.Parse(Console.ReadLine());
            if (N > 50 & N < 1)
            {
                Console.WriteLine("N not in bounds");
            }

            string[] FriendsArray = new string[N];
            for (int i =0; i<N; i++)
            {
                string FriendInput = Console.ReadLine();
                FriendsArray[i] = FriendInput;
            }

            //Rock Paper Scissors logic below
            SvenInput = SvenInput.ToUpper();//upper case check
            int SvenCurrentScore = 0;
            int SvenMaxScore = 0;

            for (int x = 0; x <N; x++)//for each friend
            {
                string FriendsInput = FriendsArray[x];

                for (int i = 0; i < R; i++)//for each round
                {

                    if (SvenInput[i] == 'R')//Rock
                    {
                        if( FriendsInput[i] == 'R')
                        {
                            SvenCurrentScore = SvenCurrentScore + 1;
                            //Tie
                        }
                        else if (FriendsInput[i] == 'P')
                        {
                            //Lose
                        }
                        else if (FriendsInput[i] == 'S')
                        {
                            SvenCurrentScore = SvenCurrentScore + 2;
                            //Win
                        }

                    }
                    else if (SvenInput[i] == 'P')//Paper
                    {
                        if (FriendsInput[i] == 'R')
                        {
                            //Win
                            SvenCurrentScore = SvenCurrentScore + 2;
                        }
                        else if (FriendsInput[i] == 'P')
                        {
                            //Tie
                            SvenCurrentScore = SvenCurrentScore + 1;
                        }
                        else if (FriendsInput[i] == 'S')
                        {
                            //Lose
                        }
                    }
                    else if (SvenInput[i] == 'S')//Scieeors
                    {
                        if (FriendsInput[i] == 'R')
                        {
                            //Lose
                        }
                        else if (FriendsInput[i] == 'P')
                        {
                            //Win
                            SvenCurrentScore = SvenCurrentScore + 2;
                        }
                        else if (FriendsInput[i] == 'S')
                        {
                            //Tie
                            SvenCurrentScore = SvenCurrentScore + 1;
                        }
                    }


                }

                

            }



            int Pcount = 0;
            int Rcount = 0;
            int Scount = 0;
            int MaxTest1 = 0;
            int MaxTest2 = 0;
            int MaxTest3 = 0;


            for (int i = 0; i < R; i++) //for each round
            {
                    Rcount = 0;
                    Pcount = 0;
                    Scount = 0;

                for (int x = 0; x < N; x++) //for each friend
                {
                    if (FriendsArray[x][i] == 'R')
                    {
                        Rcount = Rcount + 1;
                    }
                    else if (FriendsArray[x][i] == 'P')
                    {
                        Pcount = Pcount + 1;
                    }
                    else if (FriendsArray[x][i] == 'S')
                    {
                        Scount = Scount + 1;
                    }
                }


                MaxTest1 = 0;
                MaxTest2 = 0;
                MaxTest3 = 0;

                 MaxTest1 = Rcount * 2 + Pcount; //Paper
                 MaxTest2 = Scount * 2 + Rcount; //Rock
                 MaxTest3 = Pcount * 2 + Scount; //Scissors

                if(MaxTest1> MaxTest2 & MaxTest1 > MaxTest3)
                {
                    SvenMaxScore = SvenMaxScore + MaxTest1;
                }
                else if (MaxTest2 > MaxTest1 & MaxTest2 > MaxTest3)
                {
                    SvenMaxScore = SvenMaxScore + MaxTest2;
                }
                else if (MaxTest3 > MaxTest1 & MaxTest3 > MaxTest2)
                {

                    SvenMaxScore = SvenMaxScore + MaxTest3;
                }

            }

                Console.WriteLine(SvenCurrentScore);
                Console.WriteLine(SvenMaxScore);

        }
    }
}