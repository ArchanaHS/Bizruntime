
console.log("\x1b[47m\x1b[30m%s\x1b[0m","-----------STATIC types-----------"); 
let first: number = 12.2; //number
let second: number = 0xFFF; //hex
let third: number = 0o373; //octal
let fourth: number = 0b1101; //binary
console.log("\n\n---------\x1b[103m\x1b[30m--Number--\x1b[0m---------")
console.log(first)
console.log(second)
console.log(third)
console.log(fourth)
console.log("\x1b[91m-----------eof Number-----------\x1b[0m")


console.log("\n---------\x1b[103m\x1b[30m--String--\x1b[0m---------")
let empName: string = "Rohan";   
let empDept: string = "IT"; 
let strOutput: string = `${empName} works in ${empDept} department`
console.log(strOutput);
console.log("\x1b[91m-----------eof String-----------\x1b[0m")

console.log("\n---------\x1b[103m\x1b[30m--Boolean--\x1b[0m---------")
let isDone: boolean = false;
console.log(isDone);  
console.log("\x1b[91m-----------eof Boolean-----------\x1b[0m")


console.log("\n---------\x1b[103m\x1b[30m--Void--\x1b[0m---------")
function helloUser(): void {
    console.log("Greetings User!")
}
helloUser();
console.log("\x1b[91m-----------eof Void-----------\x1b[0m")


console.log("\n---------\x1b[103m\x1b[30m--Any type--\x1b[0m---------")
function ProcessData(x: any, y: any):any {  
    return x + y;  
}  
let result: any;  
result = ProcessData("Hello ", "Any!"); 
console.log(result,"of type",typeof result)
result = ProcessData(2, 3); 
console.log(result,"of type",typeof result)
console.log("\x1b[91m-----------eof Any type-----------\x1b[0m\n\n")



console.log("\x1b[47m\x1b[30m%s\x1b[0m","-----------USERDEFINED types-----------"); 

//array
console.log("\n\n---------\x1b[103m\x1b[30m--ARRAY--\x1b[0m---------")
var list : Array<number> = [1, 3, 5];
var fruits : string[] = ["Apple", "Orange", "Banana"];

console.log(list, fruits);

console.log('---------')
//Union Array
var mixed : Array<(string|number)> = ['Apple',1,'Orange',3,'Banana',5]
console.log(mixed);

console.log("\x1b[91m-----------eof ARRAY-----------\x1b[0m")


//tuple
console.log("\n---------\x1b[103m\x1b[30m--TOUPLE--\x1b[0m---------")
let tuple : [string,number];
tuple = ["One",1];

console.log(tuple)
console.log("\x1b[91m-----------eof TOUPLE-----------\x1b[0m")

//interface
console.log("\n---------\x1b[103m\x1b[30m--INTERFACE--\x1b[0m---------")
interface ops {
    subtract(a:number, b :number) : number;
    add(a:any, b :any) : any;
}

let CalculatorOperation : ops =  {
    subtract(a,b) {
        return a-b
    },
    add(a,b){
        return a+b
    }
}

console.log(CalculatorOperation.add("Amal","Salvin"))
console.log(CalculatorOperation.subtract(13,5))
console.log("\x1b[91m-----------eof INTERFACE-----------\x1b[0m")


console.log("\n---------\x1b[103m\x1b[30m--CLASS--\x1b[0m---------")
class Student{
    rollNo : number;
    Name : string;
    constructor(_rollNo: number, _name: string){
        this.rollNo = _rollNo;
        this.Name = _name;
    }

    showDetails() {
        console.log(this.rollNo);
        console.log(this.Name);        
    }
}

let Pavitra: Student
Pavitra = new Student(1,"Pavitra")
Pavitra.showDetails();

console.log("\x1b[91m-----------eof CLASS-----------\x1b[0m")

//enum
console.log("\n---------\x1b[103m\x1b[30m--ENUMS--\x1b[0m---------")
enum Color {
    Red, Green, Blue
}

let c : Color;
c = Color.Red;
console.log(c)
console.log("\x1b[91m-----------eof ENUMS-----------\x1b[0m")


//function
console.log("\n---------\x1b[103m\x1b[30m--FUNCTIONS--\x1b[0m---------")
//Named Function
function add(a: number, b: number): number {  
    return a + b;  
}  

//Anonymous Function  
let sum = function (a: number, b: number): number {  
    return a + b;  
};  

//Arrow Function
let sumArrow : (a: number, b:number) => number ;
sumArrow = (a,b) => {
    return a + b
}

console.log("Named Function:",add(5,5));
console.log("Anonymous Functions:",sum(9,3));
console.log("Arrow Functions:",sumArrow(9,3));




   



