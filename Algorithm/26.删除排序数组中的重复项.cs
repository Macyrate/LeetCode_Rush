public class Solution {
    public int RemoveDuplicates(int[] nums) {
        if(nums.Length == 0)
            return 0;
        int border = 0;
        for(int i =1;i<nums.Length;i++){
            if(nums[i] != nums[border]){
                border++;
                Swap(ref nums[border], ref nums[i]);
            }
        }
        Array.Resize(ref nums, border + 1);
        return border + 1;
    }

    private void Swap(ref int a, ref int b){
        int temp = a;
        a = b;
        b = temp;
    }
}
