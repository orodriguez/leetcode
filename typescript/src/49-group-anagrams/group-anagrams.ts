function groupAnagrams(strs: string[]): string[][] {
    const groups: Map<string, string[]> = new Map();

    for (const str of strs) {
        const sorted = str.split('').sort().join('');

        if (!groups.has(sorted)) groups.set(sorted, []);
        groups.get(sorted)!.push(str);
    }

    return Array.from(groups.values());
}

export default groupAnagrams;