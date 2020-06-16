using System;
using System.IO;

namespace HomeWorkOOP_KSergey
{
    class FileManager
    {
        private string _path;

        public FileManager(string path)
        {
            
            if (!path.Contains(":"))
            {
                throw new ArgumentException("Директория не содержит имя диска");
                
            }

            if (path.Contains("."))
            {
                throw new ArgumentException("Записано название файла");
            }

            if(path.Contains("//"))
            {
                throw new ArgumentException("Пропущено название директории");
            }
            
            DirectoryInfo dirInfo = new DirectoryInfo($@"{path}");
            if (!dirInfo.Exists)
            {
                dirInfo.Create();
            }
            _path = path;

        }
        public void CreateFile(Person p)
        {
            //check

            var filename = p.FirstName + ".txt";
            var fullfilename = Path.Combine(_path, filename);

            DirectoryInfo dirInfo = new DirectoryInfo(fullfilename);
            if (!dirInfo.Exists)
            {
                dirInfo.Create();
            }
        }

    }
}
