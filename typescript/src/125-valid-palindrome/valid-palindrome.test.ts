import containsDuplicate from '../217-contains-duplicate/contains-duplicates';
import isPalindrome from './valid-palindrome';

test.each([
    ['one palindrome', 'a', true],
    ['two palindrome', 'aa', true],
    ['3 palindrome', 'aba', true],
    ['4 palindrome', 'Anna', true],
    ['empty', ' ', true],
    ['special characters long palindrome', '"A man, a plan, a canal: Panama"', true],
    ['long not palindrome', 'race a car', false],
])('isPalindrome %s', (example, input, expected) => {
    expect(isPalindrome(input)).toBe(expected);
});