namespace TaskLesson
{
    internal class Program
    {
        static async Task Main(string[] args)
        {

            //var a = Task.Run(() =>
            //{
            //    return "Salam";
            //});
            //Console.WriteLine(a.Result);

            //Console.WriteLine(GetString());
            //Console.WriteLine("salam");

            //var a = await GetStringRufetAsync();
            await Task.WhenAll(  GetStringRufetAsync("https://docs.microsoft.com/azure/devops"),GetStringRufetAsync("https://docs.microsoft.com/dotnet"), GetStringRufetAsync("https://docs.microsoft.com"));
            //a.Wait();

            //Console.WriteLine(a.Result);

            //while (!a.IsCompleted)
            //{
            //    Console.WriteLine("Davam edir...");
            //}
            //Console.WriteLine("Finished!");
            //Console.WriteLine(a.Result);
        }

        public static string GetString()
        {
            HttpClient client = new HttpClient();
            return client.GetStringAsync("https://github.com/").Result;
        }

        //public static  Task<string> GetStringRufetAsync()
        //{
        //    HttpClient client = new HttpClient();
        //    return  client.GetStringAsync("https://github.com/");
        //}

        public static async Task<string> GetStringRufetAsync(string url)
        {
            HttpClient client = new HttpClient();
            string str = await client.GetStringAsync(url);
            Console.WriteLine(url+" -> "+str.Length);
          return str; 
        }

        public static async Task GetHello()
        {
            Console.WriteLine("Salam");
        }

        public static async Task Get (string str)
        {
            await Task.Delay(2000);
            Console.WriteLine(str.Length);
        }
    }
}