using System;
using System.Collections.Generic;
class IDlist : Node
{
    public IDlist Next
    {
        get { return next as IDlist; }
        set { next = value; }
    }
    public List<ID> IDdata;
    public IDlist()
    {
        IDdata = new List<ID>();
    }
    public void AddList(ID data)
    {
        IDdata.Add(data);
    }
    public void RemoveList(ID data)
    {
        IDdata.Remove(data);
    }
    public void GetList()
    {
        IDdata.ForEach(value => { Console.WriteLine("Data {0}", value); });
    }
    public int CheckList(char check, char dataCh)
    {
        int checker = 0;

        foreach (ID i in IDdata)
        {
            if (check == i.Instruction)
            {
                if (i.Data == dataCh || i.Data2 == dataCh || i.Data3 == dataCh)
                {
                    checker = 0;
                    break;
                }
                else if (i.Data2 == '0')
                {
                    checker = 1;
                    break;

                }
                else if (i.Data3 == '0')
                {
                    checker = 2;
                    break;
                }
                else
                {
                    checker = 3;
                }

            }
            else
            {
                checker = 4;

            }
        }
        return checker;
    }
    public void CycleNeeded()
    {
        int need = 1;
        int count = 0;
        foreach (ID i in IDdata)
        {
            count = count + 1;
        }
        need = need + count / 4;
        Console.WriteLine("CPU cycles needed: {0}", need);
    }
}
