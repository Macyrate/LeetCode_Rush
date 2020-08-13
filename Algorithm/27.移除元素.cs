public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int len = nums.Length;
        if(!Array.Exists(nums, x => x == val))
            return len;

        //val集中区的第一个下标
        int border = 0;
        while(border < len)
        {
            if(nums[border] == val)
            {
                //val集中区中首个非val元素的下标
                int indexFirstNotVal = Array.FindIndex(nums[border..], x => x != val);
                if(indexFirstNotVal == -1)
                    break;
                indexFirstNotVal += border;

                //val集中区中首个非val元素交换到已处理部分末尾
                Swap(ref nums[border], ref nums[indexFirstNotVal]);
            }
            border++;
        }
        
        //重新指定数组大小
        Array.Resize(ref nums, border);
        return border;
    }

    //交换元素
    private void Swap(ref int a, ref int b){
        int temp = a;
        a = b;
        b = temp;
    }
}