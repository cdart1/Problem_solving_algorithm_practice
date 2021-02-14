using System;
using System.Collections.Generic;
using System.Text;

namespace FileSystem
{
    public class Folder
    {
        public string Name { get; set; }
        public List<Folder> FolderList { get; set; }
        public List<File> FileList { get; set; }

        public Folder(string nameOfFolder)
        {
            Name = nameOfFolder;
        }
        public Folder CreateFolder()
        {
            throw new NotImplementedException();
        }
        public void DeleteFolder()
        {

        }
        public string CreateFile()
        {
            throw new NotImplementedException();
        }
        public void DeleteFile()
        {

        }
    }
}
