namespace NewApp.Services.CheckParanthesis
{
    public class CheckParanthesis
    {
        public static bool IsValid(string statement)
        {
            // Simulate token validation logic
            Stack<char> charStack = new Stack<char>();

            foreach (char ch in statement)
            {

                if (ch == '(')
                {
                    charStack.Push(ch);
                }
                else if (ch == ')')
                {
                    if (charStack.Count == 0)
                        return false;
                    charStack.Pop();
                }
            }
            return charStack.Count == 0;
        }
    }
}