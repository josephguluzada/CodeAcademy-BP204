namespace Pustok.Helpers
{
    public static class FileManager
    {
        //public static string SaveFile(string rootPath, string folderName, IFormFile file)
        //{
        //    string fileName = file.FileName;
        //    fileName = fileName.Length > 64 ? fileName.Substring(fileName.Length - 64, 64) : fileName;

        //    fileName = Guid.NewGuid().ToString() + fileName;

        //    string path = Path.Combine(rootPath, folderName, fileName);

        //    using(FileStream fileStream = new FileStream(path, FileMode.Create))
        //    {
        //        file.CopyTo(fileStream);
        //    }

        //    return fileName;
        //}

        public static string SaveFile(this IFormFile file,string rootPath, string folderName)
        {
            string fileName = file.FileName;
            fileName = fileName.Length > 64 ? fileName.Substring(fileName.Length - 64, 64) : fileName;

            fileName = Guid.NewGuid().ToString() + fileName;

            string path = Path.Combine(rootPath, folderName, fileName);

            using (FileStream fileStream = new FileStream(path, FileMode.Create))
            {
                file.CopyTo(fileStream);
            }

            return fileName;
        }
    }
}
