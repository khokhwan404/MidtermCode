using System.Collections.Generic;
using System;

class PersonList {
    private List<Person> personList;

    public PersonList() {
        this.personList = new List<Person>();
    }

    public void AddNewPerson(Person person) {
        this.personList.Add(person);
    }

    public void FetchPersonList() {
        Console.WriteLine("List person");
        Console.WriteLine("***********");

        foreach(Person person in this.personList) {
            if (person is CurrentStudent) {
                Console.WriteLine("Name {0}{1} {2}", person.GetTitleName(), person.GetFirstName(), person.GetLastname);
            } else if (person is Student) {
                Console.WriteLine("Name {0}{1} {2}", person.GetTitleName(), person.GetFirstName(), person.GetLastname);
            } else if (person is Teacher) {
                Console.WriteLine("Name {0}{1} {2}", person.GetTitleName(), person.GetFirstName(), person.GetLastname);
            }
        }
    }
}