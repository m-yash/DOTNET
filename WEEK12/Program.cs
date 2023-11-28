// See https://aka.ms/new-console-template for more information

namespace Week12;

class Program
{
    static void Main(string[] args)
    {

        List<Student> students = new List<Student>{
        new Student(1,"Yash", "PROG8146", "A", 81),
        new Student(2,"John", "PROG8146", "B", 43),
        new Student(3,"Sam", "PROG8147", "A", 98),
        new Student(4,"Dwayne", "PROG8146", "C", 62),
        new Student(5,"Barack", "PROG8146", "A", 54),
    };

        // Where Score > 70
        List<Student> moreThan70 = students
                .Where(student => student.Score > 70)
                .ToList();
        foreach (var i in moreThan70)
        {
            Console.WriteLine(i);
        }

        // Where Name starts with B
        List<Student> nameStartsWithB = students
                .Where(student => student.Name.StartsWith('B'))
                .ToList();
        foreach (var i in nameStartsWithB)
        {
            Console.WriteLine(i);
        }
        // Where program prog8147
        List<Student> partOfProg8147 = students
                .Where(student => student.Class == "PROG8147")
                .ToList();
        foreach (var i in partOfProg8147)
        {
            Console.WriteLine(i);
        }

        // Select only Student names
        List<string> sNames = students
                .Select(student => student.Name).ToList();
        foreach (var i in sNames)
        {
            Console.WriteLine(i);
        }

        Select - tranform score to grades
        List<string> grades = students.Select(Student => {
            if(Student.Score > 90)
            return "A";
            else if(Student.Score > 70)
            return "B";
            else if(Student.Score > 50)
            return "C";
            else
            return "D";
        });

        // OrderBy names descending
        List<Student> namesDesc = students.OrderByDescending(student => student.Name).ToList();
        foreach (var i in namesDesc)
        {
            Console.WriteLine(i);
        }
        // Give all students names that score more than 80

        List<string> moreThan80Names = students
                .Where(student => student.Score > 80)
                .Select(student => student.Name)
                .ToList();
        foreach (var i in moreThan80Names)
        {
            Console.WriteLine(i);
        }
    }

}

public class Student
{
    public string Name;
    public int ID;
    public string Class;
    public string Section;
    public int Score;

    public Student(int id, string name, string classs, string section, int score)
    {
        ID = id;
        Name = name;
        Class = classs;
        Section = section;
        Score = score;
    }

    public override string ToString()
    {
        return $"{ID}, {Name}, {Class}, {Section}, {Score}";
    }
}