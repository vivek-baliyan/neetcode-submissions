public class Solution {
    public bool hasDuplicate(int[] nums) {
        var unique = new HashSet<int>();
        foreach(int num in nums){
            if(!unique.Add(num)) return true;
        }

        return false;
    }
}