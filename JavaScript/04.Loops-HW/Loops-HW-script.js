// Feel free to try with other examples ;)
// TO CHECK: copy each problem into your console or http://jsconsole.com

// Problem 1. Numbers
// Write a script that prints all the numbers from 1 to N.

var nPos = 8;
var nNeg = -7;
printTillN(nPos);
printTillN(nNeg);

function printTillN(n) {
    if(n>0) {
        for(var i = 1; i < n; i++) {
            console.log(i)
        }
    }
    else {
        for(var i = 1; i > n; i--) {
            console.log(i)
        }
    }
}

// Problem 2. Numbers not divisible
// Write a script that prints all the numbers from 1 to N, that are not divisible by 3 and 7 at the same time

var n = 50;
var notDivisible =[];
for (var num = 1; num <= n; num++) {
    if (num % 21) {
        notDivisible.push(num);
    }
}
console.log(notDivisible); // nums not printed are 21, 42

// Problem 3. Min/Max of sequence
// Write a script that finds the max and min number from a sequence of numbers.

var max, min;
var sequence = [-5, 4, 63, -7, 15, -21, -0.7, 4, -15];
max = min = sequence[0];
var length = sequence.length;
for (var i = 0; i < length; i++) {
    if (max < sequence[i]) {
        max = sequence[i];
    }
    if (min > sequence[i]) {
        min = sequence[i];
    }
}
console.log('Max is: ' + max);
console.log('Min is: ' + min);

// Problem 4. Lexicographically smallest
// Write a script that finds the lexicographically smallest and largest property in document, window and navigator objects.

console.log('Window properties:');
getProps(window);
console.log('Navigator properties:');
getProps(navigator);
console.log('Document properties:');
getProps(document);
function getProps(obj){
    var min = 'zz';
    var max = '';
    for(var property in obj){

        if(property < min){
            min = property;
        }
        if(property > max){
            max = property;
        }
    }
    console.log('Smallest: ' + min);
    console.log('Largest: ' + max + '\n\r');
}

// 'for' iterates over object properties - isn't that lovely!