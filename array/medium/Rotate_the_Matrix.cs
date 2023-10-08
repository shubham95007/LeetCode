public class Solution {
    public void Rotate(int[][] matrix) {
       int index=0;
       int n=matrix.Length;
       
       for(int i=index;i<n;i++){
           for(int j=i+1;j<n;j++){
              int tmp = matrix[i][j];
              matrix[i][j] = matrix[j][i];
              matrix[j][i] = tmp;
              }
           }
           index++;
       
        int c1=0, c2=n-1;
        while(c1<c2){
            for(int i=0;i<n;i++){
                int tmp = matrix[i][c1];
                matrix[i][c1] = matrix[i][c2];
                matrix[i][c2] = tmp;
            }
            c1++;
            c2--;
        }
    }
}
