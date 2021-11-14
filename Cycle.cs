using System;

class Cycle
{
    private IDlist root = null;

    public void Push(IDlist newID)
    {
        if (root == null)
        { root = newID; }
        else
        {
            IDlist id = root;
            while (id.Next != null)
            { id = id.Next; }
            id.Next = newID;
        }

    }

    public IDlist Pop()
    {
        IDlist id = root;
        root = root.Next;
        id.Next = null;
        return id;
    }
    public void Get(int index)
    {
        IDlist id = root;
        while (index > 0)
        {
            if (id == null)
            {
                throw new IndexOutOfRangeException();
            }
            id = id.Next;
            index--;
        }
        id.GetList();
    }
}

