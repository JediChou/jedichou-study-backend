type Person(name:string, age:int) =
    let mutable internalAge = age
    new(name:string) = Person(name, 0)
    
    member this.Name = name
    member this.Age
        with get() = internalAge
        and set(value) = internalAge <- value

    member this.HasABirthday () = internalAge <- internalAge + 1
    member this.IsOfAge targetAge = internalAge >= targetAge

    override this.ToString() = "Name: " + name + "\n" + "Age: " + (string)internalAge

let person1 = Person("Siu", 25)
let person2 = Person("Sarah", 27)

person2.Age <- 15
person1.HasABirthday()

// output
System.Console.WriteLine(person1.ToString())
System.Console.WriteLine(person2.ToString())
System.Console.WriteLine(person2.IsOfAge(18))