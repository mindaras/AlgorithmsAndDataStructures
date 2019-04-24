using System;
using System.Collections.Generic;

namespace Stack
{
    public class Postfix
    {
        Stack<int> values = new Stack<int>();

        public int Calculate(string[] args)
        {
            foreach (string token in args)
            {
                if (int.TryParse(token, out int value))
                {
                    values.Push(value);
                }
                else
                {
                    int rhs = values.Pop();
                    int lhs = values.Pop();

                    switch (token)
                    {
                        case "+":
                            values.Push(lhs + rhs);
                            break;
                        case "-":
                            values.Push(lhs - rhs);
                            break;
                        case "*":
                            values.Push(lhs * rhs);
                            break;
                        case "/":
                            values.Push(lhs / rhs);
                            break;
                        case "%":
                            values.Push(lhs % rhs);
                            break;
                        default:
                            throw new ArgumentException($"Unrecognized token: {token}");
                    }
                }
            }

            return values.Pop();
        }
    }
}
