namespace LinkedList
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            //vamos inicializar nossa lista
            var linkedList = new LinkedList();
            
            //inserindo o primeiro valor
            linkedList.Push("Joseph");
            linkedList.Push("Drake");
            
            //Vai imprimir Joseph, Drake
            Console.WriteLine(linkedList.ToString());

            //removendo o joseph
            linkedList.RemoveAt(0);

            //Vai imprimir Drake
            Console.WriteLine(linkedList.ToString());

            //vamos inserir um novo nome
            linkedList.Push("Barney");      

            //vamos até a posição 1 onde está o Barney e imprimir
            Console.WriteLine(linkedList.getElementAt(1).Name);      

            //inserimos Arya depois de Drake
            linkedList.Insert("Arya", 1);

            //Vai imprimir no console Drake, Arya e Barney
            Console.WriteLine(linkedList.ToString());

        }
    }
}
