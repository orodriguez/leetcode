import Stack from "./stack";

describe(Stack, () => {
    test('push', () => {
        const stack = new Stack<number>();
        stack.push(1);
        stack.push(2);
        stack.push(3);
        expect(stack.peek()).toBe(3);
        expect(stack.size()).toBe(3);
    });

    test('pop', () => {
        const stack = new Stack<number>();
        stack.push(1);
        stack.push(2);
        stack.push(3);
        expect(stack.pop()).toBe(3);
        expect(stack.pop()).toBe(2);
        expect(stack.pop()).toBe(1);
        expect(stack.size()).toBe(0);
    });

    test('isEmpty', () => {
        const stack = new Stack<number>();
        expect(stack.isEmpty()).toBe(true);
        stack.push(1);
        expect(stack.isEmpty()).toBe(false);
        stack.pop();
        expect(stack.isEmpty()).toBe(true);
        expect(stack.size()).toBe(0);
    });

    test('peek', () => {
        const stack = new Stack<number>();
        stack.push(1);
        stack.push(2);
        stack.push(3);
        expect(stack.peek()).toBe(3);
        stack.pop();
        expect(stack.peek()).toBe(2);
        expect(stack.size()).toBe(2);
    });


    test('size', () => {
        const stack = new Stack<number>();
        stack.push(1);
        stack.push(2);
        stack.push(3);
        expect(stack.size()).toBe(3);
        stack.pop();
        expect(stack.size()).toBe(2);
        stack.pop();
        expect(stack.size()).toBe(1);
        stack.pop();
        expect(stack.size()).toBe(0);
    });
});