var someArr = ['red', 'green', 'blue'];
var first, second, third;

//Before
// first = someArr[0];
// second = someArr[1];
// third = someArr[3];

//Now
var [first, second, third] = someArr;

var arr2 = [0, 1, 2, 3];
arr2.reverse();
var elem1 = arr2[0];
var elem2 = arr2[1];
console.log(elem1);
console.log(elem2);

var text1 = 'HELLO WORLD';

// var result = prompt('Text', text);

var arrowFunc = (str) => str === str.toUpperCase();


console.log(arrowFunc("helloWorld"));
console.log(arrowFunc('HELLO'));

var animals = ['cow', 'leo', 'elephant'];

console.log(animals.slice(0, animals.length - 1));

var copyWithoutLast = (str2) => str2.slice(0, str2.length - 1);

console.log(copyWithoutLast('kek'));

var obj = {
    color: 'red',
    name: 'Noname',
    surname: 'Nosurname',
};

var obj2 = {
    color: 'blue',
    name: 'name',
    surname: 'surname',
};

console.log(Object.getOwnPropertyDescriptor(obj));
//Object.assign(obj, obj2);