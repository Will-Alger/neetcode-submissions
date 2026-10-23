public class Solution {
    public int Trap(int[] height) {
        int 
            left = 0, 
            right = height.Length - 1, 
            sum = 0,
            leftMax = height[left],
            rightMax = height[right];

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
