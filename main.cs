public class Solution {
    public int RomanToInt(string s) {
        int sum = 0;
        for (int i = 0; i < s.Length; i++) {
            int nbr = 0;
            switch (s[i]) {
                case 'I':
                    if (i + 1 < s.Length && (s[i + 1] == 'V' || s[i + 1] == 'X')) {
                        nbr = -1;
                    } else {
                        nbr = 1;
                    }
                    break;
                case 'V':
                    nbr = 5;
                    break;
                case 'X':
                    if (i + 1 < s.Length && (s[i + 1] == 'L' || s[i + 1] == 'C')) {
                        nbr = -10;
                    } else {
                        nbr = 10;
                    }
                    break;
                case 'L':
                    nbr = 50;
                    break;
                case 'C':
                    if (i + 1 < s.Length && (s[i + 1] == 'D' || s[i + 1] == 'M')) {
                        nbr = -100;
                    } else {
                        nbr = 100;
                    }
                    break;
                case 'D':
                    nbr = 500;
                    break;
                case 'M':
                    nbr = 1000;
                    break;
            }
            sum += nbr;
        }
        return sum;
    }
}
