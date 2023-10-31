using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test0809;


namespace test0809
    {
        internal class Program
        {
            static teacher[] _teacher = new teacher[100];
            static int teachercount = 0;
            static student[] _students = new student[100];
            static int studentCount = 0;

            static void Main(string[] args)
            {
                try
                {
                    Console.WriteLine("menu: ");
                    Console.WriteLine("1-teacher: ");
                    Console.WriteLine("2-student: ");
                    Console.WriteLine("3-termzaban: ");
                    Console.WriteLine("4-exit :");
                    int choice1 = Convert.ToInt32(Console.ReadLine());
                    switch (choice1)
                    {
                        case 1:
                            methodteacher();
                            break;
                        case 2:
                            methodstudent();
                            break;
                        //case 3:
                        //    methodtermzaban();
                        //    break;
                        case 4:
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("please enter of 1-4!!");
                            break;
                    }
                }
                finally
                {
                    Console.Clear();

                }




            }

            static void RegisterStudent()
            {
                if (studentCount < _students.Length)
                {
                    Console.Write("first name : ");
                    string firstName = Console.ReadLine();
                    Console.Write("last name : ");
                    string lastName = Console.ReadLine();
                    Console.Write("score ");
                    int score = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("codeid : ");
                    int codeID = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("dateold : ");
                    int dateOLD = Convert.ToInt32(Console.ReadLine());

                    _students[studentCount] = new student(firstName, lastName, score, codeID, dateOLD);
                    studentCount++;

                    Console.WriteLine("success register");

                }
                else
                {
                    Console.WriteLine("opps over load");
                }
            }

            static void EditStudent()
            {
                Console.Write("enter codID to edit ");
                int studentNumber = Convert.ToInt32(Console.ReadLine());

                if (studentNumber >= 1 && studentNumber <= studentCount)
                {
                    Console.Write("new name :  ");
                    string newFirstName = Console.ReadLine();
                    Console.Write("new lastname :  ");
                    string newLastName = Console.ReadLine();
                    Console.Write("new score : ");
                    int newscore = Convert.ToInt32(Console.ReadLine());
                    Console.Write("new codID : ");
                    int newcodeID = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("new dateOLD");
                    int newdateOLD = Convert.ToInt32(Console.ReadLine());




                    _students[studentNumber - 1].Firstname = newFirstName;
                    _students[studentNumber - 1].Lastname = newLastName;
                    _students[studentNumber - 1].Score = newscore;
                    _students[studentNumber - 1].codeid = newcodeID;
                    _students[studentNumber - 1].dateold = newdateOLD;

                    Console.WriteLine("seccuss edited");

                }
                else
                {
                    Console.WriteLine("invalid codID!!!!!");
                }
            }

            static void DeleteStudent()
            {
                Console.Write("enter codID to remove : ");
                int studentNumber = Convert.ToInt32(Console.ReadLine());

                if (studentNumber >= 1 && studentNumber <= studentCount)
                {
                    for (int i = studentNumber - 1; i < studentCount - 1; i++)
                    {
                        _students[i] = _students[i + 1];
                    }
                    studentCount--;

                    Console.WriteLine("seccuss removed ");


                }
                else
                {
                    Console.WriteLine(" invalid codID!!!!");
                }
            }

            static void ListStudents()
            {
                if (studentCount == 0)
                {
                    Console.WriteLine("nothing student ");
                    return;
                }

                Console.WriteLine("listOFstudent:");
                for (int i = 0; i < studentCount; i++)
                {
                    Console.WriteLine($"number: {i + 1}," +
                        $" firstname: {_students[i].Firstname}, " +
                        $" lastname: {_students[i].Lastname}," +
                        $" score: {_students[i].Score}," +
                        $" codID: {_students[i].codeid}," +
                        $" dateOLD: {_students[i].dateold}");
                }
            }

            static void ReturnToMainMenu()
            {
                Console.WriteLine("enter to return");
                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 6)
                {
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine(" invalid choice");
                    ReturnToMainMenu();
                }
            }
            static void methodstudent()
            {
                while (true)
                {
                    Console.WriteLine("menu :");
                    Console.WriteLine("1.sabt danesh amoz:");
                    Console.WriteLine("2.edit student");
                    Console.WriteLine("3.remove student");
                    Console.WriteLine("4.listOFstudent");
                    Console.WriteLine("5.exit");
                    Console.WriteLine("6.ReturnToMainMenu");
                    int choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            RegisterStudent();
                            break;
                        case 2:
                            EditStudent();
                            break;
                        case 3:
                            DeleteStudent();
                            break;
                        case 4:
                            Console.Clear();
                            ListStudents();
                            break;
                        case 5:
                            Environment.Exit(0);
                            break;
                        case 6:
                            ReturnToMainMenu();
                            break;
                        default:
                            Console.WriteLine("invalid choice");
                            break;
                    }
                }
            }

            static void methodteacher()
            {
                while (true)
                {
                    Console.WriteLine("menu :");
                    Console.WriteLine("1.sabt  teacher:");
                    Console.WriteLine("2.edit teacher");
                    Console.WriteLine("3.remove teacher");
                    Console.WriteLine("4.listOFteacher");
                    Console.WriteLine("5.exit");
                    Console.WriteLine("6.ReturnToMainMenu");
                    int choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            RegisterTeacher();
                            break;
                        case 2:
                            EditTeacher();
                            break;
                        case 3:
                            DeleteTeacher();
                            break;
                        case 4:
                            Console.Clear();
                            ListTeacher();
                            break;
                        case 5:
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("invalid choice");
                            break;
                    }

                }
            }
            static void RegisterTeacher()
            {
                if (teachercount < _teacher.Length)
                {
                    Console.WriteLine("first name : ");
                    string first_name = Console.ReadLine();
                    Console.WriteLine("last name : ");
                    string last_name = Console.ReadLine();
                    Console.WriteLine("codetc : ");
                    int codeTC = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("codeid : ");
                    int codeID = Convert.ToInt32(Console.ReadLine());

                    _teacher[teachercount] = new teacher(first_name, last_name, codeTC, codeID);
                    teachercount++;

                    Console.WriteLine("success register");
                }
                else
                {
                    Console.WriteLine("oops over load");
                }
            }
            static void EditTeacher()
            {
                Console.WriteLine("invalid codeid");
                int nums = Convert.ToInt32(Console.ReadLine());

                if (nums >= 1 && nums <= teachercount)
                {
                    Console.WriteLine("enter new name :");
                    string newfirst_name = Console.ReadLine();
                    Console.WriteLine("enter new kast name : ");
                    string newlast_name = Console.ReadLine();
                    Console.WriteLine("codetc :");
                    int newcodetc = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("codetid :");
                    int newcodeid = Convert.ToInt32(Console.ReadLine());

                    _teacher[nums - 1].FirstName = newfirst_name;
                    _teacher[nums].LastName = newlast_name;
                    _teacher[nums].CodeTC = newcodetc;
                    _teacher[nums].CodeID = newcodeid;
                    Console.WriteLine("success edited");


                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            static void DeleteTeacher()
            {
                Console.WriteLine("enter a id");
                int nums = Convert.ToInt32(Console.ReadLine());

                if (nums >= 1 && nums <= teachercount)
                {
                    for (int i = nums - 1; i >= 0; i--)
                    {
                        _teacher[i] = _teacher[i + 1];
                    }
                    teachercount--;

                    Console.WriteLine("remove seccuss..");
                }
                else
                {
                    Console.WriteLine("invalid codeid");
                }
            }
            static void ListTeacher()
            {
                if (teachercount == 0)
                {
                    Console.WriteLine("nothing teacher!!!");
                }
                else
                {
                    Console.WriteLine("listOFteacher");
                    for (int i = 0; i < teachercount; i++)
                    {
                        Console.WriteLine($"number {i + 1} firstname : {_teacher[i].FirstName}" +
                            $",lastname : {_teacher[i].LastName}," +
                            $"CodeTC  : {_teacher[i].CodeTC}" +
                            $"codeID : {_teacher[i].CodeID}");
                    }
                }
            }



        }







































        //int i = 0;
        //student[] student_person = new student[20];

        //Console.WriteLine("please enter a number : ");
        //int num = Convert.ToInt32(Console.ReadLine());
        //if (num == 2)
        //{
        //    Console.WriteLine("please enter a number : ");
        //    int num1 = Convert.ToInt32(Console.ReadLine());
        //    if(num1 == 1)
        //    {

        //        Console.WriteLine("please enter name : ");
        //        string name_ = Console.ReadLine();
        //        Console.WriteLine("please enter family : ");
        //        string family_ = Console.ReadLine();
        //        Console.WriteLine("please enter codeid : ");
        //        int codeid_ = Convert.ToInt32(Console.ReadLine());
        //        Console.WriteLine("please enter dateold : ");
        //        int dateold_ = Convert.ToInt32(Console.ReadLine());
        //        Console.WriteLine("please enter score : ");
        //        int score_ = Convert.ToInt32(Console.ReadLine());

        //        student s = new student(name_, family_, codeid_, dateold_, score_);
        //        student_person[i] = s;
        //        i++;

        //    }
        //}
        //foreach(student s1 in student_person)
        //{
        //    Console.WriteLine($"s1 name is : {s1.Name} s1 famoily is : {s1.Family}    ");
        //}


    }




