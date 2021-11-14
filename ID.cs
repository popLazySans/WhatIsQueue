using System;

class ID : Node
{



    public char Instruction;
    public char Data, Data2, Data3;

    public ID(char ins, char data)
    {
        Instruction = ins;
        Data = data;
        Data2 = '0';
        Data3 = '0';


    }
    public ID(char ins, char data, char data2)
    {
        Instruction = ins;
        Data = data;
        Data2 = data2;
        Data3 = '0';


    }
    public ID(char ins, char data, char data2, char data3)
    {
        Instruction = ins;
        Data = data;
        Data2 = data2;
        Data3 = data3;


    }
    public override string ToString()
    {
        return String.Format(" I = {0} D = {1} D2 = {2} D3 = {3}", Instruction, Data, Data2, Data3);
    }

}
