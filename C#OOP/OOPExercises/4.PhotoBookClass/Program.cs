// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

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