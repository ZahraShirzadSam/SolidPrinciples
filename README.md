# SOLID Principles
![solid3](https://github.com/user-attachments/assets/c1c2e793-deee-4d67-a1f6-cd5d5c5ec537)

![solid3](https://github.com/user-attachments/assets/bcc9fbc5-3442-4e8b-9e4d-3158572e4683)

![download](https://github.com/ZaraSam/SolidPrinciples/assets/136806163/35934e97-036e-45db-aafb-205835c67364)


SOLID is an acronym for the first five object-oriented design (OOD) principles by Robert C. Martin

These principles establish practices for developing software with considerations for maintaining and extending it as the project grows. Adopting these practices can also help avoid code smells, refactor code, and develop Agile or Adaptive software.
These five principles help us understand the need for certain design patterns and software architecture in general. So I believe that it is a topic that every developer should learn.
"To create understandable, readable, and testable code that many developers can collaboratively work on."
In software development, Object-Oriented Design plays a crucial role when it comes to writing flexible, scalable, maintainable, and reusable code. There are so many benefits of using OOD but every developer should also know the SOLID principle for good object-oriented design in programming. 
The SOLID principle helps in reducing tight coupling. Tight coupling means a group of classes are highly dependent on one another which you should avoid in your code.
Opposite of tight coupling is loose coupling and your code is considered as a good code when it has loosely-coupled classes.
Loosely coupled classes minimize changes in your code, helps in making code more reusable, maintainable, flexible and stable. Now let’s discuss one by one these principles…
Let's look at each principle one by one. Following the SOLID acronym, they are:

- S - Single-responsibility Principle(SRP)
- O - Open-closed Principle(O/CP)
- L - Liskov Substitution Principle(LSP)
- I - Interface Segregation Principle(ISP)
- D - Dependency Inversion Principle(DIP)


## Single-responsibility Principle (SRP) :
* A class should have one and only one reason to change, meaning that a class should have only one job.
This means that if a class is a data container, like a Book class or a Student class, and it has some fields regarding that entity, it should change only when we change the data model.
Second, it makes version control easier. For example, say we have a persistence class that handles database operations, and we see a change in that file in the GitHub commits. By following the SRP, we will know that it is related to storage or database-related stuff.

## Open-closed Principle(O/CP) :
 *  Objects or entities should be open for extension but closed for modification.
So what this principle wants to say is: We should be able to add new functionality without touching the existing code for the class. This is because whenever we modify the existing code, we are taking the risk of creating potential bugs. So we should avoid touching the tested and reliable (mostly) production code if possible.
It is usually done with the help of interfaces and abstract classes.

## Liskov Substitution Principle(LSP)
* Let q(x) be a property provable about objects of x of type T. Then q(y) should be provable for objects y of type S where S is a subtype of T.
This means that every subclass or derived class should be substitutable for their base or parent class.
* The Liskov Substitution Principle states that subclasses should be substitutable for their base classes.
This means that, given that class B is a subclass of class A, we should be able to pass an object of class B to any method that expects an object of class A and the method should not give any weird output in that case.   
Therefore, when a class does not obey this principle, it leads to some nasty bugs that are hard to detect.
Liskov's principle is easy to understand but hard to detect in code. 
“Derived or child classes must be substitutable for their base or parent classes“.

## Interface Segregation Principle(ISP) :
* A client should never be forced to implement an interface that it doesn’t use, or clients shouldn’t be forced to depend on methods they do not use.
This principle is the first principle that applies to Interfaces instead of classes in SOLID and it is similar to the single responsibility principle. It states that “do not force any client to implement an interface which is irrelevant to them“. Here your main goal is to focus on avoiding fat interface and give preference to many small client-specific interfaces. You should prefer many client interfaces rather than one general interface and each interface should have a specific responsibility.

## Dependency Inversion Principle(DIP) :
* It states that the high-level module must not depend on the low-level module, but they should depend on abstractions.
"If the OCP states the goal of OO architecture, the DIP states the primary mechanism".
These two principles are indeed related and we have applied this pattern before while we were discussing the Open-Closed Principle.
We want our classes to be open to extension, so we have reorganized our dependencies to depend on interfaces instead of concrete classes.
The Dependency Inversion Principle (DIP) is a principle in object-oriented design that states that “High-level modules should not depend on low-level modules. Both should depend on abstractions“. Additionally, abstractions should not depend on details. Details should depend on abstractions.
This allows for more flexible and decoupled code, making it easier to change implementations without affecting other parts of the codebase.









         
