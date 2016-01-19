// Problem 6. Larger than neighbours
// Write a function that checks if the element at given position in given array of integers is bigger than its two neighbours (when such exist).

console.log(isLarger([1, 2, 1], 1));
console.log(isLarger([5], 0));
console.log(isLarger([7, 8, 9], 0));

function isLarger(arr, index) {
    var isBigger = true; //also returns true if there are no neighbours
    for (var i = index-1; i<=index+1;i+=2) {
        if(arr[index] <= arr[i]) {
            isBigger = false;
        }
    }
        return isBigger;
}

