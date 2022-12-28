namespace DirectoryInfoFileIO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\Users\\asus\\Desktop\\BB201Test";
            DirectoryInfo directoryInfo = new DirectoryInfo(path);

            directoryInfo.Create();
            directoryInfo.Refresh();

            //Console.WriteLine("Directories: ");
            //foreach (var dr in directoryInfo.GetDirectories())
            //{
            //    //Console.WriteLine($"{dr.Name} - {dr.FullName} - {dr.Parent.Parent.Parent} - {dr.Root} - {dr.Attributes} - {dr.LinkTarget}");
            //    Console.WriteLine("Sub Files: ");
            //    foreach (var item in dr.GetFiles())
            //    {
            //        Console.WriteLine(item.Name);
            //    }
            //}

            //Console.WriteLine("====================================================");
            //Console.WriteLine("Files: ");
            //foreach (var file in directoryInfo.GetFiles())
            //{
            //    Console.WriteLine($"{file.Name} - {file.FullName} - {file.LastAccessTime} - {file.LastWriteTime}");
            //}

            FileInfo newFile = new FileInfo(path + "\\BB201.txt");

            if (!newFile.Exists)
            {
                newFile.Create().Close();
            }
            string[] words = { "Bu", "Bir", "Testdir" };

            File.WriteAllLines(newFile.FullName, words);

            foreach (var file in directoryInfo.GetFiles())
            {
                Console.WriteLine("Files: ");
                foreach (var line in File.ReadAllLines(file.FullName))
                {
                    Console.WriteLine(line);
                }
            }
            if (newFile.LastWriteTime.Date == DateTime.Now.Date)
            {
                newFile.Delete();
            }



        }
    }
}