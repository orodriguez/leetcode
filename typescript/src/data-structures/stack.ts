class Stack<T> {
    #items: T[] = [];
    #size: number;

    constructor() {
        this.#items = [];
        this.#size = 0;
    }

    push = (item: T): void => {
        this.#items.push(item);
        this.#size++;
    };

    pop = (): T | undefined => {
        this.#size--;
        return this.#items.pop();
    };

    peek = (): T | undefined => {
        if (this.#items.length <= 0)
            return undefined;

        return this.#items[this.#items.length - 1];
    };

    size = (): number => this.#size;

    isEmpty = () => this.#items.length == 0;
}

export default Stack;