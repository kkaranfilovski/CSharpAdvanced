using SEDC.Oop.Class11.Homework.TreeCommand.Helpers.cs;

namespace SEDC.Oop.Class11.Homework.TreeCommand.Entities
{
    public class ConsoleWriter
    {
        protected string Lines { get; } = $"---";
        protected string Indent { get; set; } = String.Empty;
        protected string Root { get; init; }
        protected List<string> File { get; set; } = new List<string>();

        public ConsoleWriter()
        {
            Root = Directory.GetCurrentDirectory();
            ShowTree();
        }

        public ConsoleWriter(string root)
        {
            Root = root;
            if (!Directory.Exists(root))
            {
                throw new ApplicationException("folder doesnt exist");
            }
            ShowTree();
        }

        public ConsoleWriter(string root, string folderName)
        {
            Root = root;
            if (!Directory.Exists(root))
            {
                throw new ApplicationException("folder doesnt exist");
            }
            ShowTree();
            FileWriter.WriteFile(folderName, File);
        }

        protected void ShowTree()
        {
            GetTree(Root, Lines);
        }

        protected void GetTree(string root, string space)
        {
            try
            {
                var folders = Directory.GetDirectories(root, "", SearchOption.TopDirectoryOnly).ToList();
                var files = Directory.GetFiles(root).ToList();

                foreach (string file in files)
                {
                    var filePath = $"{space}{file.Split(@"\").Last()}";
                    File.Add(filePath);

                    Helper.WriteFiles(filePath);
                }

                foreach (string folder in folders)
                {
                    var folderPath = $"{space}{folder.Split(@"\").Last()}";
                    File.Add(folderPath);

                    Helper.WriteFolders(folderPath);
                    Indent = $"   {space}";
                    GetTree(folder, Indent);
                }
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        protected DirectoryInfo GetFolder(string folderName)
        {
            DirectoryInfo asd = new DirectoryInfo(Root);
            DirectoryInfo folderInfo = asd.GetDirectories(folderName, SearchOption.AllDirectories).First();
            return folderInfo;
        }
    }
}
