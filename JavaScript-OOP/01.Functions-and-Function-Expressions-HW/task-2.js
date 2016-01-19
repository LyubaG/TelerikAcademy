/* Task description */
/*
 Write a function that finds all the prime numbers in a range
 1) it should return the prime numbers in an array
 2) it must throw an Error if any on the range params is not convertible to `Number`
 3) it must throw an Error if any of the range params is missing
 */

function () {
    return function primes(from, to) {
        var n,
            i,
            divisor,
            maxDiv,
            isPrime,
            primesArr = [];

        /*        if (arguments.length < 2) {
         throw new Error('Missing range params');*/ // can't make it work...
        if(typeof(from) === 'undefined' || typeof(to) === 'undefined') {
            throw new Error('Give me proper params, please');
        }
        from = +from;
        to = +to;
        for(n = from; n <= to; n += 1) {
            maxDiv = Math.sqrt(n);
            isPrime = true;
            if (n < 2) {
                isPrime = false;
            }
            for(divisor = 2; divisor <= maxDiv; divisor += 1) {
                if(!(n % divisor)) {
                    isPrime = false;
                    break;
                }
            }
            if (isPrime) {
                primesArr.push(n);
            }
        }
        return primesArr;
    };
}
