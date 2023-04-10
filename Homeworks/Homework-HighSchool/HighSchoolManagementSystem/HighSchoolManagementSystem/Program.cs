using HighSchoolManagementSystem.Entities;
using HighSchoolManagementSystem.Services;

ISchool school = new School("TGGY HighSchool");
ISchoolManagement schoolManagement = new SchoolManagement(school);

IClassroom classroomMath = new Classroom("Math");
IClassroom classroomProgramming = new Classroom("Programming");
IClassroom classroomTurkikshHistory = new Classroom("Turkish History");

IStudent studentGani = new Student("Gani");
IStudent studentAyten = new Student("Ayten");
IStudent studentMirac = new Student("Mirac");
IStudent studentAhmet = new Student("Ahmet");
IStudent studentBurak = new Student("Burak");

ITeacher mathTeacher = new Teacher("Necmeddin");
ITeacher programmingTeacher = new Teacher("Yeşim");
ITeacher turkishLectureTeacher = new Teacher("Handan");

schoolManagement.AddClassroom(classroomMath);
schoolManagement.AddClassroom(classroomProgramming);
schoolManagement.AddClassroom(classroomTurkikshHistory);

schoolManagement.AddTeacher(mathTeacher);
schoolManagement.AddTeacher(programmingTeacher);
schoolManagement.AddTeacher(turkishLectureTeacher);

schoolManagement.AddStudent(studentGani);
schoolManagement.AddStudent(studentAyten);
schoolManagement.AddStudent(studentMirac);
schoolManagement.AddStudent(studentAhmet);
schoolManagement.AddStudent(studentBurak);

IClassroomManagement mathClassroomManagement = new ClassroomManagement(classroomMath);
IClassroomManagement programmingClassroomManagement = new ClassroomManagement(classroomProgramming);
IClassroomManagement turkishHistoryClassManagement = new ClassroomManagement(classroomTurkikshHistory);


Console.WriteLine("All Students in School:");
schoolManagement.GetStudents().ForEach(x => Console.WriteLine($"Student ID: {x.StudentID} & Student Name: {x.StudentName}"));
Console.WriteLine("\n\n*********\n*********\n*********\n\n");

Console.WriteLine("All Classes in School:");
schoolManagement.GetClassrooms().ForEach(x => Console.WriteLine($"Classroom ID: {x.ClassroomID} & Classroom Name: {x.ClassroomName}"));
Console.WriteLine("\n\n*********\n*********\n*********\n\n");

Console.WriteLine("All Teachers in School:");
schoolManagement.GetTeachers().ForEach(x => Console.WriteLine($"Teacher ID: {x.TeacherID} & Teacher Name: {x.TeacherName}"));
Console.WriteLine("\n\n*********\n*********\n*********\n\n");

mathClassroomManagement.AssignStudent(studentGani);
mathClassroomManagement.AssignStudent(studentAyten);
mathClassroomManagement.AssignTeacher(mathTeacher);

programmingClassroomManagement.AssignStudent(studentMirac);
programmingClassroomManagement.AssignStudent(studentAhmet);
programmingClassroomManagement.AssignTeacher(programmingTeacher);

turkishHistoryClassManagement.AssignStudent(studentBurak);
turkishHistoryClassManagement.AssignTeacher(turkishLectureTeacher);

Console.WriteLine("Students in Math Class: ");
classroomMath.Students.ForEach(x => Console.WriteLine($"Student ID: {x.StudentID} & Student Name: {x.StudentName}"));
Console.WriteLine("\n\n*********\n*********\n*********\n\n");

Console.WriteLine("Teacher of Math Class: ");
Console.WriteLine($"Teacher ID: {classroomMath.Teacher.TeacherID} & Teacher Name: {classroomMath.Teacher.TeacherName}");
Console.WriteLine("\n\n*********\n*********\n*********\n\n");

Console.WriteLine("The Student ID No:3 is: ");
Console.WriteLine(schoolManagement.FindStudentByID(3).StudentName);
Console.WriteLine("\n\n*********\n*********\n*********\n\n");

Console.WriteLine("The Teacher ID NO:1 is: ");
Console.WriteLine(schoolManagement.FindTeacherByID(1).TeacherName);
Console.WriteLine("\n\n*********\n*********\n*********\n\n");

Console.WriteLine("Student homework sending:");
studentGani.SendHomework(mathTeacher);
Console.WriteLine("\n\n*********\n*********\n*********\n\n");

schoolManagement.RemoveStudent(studentBurak);
Console.WriteLine("All Students in School After Removing Student5: ");
schoolManagement.GetStudents().ForEach(x => Console.WriteLine($"Student ID: {x.StudentID} & Student Name: {x.StudentName}"));
Console.WriteLine("\n\n*********\n*********\n*********\n\n");

schoolManagement.RemoveClassroom(classroomMath);
Console.WriteLine("All Classes in School After Removing MathCLass:");
schoolManagement.GetClassrooms().ForEach(x => Console.WriteLine($"Classroom ID: {x.ClassroomID} & Classroom Name: {x.ClassroomName}"));
Console.WriteLine("\n\n*********\n*********\n*********\n\n");

schoolManagement.RemoveTeacher(mathTeacher);
Console.WriteLine("All Teachers in School After Removing Math Teacher:");
schoolManagement.GetTeachers().ForEach(x => Console.WriteLine($"Teacher ID: {x.TeacherID} & Teacher Name: {x.TeacherName}"));
Console.WriteLine("\n\n*********\n*********\n*********\n\n");