using System;
class Program
{
    static void Main(string[] args)
    {
        bool first = true;
        Cycle cc = new Cycle();
        IDlist list = new IDlist();
        string fromS ="";
        while (true)
        {
            
            fromS = Console.ReadLine();
            if(fromS == "?")
            {
                break;
            }
            char[] fromCh = fromS.ToCharArray();
            
            ID insertData = null;

           

            foreach (ID i in list.IDdata) {
               
                if (fromCh[0] == i.Instruction)
                {
                    insertData = i;
                }
            }
              //Console.WriteLine(list.CheckList(fromCh[0],fromCh[2]));
            if (list.CheckList(fromCh[0],fromCh[2]) != 4)
               {
                   if (list.CheckList(fromCh[0],fromCh[2]) == 1)
                   {
                    list.AddList(new ID(insertData.Instruction,insertData.Data,fromCh[2]));
                    list.RemoveList(insertData);
                   }
                   else if (list.CheckList(fromCh[0],fromCh[2]) == 2)
                   {
                    list.AddList(new ID(insertData.Instruction, insertData.Data, insertData.Data2,fromCh[2]));
                    list.RemoveList(insertData);
                }
                   else if (list.CheckList(fromCh[0],fromCh[2]) == 3)
                   {
                    list.AddList(new ID(insertData.Instruction,fromCh[2]));
                }
                else if (list.CheckList(fromCh[0], fromCh[2]) == 0)
                {
                   
                }
            }
               else
               {
                   list.AddList(new ID(fromCh[0], fromCh[2]));
               }
          
            if (first == true)
            {
                list.AddList(new ID(fromCh[0], fromCh[2]));
                first = false;
            }

            //list.GetList();
       
            

           
        }
        foreach (ID i in list.IDdata)
        {
            IDlist list2 = new IDlist();
            list2.AddList(i);
            cc.Push(list2);
        }
        list.CycleNeeded();
        //cc.Get(0);
    }
}
