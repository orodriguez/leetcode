const twoSum = (nums: number[], target: number): number[] => {
    const seen = new Map<number, number>();

    for (let i = 0; i < nums.length; i++) {
        const n = nums[i];
        const complement = target - n;
        if (seen.has(complement)) return [seen.get(complement)!, i]
        seen.set(n, i);
    }

    return [];
};

export default twoSum;