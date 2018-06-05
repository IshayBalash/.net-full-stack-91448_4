

class Student {
    constructor(public studentName: string) { }
  
    //לא יודעים מה תהיה התגובה - ידוע שתהיה תגובה
    //פונקציה שמקבלת מחרוזת ולא מחזירה ערך
    subjectReaction: (subject: string) => void;
  
    subject: string;
  
  }
  
  //we have an array with 2 students: Assa , Meir
  let studentsArray: Student[] = [new Student("Assa"), new Student("Meir")];
  let subjectArray: string[] = ["Math", "Music", "Sport", "Physics"];
  
  
  for (let str of subjectArray) {
  
    for (let student of studentsArray) {
  
      if (student.studentName == "Assa" && str == "Math") {
        student.subject = str;
        student.subjectReaction = (subject: string) => {
          document.write("<h1 style='color:magenta'>Mesiba Beibiza<h1>");
        }
      }
  
  
      if (student.studentName == "Meir" && str == "Physics") {
        student.subject = str;
        student.subjectReaction = (subject: string) => {
          document.write("<img style='width:100px' src='https://upload.wikimedia.org/wikipedia/commons/d/d3/Albert_Einstein_Head.jpg'>");
        }
      }
    }
  }
  
  
  for (let student of studentsArray) {
  
    document.write(`
          <div>
          <h1>${student.studentName}</h1>
          <h3>${student.subject}</h3>
          </div>
  `);
    student.subjectReaction(student.subject);
  }
  
  
  console.log(studentsArray);