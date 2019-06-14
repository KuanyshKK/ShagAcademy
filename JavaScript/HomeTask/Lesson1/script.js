// var a = prompt('Введите первое число: ','');
// var b = prompt('Введите второе число: ','');
// function min(a,b){
//     return a < b ? a : b;
// }

// alert(min(a,b));

function fizzBuzz(){
    for(var i = 1; i <= 100; i++){
        
        if(i%3==0 && i%5 !=0){
            console.log('Fizz');
        }else if(i%3 !=0 && i%5 ==0){
            console.log('Buzz');
        }else if(i%3 ==0 && i%5 ==0){
            console.log('FizzBuzz');
        }        
        console.log(i+'\n');
    }
}
fizzBuzz();

var str;

function countBs(str){    
    var countB = 0;
    for(var i = 0; i<str.length;i++){
        if(str.charAt(i)=='B'){
            countB++;
        }
    }
    return countB;
}

str = 'BlueBrown';
console.log(countBs(str));

function countChar(str2,symb){
    var countS = 0;
    for(var i = 0; i<str2.length;i++){
        if(str2.charAt(i)==symb){
            countS++;
        }
    }
    return countS;
}

console.log(countChar('HelloHenry','H'));