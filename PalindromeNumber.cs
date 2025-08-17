/*
Given an integer x, return true if x is a palindrome, and false otherwise.
*/
public class Solution {
    public bool IsPalindrome(int x)
    {
        if (x < 0) {
            return false;
        } else if (x >= 0 && x < 10) {
            return true;
        }
        
        var quantity = x.ToString().Length;

        var charArray = x.ToString().ToCharArray();
        
        for (int i = 0; i < quantity; i++)
        {
            if (charArray[i] != charArray[quantity - 1 - i])
            {
                return false;
            }
        }

        return true;
    }
}