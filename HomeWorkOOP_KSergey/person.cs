using System;
using System.IO;

namespace HomeWorkOOP_KSergey
{
    public class Person
    {

        public int ID { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string MideName { get; set; }
        public DateTime BirthDate { get; set; }
        // public enum Gender { get; set }
        public DateTime CreatedTime { get; set; }
        public DateTime UpdetedTime { get; set; }
        public int UserID { get; set; }


        // создаем директорию и файл для записи

        public void ReadCreateDirectoryF()
        {
            Console.WriteLine("Веедите директорию для записи: ");
            string dirfile = Console.ReadLine();
            if (!dirfile.Contains(":"))
            {
                Console.WriteLine("Директория не содержит имя диска");
            }
            DirectoryInfo dirInfo = new DirectoryInfo($@"{dirfile}");
            if (!dirInfo.Exists)
            {
                dirInfo.Create();
            }

            // создаем файл для записи информации

            Console.WriteLine("введите имя файла(имя файла.расширение)");
            var createFile = Console.ReadLine();

            string path = $@"{dirfile}\{createFile}";

            // Console.WriteLine(path);

            FileStream fstream = new FileStream(path, FileMode.OpenOrCreate);

        }

    }
}
