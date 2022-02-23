using System;


namespace Code_First_Student_dB
{


    class Program
    {
        static void Main(string[] args)
        {
            using (SchoolContext ctx = new SchoolContext())
            {
                var stud = new Student() { StudentName = "Bill" };

                //ctx.Students.Add(stud);
                //ctx.SaveChanges();
                //Console.WriteLine(stud.StudentName);

                var stud2 = new Student() { StudentFName="Bob",Height=160,Weight=60 };
                ctx.Students.Add(stud2);
                ctx.SaveChanges();
                Console.WriteLine(stud2.StudentFName + stud2.Height.ToString() + stud2.Weight.ToString());
            }
        }
    }
}
