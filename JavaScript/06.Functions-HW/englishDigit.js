// Problem 1. English digit
// Write a function that returns the last digit of given integer as an English word.

console.log(GetDigitAsWord(512));
console.log(GetDigitAsWord(1024));
console.log(GetDigitAsWord(12309));
console.log(GetDigitAsWord(0.5));
console.log(GetDigitAsWord('abc'));

function GetDigitAsWord(int) {
    var digit = Math.floor(int) % 10;
    switch (digit) {
        case 0:
            return 'zero';
        case 1:
            return 'one';
        case 2:
            return 'two';
        case 3:
            return 'three';
        case 4:
            return 'four';
        case 5:
            return 'five';
        case 6:
            return 'six';
        case 7:
            return 'seven';
        case 8:
            return 'eight';
        case 9:
            return 'nine';
        default:
            return 'invalid input';
    }
}
