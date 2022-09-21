using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//your name
//your course name
//your id
//----------------
//------------Exper..... programming -------------------
//date

namespace QuizProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //--------------------- checking password ---------------------------------

            string myPassword = "";
            string myUserName;

            // check 3 times

            int i = 0;

            while (i < 3)
            {
                Console.Write("Enter User Name :");
                myUserName = Console.ReadLine();
                Console.Write("Enter your password: ");
                ConsoleKeyInfo key;

                do
                {
                    key = Console.ReadKey(true);
                    if (key.Key != ConsoleKey.Backspace && key.Key != ConsoleKey.Enter)
                    {
                        myPassword += key.KeyChar;
                        Console.Write("*");
                    }
                    else
                    {
                        if (key.Key == ConsoleKey.Backspace && myPassword.Length > 0)
                        {
                            myPassword = myPassword.Substring(0, (myPassword.Length - 1));
                            Console.Write("\b \b");
                        }
                    }
                }
                while (key.Key != ConsoleKey.Enter);

                if (myUserName != "Staff" && myPassword != "Staf123")
                {
                    Console.Clear();
                    Console.WriteLine("Wrong Password ! Please enter again !");
                    i += 1;
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("Welcome to Expert Quiz Program !");
                    Console.WriteLine("Please read question carefully and answer them  !");
                    Console.WriteLine("Good Luck !! Press Enter Key.....");
                    Console.ReadLine();

                    // ------------------------------------------------------------------------


                    int myChoice = 0;


                    // memory variable to stroe the wrong and correct anser

                    int correctAnswer = 0;
                    int wrongAnswer = 0;

                    // declare array to store question, answer and student answer

                    string[] Questions = new string[5];
                    string[] Answers = new string[5];
                    string[] CandidateAnswers = new string[5]; // to store the answer of candidate

                    // store questions

                    Questions[0] = "2+3";
                    Questions[1] = "12+3";
                    Questions[2] = "22+3";
                    Questions[3] = "22+3";
                    Questions[4] = "22+3";

                    // store answer

                    Answers[0] = "1";
                    Answers[1] = "1";
                    Answers[2] = "25";
                    Answers[3] = "25";
                    Answers[4] = "25";

                    // delcar memory variable for candidate information

                    string cname = "";
                    string sex = "";
                    string address = "";
                    string postcode = "";
                    string hq = "";
                    int age = 0;
                    int contactNo = 0;
                    string myflag = "Red";
                    Console.Clear();

                    do
                    {
                        Console.WriteLine();
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("=================== MENU ====================");
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine();
                        Console.WriteLine("<1> Candidate Registration ");
                        Console.WriteLine("<2> QUIZ Program ");
                        Console.WriteLine("<3> Help ");
                        Console.WriteLine("<4> Exit ");
                        Console.WriteLine("----------------------------------------------");
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write("Enter Your Selection (1-4) : ");
                        myChoice = int.Parse(Console.ReadLine());

                        Console.Clear();

                        switch (myChoice)
                        {
                            case 1:

                                Console.WriteLine("Candidate Registration");
                                Console.WriteLine("----------------------");
                                Console.Write("Enter Name :");
                                cname = Console.ReadLine();
                                Console.Write("Enter Address:");
                                address = Console.ReadLine();
                                Console.Write("Enter PostCode:");
                                postcode = Console.ReadLine();
                                Console.Write("Enter Sex:");
                                sex = Console.ReadLine();
                                Console.Write("Enter Age:");
                                age = int.Parse(Console.ReadLine());
                                Console.Write("Enter Contact Number:");
                                contactNo = int.Parse(Console.ReadLine());
                                Console.Write("Enter Highest Qualification:");
                                hq = Console.ReadLine();
                                Console.Clear();
                                myflag = "Green";
                                break;

                            case 2:

                                // check candidate is register or not

                                if (myflag == "Green")
                                {
                                    // ask question, store answer and produce result
                                    // ask question

                                    for (i = 0; i < Questions.Length; i++)
                                    {
                                        Console.WriteLine(Questions[i]);
                                        CandidateAnswers[i] = Console.ReadLine();
                                    }

                                    // Check answer

                                    for (i = 0; i < Questions.Length; i++)
                                    {
                                        if (Answers[i] == CandidateAnswers[i])
                                        {
                                            correctAnswer = correctAnswer + 1;
                                        }
                                        else
                                        {
                                            wrongAnswer = wrongAnswer + 1;
                                        }
                                    }

                                    // prepare result

                                    Console.WriteLine("=========Result=====");
                                    Console.WriteLine();
                                    Console.WriteLine("Name :" + cname);
                                    Console.WriteLine("Address:" + address);
                                    Console.WriteLine("Sex :" + sex);
                                    Console.WriteLine("PostCode :" + postcode);
                                    Console.WriteLine("Age :" + age);
                                    Console.WriteLine("Contact Number:" + contactNo);
                                    Console.WriteLine("Higest Qulification :" + hq);
                                    Console.WriteLine("------------------------------");
                                    Console.WriteLine("No. of Correct Answer :" + correctAnswer);
                                    Console.WriteLine("No. of Wrong Answer :" + wrongAnswer);
                                    Console.WriteLine("Obtained Mark :" + correctAnswer * 4);
                                    Console.WriteLine("----------------------------------------");

                                    if ((correctAnswer * 4) >= 90)
                                    {
                                        Console.WriteLine("Recommendation Level : Intermedidate");
                                    }
                                    else if ((correctAnswer * 4) >= 66)
                                    {
                                        Console.WriteLine("Recommendation Level : Basic Level");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Recommendation Level : Very Basic Level");
                                    }
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("Candidate has not registered ! please register candidate !");

                                }
                                break;

                            case 3:
                                // help inforamtion

                                Console.WriteLine("Help : How to use system");
                                Console.WriteLine("Press number 1 for candidate registration !");

                                Console.ReadLine();

                                break;
                            case 4:
                                Console.WriteLine("----Thank you for using program -------");
                                Console.BackgroundColor = ConsoleColor.White;
                                Console.ReadLine();
                                break;
                            default:
                                Console.WriteLine("Invalid Selection !");
                                Console.ReadLine();
                                break;
                        }
                    }
                    while (myChoice != 4);
                }
            }

        }
    }
}
