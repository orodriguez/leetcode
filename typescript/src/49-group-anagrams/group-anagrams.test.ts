import groupAnagrams from './group-anagrams';

describe(groupAnagrams, () => {
    test('["eat","tea","tan","ate","nat","bat"]', () =>
        expect(groupAnagrams(["eat", "tea", "tan", "ate", "nat", "bat"])).toStrictEqual([["eat", "tea", "ate"], ["tan", "nat"], ["bat"]]));
});