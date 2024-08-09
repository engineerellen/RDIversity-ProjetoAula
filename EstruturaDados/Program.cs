
using EstruturaDados;
using EstruturaDados.BinaryTree;
using EstruturaDados.HashDictionary;
using EstruturaDados.Pilha;

//Dictionary
DictionaryTest.TestDictionary();

 //HashTable
HashTableTest.TestHashTable();
//List
TesteLista();

Console.WriteLine("-------------------------------------------");

//Pilha
TestePilha();

Console.WriteLine("-------------------------------------------");

//Fila
QueueClass.TestQueue();

Console.WriteLine("-------------------------------------------");

//LinkedList
LinkedList.PrioridadePostinho();

Console.WriteLine("-------------------------------------------");

BinaryTree.TestBinaryTree();


static void TesteLista()
{
    //leitura da lista
    var turminhaGalinha = ListTest.TestList();

    //insercao da lista
    Console.WriteLine("Insira um amiguinho ");
    string amiguinho = Console.ReadLine();

    ListTest.AddList(amiguinho, turminhaGalinha);

    Console.WriteLine("Lista com os amiguinhos atualizados: ");
    foreach (var item in turminhaGalinha)
        Console.WriteLine(item);
}

static void TestePilha()
{
    StackSimples.TestarStackSimples();
    StackGenerica.TesteStackGenerica();
}