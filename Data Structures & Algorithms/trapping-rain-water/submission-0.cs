public class Solution {
    public int Trap(int[] height) {

        int left = 0, right = height.Length - 1;
        int leftMax = height[left], rightMax = height[right];
        int sum = 0;

        /*
            1. water can never sit on the edge
            2. between left and right pointer, we only care about the min because it
                will be the constraint.

            
        
        
         */

        while (left < right) {
            if (leftMax < rightMax) {
                left++;
                leftMax = Math.Max(leftMax, height[left]);
                sum += leftMax - height[left];
            } else {
                right--;
                rightMax = Math.Max(rightMax, height[right]);
                sum += rightMax - height[right];
            }
        }
        return sum;
    }
}
