namespace StudentIEnumerableConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Cohort cohort = new Cohort();
            foreach(string student in cohort) 
            {
                Console.WriteLine(student);
            }
        }

    }
}