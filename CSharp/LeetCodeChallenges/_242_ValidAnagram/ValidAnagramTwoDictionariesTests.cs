using LeetCodeChallenges.Tests._217_ContainsDuplicate;

namespace LeetCodeChallenges.Tests._242_ValidAnagram;

public class ValidAnagramTwoDictionariesTests : AbstractValidAnagramTests
{
    protected override Func<string, string, bool> IsAnagram => StringExtensions.IsAnagramTwoDictionaries;
}