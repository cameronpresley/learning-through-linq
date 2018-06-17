# Learning Through LINQ - An Exploration of Generics, Extensions, and More!

## Abstract

When learning some of the more advanced concepts of .NET, it can be hard to find real life, practical applications of when you would use these concepts. For example, when would you use Generics? When do Extensions make sense?

In this talk, I'm going to show you how when to use some of these advanced features by implementing our own version of LINQ. Together, we'll build

Intended for developers who are already familiar with Generics, Funcs, Actions, and Extensions, you will learn when to apply these concepts and learn when to refactor.

### Outline

* Introduction
* Overview of LINQ
* * Explanation of why it's a great tool to learn advanced concepts
* * Look at the common operators (example and type signatures)
* * * Select (List<'a> -> Func<'a, 'b> -> List<'b>)
* * * Where (List<'a> -> Func<'a, bool> -> List<'a>)
* * * Any (List<'a> -> Func<'a, bool> -> bool)
* * * All (List<'a> -> Func<'a, bool> -> bool)
* * * FirstOrDefault (List<'a> -> 'a) | (List<'a> -> Func<'a, bool> -> 'a)
* * * First (List<'a> -> 'a) | (List<'a> -> Func<'a, bool> -> 'a)
* * * SingleOrDefault
* * * Single
* * * ForEach (List<'a> -> Action<'a> -> unit)
* Explanation of the Source Code (Driver)
* * Show them the Console Project Driver
* * * Write Select Together
* * * Have the Audience write Where together
* * * Have the Audience write Any together
* * * Have the Audience write All together
* * * Proceed as time allows

### Resources

* [Presentation]()
* [Code Sample]()
* [Insert Tutorial to Generics Here]()