// Problem 1. Increase array members

function problem1() {
    var intArr = new Array(20);
    var len = intArr.length;
    for(var i = 0; i < len; i += 1) {
        intArr[i] = i*5;
    }
    console.log(intArr);
}

// Problem 2. Lexicographically comparison

function problem2(){
    var firsArr = 'Traktor'; // each string is a char array, too
    var secondArr = ['h', 'k', 'm', 'w'];
    if(firsArr > secondArr) {
        console.log(firsArr + 'comes lexicographically before ' + secondArr);
    }
    else {
        console.log(secondArr + ' comes lexicographically before ' + firsArr);
    }
}

// Problem 3. Maximal sequence

function problem3() {
    // for testing:
    //var arr = [2, 1, 1, 2, 3, 3, 2, 2, 2, 1];
    var arr = [2, 5, 6, 8, 8, 8, 12, 12, 12, 12, 3, 4, 5, 6, 0];
    var countSequence = 0;
    var repElement = 0;
    var countStored = 0;
    var repElementStored = 0;
    var len = arr.length;
    for (var i = 0; i < len - 1; i++)
    {
        if (arr[i] === arr[i + 1]) {
            countSequence++;
            repElement = arr[i];
        }
        else if (countSequence >= countStored) {
            countStored = countSequence;
            repElementStored = repElement;
            countSequence = 0;
        }
        else
            continue;
    }
    console.log('The longest sequence is ' + Array(countStored + 2).join(repElementStored.toString()+', '));
    // TODO find out why it's +2 above and not +1
}

// Problem 4. Maximal increasing sequence

function problem4() {
    // for testing:
    //var elements = [3, 2, 3, 4, 2, 2, 4];
    var elements = [3, 2, 2, 2, 3, 4, 5, 11, 14, 6, 2, 2, 4]; //to test increasing sequence even if sequence is not +1

    var len = elements.length;
    var countSequence = 0;
    var sequenceArr = new Array(len);
    var copiedSeq = sequenceArr.slice(0);
    var countStored = 0;
    var index2 = 0;
    for (var i = 1; i < len; i++) {
        if (elements[i] > elements[i - 1]) {
            countSequence+=1;
            sequenceArr[index2] = elements[i - 1];
            sequenceArr[index2 + 1] = elements[i];
            index2+=1;
        }
        else if (countSequence > countStored) {
            countStored = countSequence + 1;

            copiedSeq = sequenceArr.slice(0);
            sequenceArr.length = 0;
            countSequence = 0;
        }
        else
            continue;
    }

    console.log(copiedSeq);

}

// Problem 5. Selection sort:
// Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.

function problem5() {
    //pick an array for testing:
    //var arr = [1, 1, 1, 4, 4, 4, 5, 6, 7, 12, 43, 32, 78];
    //var arr = [3, 2, 3, 4, 5, 6, 2, 2, 4];
    var arr = [12, 11, 9, 8, 0, -9, 13, -54];
    var len = arr.length;
    var minValue;
    var minIndex = -1;
    for (var i = 0; i < len-1; i++) {
        minValue = Number.MAX_VALUE;
        minIndex = i;
        for (var j = i+1; j < len; j++) {
            if (arr[minIndex] > arr[j]) {
                minValue = arr[j];
                minIndex = j;
            }
        }
        var temp = arr[i];
        arr[i] = minValue;
        arr[minIndex] = temp;
    }
    console.log(arr);
}

// Problem 6. Most frequent number

function problem6() {
    // for testing:
    //var elements = [3, 2, 2, 2, 3, 4, 5, 11, 14, 6, 2, 2, 4];
    var elements = [4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3];
    var len = elements.length;

    elements.sort(); //doesn't need to be a stable sort, we just need equals next to each other
    var countSequence = 0, repElement = 0, countStored = 0, repElementStored = 0;
    for (var i = 0; i < len - 1; i++) {
        if (elements[i] == elements[i + 1]) {
            countSequence++;
            repElement = elements[i];
        }
        else if (countSequence >= countStored) {
            countStored = countSequence;
            repElementStored = repElement;
            countSequence = 0;
        }
        else
            continue;
    }
    console.log('Most frequent number: ' + repElementStored + ', repeated ' +(countStored + 1) +' times.');
}

// Problem 7. Binary search
// Write a script that finds the index of given element in a sorted array of integers by using the binary search algorithm.

function problem7() {

    var array = [ -9, 23, 45, -14, 0, 1, 2, 13, 37, 3, 4, 12, 11, 54, 0, 0, 11, 12];
    var soughtNum = 4;
    array.sort(function(a, b) {
        return a - b;
    });
    console.log(array);
    var startIndex = 0;
    var endIndex = array.length;
    while (startIndex <= endIndex)
    {
        var mid = Math.floor((startIndex + endIndex) / 2);
        if (soughtNum == array[mid]) {
            break;
        }
        else         {
            if (soughtNum > array[mid]) {
                startIndex = mid;
            }
            else {
                endIndex = mid;
            }
        }
    }
    var position = Math.floor((startIndex + endIndex) / 2);
    console.log('When the array is sorted, the number ' + array[position] + ' is on position ' + position);
}