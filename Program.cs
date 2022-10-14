enum MainMenu {
    Registeration = 1,
    AllCurrentStudent,
    AllStudent,
    AllTeacher,
    Logout
}

class Program {

    static PersonList personList;

    static void Main(string[] args) {
        PreparePersonalListWhenProgramIsLoad();
        PrintMenuScreen();
    }
    static void PrintMenuScreen() {
        Console.Clear();

        PrintListMenu();
        InputMenuFromKeyboard();
        PresentMenu();
    }

    static void PrintMainMenuScreen() {
        Console.Clear();

        PrintListMainMenu();
        InputMainMenuFromKeyboard();
    }

    static void PrintListMainMenu() {
        Console.WriteLine("Welcome to Idia Camp 2022");
        Console.WriteLine("***************************************************");
        Console.WriteLine("1. Registration");
        Console.WriteLine("2. Current Student Participants");
        Console.WriteLine("3. Student Participants");
        Console.WriteLine("4. Teacher Participants");
        Console.WriteLine("5. Logout");
        Console.WriteLine("***************************************************");  
    }

    static void PrintListMenu() {
        Console.WriteLine("Welcome to Idia Camp 2022");
        Console.WriteLine("***************************************************");
        Console.WriteLine("1. Registration");
        Console.WriteLine("2. Statistis of Participants");
        Console.WriteLine("3. Login");
        Console.WriteLine("***************************************************");  
    }

    static int InputMenuFromKeyboard() {
        Console.Write("Please Input Menu : ");

        return int.Parse(Console.ReadLine());
    }

    static void InputMainMenuFromKeyboard() {
        Console.Write("Please input Menu : ");
        MainMenu mainMenu = (MainMenu)(int.Parse(Console.ReadLine()));

        PresentMainMenu(mainMenu);
    }

    static void PresentMenu() {
        int presentMenu = InputMenuFromKeyboard();

        if (presentMenu == 1) {
            ShowInputRegistrationScreen();
        } else if (presentMenu == 2) {

        } else if (presentMenu ==3) {
            ShowInputLoginScreen();
        }
    }

    static void PresentMainMenu(MainMenu mainMenu) {
        switch (mainMenu) {
            case MainMenu.Registeration:
                 ShowInputRegistrationScreen();
                 break;
            case MainMenu.AllCurrentStudent:
                 ShowPersons();
                 break;
            case MainMenu.AllStudent:
                 ShowPersons();
                 break;
            case MainMenu.AllTeacher:
                 ShowPersons();
                 break;
            case MainMenu.Logout:
                 PrintMenuScreen();
                 break;
            default:
                 break;
        }
    }

    static void ShowPersons() {
        Console.WriteLine("Show Persons");
        Console.WriteLine("************");

        Program.personList.FetchPersonList();
    }

    static void ShowInputLoginScreen() {
        Console.Clear();
        PrintHeaderLogin();

        InputEmail();
        InputPassword();
        
    }

    static void ShowInputRegistrationScreen() {
        Console.Clear();

        PrintHeaderRegister();

        TypePerson();
        int typePerson = TypePerson();

        if (typePerson == 1){
            InputNewCurrentStudentFromKeyboard();
        } else if (typePerson == 2) {
            InputNewStudentFromKeyboard();
        } else if (typePerson == 3) {
            InputNewTeacherFromKeyboard();
        }
    }

    static void PrintHeaderRegister() {
        Console.WriteLine("      Register     ");
        Console.WriteLine("*******************");
    }

    static void PrintHeaderLogin() {
        Console.WriteLine("        Login      ");
        Console.WriteLine("*******************");
    }


    static int TypePerson() {
        Console.Write("Input 1 for Current Student \n 2 for Student \n 3 for Teacher : ");

        return int.Parse(Console.ReadLine());
    }

    static void InputNewCurrentStudentFromKeyboard() {
        Console.Clear();
        PrintHeaderRegister();

        CurrentStudent currentStudent = new CurrentStudent(InputTitleName(), InputFirstName(), InputLastName(),
        InputStudentID(), InputAge(), InputAllergy(), InputReligion(), InputEmail(), InputPassword());

        Program.personList.AddNewPerson(currentStudent);

        BackToMainMenu();
    }
    static void InputNewStudentFromKeyboard() {
        Console.Clear();
        PrintHeaderRegister();

        Student student = new Student(InputTitleName(), InputFirstName(), InputLastName(),
        InputAge(), InputLevel(), InputAllergy(), InputReligion(), InputSchool());

        Program.personList.AddNewPerson(student);
        
        BackToMainMenu();

    }

    static void InputNewTeacherFromKeyboard() {
        Console.Clear();
        PrintHeaderRegister();

        Teacher teacher = new Teacher(InputTitleName(), InputFirstName(), InputLastName(),
        InputAge(), InputPosition(), InputAllergy(), InputReligion(), InputCarNumber(), InputEmail(), InputPassword());

        Program.personList.AddNewPerson(teacher);
        
        BackToMainMenu();

    }

 
    static void BackToMainMenu() {
        PrintMainMenuScreen();
    }

    static void PreparePersonalListWhenProgramIsLoad() {
        Program.personList = new PersonList();
    }

    static string InputTitleName() {
        Console.Write("Title Name : ");

        return Console.ReadLine();
    }

    static string InputFirstName() {
        Console.Write("First Name : ");

        return Console.ReadLine();
    }

    static string InputLastName() {
        Console.Write("Last Name : ");

        return Console.ReadLine();
    }

    static string InputStudentID() {
        Console.Write("StudentID : ");

        return Console.ReadLine();
    }

    static string InputAge() {
        Console.Write("Age : ");

        return Console.ReadLine();
    }

    static string InputLevel() {
        Console.Write("Level : ");

        return Console.ReadLine();
    }
    static string InputPosition() {
        Console.Write("Position : ");

        return Console.ReadLine();
    }

    static string InputSchool() {
        Console.Write("School : ");

        return Console.ReadLine();
    }

    static string InputAllergy() {
        Console.Write("Allergy : ");

        return Console.ReadLine();
    }

    static string InputReligion() {
        Console.Write("Religion : ");

        return Console.ReadLine();
    }

    static string InputCarNumber() {
        Console.Write("Car Number : ");

        return Console.ReadLine();
    }

    static string InputEmail() {
        Console.Write("Email : ");

        return Console.ReadLine();
    }

    static string InputPassword() {
        Console.Write("Password : ");

        return Console.ReadLine();
    }
}
