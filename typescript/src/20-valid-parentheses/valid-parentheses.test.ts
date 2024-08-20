import isValidParentheses from './valid-parentheses';

describe(isValidParentheses, () => {
    test('single valid pair', () => expect(isValidParentheses('()')).toBeTruthy());
    test('two valid pairs', () => expect(isValidParentheses('()()')).toBeTruthy());
    test('valid wrapping', () => expect(isValidParentheses('(())')).toBeTruthy());
    test('valid complex', () => expect(isValidParentheses('{([]){()}}')).toBeTruthy());
    test('valid square', () => expect(isValidParentheses('[]')).toBeTruthy());
    test('invalid only opening', () => expect(isValidParentheses('(')).toBeFalsy());
    test('invalid only closing', () => expect(isValidParentheses(')')).toBeFalsy());
    test('invalid only opening square', () => expect(isValidParentheses('[')).toBeFalsy());
    test('invalid only opening curly', () => expect(isValidParentheses('{')).toBeFalsy());
});