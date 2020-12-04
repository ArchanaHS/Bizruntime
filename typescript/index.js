//string
var message = "Hello World";
console.log(message);
//class,object,method.
var Greeting = /** @class */ (function () {
    function Greeting() {
    }
    Greeting.prototype.greet = function () {
        console.log("Hello World!!!");
    };
    return Greeting;
}());
var obj = new Greeting();
obj.greet();
//variables
var name1 = "John";
var score1 = 50;
var score2 = 42.50;
var sum = score1 + score2;
console.log("name" + name1);
console.log("first score: " + score1);
console.log("second score: " + score2);
console.log("sum of the scores: " + sum);
//Decision Making.
//if condition.
var num = 5;
if (num > 0) {
    console.log("number is positive");
}
//if else Condition
var num1 = 12;
if (num % 2 == 0) {
    console.log("even");
}
else {
    console.log("odd");
}
//if-else-if-else 
var num2 = 2;
if (num2 > 0) {
    console.log(num2 + " is positive");
}
else if (num2 < 0) {
    console.log(num2 + " is negative");
}
else {
    console.log(num2 + " is neither positive nor negative");
}
//switch statement
var grade = "A";
switch (grade) {
    case "A": {
        console.log("Excellent");
        break;
    }
    case "B": {
        console.log("Good");
        break;
    }
    case "C": {
        console.log("Fair");
        break;
    }
    case "D": {
        console.log("Poor");
        break;
    }
    default: {
        console.log("Invalid choice");
        break;
    }
}
//loops
//for loop
var j;
var n = "a b c";
for (j in n) {
    console.log(n[j]);
}
//while and do-while loop
var x = 5;
while (x > 5) {
    console.log("Entered while");
}
do {
    console.log("Entered do…while");
} while (x > 5);
//function
function test(n1, s1) {
    console.log(n1);
    console.log(s1);
}
test(123, "this is a string"); //method call
//array
var alphas;
alphas = ["a", "b", "c", "d"];
console.log(alphas[0]);
console.log(alphas[1]);
//array object
var arr_names = new Array(4);
for (var i = 0; i < arr_names.length; i++) {
    arr_names[i] = i * 2;
    console.log(arr_names[i]);
}
//array method
//filter()
function isBigEnough(element, index, array) {
    return (element >= 10);
}
var passed = [12, 5, 8, 130, 44].filter(isBigEnough);
console.log("Test Value : " + passed);
//tuples.
var mytuple = [10, "Hi"];
console.log(mytuple[0]);
console.log(mytuple[1]);
//emty tuple.
var tup = [];
tup[0] = 12;
tup[1] = "hello";
console.log(tup[0]);
console.log(tup[1]);
//union
var val;
val = 12;
console.log("numeric value of val " + val);
val = "This is a string";
console.log("string value of val " + val);
var customer = {
    firstName: "Tom",
    lastName: "Hanks"
};
console.log("Customer Object ");
console.log(customer.firstName);
console.log(customer.lastName);
//class declaration
var Car = /** @class */ (function () {
    //constructor 
    function Car(engine) {
        this.engine = engine;
    }
    //function 
    Car.prototype.disp = function () {
        console.log("Engine is  :   " + this.engine);
    };
    return Car;
}());
//object declaration.
var person = {
    firstname: "Tom",
    lastname: "Hanks"
};
console.log(person.firstname);
console.log(person.lastname);
