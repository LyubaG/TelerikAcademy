// Problem 7. First larger than neighbours
// Write a function that returns the index of the first element in array that is larger than its neighbours or -1, if there’s no such element.
// Use the function from the previous exercise.

console.log(firstLargeGuyIndex([1, 2, 1]));
console.log(firstLargeGuyIndex([5]));
console.log(firstLargeGuyIndex([7, 7, 7]));


function firstLargeGuyIndex(arr){
    for(var i in arr){
        if (isLarger(arr, i)){
            return i;
        }
    }
    return -1;
}


function isLarger(arr, index) {
    var isBigger = true; //also returns true if there are no neighbours
    for (var i = index - 1; i <= index + 1; i += 2) {
        if (arr[index] <= arr[i]) {
            isBigger = false;
        }
    }
    return isBigger;
}
