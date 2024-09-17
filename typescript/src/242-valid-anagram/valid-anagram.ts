function isAnagram(s: string, t: string): boolean {
    if (s.length !== t.length) return false;

    const countS = new Map<string, number>();
    const countT = new Map<string, number>();
    for (var i = 0; i < s.length; i++) {
        countS.set(s[i], (countS.get(s[i]) ?? 0) + 1);
        countT.set(t[i], (countT.get(t[i]) ?? 0) + 1);
    };

    return Array.from(countS)
        .every(([chr, count]) => countT.get(chr) === count);
};

export default isAnagram;