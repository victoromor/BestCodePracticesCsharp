/// 15 C sharp Best/secure coding Practices 

/// 1. Class and Method names should be in Pascal Case

public class Student
{
    public Trainee GetDetails()
    {
        
    }
    public double GetFee()
    {
        
    }
}


/// 2. Don't use underscore when naming an identifiers  

/// Correct Way
public DateTime fromDate;
public String firstName;


/// wrong way
public DateTime from_Date;
public String first_Name;




/// 3. Method argument and variables should be in camelCase  

/// Correct Way
public class Student
{
    public void PrintDetails(int traineeId, String fullName)
    {
        int totalAmount = 5000;
        
    }
}


/// wrong Way
public class Student
{
    public void PrintDetails(int TraineeId, String FullName)
    {
        int TotalAmount = 5000;
        
    }
}


/// 4. Do declare member variables and static variables at the top of a class.

public class Student
{
    Public static string traineeType;
    Public string traineeName { get; set; };
    Public int traineeFees { get; set};
    Public Student()
    {
        
    }
}



/// 5. Always declare the variables as close as possible to their use.  

/// right Way
String firstName = "Victor";
Console.WriteLine(firstName);


/// wrong Way
String fName = "Victor";

Console.WriteLine(fName);



/// 6. Always declare the properties as private so as to achieve Encapsulation and ensure data hiding.  

/// Correct way
private int traineeId { get; set; }

/// wrong way
public int traineeId { get; set; }




/// 7. Always separate the methods, different sections of program by one space.  

/// right way
class Trainee
{
    private int traineeId { get; set; }

    public void PrintDetails()
    {
        
    }
}

/// Wrong
class Trainee
{

    private int traineeId { get; set; }



    public void PrintDetails()
    {
        
    }

}




/// 8. Constants should always be declared in UPPER_CASE.  

/// Right 
public const int MIN_AGE = 18;
public const int MAX_AGE = 60;

/// Wrong
public const int Min_Age = 18;
public const int Max_Age = 60;



/// 9.Avoid the use of System data types and prefer using the Predefined data types.

/// Right Way
int traineeId;
string traineeName;
bool isPresent;


/// Wrong Way
Int32 traineeId;
String traineeName;
Boolean isPresent;




/// 10. Always prefix an interface with letter I.

/// Right
public interface ITrainee
{
}
public interface IShape
{
}


/// Wrong
public interface Trainee
{
}
public interface Shape
{
}




/// 11. For better code indentation and readability always align the curly braces vertically.  

/// Right
class Trainee
{
    static void PrintDetails()
    {
    }
}

/// Avoid
class Trainee
{
    static void PrintDetails()
    {
    }
}



/// 12. Do not suffix enum names with Enum.

///  Wrong Way:
Public enum DirectionEnum
{
    
}




/// 13. To declare an empty method that only returns a view in the MVC, we should use the expression body.
/// Wrong
Public ActionResult Login()
{
    return View();
}

/// Right
Public ActionResult Login () => View();




/// 14. To check for null or empty conditions, use the following:

/// Wrong
var traineeName =”testing”;
if (studentName != null && studentName !=””)
{
    
}
/// Right
var traineeName =”testing”;
if (!string.IsNullOrEmpty(studentName))
{
    
}



/// 15. Do object initialization like below:
///Right Way
var test = new Test
{
    Id = 1;
    Name =”value”;
};

/// Wrong Way
Test test = new Test();
test.id = 1;
test.name =”value”;