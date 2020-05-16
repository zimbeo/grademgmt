using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grademgmt
{
    class Program   
    {

        // A1) Show all grades for a single student 
        static void DisplayOne(Dictionary<string, List<int>> aDict)
        {
            Console.Write("Please enter Students full name: ");
            string i = Console.ReadLine();

            if (aDict.ContainsKey(i))
            {
                Console.Write("\n" + i + "\n\nGrades:   ");
                

                foreach (int k in aDict[i])
                {
                    Console.Write(k + " ");
                }

                Console.WriteLine("\nPress any key to return");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Student does not exist in our reccords");
                Console.ReadKey();
            }
        }
        // A2) Show the student name and grade average for the top student 
        static void ShowTop(Dictionary<string, List<int>> aDict)
        {
            string highestName = "";
            double highestScore = 0;
            foreach (KeyValuePair<string, List<int>> l in aDict)
            {
                try
                {
                    double a = l.Value.Average();
                    if (a > highestScore)
                    {
                        highestName = l.Key;
                        highestScore = a;
                    }
                }
                catch (Exception)
                {

                }
            }
            Console.WriteLine(highestName + " has the highest average with " + highestScore);
            Console.WriteLine("\n Press any key to return");
            Console.ReadKey();
        }
        // B1) Change one student 
        static void ChangeStudent(Dictionary<string, List<int>> aDict)
        {
            Console.Clear();    
            Console.Write("Please enter the student name to change: ");
            string StudentName = Console.ReadLine();

            if (!aDict.ContainsKey(StudentName))
            {
                Console.WriteLine("That student name does not exist in our records.");
            }
            else
            { 
                Console.WriteLine("\nPlease enter the corrected student name:");
                string newname = Console.ReadLine();

                aDict.Add(newname, aDict[StudentName]);
                aDict.Remove(StudentName);

                Console.WriteLine("\nChange has been made. Press any key to go back to the menu.");
                Console.ReadKey();
                while (true)
                {
                    break;
                }
            }
        }
        // B2) Add one student 
        static void AddOneStudent(Dictionary<string, List<int>> aDict)
        {
            Console.Clear();
            Console.Write("Please enter name for the new student: ");
            string i = Console.ReadLine();

            if (!aDict.ContainsKey(i))
            {
                aDict.Add(i, new List<int> { });
                Console.WriteLine("\nThe change has been made. Press any key to go back to the menu.");
                
            }
            else
            {
                Console.WriteLine("Student already exists");
                Console.WriteLine("\nPress any key to go back to the menu.");

            }
            Console.ReadKey();
        }
        // B3) Delete student 
        static void DeleteStudent(Dictionary<string, List<int>> aDict)
        {
            Console.Clear();
            Console.Write("Please enter name for the student to be deleted: ");
            string i = Console.ReadLine();


            aDict.Remove(i);

            Console.WriteLine("\nThe change has been made. Press any key to go back to the menu.");
            Console.ReadKey();
        }
        // C1) Change one grade for a particular student 
        static void ChangeGrade(Dictionary<string, List<int>> aDict)
        {
            Console.Write("Please enter the student names whose grade to change: ");
            string StudentName = Console.ReadLine();
            if (!aDict.ContainsKey(StudentName))
            {
                Console.WriteLine("That student name does not exist in our records.");
            }
            else
            {
                for (int i = 0; i < aDict[StudentName].Count; i++)
                {
                    Console.WriteLine(i + ". " + aDict[StudentName][i]);
                }
                Console.Write("\nPlease enter the number of the grade to change: ");

                int gradeIndex = Convert.ToInt32(Console.ReadLine());

                Console.Write("\nPlease enter the new grade value: ");
                int newGrade = Convert.ToInt32(Console.ReadLine());

                aDict[StudentName][gradeIndex] = newGrade;
            }
        }
        // C2) Add one grade for a particular student 
        static void AddGrade(Dictionary<string, List<int>> aDict)
        {
            Console.Write("Please enter the student names for grade change: ");
            string StudentName = Console.ReadLine();

            if (!aDict.ContainsKey(StudentName))
            {
                Console.WriteLine("That student name does not exist in our records.");
            }
            else
            {
                for (int i = 0; i < aDict[StudentName].Count; i++)
                {
                    Console.WriteLine(i + ". " + aDict[StudentName][i]);
                }
                Console.Write("\nPlease enter the number of the grade to add: ");
                int gradeIndex = Convert.ToInt32(Console.ReadLine());
                aDict[StudentName].Add(gradeIndex);
           
                Console.WriteLine("\n" + gradeIndex + " has been added");
                for (int i = 0; i < aDict[StudentName].Count; i++)
                {
                    Console.WriteLine(i + ". " + aDict[StudentName][i]);
                }
                Console.ReadKey();
            }
        }
        // C3) Delete Grade for a particular student 
        static void DeleteGrade(Dictionary<string, List<int>> aDict)
        {
            Console.Write("Please enter the student names for grade deletion: ");
            string StudentName = Console.ReadLine();

            if (!aDict.ContainsKey(StudentName))
            {
                Console.WriteLine("That student name does not exist in our records.");
            }
            else
            {
                for (int i = 0; i < aDict[StudentName].Count; i++)
                {
                    Console.WriteLine(i + ". " + aDict[StudentName][i]);
                }
                Console.Write("\nPlease enter the number of the grade to delete: ");
                int gradeIndex = Convert.ToInt32(Console.ReadLine());
                aDict[StudentName].RemoveAt(gradeIndex);

                Console.WriteLine("\n" + gradeIndex + " has been deleted");
                for (int i = 0; i < aDict[StudentName].Count; i++)
                {
                    Console.WriteLine(i + ". " + aDict[StudentName][i]);
                }
                Console.ReadKey();
            }
        }

        // Main Method
        static void Main(string[] args)
        {
            Dictionary<string, List<int>> studentGrades = new Dictionary<string, List<int>>()
            {
                {"Alfred S. McKenzie",new List<int> {48, 96, 64}},
                {"Alison W. MacDonald",new List<int> {54, 99, 72}},
                {"Allan Y. Nguyen",new List<int> {42, 42, 41}},
                {"Audrey M. Kern",new List<int> {49, 67, 93}},
                {"Barry V. Gordon",new List<int> {66, 57, 52}},
                {"Beth G. Swanson",new List<int> {67, 55, 70}},
                {"Billy P. Carroll",new List<int> {70, 58, 80}},
                {"Calvin A. Diaz",new List<int> {86, 42, 50}},
                {"Charlotte G. Hamrick",new List<int> {43, 74, 40}},
                {"Chris Anderson",new List<int> {72, 67, 76}},
                {"Claire Q. Gray",new List<int> {63, 90, 47}},
                {"Clara H. Best",new List<int> {59, 63, 69}},
                {"Clifford Garrett",new List<int> {87, 89, 72}},
                {"Dean Leach",new List<int> {95, 40, 100}},
                {"Edgar P. Stuart",new List<int> {96, 49, 91}},
                {"Edna H. Hoyle",new List<int> {66, 70, 88}},
                {"Eileen Olson",new List<int> {100, 85, 51}},
                {"Franklin M. Coley",new List<int> {59, 63, 97}},
                {"Frederick J. McCall",new List<int> {97, 52, 57}},
                {"Glen R. Kramer",new List<int> {70, 48, 52}},
                {"Gordon D. Berman",new List<int> {88, 74, 46}},
                {"Jean M. Griffin",new List<int> {48, 86, 99}},
                {"Jeff T. Kaplan",new List<int> {54, 91, 72}},
                {"Joanna L. Middleton",new List<int> {43, 88, 73}},
                {"Joanne L. Bowling",new List<int> {78, 79, 79}},
                {"Julian E. Hendrix",new List<int> {99, 51, 91}},
                {"Keith X. Schwartz",new List<int> {97, 86, 97}},
                {"Ken T. Kennedy",new List<int> {80, 66, 40}},
                {"Kim T. Matthews",new List<int> {75, 95, 55}},
                {"Kristen O. Fisher",new List<int> {44, 72, 57}},
                {"Louise F. Coble",new List<int> {67, 63, 98}},
                {"Luis A. Burnett",new List<int> {85, 74, 52}},
                {"Luis N. Turner",new List<int> {86, 53, 86}},
                {"Margaret M. Burgess",new List<int> {76, 93, 63}},
                {"Martin Y. Hester",new List<int> {61, 74, 51}},
                {"Mary G. Byrd",new List<int> {95, 40, 95}},
                {"Nina Y. Savage",new List<int> {73, 41, 84}},
                {"Pauline N. Coley",new List<int> {73, 51, 87}},
                {"Penny Lamb",new List<int> {49, 94, 61}},
                {"Peter L. Guthrie",new List<int> {75, 70, 44}},
                {"Rhonda Chan",new List<int> {94, 52, 93}},
                {"Richard E. Hull",new List<int> {76, 99, 59}},
                {"Robyn K. Shapiro",new List<int> {45, 82, 68}},
                {"Samantha I. Hardin",new List<int> {89, 42, 95}},
                {"Sara Lucas",new List<int> {80, 60, 85}},
                {"Stephen Finch",new List<int> {84, 95, 70}},
                {"Tammy L. Lang",new List<int> {62, 73, 56}},
                {"Vincent Y. Fischer",new List<int> {79, 88, 92}},
                {"William S. McCormick",new List<int> {99, 68, 65}}
            };
            
            // Main Menu Loop
            while (true)
            {
                Console.WriteLine("1) Reports");
                Console.WriteLine("2) Student Management");
                Console.WriteLine("3) Grade Management");
                Console.WriteLine("4) Exit");
                Console.Write("\n" + "Please choose from one of the menu options:");

                string menuSelection = Console.ReadLine();

                // Report Management 
                if (menuSelection == "1")
                {
                    while (true)
                    {
                        Console.Clear();

                        Console.WriteLine("1) Show all grades for a single student");
                        Console.WriteLine("2) Show the student name and grade average for the top student");
                        Console.WriteLine("3) Return to the main menu");
                        Console.Write("\n" + "Please choose from one of the menu options:");

                        string ReportMenuSelection = Console.ReadLine();

                        if (ReportMenuSelection == "1")
                        {
                            // A1) Show all grades for a single student
                            Console.Clear();
                            DisplayOne(studentGrades);
                        }
                        else if (ReportMenuSelection == "2")
                        {
                            // 2) Show the student name and grade average for the top student
                            Console.Clear();
                            ShowTop(studentGrades);
                        }
                        else if (ReportMenuSelection == "3")
                        {
                            // 3) Return to the main menu
                            break;
                        }
                        else
                        {
                            Console.Write("Invalid input");
                        }
                    }
                   
                }
                //  Student Management 
                else if (menuSelection == "2")
                {
                    while (true)
                    {
                        Console.Clear();

                        Console.WriteLine("1) Change student");
                        Console.WriteLine("2) Add student");
                        Console.WriteLine("3) Delete student");
                        Console.WriteLine("4) Return to the main menu");
                        Console.Write("\n" + "Please choose from one of the menu options:");

                        string ReportMenuSelection = Console.ReadLine();

                        if (ReportMenuSelection == "1")
                        {
                            // B1) Change student
                            
                            ChangeStudent(studentGrades);

                        }
                        else if (ReportMenuSelection == "2")
                        {
                            // B2) Add student
                            AddOneStudent(studentGrades);

                        }
                        else if (ReportMenuSelection == "3")
                        {
                            // B3) Delete student
                            DeleteStudent(studentGrades);
                        }
                        else if (ReportMenuSelection == "4")
                        {
                            // 3) Return to the main menu
                            break;
                        }
                        else
                        {
                            Console.Write("Invalid input");
                        }
                    }
                    
                }
                // Grade Management 
                else if (menuSelection == "3")
                {
                    while (true)
                    {
                        Console.Clear();

                        Console.WriteLine("1) Change grades");
                        Console.WriteLine("2) Add grades");
                        Console.WriteLine("3) Delete grades");
                        Console.WriteLine("4) Return to the main menu");
                        Console.Write("\n" + "Please choose from one of the menu options:");

                        string ReportMenuSelection = Console.ReadLine();

                        if (ReportMenuSelection == "1")
                        {
                            // C1) Change grade
                            Console.Clear();
                            ChangeGrade(studentGrades);
                        }
                        else if (ReportMenuSelection == "2")
                        {
                            // C2) Add grade
                            Console.Clear();
                            AddGrade(studentGrades);
                        }
                        else if (ReportMenuSelection == "3")
                        {
                            // C3) Delete grade
                            Console.Clear();
                            DeleteGrade(studentGrades);
                        }
                        else if (ReportMenuSelection == "4")
                        {
                            // C4) Return to the main menu
                            break;
                        }
                        else
                        {
                            Console.Write("Invalid input");
                        }
                    }

                }
                // Exit 
                else if (menuSelection == "4")
                {
                    break;
                }
                else
                {
                    Console.Write("Invalid input");
                }

                
                Console.Clear();
            }


            Console.ReadKey();


        }
        }
    }

