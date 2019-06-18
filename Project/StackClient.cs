namespace StackNodeParenthesis.Project
{

    public class StackClient
    {
        StackNode root;
        public class StackNode
        {
            public char Value { get; set; }
            public StackNode Next { get; set; }
        }

        public bool IsEmpty => root == null;

        public void Push(char c)
        {
            var node = new StackNode { Value = c };
            if (root == null)
            {
                root = node;
                return;
            }
            node.Next = root;
            root = node;
        }
        public char Pop()
        {
            if (root == null)
            {
                throw new System.Exception("Stack is empty");
            }

            var result = root.Value;
            root = root.Next;
            return result;
        }

    }
}