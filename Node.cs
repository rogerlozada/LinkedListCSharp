namespace LinkedList
{
    public class Node
    {
        public Node(string name)
        {
            this.Name = name;
            this.Next = null;
        }
        
        public string Name { get; set; }

        public Node Next { get; set; }
    }
}
