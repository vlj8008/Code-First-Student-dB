using System;


namespace Code_First_Student_dB
{


    class Program
    {
        static void Main(string[] args)
        {
            using (SchoolContext ctx = new SchoolContext())
            {
                Console.WriteLine("Please enter your name");
                string fname = Console.ReadLine();
                Console.WriteLine("What is your last name");
                string lname = Console.ReadLine();
                Console.WriteLine("What is your height?");
                int height = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("What is your weight?");
                int weight = Convert.ToInt32(Console.ReadLine());

                var stud = new Student() { StudentName = fname, StudentLName = lname,Height = height, Weight=weight };

                ctx.Students.Add(stud);
                ctx.SaveChanges();
                Console.WriteLine("Your name is:" + stud.StudentName + stud.StudentLName);
                Console.WriteLine("Your height is: " + stud.Height.ToString());
                Console.WriteLine("Your weight is: "+ stud.Weight.ToString());
                Console.ReadLine();
            }
        }
    }
}
