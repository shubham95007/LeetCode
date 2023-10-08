//Approach,
// start from right
// check if there is any element(x) who is less than right one
// now pick that element(x) and search for least greater element than x on right side(y)
// replace x with y and then sort all the element after x position
public class Solution {
    public void NextPermutation(int[] nums) {
        int index=-1;
        int n= nums.Length;
        for(int i=n-2;i>=0;i--){
            if(nums[i]<nums[i+1]){
                index =i;
                break;
            }
        }
        int curr_max= Int32.MaxValue;
        int replaceIndex = index;
        if(index!=-1){
            for(int i=index+1;i<n;i++){
                if(nums[i]>nums[index] && nums[i]< curr_max){
                    replaceIndex = i;
                    curr_max = nums[i];
                }
                    
            }
            int tmp= nums[index];
            nums[index] = nums[replaceIndex];
            nums[replaceIndex]= tmp;
            Array.Sort(nums,index+1,n-index-1);
        }
        else{
            Array.Sort(nums);
        }
    }
}
