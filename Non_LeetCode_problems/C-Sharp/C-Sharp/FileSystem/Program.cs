using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace FileSystem
{
    class Program
    {
        static void Main(string[] args)
        {


            FileSystem fileSystem = new FileSystem();

            Console.WriteLine("FileSystem v1 2021");
            Console.WriteLine("(c) Welcome to the BudgetingAppFileSystem!!\n");

            ConsoleIteration(fileSystem);

        }
        public static void ConsoleIteration(FileSystem fileSystem)
        {
            //Ask you for commands.
            Console.Write("\n" + fileSystem.CurrentDirectory);
            string command = Console.ReadLine();
            string commandName = TryGetCommandName(command);

            //Ask to enter command if previous command is wrong.
            if (!Enum.IsDefined(typeof(FileSystem.Commands), commandName))
            {
                Console.WriteLine("'{0}' is not recognized as a command.", command);
                // Here we will give them a list of recognized commands.

                ConsoleIteration(fileSystem);
            }
            else
            {
                // Regex to match user input
                Regex regexCreateFolder = new Regex("crfo [A-Za-z0-9_-]*");
                Regex regexCreateFile = new Regex(@"crfi [A-Za-z0-9_-]*\.[A-Za-z]*");
                Regex regexDeleteFolder = new Regex("defo [A-Za-z0-9]*");
                Regex regexDeleteFile = new Regex(@"defi [A-Za-z0-9_-]*\.[A-Za-z]*");
                Regex regexGoToFolder = new Regex("gofo [A-Za-z0-9]*");

                if (regexCreateFolder.IsMatch(command))
                {
                    // Get folder name
                    string folderName = GetFolderOrFileName(command);

                    // For root it looks like this 'FS:/>'
                    // If you are in some other folder inside 'FS:/>' it will look like this 'FS:/folder1/>'
                    string currentDir = fileSystem.CurrentDirectory;

                    // If this is the root folder,
                    if (currentDir == fileSystem.RootFolder.Name)
                    {
                        // Add the list of folders to RootFolder
                        fileSystem.RootFolder.FolderList = new List<Folder>();
                        // Add folder into the new list
                        fileSystem.RootFolder.FolderList.Add(new Folder(folderName));

                        // Removes '/>' from the end of a string.
                        // It will change a string from 'FS:/>' to 'FS: (or 'FS:/folder1/>' to 'FS:/folder1' when you're not in root folder).
                        string currentPathString = GetCurrentPathString(currentDir);

                        // E.g. Takes 'FS:' and concatinates it with '/folder1/' to return 'FS:/folder1'
                        string pathWithNewFolder = GetPathWithNewFolder(currentPathString, folderName);

                        //Adds 'FS:/folder1' to PossiblePathSet.
                        fileSystem.PossiblePathSet.Add(pathWithNewFolder);
                    }
                    else
                    {
                        
                    }
                }
                if (regexCreateFile.IsMatch(command))
                {
                    string fileName = GetFolderOrFileName(command);

                    string currentDir = fileSystem.CurrentDirectory;

                    if (currentDir == fileSystem.RootFolder.Name)
                    {
                        
                        fileSystem.RootFolder.FileList = new List<File>();
                        
                        fileSystem.RootFolder.FileList.Add(new File(fileName));
                    }
                }
                if (regexDeleteFolder.IsMatch(command))
                {
                    string folderName = GetFolderOrFileName(command);

                    // check if the current directory has the file that you want to delete
                    // if it does, 
                    
                }
                if (regexDeleteFile.IsMatch(command))
                {
                    string fileName = GetFolderOrFileName(command);
                    
                }
                if (regexGoToFolder.IsMatch(command))
                {
                    string folderName = GetFolderOrFileName(command);
                    string currentPathString = GetCurrentPathString(fileSystem.CurrentDirectory);
                    string currentPathWithNewFolder = GetPathWithNewFolder(currentPathString, folderName);

                    if (fileSystem.PossiblePathSet.Contains(currentPathWithNewFolder))
                    {
                        string newCurrentDir = currentPathWithNewFolder + ">";
                        fileSystem.CurrentDirectory = newCurrentDir;

                    }

                    // First we need to get where we at currently e.g. 'FS:/>' (
                    // Then get 'FS:/>' without '/>' sooo 'FS:'.
                    // Then build a string  adding '/'
                    // Then add 'folderName'
                    // Then add '/' at the end.
                    // Once the string is complete, check if it is in the Set.

                    //If it is 
                    //Then you want to update 'FileSystem.CurrentDirectory' (For that you have to add '/>' at the end)
                    

                }
                
            }


            string stringOfNewFolderName = "MyFolder1";

            switch (command)
            {
                case "crfo":
                    Console.WriteLine("The syntax of the command is incorrect. You may have forgotten folder name argument.");
                    Console.WriteLine("Correct usage: crfo [folderName]");
                    break;
                case "crfi":
                    Console.WriteLine("The syntax of the command is incorrect. You may have forgotten file name argument.");
                    Console.WriteLine("Correct usage: crfi [fileName]");
                    break;
                case "defo":
                    Console.WriteLine("The syntax of the command is incorrect. You may have forgotten folder name argument.");
                    Console.WriteLine("Correct usage: defo [folderName]");
                    break;
                case "defi":
                    Console.WriteLine("The syntax of the command is incorrect. You may have forgotten file name argument.");
                    Console.WriteLine("Correct usage: defi [fileName]");
                    break;
                default:
                    ConsoleIteration(fileSystem);
                    break;

            }
        }

        private static string GetPathWithNewFolder(string currentPathString, string folderName)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(currentPathString);
            sb.Append("/");
            sb.Append(folderName);
            sb.Append("/");
            return sb.ToString();
        }

        private static string GetCurrentPathString(string currentDir)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = currentDir.Length - 1; i >= 0; i--)
            {
                if (i < currentDir.Length - 2 && currentDir[i] != '/')
                {
                    sb.Insert(0, currentDir[i]);
                }
                //if (i < currentDir.Length - 2 && currentDir[i] == '/')
                //{
                //    break;
                //}
            }
            return sb.ToString();
        }

        private static string GetFolderOrFileName(string command)
        {
            string folderOrFileName = "";
            bool isAfterSpace = false;
            for (int i = 0; i < command.Length; i++)
            {
                if (command[i] == ' ')
                {
                    isAfterSpace = true;
                }
                if (isAfterSpace && command[i] != ' ')
                {
                    folderOrFileName += command[i];
                }
            }
            return folderOrFileName;
        }

        private static string TryGetCommandName(string command)
        {
            string initialCommand = "";
            for (int i = 0; i < command.Length; i++)
            {
                if (command[i] == ' ')
                {
                    break;
                }
                initialCommand += command[i];
            }
            return initialCommand;
        }
    }
}
