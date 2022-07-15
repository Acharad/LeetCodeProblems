public class Solution 
{
     public int MaxAreaOfIsland(int[][] grid) { 
        if (grid == null) return 0;

        var counter = 0;
        var r = grid.Length;
        var c = grid[0].Length;
        var visited = new HashSet<(int i, int j)>();

        for (var i = 0; i < r; i++) {
            for (var j = 0; j < c; j++) {
                if (grid[i][j] == 1) {
                    counter = Math.Max(counter, DFS(i, j));
                }
            }
        }

        int DFS(int i, int j) {
            if (visited.Contains((i, j))) return 0;
            if (i < 0 || i > r - 1) return 0;
            if (j < 0 || j > c - 1) return 0;
            if (grid[i][j] == 0) return 0;

            visited.Add((i, j));
            return DFS(i, j - 1) + DFS(i, j + 1) + DFS(i - 1, j) + DFS(i + 1, j) + 1;
        }

        return counter;
    }
}