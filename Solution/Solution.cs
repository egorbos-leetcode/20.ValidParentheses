namespace Solution;

public static class Solution
{
    public static bool IsValid(string s) {
        if (s.Length % 2 > 0) return false;
        
        var stack = new Stack<char>();
        var openBrackets = new[] {'(', '{', '['};
        
        foreach (var bracket in s)
        {
            if (openBrackets.Contains(bracket))
            {
                stack.Push(bracket);
            }
            else if (stack.TryPop(out var openBracket))
            {
                if (!openBrackets.Contains(openBracket))
                {
                    return false;
                }
                switch (bracket)
                {
                    case ')':
                        if (openBracket != '(') return false;
                        break;
                    case '}':
                        if (openBracket != '{') return false;
                        break;
                    case ']':
                        if (openBracket != '[') return false;
                        break;
                }
            }
            else
            {
                return false;
            }
        }
        return stack.Count == 0;
    }
}