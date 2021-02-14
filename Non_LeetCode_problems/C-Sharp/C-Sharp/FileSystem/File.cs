using System;
using System.Collections.Generic;
using System.Text;

namespace FileSystem
{
    public class File
    {
        public string Name { get; set; }
        public string Extension { get; set; }
        public File(string name)
        {
            Name = name;
        }
    }
}
