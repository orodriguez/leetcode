import isAnagram from './valid-anagram';

describe(isAnagram, () => {
    test('a a true', () => expect(isAnagram('a', 'a')).toBeTruthy());
    test('ab ba true', () => expect(isAnagram('ab', 'ba')).toBeTruthy());
    test('abc cba true', () => expect(isAnagram('abc', 'cba')).toBeTruthy());
    test('anagram nagaram true', () => expect(isAnagram('anagram', 'nagaram')).toBeTruthy());
    test('abc ab true', () => expect(isAnagram('abc', 'ab')).toBeFalsy());
    test('rat car false', () => expect(isAnagram('rat', 'car')).toBeFalsy());
});