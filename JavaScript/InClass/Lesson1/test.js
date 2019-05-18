
// var name = prompt('What is your name?', '...');
// alert(name);


// var num;
// if (num == 0) {
//     alert('0');
// } else if (num < 0) {
//     alert('-1');
// } else if (num > 0) {
//     alert('1');
// }

// var zoo = prompt('Введите число?', '...');
// var message = zoo > 0 ? 1 : zoo < 0 ? -1 : 0;
// alert(message);

for(var line = '*';line.length<=7;line+='*'){
    console.log(line);
}

function printChar(str){
    for(var line = str;line.length<=7;line+=str){
        console.log(line);
    }
}

printChar('+');

if(true){
    let letMes = 'let';
}

//console.log(let);

var square = function(x){
    return x*x;
};
console.log(square(12));


