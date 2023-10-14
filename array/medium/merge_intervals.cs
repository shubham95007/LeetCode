/*
Given an array of intervals where intervals[i] = [starti, endi], merge all overlapping intervals, and return an array of the non-overlapping intervals that cover all the intervals in the input.
Example 1:
Input: intervals = [[1,3],[2,6],[8,10],[15,18]]
Output: [[1,6],[8,10],[15,18]]
Explanation: Since intervals [1,3] and [2,6] overlap, merge them into [1,6].

Example 2:
Input: intervals = [[1,4],[4,5]]
Output: [[1,5]]
Explanation: Intervals [1,4] and [4,5] are considered overlapping.
*/

public class Solution {
    public int[][] Merge(int[][] intervals) {
        int n = intervals.Length;
        Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));
         List<int[]> listOfArrays = new List<int[]>();
        int x= intervals[0][0];
        int y= intervals[0][1];
        int start, end;
        for(int i=1;i<n;i++) {
             start = intervals[i][0];
             end = intervals[i][1];
             if((start>=x && start<= y)){
                y = Math.Max(y,end);
             }
             else{
                 listOfArrays.Add(new int[]{x,y});
                 x= start;
                 y= end;
             }
        }
        
        listOfArrays.Add(new int[]{x,y});
     
        int[][] arrayOfArrays = listOfArrays.ToArray();
        return arrayOfArrays;
    }
}
