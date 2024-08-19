function isPalindrome(s: string): boolean {
    const clearInput = s.replace(/[^a-zA-Z0-9]/g, '').toLocaleLowerCase();

    var firstI = 0;
    var lastI = clearInput.length - 1;

    while (firstI < lastI) {

        if (clearInput[firstI] !== clearInput[lastI]) {
            return false;
        }
        firstI++;
        lastI--;
    }

    return true;
};

export default isPalindrome;