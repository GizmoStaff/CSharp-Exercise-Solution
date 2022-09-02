/*1. Write a program and ask the user to enter a few numbers separated 
by a hyphen. Work out if the numbers are consecutive. For example, if 
the input is "5-6-7-8-9" or "20-19-18-17-16", display a message: 
"Consecutive"; otherwise, display "Not Consecutive".

System.Console.WriteLine("Enter few numbers separated by hyphen (eg.5-6-7): ");
var input=Console.ReadLine();

if(!String.IsNullOrWhiteSpace(input)){
var inputNumbers=input.Split('-');

if(Convert.ToInt32(inputNumbers[0])>Convert.ToInt32(inputNumbers[inputNumbers.Length-1])){
    System.Console.WriteLine("Not Consecutive");
}
else{
    System.Console.WriteLine("Consecutive");
}

}*/

/*2. Write a program and ask the user to enter a few numbers separated by a hyphen. 
If the user simply presses Enter, without supplying an input, exit immediately; 
otherwise, check to see if there are duplicates. If so, display "Duplicate" on the console. 

System.Console.WriteLine("Enter few numbers separated by hyphen (eg.5-6-7): ");
var input = Console.ReadLine();

if (!String.IsNullOrWhiteSpace(input))
{
    var inputNumbers = input.Split("-");

    var listNo = new List<string>();

    foreach (var no in inputNumbers)
    {

        if (!listNo.Contains(no))
        {
            listNo.Add(no);

        }

        else
        {
            System.Console.WriteLine("Duplicate");
        }

    }


}

*/



/* 3. Write a program and ask the user to enter a time value in the 24-hour 
time format (e.g. 19:00). A valid time should be between 00:00 and 23:59. 
If the time is valid, display "Ok"; otherwise, display "Invalid Time". If the 
user doesn't provide any values, consider it as invalid time. 

System.Console.WriteLine("Enter a time value in the 24-hour time format (eg. 19:00): ");
var input=Console.ReadLine();

if(!String.IsNullOrWhiteSpace(input)){
try{
TimeOnly inputTime=TimeOnly.Parse(input);

TimeOnly min=new TimeOnly(00,00);
TimeOnly max=new TimeOnly(23,59);

if(inputTime.IsBetween(min,max)){
    System.Console.WriteLine("Ok");
}
else{
    System.Console.WriteLine("Invalid Time");
}
}catch(Exception ){
    System.Console.WriteLine("Invalid Time");
}

}
else{
    System.Console.WriteLine("Invalid Time");
}

*/

/*4. Write a program and ask the user to enter a few words 
separated by a space. Use the words to create a variable 
name with PascalCase. For example, if the user types: "number 
of students", display "NumberOfStudents". Make sure that the program 
is not dependent on the input. So, if the user types "NUMBER OF STUDENTS", 
the program should still display "NumberOfStudents". 

System.Console.WriteLine("Enter a few words separated by space: ");
var input=Console.ReadLine();


if(!String.IsNullOrWhiteSpace(input)){

var inputWords=input.Trim().Split(" ");

foreach( var w in inputWords){
    
 System.Console.Write(char.ToUpper(w[0])+w.Substring(1).ToLower());
 
    
}


}*/

/*5. Write a program and ask the user to enter an English word. Count 
the number of vowels (a, e, o, u, i) in the word. So, if the user enters 
"inadequate", the program should display 6 on the console.*/


System.Console.WriteLine("Enter an English word: ");
var input=Console.ReadLine();

if(!String.IsNullOrWhiteSpace(input)){

var chInput=input.Trim().ToCharArray();
var count=0;

foreach(var c in chInput){
    if(c=='a'|| c=='e'||c=='o'||c=='u'||c=='i')
    count++;
}

System.Console.WriteLine($"Entered word {input} contains {count} vowels.");

}