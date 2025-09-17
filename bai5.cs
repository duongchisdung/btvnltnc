using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    public string Id { get; set; }
    public string Name { get; set; }
    public int Semester { get; set; }
    public string CourseName { get; set; }
}

class StudentManager
{
    private List<Student> students = new List<Student>();
    private string[] validCourses = { "Java", ".Net", "C/C++" };

    public void AddStudent()
    {
        Console.Write("Nhap ma sinh vien: ");
        string id = Console.ReadLine();

        Console.Write("Nhap ten sinh vien: ");
        string name = Console.ReadLine();

        Console.Write("Nhap hoc ki: ");
        int semester = int.Parse(Console.ReadLine());

        string course;
        do
        {
            Console.Write("Nhap ten khoa hoc (Java, .Net, C/C++): ");
            course = Console.ReadLine();
        } while (!validCourses.Contains(course));

        students.Add(new Student { Id = id, Name = name, Semester = semester, CourseName = course });
        Console.WriteLine("Them sinh vien thanh cong!");
    }

    public void SearchStudent()
    {
        Console.Write("Nhap ID hoac ten sinh vien can tim: ");
        string keyword = Console.ReadLine();

        var result = students.Where(s =>
            s.Id.Equals(keyword, StringComparison.OrdinalIgnoreCase)
                || s.Name.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0).ToList();


        if (result.Count > 0)
        {
            Console.WriteLine("\nKet qua tim kiem:");
            Display(result);
        }
        else
        {
            Console.WriteLine("Khong tim thay sinh vien nao!");
        }
    }

    public void EditStudent()
    {
        Console.Write("Nhap ID sinh vien can sua: ");
        string id = Console.ReadLine();

        var student = students.FirstOrDefault(s => s.Id.Equals(id, StringComparison.OrdinalIgnoreCase));
        if (student != null)
        {
            Console.Write("Nhap ten moi: ");
            student.Name = Console.ReadLine();

            Console.Write("Nhap hoc ki moi: ");
            student.Semester = int.Parse(Console.ReadLine());

            string course;
            do
            {
                Console.Write("Nhap ten khoa hoc moi (Java, .Net, C/C++): ");
                course = Console.ReadLine();
            } while (!validCourses.Contains(course));

            student.CourseName = course;
            Console.WriteLine("Cap nhat thong tin thanh cong!");
        }
        else
        {
            Console.WriteLine("Khong tim thay sinh vien voi ID nay");
        }
    }

    public void DeleteStudent()
    {
        Console.Write("Nhap ID sinh vien can xoa: ");
        string id = Console.ReadLine();

        var student = students.FirstOrDefault(s => s.Id.Equals(id, StringComparison.OrdinalIgnoreCase));
        if (student != null)
        {
            students.Remove(student);
            Console.WriteLine("Xoa sinh vien thanh cong!");
        }
        else
        {
            Console.WriteLine("Khong tim thay sinh vien voi ID nay!");
        }
    }

    public void Report()
    {
        Console.WriteLine("\nStudent Name | Course | Total of Course");
        var report = students
            .GroupBy(s => new { s.Name, s.CourseName })
            .Select(g => new { g.Key.Name, g.Key.CourseName, Count = g.Count() });

        foreach (var item in report)
        {
            Console.WriteLine($"{item.Name} | {item.CourseName} | {item.Count}");
        }
    }

    public void Display(List<Student> list = null)
    {
        var displayList = list ?? students;
        if (displayList.Count == 0)
        {
            Console.WriteLine("Danh sach sinh vien trong!");
            return;
        }

        Console.WriteLine("\nDanh sach sinh vien:");
        Console.WriteLine("ID\t\tName\t\tSemester\tCourse");
        foreach (var s in displayList)
        {
            Console.WriteLine($"{s.Id}\t{s.Name}\t{s.Semester}\t\t{s.CourseName}");
        }
    }
}

class Program
{
    static void Main()
    {
        StudentManager manager = new StudentManager();
        int choice;

        do
        {
            Console.WriteLine("\n--- MENU ---");
            Console.WriteLine("1. Them sinh vien");
            Console.WriteLine("2. Tim kiem sinh vien");
            Console.WriteLine("3. Sua thong tin sinh vien");
            Console.WriteLine("4. Xoa sinh vien");
            Console.WriteLine("5. Thong ke so lan dang ki");
            Console.WriteLine("6. Hien thi danh sach sinh vien");
            Console.WriteLine("0. Thoat");
            Console.Write("Chon chuc nang: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    manager.AddStudent();
                    break;
                case 2:
                    manager.SearchStudent();
                    break;
                case 3:
                    manager.EditStudent();
                    break;
                case 4:
                    manager.DeleteStudent();
                    break;
                case 5:
                    manager.Report();
                    break;
                case 6:
                    manager.Display();
                    break;
                case 0:
                    Console.WriteLine("Ket thuc chuong trinh.");
                    break;
                default:
                    Console.WriteLine("Lua chon khonng hop le!");
                    break;
            }
        } while (choice != 0);
    }
}

