// Problem 1: Literals
var intLiteral = 42;
var floatLiteral = 12.454;
var stringLiteral = 'banichka';
var arrLiteral = [true, 12, 24.5, 'hey'];
var boolLiteral = true;
var objectLiteral = {animal: 'kitten', whiskers: 15};
var func = function(){return "I'm not quite a literal";};

// Problem 2: String with quoted text
var escapedQuotation = 'And she sang \'...yeah I\'ll go on...\'';
var integratedQuotation = "And she sang '...yeah I'll go on...'";
var outputString = escapedQuotation +'\n\r'+ escapedQuotation;
console.log(outputString);

// Problem 4: Null and undefined
var nullVar = null;
var undefinedVar = undefined;

//Problem 3: typeof on all variables
var variableArr = [intLiteral, floatLiteral, stringLiteral, arrLiteral, boolLiteral, objectLiteral, func, undefinedVar, nullVar];
for(var variable in variableArr){
    console.log(printTypeOf(variableArr[variable]));
}
function printTypeOf(obj){
    var result = obj + ' --> typeof: ' + typeof(obj);
    return result;
}