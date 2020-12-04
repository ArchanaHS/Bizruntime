console.log("\x1b[47m\x1b[30m%s\x1b[0m", "-----------STATIC types-----------");
var first = 12.2; //number
var second = 0xFFF; //hex
var third = 251; //octal
var fourth = 13; //binary
console.log("\n\n---------\x1b[103m\x1b[30m--Number--\x1b[0m---------");
console.log(first);
console.log(second);
console.log(third);
console.log(fourth);
console.log("\x1b[91m-----------eof Number-----------\x1b[0m");
console.log("\n---------\x1b[103m\x1b[30m--String--\x1b[0m---------");
var empName = "Rohan";
var empDept = "IT";
var strOutput = empName + " works in " + empDept + " department";
console.log(strOutput);
console.log("\x1b[91m-----------eof String-----------\x1b[0m");
console.log("\n---------\x1b[103m\x1b[30m--Boolean--\x1b[0m---------");
var isDone = false;
console.log(isDone);
console.log("\x1b[91m-----------eof Boolean-----------\x1b[0m");
console.log("\n---------\x1b[103m\x1b[30m--Void--\x1b[0m---------");
function helloUser() {
    console.log("Greetings User!");
}
helloUser();
console.log("\x1b[91m-----------eof Void-----------\x1b[0m");
console.log("\n---------\x1b[103m\x1b[30m--Any type--\x1b[0m---------");
function ProcessData(x, y) {
    return x + y;
}
var result;
result = ProcessData("Hello ", "Any!");
console.log(result, "of type", typeof result);
result = ProcessData(2, 3);
console.log(result, "of type", typeof result);
console.log("\x1b[91m-----------eof Any type-----------\x1b[0m\n\n");
console.log("\x1b[47m\x1b[30m%s\x1b[0m", "-----------USERDEFINED types-----------");
//array
console.log("\n\n---------\x1b[103m\x1b[30m--ARRAY--\x1b[0m---------");
var list = [1, 3, 5];
var fruits = ["Apple", "Orange", "Banana"];
console.log(list, fruits);
console.log('---------');
//Union Array
var mixed = ['Apple', 1, 'Orange', 3, 'Banana', 5];
console.log(mixed);
console.log("\x1b[91m-----------eof ARRAY-----------\x1b[0m");
//tuple
console.log("\n---------\x1b[103m\x1b[30m--TOUPLE--\x1b[0m---------");
var tuple;
tuple = ["One", 1];
console.log(tuple);
console.log("\x1b[91m-----------eof TOUPLE-----------\x1b[0m");
//interface
console.log("\n---------\x1b[103m\x1b[30m--INTERFACE--\x1b[0m---------");
var CalculatorOperation = {
    subtract: function (a, b) {
        return a - b;
    },
    add: function (a, b) {
        return a + b;
    }
};
console.log(CalculatorOperation.add("Amal", "Salvin"));
console.log(CalculatorOperation.subtract(13, 5));
console.log("\x1b[91m-----------eof INTERFACE-----------\x1b[0m");
console.log("\n---------\x1b[103m\x1b[30m--CLASS--\x1b[0m---------");
var Student = /** @class */ (function () {
    function Student(_rollNo, _name) {
        this.rollNo = _rollNo;
        this.Name = _name;
    }
    Student.prototype.showDetails = function () {
        console.log(this.rollNo);
        console.log(this.Name);
    };
    return Student;
}());
var Pavitra;
Pavitra = new Student(1, "Pavitra");
Pavitra.showDetails();
console.log("\x1b[91m-----------eof CLASS-----------\x1b[0m");
//enum
console.log("\n---------\x1b[103m\x1b[30m--ENUMS--\x1b[0m---------");
var Color;
(function (Color) {
    Color[Color["Red"] = 0] = "Red";
    Color[Color["Green"] = 1] = "Green";
    Color[Color["Blue"] = 2] = "Blue";
})(Color || (Color = {}));
var c;
c = Color.Red;
console.log(c);
console.log("\x1b[91m-----------eof ENUMS-----------\x1b[0m");
//function
console.log("\n---------\x1b[103m\x1b[30m--FUNCTIONS--\x1b[0m---------");
//Named Function
function add(a, b) {
    return a + b;
}
//Anonymous Function  
var sum = function (a, b) {
    return a + b;
};
//Arrow Function
var sumArrow;
sumArrow = function (a, b) {
    return a + b;
};
console.log("Named Function:", add(5, 5));
console.log("Anonymous Functions:", sum(9, 3));
console.log("Arrow Functions:", sumArrow(9, 3));
