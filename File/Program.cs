using File;

ArquivoTest arquivo = new ArquivoTest();
arquivo.WriteDirectoriesNamesFile();

ArquivoTest objArquivo = new ArquivoTest(@"C:\arquivo", "teste.txt");

objArquivo.WriteFile("Ebaaa !!! Escrevi num te xis tê!");

objArquivo.ReadFileBuffer();
objArquivo.ReadToEnd();
objArquivo.ReadFileByLine();

