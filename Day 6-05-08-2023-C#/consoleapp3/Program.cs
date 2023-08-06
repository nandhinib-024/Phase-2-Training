using consoleapp3;

//StaticDemo.Calc();
//Console.WriteLine("Amout to be paid $" + StaticDemo.Amt); 
/*
StudentGrade studentMarks = new StudentGrade(50, "Nandhini", "cbe", 90, 89, 98);

Console.WriteLine(studentMarks.Name);
Console.WriteLine(studentMarks.Rolno);
Console.WriteLine(studentMarks.Address);
Console.WriteLine(studentMarks.CalculateTotal());
Console.WriteLine(studentMarks.CalculateAverage());
*/
StudentGrade studentMarks = new StudentGrade(50, "Nandhini", "Coimbatore", 90, 89, 98, "KEC", "Erode");
TeachingStaff teachingStaff = new(1,"nandhini","Add","IT","KEC","Erode",10000,45,20,10,5);
NonTeachingStaff nonTeachingStaff = new(1, "nandhini", "add", "KEC", "Erode", 10000, 34, 20, 10, 5);

Console.WriteLine($"STudent name: {studentMarks.Name},Roll No: {studentMarks.Rolno},Average:{studentMarks.CalculateAverage()}");

Console.WriteLine($"Teaching Staff name:{teachingStaff.Name} Department : {teachingStaff.Dept} Basic Salary: {teachingStaff.Basicsalary}");
Console.WriteLine($" Final Slary :{teachingStaff.CalculateSalary()}");

Console.WriteLine($"Non Teaching Staff name:{nonTeachingStaff.Name}");
Console.WriteLine($" Final Slary :{nonTeachingStaff.CalculateSalary()}");
