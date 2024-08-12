namespace File
{
    internal class ArquivoTest
    {
        private string _directory;
        private string _file;
        private string _path;
        public string Directory
        {
            get
            {
                if (string.IsNullOrEmpty(_directory))
                    return @"C:\arquivo";
                return _directory;
            }

            set { _directory = value; }

        }
        public string File
        {
            get
            {
                if (string.IsNullOrEmpty(_file))
                    return "Text.txt";
                return _file;
            }

            set { _file = value; }
        }

        public ArquivoTest() { }
        public ArquivoTest(string directoy, string file)
        {
            _directory = directoy;
            _file = file;

            _path = Path.Combine(_directory, _file);
        }

        internal void WriteFile(string data)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(_path))
                    sw.WriteLine(data);
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        internal void ReadFileByLine()
        {
            try
            {
                using (StreamReader sr = new StreamReader(_path))
                {
                    string line;

                    while ((line = sr.ReadLine()) != null)
                        Console.WriteLine(line);
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
        }

        internal void ReadToEnd()
        {
            try
            {
                using StreamReader reader = new(_path);

                string text = reader.ReadToEnd();

                Console.WriteLine(text);
            }
            catch (IOException e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally 
            {
                Console.WriteLine("Processo finalizado!");
            }
        }

        internal void ReadFileBuffer()
        {
            Char[] buffer;

            try
            {
                using (var sr = new StreamReader(_path))
                {
                    buffer = new Char[(int)sr.BaseStream.Length];
                    sr.Read(buffer, 0, (int)sr.BaseStream.Length);
                }
                Console.WriteLine(new String(buffer));
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        internal void WriteDirectoriesNamesFile()
        {
            // obtem a lista de diretorios no drive C:/
            DirectoryInfo[] cDirs = new DirectoryInfo(@"C:\").GetDirectories();

            // Escreve o nome de cada pasta no arquivo
            using (StreamWriter sw = new StreamWriter("CDriveDirs.txt"))
            {
                foreach (DirectoryInfo dir in cDirs)
                {
                    sw.WriteLine(dir.Name);
                }
            }

            // Le e mostra cada pasta no console
            string line = "";
            using (StreamReader sr = new StreamReader("CDriveDirs.txt"))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
}
