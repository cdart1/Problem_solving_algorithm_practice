using System;
using System.Collections.Generic;
using System.Text;

namespace FileSystem
{
    public class FileSystem
    {
        public Folder RootFolder { get; set; }

        public Folder CurrentFolder { get; set; }
        public string CurrentDirectory { get; set; }
        public HashSet<string> PossiblePathSet { get; set; }
        public enum Commands
        {
            crfo,
            crfi,
            defo,
            defi,
            gofo
        };
        public string RootDirectoryName {get;} = @"FS:/>";

        public FileSystem()
        {
            RootFolder = new Folder(RootDirectoryName);
            CurrentDirectory = RootDirectoryName;
            PossiblePathSet = new HashSet<string>();
            PossiblePathSet.Add(@"FS:");
            CurrentFolder = RootFolder;
        }

        public static string GetDirectory()
        {
            throw new NotImplementedException();
        }
    }
}
