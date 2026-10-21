public class Solution {
    public bool IsValidSudoku(char[][] board) {
        var rows = new HashSet<char>[9];
        var cols = new HashSet<char>[9];
        var boxes = new HashSet<char>[3, 3];

        // initialize the arrays;
        for (int i = 0; i < 9; i++) {
            rows[i] = new HashSet<char>();
            cols[i] = new HashSet<char>();
        }

        for (int r = 0; r < 3; r++) {
            for (int c = 0; c < 3; c++) {
                boxes[r, c] = new HashSet<char>();
            }
        }

        for (int rowI = 0; rowI < 9; rowI++) {
            for (int colI = 0; colI < 9; colI++) {
                char num = board[rowI][colI];

                if (num == '.')
                    continue;

                if (rows[rowI].Contains(num))
                    return false;
                if (cols[colI].Contains(num))
                    return false;
                if (boxes[rowI / 3, colI / 3].Contains(num))
                    return false;
                
                rows[rowI].Add(num);
                cols[colI].Add(num);
                boxes[rowI / 3, colI / 3].Add(num);
            }
        }
        return true;
    }
}
