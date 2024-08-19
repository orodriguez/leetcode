import containsDuplicate from "./contains-duplicates";

test.each([
    ['one', [1], false],
    ['two duplicated', [1, 1], true],
    ['two unique', [1, 2], false],
    ['many unique', [1, 2, 3, 4], false],
    ['many duplicated', [1, 1, 1, 3, 3, 4, 3, 2, 4, 2], true],
])('containsDuplicate %s', (example, input, expected) => {
    expect(containsDuplicate(input)).toBe(expected);
});