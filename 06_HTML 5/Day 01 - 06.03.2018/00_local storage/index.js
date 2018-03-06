
//a way to add to the <body> a function that will be executed when the  "onload" event is raised
onload = () => {

    //if we dont have an item with this key - we will get null
    let prevColor = localStorage.getItem("MyColor");
    prevColor = (prevColor) ? prevColor:"#111111" ;


    console.log("prevColor", prevColor);

    document.body.style.backgroundColor = prevColor;
    document.getElementById("color").value = prevColor;
};


function saveColor() {
    let color = document.getElementById("color").value;

    console.log("color",color);

    //localStorage����� ���� � 
    //MyColor ����� �� ����� ���
    //color ���� �� ����� ��� ����� �� ������ 
    localStorage.setItem("MyColor", color);

    document.body.style.backgroundColor = color;
}



