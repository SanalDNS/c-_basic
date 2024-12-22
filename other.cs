namespace others
{

    public class justOthers
    {
        public static async Task runss()
        {
            Console.WriteLine("async code");
            await Task.Delay(5000);
            Console.WriteLine("async code done");

        }
    }
}