using File;

//StreamWrite - escrita de arquivo

Arquivo objArquivo = new Arquivo(@"C:\arquivo", "testeB.pdf");
objArquivo.WritePDFFile("Ebaaa !!! Escrevi num pê dê éfe!");

objArquivo.WriteFile("Ebaaa !!! Escrevi num te xis tê!");

objArquivo.WriteDirectoriesNamesFile();

objArquivo.ReadFileBuffer();
objArquivo.ReadToEnd();
objArquivo.ReadFileByLine();