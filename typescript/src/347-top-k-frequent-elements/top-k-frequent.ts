const topKFrequent = (nums: number[], k: number): number[] => {
    var freq = new Map<number, number>();

    for (var num of nums)
        freq.set(num, (freq.get(num) ?? 0) + 1);

    return Array.from(freq)
        .sort((a, b) => b[1] - a[1])
        .slice(0, k)
        .map(([num, _]) => num);
};

export default topKFrequent;