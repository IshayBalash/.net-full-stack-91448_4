class A{
  getInfo(){
    console.log("A");
  }
}


class B extends A{
  getInfo(){
    console.log("B");
  }
}


class C extends B{
  getInfo(){
    console.log("C");
  }
}


//-------------A POINTER-----------------
let a1:A=new A();
let a2:A=new B();
let a3:A=new C();



//-------------B POINTER-----------------
let b1:B=new B();
let b2:B=new C();


//-------------C POINTER-----------------
let c1:C=new C();



console.log("------------A POINTER---------------");
a1.getInfo();
a2.getInfo();
a3.getInfo();

console.log("------------B POINTER---------------");
b1.getInfo();
b2.getInfo();

console.log("------------C POINTER---------------");
c1.getInfo();
