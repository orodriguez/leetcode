import carFleet from './car-fleet';

describe(carFleet, () => {
    test('1', () => expect(carFleet(1, [0], [1])).toBe(1));
    test('2', () => expect(carFleet(1, [0], [1])).toBe(1));
    test('3', () => expect(carFleet(2, [0, 1], [1, 1])).toBe(2));
    test('4', () => expect(carFleet(2, [0, 1], [2, 1])).toBe(1));
    test('5', () => expect(carFleet(2, [1, 0], [1, 2])).toBe(1));
    test('6', () => expect(carFleet(3, [0, 1, 2], [3, 2, 1])).toBe(1));
    test('7', () => expect(carFleet(3, [0, 1, 2], [1, 2, 1])).toBe(2));
    test('8', () => expect(carFleet(3, [0, 1, 2], [3, 1, 1])).toBe(2));
});