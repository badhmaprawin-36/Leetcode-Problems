public class Solution {
    public string MostCommonWord(string paragraph, string[] banned) {
        var separators= new char[]{' ','!','?',',',';','.','"','\''};
        return paragraph
        .ToLower()
        .Split(separators)
        .Where(word =>word!=string.Empty)
        .GroupBy(word => word)
        .ExceptBy(banned,gr => gr.
        Key)
        .MaxBy(gr => gr.Count()).Key;
        
        
    }
}