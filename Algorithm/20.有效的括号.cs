public class Solution {
    public bool IsValid(string s) {
        var stack = new Stack<char>();
        var bracketPairs = 
            new List<(char left,char right)>(){('(',')'),('{','}'),('[',']')};
        foreach(char c in s)
        {
            if(bracketPairs.Exists(x => x.left == c))
            {
                stack.Push(c);
            }
            if(bracketPairs.Exists(x => x.right == c))
            {
                if(stack.Any() && stack.Peek() == bracketPairs.Find(x => x.right == c).left)
                    stack.Pop();
                else
                    return false;
            }
        }
        return (stack.Count() == 0);
    }
}