// Feel free to try with other examples ;)
// TO CHECK: copy each problem into your console or http://jsconsole.com

// Problem 1. Exchange if greater

var first = 5.5;
var second = 4.5;
var temp;
if (first > second) {
    temp = second;
    second = first;
    first = temp;
}
console.log(first + ' ' + second);

// Problem 2. Multiplication Sign

var numSet1 = [0, -2.5, 4];
var numSet2 = [-1, -0.5, -5.1];
var numSet3 = [-2, -2, 1];

function multipSign(numSet) {
    var minusCount = 0;
    var length = numSet.length;
    for(var i = 0; i < length; i++) {
        if(numSet[i] != 0) {
            if(numSet[i] < 0) {
                minusCount += 1;
            }
        }
        else return 0;
    }
    if(minusCount % 2) {
        return '-';
    }
    else return '+';
}

console.log(numSet1 + ' --> ' + multipSign(numSet1));
console.log(numSet2 + ' --> ' + multipSign(numSet2));
console.log(numSet3 + ' --> ' + multipSign(numSet3));

// Problem 3. The biggest of Three

var threeSet1 = [5, 2, 2];
var threeSet2 = [0, -2.5, 5];
var threeSet3 = [-0.1, -0.5, -1.1];

function biggestNum(numSet) {
    if(numSet[0] > numSet[1]) {
        if(numSet[0] > numSet[2]) {
            return numSet[0];
        }
        else return numSet[2];
        }
    else if(numSet[2] > numSet[1]) {
        return numSet[2];
    }
    else return numSet[1];
}

console.log(threeSet1 + ' --> ' + biggestNum(threeSet1));
console.log(threeSet2 + ' --> ' + biggestNum(threeSet2));
console.log(threeSet3 + ' --> ' + biggestNum(threeSet3));

// Problem 4. Sort 3 numbers

console.log('-1.1, -0.5, -0.1 --> ' + sortNums(-1.1, -0.5, -0.1));
console.log('0, -2.5, 5 --> ' + sortNums(0, -2.5, 5));
console.log('-2, -2, 1 --> ' + sortNums(-2, -2, 1));

function sortNums(a,b,c) {
    var sortedString = '';
    if (a >= b) {
        if (b >= c) {
            sortedString = a + ' ' + b + ' ' + c;
        } else {
            if (c > a) {
                sortedString = c + ' ' + a + ' ' + b;
            } else {
                sortedString = a + ' ' + c + ' ' + b;
            }
        }
    } else {
        if (b >= c) {
            if (a >= c) {
                sortedString = b + ' ' + a + ' ' + c;
            } else {
                sortedString = b + ' ' + c + ' ' + a;
            }
        } else {
            sortedString = c + ' ' + b + ' ' + a;
        }
    }
    return sortedString;}

// Problem 5. Digit as word

var number = prompt('Enter number between 0 and 9, inclusive: ');
switch (number) {
    case '0': console.log('Zero.'); break;
    case '1': console.log('One.'); break;
    case '2': console.log('Two.'); break;
    case '3': console.log('Three.'); break;
    case '4': console.log('Four.'); break;
    case '5': console.log('Five.'); break;
    case '6': console.log('Six.'); break;
    case '7': console.log('Seven.'); break;
    case '8': console.log('Eight.'); break;
    case '9': console.log('Nine.'); break;
    default: console.log('not a digit');
}

// Problem 6. Quadratic equation

console.log(getRealRoots(2, 5, -3));
console.log(getRealRoots(-1, 3, 0));
console.log(getRealRoots(-0.5, 4, -8));
console.log(getRealRoots(5, 2, 8));

function getRealRoots(a,b,c) {
    if (a == 0) {
        var x = -c / b;
        return 'One root: ' + x;
    }
    else {
        var D = (b * b) - (4 * a * c);
        if (D < 0) {
            return 'No real roots.';
        }
        if (D == 0) {
            var x = (-1 * b) / (2 * a);
            return 'Double root: ' + x;
        }
        if (D > 0) {
            var x1 = ((-1 * b) - Math.sqrt(D)) / (2 * a);
            var x2 = ((-1 * b) + Math.sqrt(D)) / (2 * a);
            return 'First root: ' + x1 + '; ' + 'Second root: ' + x2;
        }
    }
}

// Problem 7. The biggest of five numbers

console.log(findGreatest(5, 2, 2, 4, 1));
console.log(findGreatest(-2, -22, 1, 0, 0));
console.log(findGreatest(-2, 4, 3, 2, 0));
console.log(findGreatest(0, -2.5, 0, 5, 5));
console.log(findGreatest(-3, -0.5, -1.1, -2, -0.1));

function findGreatest(a, b, c, d, e){
    var max = Math.max();
    if(a > max){
        max = a;
    }
    if(b > max){
        max = b;
    }
    if(c > max){
        max = c;
    }
    if(d > max){
        max = d;
    }
    if(e > max){
        max = e;
    }
    return max;
}

// Problem 8. Number as words
// (Solution is a bit long - easiest way to make sure spelling/capitalization is ok)

var digit = prompt('Enter a number between 0 and 999:');
var numPhrase;
if (digit >= 0 && digit <= 20)
{
    switch (digit)
    {
        case '0':
            numPhrase = 'Zero';
            break;
        case '1':
            numPhrase = 'One';
            break;
        case '2':
            numPhrase = 'Two';
            break;
        case '3':
            numPhrase = 'Three';
            break;
        case '4':
            numPhrase = 'Four';
            break;
        case '5':
            numPhrase = 'Five';
            break;
        case '6':
            numPhrase = 'Six';
            break;
        case '7':
            numPhrase = 'Seven';
            break;
        case '8':
            numPhrase = 'Eight';
            break;
        case '9':
            numPhrase = 'Nine';
            break;
        case '10':
            numPhrase = 'Ten';
            break;
        case '11':
            numPhrase = 'Eleven';
            break;
        case '12':
            numPhrase = 'Twelve';
            break;
        case '13':
            numPhrase = 'Thirteen';
            break;
        case '14':
            numPhrase = 'Fourteen';
            break;
        case '15':
            numPhrase = 'Fifteen';
            break;
        case '16':
            numPhrase = 'Sixteen';
            break;
        case '17':
            numPhrase = 'Seventeen';
            break;
        case '18':
            numPhrase = 'Eighteen';
            break;
        case '19':
            numPhrase = 'Nineteen';
            break;
        case '20':
            numPhrase = 'Twenty';
            break;
    }
}
if (digit > 20 & digit < 100)
{
    var secondDigit = (digit / 10).toFixed();
    if (digit % 10 >= 5)
    {
        secondDigit -= 1;
    }
    var firstDigit = (digit % 10);
    switch (secondDigit)
    {
        case 2:
            numPhrase = 'Twenty';
            break;
        case 3:
            numPhrase = 'Thirty';
            break;
        case 4:
            numPhrase = 'Forty';
            break;
        case 5:
            numPhrase = 'Fifty';
            break;
        case 6:
            numPhrase = 'Sixty';
            break;
        case 7:
            numPhrase = 'Seventy';
            break;
        case 8:
            numPhrase = 'Eighty';
            break;
        case 9:
            numPhrase = 'Ninety';
            break;
    }
    if (firstDigit != 0)
    {
        switch (firstDigit)
        {
            case 1:
                numPhrase += '-one';
                break;
            case 2:
                numPhrase += '-two';
                break;
            case 3:
                numPhrase += '-three';
                break;
            case 4:
                numPhrase += '-four';
                break;
            case 5:
                numPhrase += '-five';
                break;
            case 6:
                numPhrase += '-six';
                break;
            case 7:
                numPhrase += '-seven';
                break;
            case 8:
                numPhrase += '-eight';
                break;
            case 9:
                numPhrase += '-nine';
                break;
        }
    }
}
if (digit >= 100 && digit <= 999)
{
    var thirdDigit = (digit / 100).toFixed();
    var secondDigit = ((digit % 100) / 10).toFixed();
    var firstDigit = digit % 10;
    if (firstDigit >= 5)
    {
        secondDigit -= 1;
    }
    if (secondDigit >= 5)
    {
        thirdDigit -= 1;
    }
// parse to number
    firstDigit *= 1;
    secondDigit *= 1;
    thirdDigit *= 1;
    switch (thirdDigit)
    {
        case 1:
            numPhrase = 'One hundred';
            break;
        case 2:
            numPhrase = 'Two hundred';
            break;
        case 3:
            numPhrase = 'Three hundred';
            break;
        case 4:
            numPhrase = 'Four hundred';
            break;
        case 5:
            numPhrase = 'Five hundred';
            break;
        case 6:
            numPhrase = 'Six hundred';
            break;
        case 7:
            numPhrase = 'Seven hundred';
            break;
        case 8:
            numPhrase = 'Eight hundred';
            break;
        case 9:
            numPhrase = 'Nine hundred';
            break;
    }
    var secondDigits = [ 'ten', 'twenty', 'thirty', 'forty', 'fifty', 'sixty', 'seventy', 'eighty', 'ninety' ];
    var firstDigits = [ '-one', '-two', '-three', '-four', '-five', '-six', '-seven', '-eight', '-nine' ];
    var aboveTen = [ 'eleven', 'twelve', 'thirteen', 'fourteen', 'fifteen', 'sixteen', 'seventeen', 'eighteen', 'nineteen' ];
    if (firstDigit == 0 && secondDigit != 0)
    {
        numPhrase = numPhrase + ' and ' + secondDigits[secondDigit-1];
    }
    if (firstDigit != 0 && secondDigit == 0)
    {
        numPhrase = numPhrase + ' and ' + firstDigits[firstDigit - 1];
    }
    if (firstDigit != 0 && secondDigit == 1)
    {
        numPhrase = numPhrase + ' and ' + aboveTen[firstDigit - 1];
    }
    if (firstDigit != 0 && secondDigit > 1)
    {
        numPhrase = numPhrase + ' ' + secondDigits[secondDigit - 1] + firstDigits[firstDigit - 1];
    }
}
console.log('\n\rResult: ' + digit + ' => ' + numPhrase);
