
using iText.IO.Image;
using iText.Kernel.Colors;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Action;
using iText.Kernel.Pdf.Canvas.Draw;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;

namespace File
{
    internal class Arquivo
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

        public Arquivo() { }
        public Arquivo(string directoy, string file)
        {
            _directory = directoy;
            _file = file;

            ValidarDiretorio();

            _path = Path.Combine(_directory, _file);
        }

        private void ValidarDiretorio()
        {
            if (!System.IO.Directory.Exists(_directory))
            {
                try
                {
                    System.IO.Directory.CreateDirectory(_directory);
                }
                catch (IOException ex)
                {
                    throw ex;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }

        }

        private void ValidarArquivo()
        {
            if (!System.IO.File.Exists(_path))
            {
                throw new IOException("arquivo não existe!");
            }
        }

        internal void WritePDFFile(string data)
        {
            try
            {
                PdfWriter writer = new PdfWriter(_path);
                PdfDocument pdf = new PdfDocument(writer);
                Document document = new Document(pdf);


                Paragraph header = new Paragraph("BEM VINDO")
                   .SetTextAlignment(TextAlignment.CENTER)
                   .SetFontSize(20);

                document.Add(header);

                Paragraph subheader = new Paragraph("PESSOAS QUERIDAS!")
                        .SetTextAlignment(TextAlignment.CENTER)
                        .SetFontSize(15);

                document.Add(subheader);

                LineSeparator ls = new LineSeparator(new SolidLine());
                document.Add(ls);

                document.Add(new Paragraph(data));

                document.Add(ls);

                Image img = new Image(ImageDataFactory
                        .Create(@"C:\Users\Ellen\OneDrive\Imagens\123575931_3519258338150648_157569515198997980_n.jpg"))
                        .SetTextAlignment(TextAlignment.CENTER);

                document.Add(img);

                Table table = new Table(2, false);
                Cell cell11 = new Cell(1, 1)
                   .SetBackgroundColor(ColorConstants.GRAY)
                   .SetTextAlignment(TextAlignment.CENTER)
                   .Add(new Paragraph("State"));
                Cell cell12 = new Cell(1, 1)
                   .SetBackgroundColor(ColorConstants.GRAY)
                   .SetTextAlignment(TextAlignment.CENTER)
                   .Add(new Paragraph("Capital"));

                Cell cell21 = new Cell(1, 1)
                   .SetTextAlignment(TextAlignment.CENTER)
                   .Add(new Paragraph("New York"));
                Cell cell22 = new Cell(1, 1)
                   .SetTextAlignment(TextAlignment.CENTER)
                   .Add(new Paragraph("Albany"));

                Cell cell31 = new Cell(1, 1)
                   .SetTextAlignment(TextAlignment.CENTER)
                   .Add(new Paragraph("New Jersey"));
                Cell cell32 = new Cell(1, 1)
                   .SetTextAlignment(TextAlignment.CENTER)
                   .Add(new Paragraph("Trenton"));

                Cell cell41 = new Cell(1, 1)
                   .SetTextAlignment(TextAlignment.CENTER)
                   .Add(new Paragraph("California"));
                Cell cell42 = new Cell(1, 1)
                   .SetTextAlignment(TextAlignment.CENTER)
                   .Add(new Paragraph("Sacramento"));

                table.AddCell(cell11);
                table.AddCell(cell12);
                table.AddCell(cell21);
                table.AddCell(cell22);
                table.AddCell(cell31);
                table.AddCell(cell32);
                table.AddCell(cell41);
                table.AddCell(cell42);

                document.Add(ls);
                document.Add(table);

                // Hyper link
                Link link = new Link("click here",
                   PdfAction.CreateURI("https://www.google.com"));
                Paragraph hyperLink = new Paragraph("Please ")
                   .Add(link.SetBold().SetUnderline()
                   .SetItalic().SetFontColor(ColorConstants.BLUE))
                   .Add(" to go www.google.com.");

                document.Add(ls);
                document.Add(hyperLink);

                document.Close();
            }
            catch (iText.IO.Exceptions.IOException ex)
            {
                Console.WriteLine(ex.Message);
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

        internal void WriteFile(string data)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(_path))
                {
                    sw.WriteLine(data);
                    Console.WriteLine("Arquivo salvo com sucesso!");
                }

            }
            catch (System.IO.IOException ex)
            {
                Console.WriteLine(ex.Message);
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

        internal void ReadFileByLine()
        {
            try
            {
                ValidarArquivo();

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
                ValidarArquivo();

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
            ValidarArquivo();

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
            using (StreamWriter sw = new StreamWriter(_path))
            {
                foreach (DirectoryInfo dir in cDirs)
                {
                    sw.WriteLine(dir.Name);
                }
            }

            // Le e mostra cada pasta no console
            string line = "";
            using (StreamReader sr = new StreamReader(_path))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
}
