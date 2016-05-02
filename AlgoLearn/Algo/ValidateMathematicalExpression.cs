using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo
{

    //Program used to validate regular expression using stack
    //Algo
    //1) Read the expression
    //2) If enocunter other than symbol i.e ( { [ ignore this
    //3) If symbol then push it into stck
    //4) If matching symbol enounter pop from stack and check reverse or not
        //4.1) If not riverse then throw error
        //4.2) If STACK is empty throw error
       
    public class ValidateMathematicalExpression
    {
        List<Char> LeftSymbols { get; set; }
        List<Char> RightSymbols { get; set; }

        Dictionary<Char, Char> SymbolMapping = new Dictionary<char, char>();

        List<Char> Stack = new List<char>();

        public ValidateMathematicalExpression()
        {
            LeftSymbols = new List<Char> {'(', '{', '[' };
            RightSymbols = new List<char> { ')', '}', ']' };
            SymbolMapping.Add('(', '(');
            SymbolMapping.Add('{', '{');
            SymbolMapping.Add('[', '[');
        }

        public void Validate(string Input)
        {
            foreach (var item in Input)
            {
                if (LeftSymbols.Contains(item))
                {
                    Stack.Add(item);
                }
                if (RightSymbols.Contains(item))
                {
                    if (Stack.Count > 0) {
                        Char StkItem = Stack[Stack.Count - 1];
                        if (StkItem == SymbolMapping[StkItem])
                        {
                            Stack.RemoveAt(Stack.Count - 1);
                        }
                    }
                    else
                        throw new Exception("Invalid Input");
                }
            }
            if (Stack.Count != 0)
                throw new Exception("Invalid Input");
            else
                System.Console.WriteLine("Valid Expression");
        }
    }
}
