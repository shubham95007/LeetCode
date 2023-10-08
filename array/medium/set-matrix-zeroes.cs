public class Solution {
    public void SetZeroes(int[][] matrix) {
        var fczero = false;
        var frzero = false;
        int row = matrix.Length; 
        int column = matrix[0].Length;
    //check if first row is zero
        for (int j = 0; j < column; j++)
        {
            if (matrix[0][j] == 0)
            {
                frzero = true;
                break;
            }
        }

        // Check if the first column should be zeroed
        for (int i = 0; i < row; i++)
        {
            if (matrix[i][0] == 0)
            {
                fczero = true;
                break;
            }
        }
        applyInfo(matrix);
        applyZero(matrix, fczero,frzero);
        
    }

    public void applyInfo(int[][] matrix){
        int row = matrix.Length; 
        int column = matrix[0].Length;
          // Check if the first row should be zeroed
    
        for(int i=1;i<row;i++){
            for(int j=1;j<column;j++){
                if(matrix[i][j]==0){
                    matrix[i][0]=0;
                    matrix[0][j]=0;
                }
            }
        }
        
       
    }
    public void applyZero(int[][] matrix, bool fczero, bool frzero)
{
    int row = matrix.Length;
    int column = matrix[0].Length;
  

  

    // Mark zeros in the rest of the matrix
    for (int i = 1; i < row; i++)
    {
        for (int j = 1; j < column; j++)
        {
            if (matrix[i][j] == 0)
            {
                matrix[i][0] = 0; // Mark the corresponding row
                matrix[0][j] = 0; // Mark the corresponding column
            }
        }
    }

    // Set zeros based on marks in the first row and first column
    for (int i = 1; i < row; i++)
    {
        for (int j = 1; j < column; j++)
        {
            if (matrix[i][0] == 0 || matrix[0][j] == 0)
            {
                matrix[i][j] = 0;
            }
        }
    }

    // Set zeros for the first row and first column if needed
    if (frzero)
    {
       
        for (int j = 0; j < column; j++)
        {
            matrix[0][j] = 0;
        }
    }

    if (fczero)
    {
       
        for (int i = 0; i < row; i++)
        {
            matrix[i][0] = 0;
        }
    }
}

}
