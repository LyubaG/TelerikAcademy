// Problem 5. Appearance count
// Write a function that counts how many times given number appears in given array.
// Write a test function to check if the function is working correctly.

var funArray = [12, 3, 4, 5, 6, 3, 4, 8, 9, 0, 11, 12, 15, 6, 7, 8, 7, 7, 3, 4, 0, 3];
var soughtNum = 3;
console.log(soughtNum + ' is present in the array ' + ElementCount(funArray,soughtNum) + ' times')
console.log('test function result: ' +TestFunc(funArray, soughtNum, 4))

function ElementCount(arr, element) {
    var count = 0, length = arr.length;
    for(var i = 0; i < length; i += 1) {
        if(arr[i] === element)
        count+=1;
    }
    return count;
}
function TestFunc(arr, element, expectedOutcome) {
    return expectedOutcome === ElementCount(arr, element) ? 'ok' : 'not very ok';
}
