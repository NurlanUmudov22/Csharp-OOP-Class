

// Csharp-OOP-CLASS-PRACTISE







//string name1 = "Emiraslan";
//string surname1 = "Miriyev";
//int age1 = 33;

//string name2 = "Sirac";
//string surname2 = "Memmedov";
//int age2 = 22;

//string name3 = "Elmir";
//string surname3 = "Qafarzade";
//int age3 = 21;


//Console.WriteLine($"{name1}  {surname1} - {age1}");



//var stu1 = new
//{
//    name = "Emiraslan",
//    surname= "Miriyev",
//    age = 33
//};



//var stu2 = new
//{
//    name = "Sirac",
//    surname = "Memmedov",
//    age = 22
//};

//Console.WriteLine(stu1);


//Console.WriteLine(stu1.name + " " + stu1.surname + " " + stu1.age );


//Console.WriteLine(stu2.name + " " + stu2.surname + " " + stu2.age);










using Csharp_OOP_CLASS;
using System.Runtime.CompilerServices;

Student stu1 = new Student();


stu1.name = "Ismayil";
stu1.surname = "Ceferli";
stu1.age = 24;
stu1.address = "Ehmedli";

//Console.WriteLine(stu1.name);
//Console.WriteLine(stu1);
//Console.WriteLine(stu1.surname);


Student stu2 = new();

stu2.name = "Test";
stu2.surname = "Testov";
stu2.age = 77;
stu2.address = "Xetai";
stu2.phone = "1234567890";


//string fullName = stu2.name + " " + stu2.surname;
//Console.WriteLine(fullName);




Student stu3 = new()
{
    name = "Sirac",
    surname = "Memmedov",
    age = 22,
    address = "Masazir"
};


//Console.WriteLine(stu3.phone);






//stu3.ShowText();




//stu3.GetFullName();
//Console.WriteLine(stu3.GetFullName());

//stu2.GetFullName();
//Console.WriteLine(stu2.GetFullName());




//var result = stu2.GetFullDatas();

//Console.WriteLine(result);






//Student[] students = {stu1, stu2, stu3};

////    foreach (var stu in students) 
////{
////    //    Console.WriteLine(stu.name);
////    //    Console.WriteLine(stu.surname);
////    //    Console.WriteLine(stu.age);
////   // //    Console.WriteLine(stu.address);
////   // //    Console.WriteLine(stu.phone);
////   //// Console.WriteLine(stu.name + " " + stu.surname);
////   // Console.WriteLine(stu.GetFullDatas());
//}






//Student[] students = { stu1, stu2, stu3 };
//void ShowAll(Student[] datas)
//{
//    foreach (var stu in datas)
//    {
//        Console.WriteLine(stu.GetFullDatas());
//    }
//}

//ShowAll(students);








//Student[] students = { stu1, stu2, stu3 };

//Student GetByAge(Student[] datas, int age)
//{
//    foreach (var item in datas)
//    {
//        if (item.age == 24)
//        {
//            return item;
//        }
//    }

//    return default;
//}













//Student[] students = { stu1, stu2, stu3 };

//Student GetByAge(Student[] datas, int age)
//{
//    Student foundStudent = new();

//    foreach (var item in datas)
//    {
//        if (item.age == age)
//        {
//            return item;
//        }
//    }

//    return foundStudent;
//}

//var result = GetByAge(students, 24);
//Console.WriteLine(result.GetFullDatas());












//Student[] students = { stu1, stu2, stu3 };

//Student GetByAge(Student[] datas, int age)
//{
//    Student foundStudent = new();

//    foreach (var item in datas)
//    {
//        if (item.age == age)
//        {
//            foundStudent = item;
//            break;
//        }
//    }

//    return foundStudent;
//}

//var result = GetByAge(students, 29);
//Console.WriteLine(result.GetFullDatas());





// ???????????????????????????????????????????____________+++++++++++

//Student[] students = { stu1, stu2, stu3 };

//Student GetByAge(Student[] datas, int age)
//{

//    return Array.Find(datas, m=> m.age == age);
//}

//var result = GetByAge(students, 24);
//Console.WriteLine(result.GetFullDatas());









//Student[] students = { stu1, stu2, stu3 };

//Student GetByAge(Student[] datas, int age)
//{
//    var result = datas.FirstOrDefault(m => m.age == age);
//    return result != null ? result : new Student();
//}

//var result = GetByAge(students, 24);

//Console.WriteLine(result.GetFullDatas());











//Student[] students = { stu1, stu2, stu3 };

//Student GetByAge(Student[] datas, int age)
//{

//    return datas.FirstOrDefault(m=> m.age == age);
//}






//var result = GetByAge(students, 24);


//if (result != null)
//{
//    Console.WriteLine(result.GetFullDatas());
//}

//else
//{
//    Console.WriteLine("Data NotFound");
//}










//Student[] students = { stu1, stu2, stu3 };

//Student GetByAge(Student[] datas, int age) => datas.FirstOrDefault(m => m.age == age);







//var result = GetByAge(students, 24);


//if (result != null)
//{
//    Console.WriteLine(result.GetFullDatas());
//}

//else
//{
//    Console.WriteLine("Data NotFound");
//}











////////////////////////////////////




//Book book = new Book("Leyli ve Mecnun");
////Book book1 = new Book();
////Book book2 = new Book();


//Console.WriteLine(book.name);











//Book book = new Book("Leyli ve Mecnun");
////Book book1 = new Book();
////Book book2 = new Book();


//Console.WriteLine(book.name);






//Book book = new Book("elmir");









