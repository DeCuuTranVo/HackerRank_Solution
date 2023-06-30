/*
    You must create another test class called StudentProfessorTest with a Main method to do the following:

    Create a new Person and make him say hello
    Create a new Student, set an age, say hello, and display her age on the screen.
    Create a new Teacher, set an age, say hello and start the explanation.

    Question: https://www.exercisescsharp.com/oop/class-person-student-and-teacher
*/

class StudentTeacherTest {
    public static void Main(string[] args) {
        Person person = new Person();
        person.Greet();

        Student student = new Student();
        student.SetAge(21);
        student.Greet();
        student.Study();
        student.ShowAge();

        Teacher teacher = new Teacher();
        teacher.SetAge(21);
        teacher.Greet();
        teacher.Explain();
    }
}

/*
    mcs -out:StudentTeacherTest.exe StudentTeacherTest.cs
    mono StudentTeacherTest.exe
*/


/*
using System;
 
public class StudentAndTeacherTest
{
    public static void Main()
    {
        Person myPerson = new Person();
        myPerson.Greet();
 
        Student myStudent = new Student();
        myStudent.SetAge(21);
        myStudent.Greet();
        myStudent.ShowAge();
        myStudent.Study();
 
        Teacher myTeacher = new Teacher();
        myTeacher.SetAge(30);
        myTeacher.Greet();
        myTeacher.Explain();
    }
}

public class Person
{
    protected int age;
 
    public void Greet()
    {
        Console.WriteLine("Hello!");
    }
 
    public void SetAge(int n)
    {
        age = n;
    }
}
 
public class Student : Person
{
    public void Study() 
    {
        Console.WriteLine("I'm studying");
    }
 
    public void ShowAge()
    {
        Console.WriteLine("My age is {0} years old", age);
    }
}
 
public class Teacher : Person
{
    public void Explain()
    {
        Console.WriteLine("I'm explaining");
    }
}
*/