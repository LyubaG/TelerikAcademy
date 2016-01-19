function solve() {
	var domElement = (function () {
		function isValidateString(param) {
			var regex = /^[a-z0-9]+$/gi;

			if (typeof (param) !== 'string') {
				return false;
			}
			return regex.test(param);
		}

		function isValidAttribute(param) {
			var regex = /^[a-z0-9\-]+$/gi;

			return regex.test(param);
		}

		var domElement = {
			//constructor
			init: function (type) {
				this.type = type;
				this.content = '';
				this.attributes = {};
				this.children = [];
				this.parent = '';
				return this;
			},
			appendChild: function (child) {
				this.children.push(child);
				if (typeof (child) === 'object') {
					child.parent = this;
				}
				return this;
			},
			addAttribute: function (name, value) {
				if (!isValidAttribute(name)) {
					throw new Error();
				}
				//important
				this.attributes[name] = value;
				return this;
			},
			removeAttribute: function (name) {
				if (!this.attributes.hasOwnProperty(name)) {
					throw new Error();
				}
				delete this.attributes[name];
				return this;
			},


			get innerHTML() {
				var result = '';
				var sortedAttributes = getSortedKeys(this.attributes),
					currentKey;

				result += '<';
				result += this.type;
				for (var i = 0; i < sortedAttributes.length; i += 1) {
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
				if (!isValidateString(value)) {
					throw new Error();
				}
				this._type = value;
			},

			get content() {
				if (this.children.length) {
					return '';
				}
				return this._content;
			},
			set content(value) {
				this._content = value;
			},
			get attributes() {
				return this._attributes;
			},
			set  attributes(value) {
				this._attributes = value;
			},
			get children() {
				return this._children;
			},
			set children(value) {
				this._children = value;
			},
			get parent() {
				return this._parent;
			},
			set parent(value) {
				this._parent = value;
			}
		};
		return domElement;
	}());

	return domElement;
}

module.exports = solve;