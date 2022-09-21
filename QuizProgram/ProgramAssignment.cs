using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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

                if (myUserName != "Admin" && myPassword != "dan0710")
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

                    int NST_Correct_Answer = 0;
                    int NST_Wrong_Answer = 0;
                    string NST_Result = "";
                    int NST_Mark = 0;
                    // declare array to store question, answer and student answer

                    string[] NSTQuestions = new string[10];
                    string[] NSTAnswers = new string[10];
                    string[] NSTChildrenAnswers = new string[10]; // to store the answer of candidate

                    // store questions
                    NSTQuestions[0] = "287+15";
                    NSTQuestions[1] = "49/7";
                    NSTQuestions[2] = "225-57";
                    NSTQuestions[3] = "43+89";
                    NSTQuestions[4] = "330/10";
                    NSTQuestions[5] = "25*14";
                    NSTQuestions[6] = "68+48";
                    NSTQuestions[7] = "578-48";
                    NSTQuestions[8] = "65+211";
                    NSTQuestions[9] = "18*24";





                    // store answer

                    NSTAnswers[0] = "302";
                    NSTAnswers[1] = "7";
                    NSTAnswers[2] = "168";
                    NSTAnswers[3] = "133";
                    NSTAnswers[4] = "33";
                    NSTAnswers[5] = "350";
                    NSTAnswers[6] = "116";
                    NSTAnswers[7] = "530";
                    NSTAnswers[8] = "276";
                    NSTAnswers[9] = "432";

                    // store answer children

                    NSTChildrenAnswers[0] = "";
                    NSTChildrenAnswers[1] = "";
                    NSTChildrenAnswers[2] = "";
                    NSTChildrenAnswers[3] = "";
                    NSTChildrenAnswers[4] = "";
                    NSTChildrenAnswers[5] = "";
                    NSTChildrenAnswers[6] = "";
                    NSTChildrenAnswers[7] = "";
                    NSTChildrenAnswers[8] = "";
                    NSTChildrenAnswers[9] = "";



                    // set questions and aswer for PST

                    int PST_Correct_Answer = 0;
                    int PST_Wrong_Answer = 0;
                    string PST_Result = "";
                    int PST_Mark = 0;
                    // declare array to store question, answer and student answer

                    string[] PSTQuestions = new string[10];
                    string[] PSTAnswers = new string[10];
                    string[] PSTChildrenAnswers = new string[10]; // to store the answer of candidate

                    // store questions

                    PSTQuestions[0] = "On the first day of school, students used 846 small paperclips and 43 large ones. How many paperclips did they use that day?";
                    PSTQuestions[1] = "Subtract:600 - 200 = ";
                    PSTQuestions[2] = "Which is more, 8 quarts or 1 gallon?";
                    PSTQuestions[3] = "Which words make this statement true? 47 ____ 49";
                    PSTQuestions[4] = "Write the related addition fact for 15 + 2 = 17";
                    PSTQuestions[5] = "	132+634";
                    PSTQuestions[6] = "Which number makes the equation true? 256 + 6 = 257 +";
                    PSTQuestions[7] = "A cook fed 460 adults and 12 children. How many people did the cook feed?";
                    PSTQuestions[8] = "Which number makes the equation true?   + 1 = 373 + 8";
                    PSTQuestions[9] = "Subtract 915-514";

                    // store answer

                    PSTAnswers[0] = "889";
                    PSTAnswers[1] = "400";
                    PSTAnswers[2] = "8 quarts";
                    PSTAnswers[3] = "is less than";
                    PSTAnswers[4] = "2+15=17";
                    PSTAnswers[5] = "766";
                    PSTAnswers[6] = "5";
                    PSTAnswers[7] = "472";
                    PSTAnswers[8] = "380";
                    PSTAnswers[9] = "401";

                    // store  answer childrens

                    PSTChildrenAnswers[0] = "";
                    PSTChildrenAnswers[1] = "";
                    PSTChildrenAnswers[2] = "";
                    PSTChildrenAnswers[3] = "";
                    PSTChildrenAnswers[4] = "";
                    PSTChildrenAnswers[5] = "";
                    PSTChildrenAnswers[6] = "";
                    PSTChildrenAnswers[7] = "";
                    PSTChildrenAnswers[8] = "";
                    PSTChildrenAnswers[9] = "";



                    // delcar memory variable for candidate information

                    string cname = "";
                    string sex = "";
                    string cclass = "";
                    int age = 0;
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
                        Console.WriteLine("<1> Children Registration ");
                        Console.WriteLine("<2> Numerical Skill Test  ");
                        Console.WriteLine("<3> Problem Solving Skill Test  ");
                        Console.WriteLine("<4> View Test Result ");
                        Console.WriteLine("<5> Help ");
                        Console.WriteLine("<6> Exit ");

                        Console.WriteLine("----------------------------------------------");
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write("Enter Your Selection (1-6) : ");
                        myChoice = int.Parse(Console.ReadLine());

                        Console.Clear();

                        switch (myChoice)
                        {
                            case 1:

                                Console.WriteLine("Children Registration");
                                Console.WriteLine("----------------------");
                                Console.Write("Enter Full Name :");
                                cname = Console.ReadLine();
                                Console.Write("Enter Sex:");
                                sex = Console.ReadLine();
                                Console.Write("Enter Age:");
                                age = int.Parse(Console.ReadLine());
                                Console.Write("Enter Class:");
                                cclass = Console.ReadLine();
                                Console.Clear();
                                myflag = "Green";
                                break;

                            case 2:

                                // check candidate is register or not
                               
                                        if (myflag == "Green")
                                        {
                                            // ask question, store answer and produce result

                                           for (i = 0; i < NSTQuestions.Length; i++)
                                            {
                                                Console.WriteLine(NSTQuestions[i]);
                                                NSTChildrenAnswers[i] = Console.ReadLine();
                                            }

                                            // Check answer

                                            for (i = 0; i < NSTQuestions.Length; i++)
                                            {
                                                if (NSTAnswers[i] == NSTChildrenAnswers[i])
                                                {
                                                    NST_Correct_Answer = NST_Correct_Answer + 1;
                                                }
                                                else
                                                {
                                                    NST_Wrong_Answer = NST_Wrong_Answer + 1;
                                                }
                                            }

                                           NST_Mark = NST_Correct_Answer * 10;

                                            // prepare result


                                            Console.WriteLine("=========================Result===========================");
                                            Console.WriteLine();
                                            Console.WriteLine("Name :" + cname);
                                            Console.WriteLine("Sex :" + sex);
                                            Console.WriteLine("Class :" + cclass);
                                            Console.WriteLine("Age :" + age);
                                                                             
                                            Console.WriteLine("---------------------------------------------------------");
                                            Console.WriteLine("No. of Correct Answer :" + NST_Correct_Answer);
                                            Console.WriteLine("No. of Wrong Answer :" + NST_Correct_Answer);
                                            Console.WriteLine("Obtained Mark :" + NST_Mark );
                                            Console.WriteLine("---------------------------------------------------------");

                                    if ((NST_Mark) >= 50)
                                    {
                                        NST_Result = "PASS";
                                    }
                                    else
                                    {
                                        NST_Result = "FAIL";
                                        Console.WriteLine("Children has been unsuccessful in NST test so he/she is not allowed to in sit PST rest, the system will store his detail in file !");
                                        Console.WriteLine("Press Enter Key !");
                                        Console.ReadLine();
                                                                            
                                        // open the file and save the result

                                        String myFileNameNST = cname + age + cclass;
                                        String myFileNst = @"C:\Users\14938\Desktop\QuizProgram\" + myFileNameNST + ".txt";

                                        using (StreamWriter filewrite = new StreamWriter(myFileNst))
                                        {
                                            filewrite.WriteLine(String.Format("Children Name : {0}", cname));
                                            filewrite.WriteLine(String.Format("Sex : {0}", sex));
                                            filewrite.WriteLine(String.Format("Class : {0}", cclass));
                                            filewrite.WriteLine(String.Format("Age : {0}", age));
                                            filewrite.WriteLine(String.Format("------------------Child NST Test Result-----------------------------"));
                                            filewrite.WriteLine(String.Format("NST Correct Answer : {0}", NST_Correct_Answer));
                                            filewrite.WriteLine(String.Format("NST Wrong Answer   : {0}", NST_Wrong_Answer));
                                            filewrite.WriteLine(String.Format("NST Mark : {0}", NST_Mark));
                                            filewrite.WriteLine(String.Format("NST Result : {0}", NST_Result));
                                            filewrite.WriteLine(String.Format("--------------------------------------------------"));
                                          
                                        }
                                      }
                                }
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Candidate has not registered ! please register candidate !");

                                        }
                                break;

                            case 3:
                                
                                    if (NST_Result == "FAIL")
                                    {
                                        Console.WriteLine("Children fail in NST test so can not sit in PST !");
                                        

                                    }
                                    else
                                    {
                                        // aske questions

                                        // store questions

                                        PSTQuestions[0] = "On the first day of school, students used 846 small paperclips and 43 large ones. How many paperclips did they use that day?";
                                        PSTQuestions[1] = "Subtract:600 - 200 = ";
                                        PSTQuestions[2] = "Which is more, 8 quarts or 1 gallon?";
                                        PSTQuestions[3] = "Which words make this statement true? 47 ____ 49";
                                        PSTQuestions[4] = "Write the related addition fact for 15 + 2 = 17";
                                        PSTQuestions[5] = "	132+634";
                                        PSTQuestions[6] = "Which number makes the equation true? 256 + 6 = 257 +";
                                        PSTQuestions[7] = "A cook fed 460 adults and 12 children. How many people did the cook feed?";
                                        PSTQuestions[8] = "Which number makes the equation true?   + 1 = 373 + 8";
                                        PSTQuestions[9] = "Subtract 915-514";

                                        // store answer

                                        PSTAnswers[0] = "889";
                                        PSTAnswers[1] = "400";
                                        PSTAnswers[2] = "8 quarts";
                                        PSTAnswers[3] = "is less than";
                                        PSTAnswers[4] = "2+15=17";
                                        PSTAnswers[5] = "766";
                                        PSTAnswers[6] = "5";
                                        PSTAnswers[7] = "472";
                                        PSTAnswers[8] = "380";
                                        PSTAnswers[9] = "401";

                                        // store  answer childrens

                                        PSTChildrenAnswers[0] = "";
                                        PSTChildrenAnswers[1] = "";
                                        PSTChildrenAnswers[2] = "";
                                        PSTChildrenAnswers[3] = "";
                                        PSTChildrenAnswers[4] = "";
                                        PSTChildrenAnswers[5] = "";
                                        PSTChildrenAnswers[6] = "";
                                        PSTChildrenAnswers[7] = "";
                                        PSTChildrenAnswers[8] = "";
                                        PSTChildrenAnswers[9] = "";


                                        for (i = 0; i < PSTQuestions.Length; i++)
                                        {
                                            if (PSTAnswers[i] == PSTChildrenAnswers[i])
                                            {
                                                PST_Correct_Answer = PST_Correct_Answer + 1;
                                            }
                                            else
                                            {
                                                PST_Wrong_Answer = PST_Wrong_Answer + 1;
                                            }
                                        }

                                         PST_Mark = PST_Correct_Answer * 10;

                                        // prepare result


                                        Console.WriteLine("=========================Result===========================");
                                        Console.WriteLine();
                                        Console.WriteLine("Name :" + cname);
                                        Console.WriteLine("Sex :" + sex);
                                        Console.WriteLine("Class :" + cclass);
                                        Console.WriteLine("Age :" + age);

                                        Console.WriteLine("---------------------------------------------------------");
                                        Console.WriteLine("No. of Correct Answer :" + PST_Correct_Answer);
                                        Console.WriteLine("No. of Wrong Answer :" + PST_Correct_Answer);
                                        Console.WriteLine("Obtained Mark :" + PST_Mark);
                                        Console.WriteLine("---------------------------------------------------------");
                                                                           
                                    }

                                // Save data 

                                    String myFileName = cname + age + cclass;
                                    String myFiles = @"C:\Users\14938\Desktop\QuizProgram\" + myFileName + ".txt";

                                using (StreamWriter filewrite = new StreamWriter(myFiles))
                                {
                                    filewrite.WriteLine(String.Format("Children Name : {0}", cname));
                                    filewrite.WriteLine(String.Format("Sex : {0}", sex));
                                    filewrite.WriteLine(String.Format("Class : {0}", cclass));
                                    filewrite.WriteLine(String.Format("Age : {0}", age));
                                    filewrite.WriteLine(String.Format("------------------Child NST Test Result-----------------------------"));
                                    filewrite.WriteLine(String.Format("NST Correct Answer : {0}", NST_Correct_Answer));
                                    filewrite.WriteLine(String.Format("NST Wrong Answer   : {0}", NST_Wrong_Answer));
                                    filewrite.WriteLine(String.Format("NST Mark : {0}", NST_Mark));
                                    filewrite.WriteLine(String.Format("NST Result : {0}", NST_Result));
                                    filewrite.WriteLine(String.Format("--------------------------------------------------"));
                                    filewrite.WriteLine(String.Format("--------------Child PST Result----------------"));
                                    filewrite.WriteLine(String.Format("PST Correct Answer : {0}", PST_Correct_Answer));
                                    filewrite.WriteLine(String.Format("PST Wrong Answer   : {0}", PST_Wrong_Answer));
                                    filewrite.WriteLine(String.Format("PST Mark : {0}", PST_Mark));
                                    filewrite.WriteLine(String.Format("PST Result : {0}", PST_Result));
                                }
                                break;

                            case 4:

                                // Display the children result

                                String fileName;
                                Console.Write("Enter Student Detail (name, age and class):");
                                fileName = Console.ReadLine();

                                // clear screen and display record from text file
                                Console.Clear();
                                String myFile;
                                myFile = @"C:\Users\14938\Desktop\QuizProgram\" + fileName + ".txt";
                                StreamReader sr = new StreamReader(myFile);

                                Console.BackgroundColor = ConsoleColor.White;
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.WriteLine();
                                Console.WriteLine("Children Result");
                                Console.WriteLine("-----------------------------------------------");

                                String line = "";
                                int count = 0;

                                while ((line = sr.ReadLine()) != null)
                                {
                                    count++;
                                    Console.WriteLine("{0}", line);
                                }
                                sr.Close();
                                Console.WriteLine("-----------------------------------------------");
                                Console.ReadLine();


                                break;


                            case 5:
                                // help inforamtion

                                Console.WriteLine("Help : How to use system");
                                Console.WriteLine("Press number 1 for candidate registration !");
                                Console.ReadLine();
                                break;
                            case 6:
                                Console.WriteLine("----Thank you for using program -------");
                                Console.BackgroundColor = ConsoleColor.White;
                                Console.ReadLine();
                                Environment.Exit(0);
                                break;
                            default:
                                Console.WriteLine("Invalid Selection !");
                                Console.ReadLine();
                                break;
                        }
                    }
                    while (myChoice != 6);
                }
            }

            
        }
    
        
    }
}
