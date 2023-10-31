using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace test0809
{
    internal class student
    {
        public student(string firstname, string lastname, int codeid, int dateold, int score)
        {
            this.Firstname = firstname;
            this.Lastname = lastname;
            this.codeid = codeid;
            this.dateold = dateold;
            this.Score = score;
        }

        public string Firstname { get; set; }
        public string Lastname { get; set; }

        public int codeid { get; set; }

        public int dateold { get; set; }
        public int Score { get; set; }




        //static string[] student_name = new string[20];
        //static string[] student_family = new string[20];
        //static int[] student_codeid = new int[20];
        //static int[] student_dateold = new int[20];
        //static int[] student_score = new int[20];

        static List<string> student_name = new List<string>();
        static List<string> student_family = new List<string>();
        static List<int> student_codeid = new List<int>();
        static List<int> student_dateold = new List<int>();
        static List<int> student_score = new List<int>();

        public void AddStudent(string name, string family, int codeid, int dateold, int score)
        {
            student_name.Add(name);
            student_family.Add(family);
            student_codeid.Add(codeid);
            student_dateold.Add(dateold);
            student_score.Add(score);
        }
        public void StudentOfLIST(int codeid)
        {

            //student s = new student();
            //foreach()
            Console.WriteLine();
        }


    }


    //    Console.WriteLine("enter peson number :");
    //            int number = Convert.ToInt32(Console.ReadLine());
    //    Person[] people = new Person[number];

    //            for (int i = 0; i<number; i++)
    //            {
    //                Console.WriteLine($"enter person Name {i+1} :");
    //                string name = Console.ReadLine();
    //    Console.WriteLine($"enter person Id {i+1} :");
    //                int id = Convert.ToInt32(Console.ReadLine());

    //    Person p = new Person(name, id);
    //    people[i] = p;
    //            }
    //Console.ForegroundColor = ConsoleColor.Green;
    //foreach (Person person in people)
    //{
    //    Console.WriteLine($" name :{person.name} id : {person.id} ");
    //}
    //Console.ResetColor();























}
