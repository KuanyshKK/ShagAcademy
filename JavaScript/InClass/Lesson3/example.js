class Person {
    constructor(name,age){
        this.name = name;
        this.age = age;
    }

    describe(){
        return `${this.name}, ${this.age} years old`;
    }
}

let p = new Person("John",20);
console.log(p.describe());

function divHander(){
    console.log('clocked div');
}

function askUser(){
    event.preventDefault();
    console.log("ask");
    var result = confirm("Вы действительно хотите покинуть страницу?");
    console.log("result",result);
    if(!result){
        event.preventDefault();
    }
}

function hideText() {    
    document.getElementById("text").style.display = "none";
}

function hideButton(element) {
    element.style.opacity = "0";
}

function showElements(){
   document.getElementById('element').classList.toggle("hide");
}