const carFleet = (target: number, position: number[], speed: number[]): number => {
    let pairs = position
        .map((p, i) => [p, speed[i]])
        .sort((a, b) => b[0] - a[0]);

    const fleets: number[] = [];

    for (var [p, s] of pairs) {
        const time = (target - p) / s;
        if (fleets.length == 0) {
            fleets.push(time);
            continue;
        }
        if (time > fleets[fleets.length - 1])
            fleets.push(time);
    }
    return fleets.length;
};

export default carFleet;