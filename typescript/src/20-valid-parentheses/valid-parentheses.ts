import Stack from '../stack';

const isValidParentheses = (str: string) => {
    const expectedTokens = new Stack<string>;

    const tokens = new Map<string, string>([
        ['(', ')'],
        ['[', ']'],
        ['{', '}'],
    ]);

    const closers = Array.from(tokens.values());

    for (var chr of str) {
        if (tokens.has(chr))
            expectedTokens.push(tokens.get(chr)!);

        if (closers.includes(chr) && chr !== expectedTokens.pop())
            return false;
    };
    return expectedTokens.isEmpty();
};

export default isValidParentheses;