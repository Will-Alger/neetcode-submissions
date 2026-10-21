public class Solution {
    public int MaxArea(int[] heights) {
        int maxWater = 0, left = 0, right = heights.Length - 1;
        
        while (left < right) {
            int volume = (right - left) * (Math.Min(heights[left], heights[right]));
            maxWater = Math.Max(maxWater, volume);

            if (heights[left] < heights[right]) 
                left++;
            else if (heights[left] > heights[right]) {
                right--;
            }
            else {
                left++;
                right--;
            }
    
        }

        return maxWater;
    }
}
