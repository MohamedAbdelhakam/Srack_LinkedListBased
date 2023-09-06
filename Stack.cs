
Stack<int> stack = new Stack<int>();
public class Stack<T>
{
    private Node Top { get; set; }
    private class Node
    { 
        public T value { get; set; }
        public Node Next { get; set; }
    }
    public void Push(T value) 
    {
        Top= new Node {value=value,Next=Top};    
    }
    public T pop()
    {
        if (Top != null)
        {
            T deletedValue = Top.value;
            Top = Top.Next;
            return deletedValue;
        }
        else
        {
            throw new InvalidOperationException();
        }
    }
    public T top() 
    {
        if (Top != null)
        {
            return Top.value;
        }
        else
        {
            throw new InvalidOperationException();
        }
    }
    public bool IsEmpty()
    { 
        return Top== null;
    }
}