using ExoLinq.Context;

namespace ExoLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataContext dataContext = new DataContext();

            foreach(Student student in dataContext.Students)
            {
                Console.WriteLine($"{student.Last_Name} {student.First_Name}");
            }
        }
    }
}