public class Solution {
    public bool IsValidSudoku(char[][] board) {
        var rows = new HashSet<char>[9];
        var cols = new HashSet<char>[9];
        var boxes = new HashSet<char>[9];   

        for (int i = 0; i < 9; i++) {
            rows[i] = new HashSet<char>();
            cols[i] = new HashSet<char>();
            boxes[i] = new HashSet<char>();
        }


        for (int rowIndex = 0; rowIndex < board.Length; rowIndex++) {
            for (int colIndex = 0; colIndex < board.Length; colIndex++) {
                char cell = board[rowIndex][colIndex];

                if (cell == '.') {
                    continue;
                }
                int boxIndex = (rowIndex / 3) * 3 + (colIndex / 3);

                if (!rows[rowIndex].Add(cell)) {
                    return false;
                }

                if (!cols[colIndex].Add(cell)) {
                    return false;
                }

                if (!boxes[boxIndex].Add(cell)) {
                    return false;
                }
            }
        }
        return true;
    }
}
