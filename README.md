# Abstract Factory Pattern

### Type
Creational design pattern

### What problem it solves?
In an application where instance creation of classes of same family is required and it has to be done without mixing that code in business logic then in such case Abstract Factory Design Pattern is used.

### How it solves the problem?
+ Defines an abstract factory interface with methods for creating products.
+ Concrete factory implementations override these methods and instantiate the respective product objects.
+ The client interacts only with the abstract factory, remaining decoupled from specific concrete classes, making the system extensible and maintainable.

### Limitations
+ Complexity: It introduces multiple factory classes, increasing complexity.
+ Overhead: If only a few objects need creation, using this pattern might be overkill, as simple factory methods could suffice.

### Diagram
![Abstract_Factory_Method_Diagram](https://github.com/user-attachments/assets/5a78dc8a-6777-4640-b04a-cc117649e605)
