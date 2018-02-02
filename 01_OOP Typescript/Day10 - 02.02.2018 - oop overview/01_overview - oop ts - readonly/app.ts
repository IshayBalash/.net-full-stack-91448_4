﻿class A {
    //A class member cannot have the 'const' keyword.
    //const num: number = 8;  -->שגיאת קומפילציה 

    public readonly age1: number;  
    public readonly age2: number = 6;  //השמה בשורת ההגדרה
    public readonly age3: number = 6;  //השמה בשורת ההגדרה


    public static readonly age4: number = 6;  //השמה בשורת ההגדרה
    public static readonly age5: number;  

    public constructor() {
        this.age1 = 6;  //השמה בתוך הבנאי
        this.age2 = 3;  //השמה בתוך הבנאי

        //Left- hand side of assignment expression cannot be a constant or a read- only property.
        //A.age4 = 6;  //שגיאת קומפילציה  // השמה למשתנה קבוע סטטי בתוך הבנאי

        //Left- hand side of assignment expression cannot be a constant or a read- only property.
       // A.age5 = 3; -->שגיאת קומפילציה  // השמה למשתנה קבוע סטטי בתוך הבנאי
    }

    public print(): void {
        //this.age4 -->שגיאת קומפילציה - לא קיים ברמת האובייקט כי הוא משתנה סטטי
        document.write("print function - A.age4: " + A.age4 + "<br/>");  //-->A.age4: 6
    }
}

const num: number = 8;
//Left- hand side of assignment expression cannot be a constant or a read- only property.
//num = 6; -->שגיאת קומפילציה 

let obj1: A = new A();

//Left- hand side of assignment expression cannot be a constant or a read- only property.
//obj1.age1 = 6; -->שגיאת קומפילציה 

document.write("obj1.age2: " + obj1.age2+"<br/>");  //-->obj1.age2: 3

document.write("obj1.age3: " + obj1.age3 + "<br/>");  //-->obj1.age2: 6

document.write("A.age4: " + A.age4 + "<br/>");  //-->A.age4: 6