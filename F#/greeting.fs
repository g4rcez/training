module Greeting

type SchoolPerson = 
      Teacher
    | Director
    | Student

let greeting(person: SchoolPerson, name: string) =
  match person with 
  | Teacher -> "Hello teacher, " + name
  | Director -> "Hello Director, " + name  
  | Student -> "Hey bro, " + name  

printfn "%s" (greeting(Student, "Cuzão"))