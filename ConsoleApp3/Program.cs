using ConsoleApp3;
var AllStudents = new List<Student>();
List<string> Courses = new List<string>();
initializeStudents();
Console.WriteLine("welcome to our school, choose which course you want to filter students by. type Stop to close search session");
//showMeAllCourses();
filterStudentsByCourse();


// See https://aka.ms/new-console-template for more information
/*
 Her er et javascript obj - gjør det om til en klasse i C#

var student = {
navn: “Heibert”,
alder: 42,
kurs: Radiobilkjøring
};


Bruk så denne klassen til å lage flere studenter, og lagre disse i et array eller en List.
Gjør så man kan skrive/velge et kurs i konsollen, og så listes studentene på det valgte kurset ut i konsollen.


 
 */
void initializeStudents()
{
    AllStudents.Add(new Student("Iman", 25, "C#"));
    AllStudents.Add(new Student("Ahmed", 25, "F#"));
    AllStudents.Add(new Student("Amal", 25, "C#"));
    AllStudents.Add(new Student("Ilham", 25, "C#"));
    AllStudents.Add(new Student("Terje", 25, "C#"));
}
void showMeAllCourses()
{
    foreach (var student in AllStudents)
    {
       
        if (Courses.Contains(student.Course)==false)
       {
            Courses.Add(student.Course);
           
        } 
       
    }
    Courses.ForEach(c=> Console.WriteLine(c));
}
void filterStudentsByCourse()
{
    var answer = "";
    while (answer != "STOP") { 
    Console.WriteLine("choose which course you want to filter students by. type Stop to close search session");
    showMeAllCourses();
    answer =  Console.ReadLine().ToUpper();
    foreach (var student in AllStudents)
    {
        if (student.Course==answer)
        {
            Console.WriteLine($"{student.Name} studies {answer}"); 
        }
        else if (!Courses.Contains(answer)&& answer!="STOP"){ Console.WriteLine($"this is not a course we have available");
            break;
        }
    }
    }
}











