
namespace BatchPrimeNumbers
{
    class Program
    {

        static void Main(string[] args)
        {
            // Sharing a .exe for the task AND the job creator
            // Switch on a argument flag
            if (args != null && args.Length > 0 && args[0] == "--Task")
            {
                PrimeTask.TaskMain(args);
            }
            else
            {
                PrimeJob.JobMain(args);
            }
            
        }
    }
}
