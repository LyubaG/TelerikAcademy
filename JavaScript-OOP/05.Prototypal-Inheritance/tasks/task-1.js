/* Task Description */
/*
 * Create an object domElement, that has the following properties and methods:
 * use prototypal inheritance, without function constructors
 * method init() that gets the domElement type
 * i.e. `Object.create(domElement).init('div')`
 * property type that is the type of the domElement
 * a valid type is any non-empty string that contains only Latin letters and digits
 * property innerHTML of type string
 * gets the domElement, parsed as valid HTML
 * <type attr1="value1" attr2="value2" ...> .. content / children's.innerHTML .. </type>
 * property content of type string
 * sets the content of the element
 * works only if there are no children
 * property attributes
 * each attribute has name and value
 * a valid attribute has a non-empty string for a name that contains only Latin letters and digits or dashes (-)
 * property children
 * each child is a domElement or a string
 * property parent
 * parent is a domElement
 * method appendChild(domElement / string)
 * appends to the end of children list
 * method addAttribute(name, value)
 * throw Error if type is not valid
 * method removeAttribute(attribute)
 * throw Error if attribute does not exist in the domElement
 */


/* Example

 var meta = Object.create(domElement)
 .init('meta')
 .addAttribute('charset', 'utf-8');

 var head = Object.create(domElement)
 .init('head')
 .appendChild(meta)

 var div = Object.create(domElement)
 .init('div')
 .addAttribute('style', 'font-size: 42px');

 div.content = 'Hello, world!';

 var body = Object.create(domElement)
 .init('body')
 .appendChild(div)
 .addAttribute('id', 'cuki')
 .addAttribute('bgcolor', '#012345');

 var root = Object.create(domElement)
 .init('html')
 .appendChild(head)
 .appendChild(body);

 console.log(root.innerHTML);
 Outputs:
 <html><head><meta charset="utf-8"></meta></head><body bgcolor="#012345" id="cuki"><div style="font-size: 42px">Hello, world!</div></body></html>
 */

//Object.keys... map...

function solve() {
 var domElement = (function () {
  var domElement = {
   init: function (type) {
    this.type = type;
    this.content = '';
    this.attributes = {};
    this.children = [];
    this.parent = '';
    return this;
   },
   appendChild: function (child) {
    if (typeof (child) === 'object') {
     child.parent = this;
    }
    return this;
   },
   addAttribute: function (name, value) {
    if (!(/^[a-zA-Z0-9\-]+$/.test(name))
        || typeof(name) !== 'string') {
     throw new Error('Invalid attribute');
    }
    this.attributes[name] = value;
    return this;
   },
   removeAttribute: function (attribute) {
    if (!this.attributes.hasOwnProperty(attribute)) {
     throw new Error();
    }
    delete this.attributes[attribute];
    return this;
   },

   get innerHTML() {
    var i,
        result = '';
    var sortedAttributes = getSortedKeys(this.attributes), currentKey;
    result += '<';
    result += this.type;
    for (i = 0; i < sortedAttributes.length; i += 1) {
     currentKey = sortedAttributes[i];
     result += ' ';
     result += currentKey + '="';
     result += this.attributes[currentKey] + '"';
    }
    result += '>';
    for (var index = 0; index < this.children.length; index++) {
     var element = this.children[index];
     if (typeof element === 'string') {
      result += element;
     } else {
      result += element.innerHTML;
     }

    }
    //important
    result += this.content;
    result += '</' + this.type + '>';
    return result;
    function getSortedKeys(attrs) {
     var keys = [];
     for (var key in attrs) {
      keys.push(key);
     }
     keys.sort();
     return keys;
    }
   },

   get type() {
    return this._type;
   },
   set type(value) {
    if (!(/^[a-zA-Z0-9]+$/.test(value))
        || typeof(value) !== 'string') {
     throw new Error('Invalid type');
    }
    /*    if (type.search(/[^a-zA-Z0-9]+/) === -1) {
     throw new Error('Invalid type');
     }*/
    this._type = value;
    return this;
   },
   set content(value) {
    if (typeof(value) !== 'string') {
     throw new Error();
    }
    // children!!!!!!!!
    this._content = value;
    return this;
   },
   get content() {
    if (this.children.length) { // why here and not in get???
     return ''; //of there are NO kids...
    }
    return this._content;
   },
   set attributes(value){
    this._attributes = value;
   },
   get attributes() {
    return this._attributes;
   },
   set children(value) {
    this._children = value;
   },
   get children() {
    return this._children;
   },
   set parent(value) {
    this._parent = value;
   },
   get parent() {
    return this._parent;
   },
  };
  return domElement;
 }());
 return domElement;
}

module.exports = solve;