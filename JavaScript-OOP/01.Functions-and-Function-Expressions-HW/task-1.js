/* Task Description */
/* 
 Write a function that sums an array of numbers:
 numbers must be always of type Number
 returns `null` if the array is empty
 throws Error if the parameter is not passed (undefined)
 throws if any of the elements is not convertible to Number
 */

function () {
    return function arrSum(args) {
        var n,
            i,
            len,
            result = 0;
        if (args.length < 1) {
            return null;
        }
        if (args == undefined) {
            throw new Error('No parameter');
        }
        len = args.length;
        for (i = 0; i < len; i+=1) {
            args[i] = +args[i];
            if (!Number(args[i])) {
                throw new Error();
            }
            result += args[i];
        }

        return result;
    };
}

