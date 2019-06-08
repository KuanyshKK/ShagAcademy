function addNum(a, b) {
    a = a || 10;
    b = b || 10;
    console.log("a + b =", a + b);
}
console.log(addNum(5, 10));

console.log("Hello World!");

var addNumbers = (a, b, c) => {
    var sum = a + b + c;

    return sum;

}
console.log(addNumbers(1, 2, 3));

var menu = {
    p1: 300,
    p2: 600,
    p3: 500
};

for (var key in menu) {
    console.log(key, menu[key]);
}

console.log("objeck keys", Object.keys(menu));
var big = 0;
var sum = 0;
for (var i = 0; i < Object.keys(menu).length; i++) {
    
    if(menu[Object.keys(menu)[i]]>big){
        big = menu[Object.keys(menu)[i]];
        sum = i;
    };
    
}

console.log(Object.keys(menu)[sum], "has a biggest salary = ",big);

var word = "back-ground";
word.split('-');
console.log(word);


function truncate(str,maxlength){
    str.slice(0,str.length-maxlength);
    console.log(str);
    var strCopy = str;
    strCopy +="...";
    return strCopy;
}

console.log(truncate("Hello world!",2));
