// Problem 3. Occurrences of word
// Write a function that finds all the occurrences of word in a text.
// The search can be case sensitive or case insensitive.
// Use function overloading.

var text = 'baba meca MECA Baba Meca Kuma lisa Lisa'
console.log(occurrenceCount(text, 'meca', false));
console.log(occurrenceCount(text, 'meca', true));

function occurrenceCount(text, word, isCaseSensitive) {
    var regex;
    if (isCaseSensitive) {
        regex = new RegExp('(\\b' + word + '\\b)', 'gm');
    } else {
        regex = new RegExp('(\\b' + word + '\\b)', 'gim');
    }
    return text.match(regex).length;
}
