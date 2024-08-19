function containsDuplicate(numbers: number[]): boolean {
    const set = new Set<number>();

    for (const num of numbers) {
        if (set.has(num)) return true;
        set.add(num);
    }
    return false;
};

export default containsDuplicate