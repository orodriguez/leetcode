import topKFrequent from './top-k-frequent';

describe(topKFrequent, () => {
    test('case 1', () => expect(topKFrequent([1, 1, 1, 2, 2, 3], 2)).toEqual([1, 2]));
    test('case 2', () => expect(topKFrequent([1], 1)).toEqual([1]));
});