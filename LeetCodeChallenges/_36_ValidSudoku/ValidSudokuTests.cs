namespace LeetCodeChallenges.Tests._36_ValidSudoku;

/// <summary>
/// Determine if a 9 x 9 Sudoku board is valid. Only the filled cells need to be validated according to the following rules:
/// 
/// Each row must contain the digits 1-9 without repetition.
/// Each column must contain the digits 1-9 without repetition.
/// Each of the nine 3 x 3 sub-boxes of the grid must contain the digits 1-9 without repetition.
/// Note:
/// 
/// A Sudoku board (partially filled) could be valid but is not necessarily solvable.
/// Only the filled cells need to be validated according to the mentioned rules.
/// </summary>
public class ValidSudokuTests
{
    [Fact]
    public void Empty() =>
        Assert.True(ValidSudoku(new[]
        {
            new[] { '.', '.', '.', '.', '.', '.', '.', '.', '.' },
            new[] { '.', '.', '.', '.', '.', '.', '.', '.', '.' },
            new[] { '.', '.', '.', '.', '.', '.', '.', '.', '.' },
            new[] { '.', '.', '.', '.', '.', '.', '.', '.', '.' },
            new[] { '.', '.', '.', '.', '.', '.', '.', '.', '.' },
            new[] { '.', '.', '.', '.', '.', '.', '.', '.', '.' },
            new[] { '.', '.', '.', '.', '.', '.', '.', '.', '.' },
            new[] { '.', '.', '.', '.', '.', '.', '.', '.', '.' },
            new[] { '.', '.', '.', '.', '.', '.', '.', '.', '.' },
        }));

    [Fact]
    public void ValidFullRow() =>
        Assert.True(ValidSudoku(new[]
        {
            new[] { '1', '6', '2', '7', '3', '8', '4', '9', '5' },
            new[] { '.', '.', '.', '.', '.', '.', '.', '.', '.' },
            new[] { '.', '.', '.', '.', '.', '.', '.', '.', '.' },
            new[] { '.', '.', '.', '.', '.', '.', '.', '.', '.' },
            new[] { '.', '.', '.', '.', '.', '.', '.', '.', '.' },
            new[] { '.', '.', '.', '.', '.', '.', '.', '.', '.' },
            new[] { '.', '.', '.', '.', '.', '.', '.', '.', '.' },
            new[] { '.', '.', '.', '.', '.', '.', '.', '.', '.' },
            new[] { '.', '.', '.', '.', '.', '.', '.', '.', '.' },
        }));

    [Fact]
    public void InvalidRow() =>
        Assert.False(ValidSudoku(new[]
        {
            new[] { '1', '1', '2', '7', '3', '8', '4', '9', '5' },
            new[] { '.', '.', '.', '.', '.', '.', '.', '.', '.' },
            new[] { '.', '.', '.', '.', '.', '.', '.', '.', '.' },
            new[] { '.', '.', '.', '.', '.', '.', '.', '.', '.' },
            new[] { '.', '.', '.', '.', '.', '.', '.', '.', '.' },
            new[] { '.', '.', '.', '.', '.', '.', '.', '.', '.' },
            new[] { '.', '.', '.', '.', '.', '.', '.', '.', '.' },
            new[] { '.', '.', '.', '.', '.', '.', '.', '.', '.' },
            new[] { '.', '.', '.', '.', '.', '.', '.', '.', '.' },
        }));
    
    [Fact]
    public void ValidCol() =>
        Assert.True(ValidSudoku(new[]
        {
            new[] { '.', '1', '.', '.', '.', '.', '.', '.', '.' },
            new[] { '.', '2', '.', '.', '.', '.', '.', '.', '.' },
            new[] { '.', '3', '.', '.', '.', '.', '.', '.', '.' },
            new[] { '.', '5', '.', '.', '.', '.', '.', '.', '.' },
            new[] { '.', '4', '.', '.', '.', '.', '.', '.', '.' },
            new[] { '.', '7', '.', '.', '.', '.', '.', '.', '.' },
            new[] { '.', '6', '.', '.', '.', '.', '.', '.', '.' },
            new[] { '.', '9', '.', '.', '.', '.', '.', '.', '.' },
            new[] { '.', '8', '.', '.', '.', '.', '.', '.', '.' },
        }));
    
    [Fact]
    public void InvalidCol() =>
        Assert.False(ValidSudoku(new[]
        {
            new[] { '.', '1', '.', '.', '.', '.', '.', '.', '.' },
            new[] { '.', '2', '.', '.', '.', '.', '.', '.', '.' },
            new[] { '.', '3', '.', '.', '.', '.', '.', '.', '.' },
            new[] { '.', '5', '.', '.', '.', '.', '.', '.', '.' },
            new[] { '.', '4', '.', '.', '.', '.', '.', '.', '.' },
            new[] { '.', '7', '.', '.', '.', '.', '.', '.', '.' },
            new[] { '.', '6', '.', '.', '.', '.', '.', '.', '.' },
            new[] { '.', '9', '.', '.', '.', '.', '.', '.', '.' },
            new[] { '.', '9', '.', '.', '.', '.', '.', '.', '.' },
        }));
    
    [Fact]
    public void ValidArea() =>
        Assert.True(ValidSudoku(new[]
        {
            new[] { '.', '.', '.', '.', '.', '.', '.', '.', '.' },
            new[] { '.', '.', '.', '.', '.', '.', '.', '.', '.' },
            new[] { '.', '.', '.', '.', '.', '.', '.', '.', '.' },
            new[] { '.', '.', '.', '1', '2', '4', '.', '.', '.' },
            new[] { '.', '.', '.', '5', '6', '3', '.', '.', '.' },
            new[] { '.', '.', '.', '7', '9', '8', '.', '.', '.' },
            new[] { '.', '.', '.', '.', '.', '.', '.', '.', '.' },
            new[] { '.', '.', '.', '.', '.', '.', '.', '.', '.' },
            new[] { '.', '.', '.', '.', '.', '.', '.', '.', '.' },
        }));
    
    [Fact]
    public void ValidRowColAndBlock() =>
        Assert.True(ValidSudoku(new[]
        {
            new[] { '.', '.', '1', '2', '.', '.', '.', '.', '.' },
            new[] { '.', '.', '8', '3', '.', '.', '.', '.', '.' },
            new[] { '.', '.', '9', '4', '.', '.', '.', '.', '.' },
            new[] { '5', '6', '7', '1', '2', '4', '8', '9', '3' },
            new[] { '.', '.', '2', '5', '6', '3', '1', '.', '.' },
            new[] { '.', '.', '3', '7', '9', '8', '.', '.', '.' },
            new[] { '.', '.', '4', '6', '.', '.', '.', '.', '.' },
            new[] { '.', '2', '5', '8', '.', '.', '.', '.', '.' },
            new[] { '1', '.', '6', '9', '.', '.', '.', '.', '.' },
        }));
    
    private bool ValidSudoku(char[][] board)
    {
        var sections = new Dictionary<string, List<char>>();
        
        for (var i = 0; i < board.Length; i++)
        {
            for (var j = 0; j < board[i].Length; j++)
            {
                var value = board[i][j];

                if (!ValidateSection("r" + i, value)) return false;
                if (!ValidateSection("c" + j, value)) return false;
                if (!ValidateSection($"b{i/3}{j/3}", value)) return false;
            }
        }
        return true;
        
        bool ValidateSection(string sectionKey, char value)
        {
            if (!sections.ContainsKey(sectionKey))
                sections[sectionKey] = new List<char>();

            var section = sections[sectionKey];

            if (value != '.' && section.Contains(value))
                return false;

            section.Add(value);
            return true;
        }
    }
}