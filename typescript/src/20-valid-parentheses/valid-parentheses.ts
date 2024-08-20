import Stack from '../stack';

const isValidParentheses = (str: string) => {
    const expectedTokens = new Stack<string>;

    const pairs = new Map<string, string>([
        ['(', ')'],
        ['[', ']'],
        ['{', '}'],
    ]);

    const closers = Array.from(pairs.values());

    for (var chr of str) {
        if (pairs.has(chr))
            expectedTokens.push(pairs.get(chr)!);

        if (closers.includes(chr) && chr !== expectedTokens.pop())
            return false;
    };
    return expectedTokens.isEmpty();
};

export default isValidParentheses;