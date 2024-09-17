function longestConsecutive(nums: number[]): number {
    var longest = 0;
    var set = new Set(nums);

    for (var n of set) {
        if (set.has(n - 1)) continue;

        var length = 0;
        while (set.has(n + length)) length++;

        longest = Math.max(longest, length);
    }

    return longest;
};

export default longestConsecutive;