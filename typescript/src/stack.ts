class Stack<T> {
    private items: T[] = [];

    push = (item: T): void => {
        this.items.push(item);
    }

    pop = (): T | undefined => {
        return this.items.pop();
    }

    peek = (): T | undefined => {
        if (this.items.length <= 0)
            return undefined;

        return this.items[this.items.length - 1];
    }

    isEmpty = () => this.items.length == 0;
}

export default Stack;