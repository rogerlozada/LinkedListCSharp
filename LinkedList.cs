namespace LinkedList
{
    using System;
    using System.Text;

    public class LinkedList{
        public int Count { get; set; }
        public Node Head { get; set; }

        //insere elemento no final da lista
        public void Push(string name){
            
            //criamos o node
            var node = new Node(name);
            
            // se não tiver nenhum node na LinkedList inserimos o primeiro na Head
            if(this.Head == null){
                this.Head = node;
                this.Count++;
                return;
            }

            //se houver mais do que um node caminhamos até o último node e inserimos o novo node na última posição
            Node current = this.Head;
            while(current.Next != null){
                current = current.Next;
            }

            current.Next = node;
            this.Count++;
        }


        public void RemoveAt(int index){
            
            if(!ExistIndexPosition(index))
                throw new Exception("Invalid index!!!");

            Node current = this.Head;

            //Se for o primeiro indíce nós passamos o valor de Head para o valor do Next
            if(index == 0){
                this.Head = current.Next;
                this.Count--;
                return;
            }


            Node previous = current;
            //Percorremos até o indice e pegamos o Node anterior e o próximo node
            for(var i = 0; i < index; i++){
                previous = current;
                current = current.Next;
            }

            //Definimos o valor do next do Node anterior com o Próximo do atual, removendo um Node
            previous.Next = current.Next;

            this.Count--;
        }

        public Node getElementAt(int index){
            
            if(!ExistIndexPosition(index))
                throw new Exception("Invalid index!!!");

            Node node = this.Head;
            for(var i = 0; i < index && node != null; i++){
                node = node.Next;
            }

            return node;
        }

        public void Insert(string name, int index){
            if(!ExistIndexPosition(index))
                throw new Exception("Invalid index!!!");

            var node = new Node(name);
            
            //Se o indíce estiver na primeira posição inserimos o novo node na sua posição e passamos a primeira posição para a segunda posição
            if(index == 0){
                node.Next = this.Head;
                this.Head = node;
                this.Count++;
                return;
            }

            //obtem o indice anterior
            Node previous = this.getElementAt(index - 1);

            //obtem o node do indíce
            Node current = previous.Next;

            //Define o next do novo node como o node do índice
            node.Next = current;

            //define o next do índice anterior com o valor do novo node
            previous.Next = node;

            this.Count++;
        }

        private bool ExistIndexPosition(int index) =>  index >= 0 && index < this.Count;
        public int Size() => this.Count;
        public bool IsEmpty() => this.Size() == 0;


        public override string ToString(){
            if(this.Head == null){
                return "";
            }

            var names = new StringBuilder();
            names.Append(this.Head.Name);

            Node current = this.Head.Next;
            for(var i = 1; i < this.Size() && current != null; i++){
                names.Append($", {current.Name}"); 
                current = current.Next;
            }

            return names.ToString();
        }

    }
}