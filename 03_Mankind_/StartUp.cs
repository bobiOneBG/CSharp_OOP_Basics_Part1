namespace _03_Mankind_
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var studentInData = Console.ReadLine().Trim().Split();
            var workerInData = Console.ReadLine().Trim().Split();
            try
            {
                var student = new Student(studentInData[0],
                    studentInData[1],
                    studentInData[2]);
                var worker = new Worker(workerInData[0],
                    workerInData[1],
                    decimal.Parse(workerInData[2]),
                    int.Parse(workerInData[3]));

                Console.WriteLine(student);
                Console.WriteLine(worker);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
