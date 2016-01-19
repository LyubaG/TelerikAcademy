// Problem 2. Reverse number
// Write a function that reverses the digits of given decimal number.
// Example: input   output
//          256     652
//          123.45  54.321

console.log(reversedNumber(256)); //received as a number
console.log(reversedNumber('123.45'));
console.log(reversedNumber(-12.11));

function reversedNumber(inputStr) {
    var isNegative = false, revArr = [];
    if(+inputStr < 0) {
        isNegative = true;
    }
    inputStr = inputStr.toString().trim();
    if(isNegative) {
        revArr.push('-');
        inputStr = inputStr.slice(1);
    }
    Array.prototype.push.apply(revArr, inputStr.split('').reverse());
    // TODO check why this doesn't work // revArr.push(inputStr.split('').reverse());
    return +(revArr.join('')); //to return a decimal number
}

