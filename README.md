Point Example
========

Point Example is a project to help support my answer the stack overflow question:

https://stackoverflow.com/questions/46985824/is-it-acceptable-to-return-a-canonical-representation-subclass-from-an-abstract/47009186#47009186

However, it is also an example that shows basic design principles for any standard console application. This example application includes Dependency Injection for .NET Core, Factory Method Pattern, Abstract Factory Pattern, Flyweight Pattern, and SOLID concepts.

## The Answer

I feel that the [Single responsibility principle](https://en.wikipedia.org/wiki/Single_responsibility_principle) in [SOLID](https://en.wikipedia.org/wiki/SOLID_(object-oriented_design)) has been overlooked. The `AbstractPoint` and its concrete implementation `ScreenPoint`, are essentially storing **data**, e.g. `X, Y`, unique to the class group. As well the base class `AbstractPoint` is trying to enforce what seems like the [Factory Method pattern](https://en.wikipedia.org/wiki/Factory_method_pattern) inline (minus an interface being returned). While I think it to be appropriate and necessary to have logical operations on the **data** in the `AbstractPoint` and/or `ScreenPoint` classes; I feel like a separate `ScreenPointFactory` class implementing *Factory Method pattern* to instantiate the `ScreenPoint` is much needed here.
<br /><br />
If you are needing to create thousands of `ScreenPoint` classes, having the extra virtual method calls such as `ToScreenPoint()` and extra object size could have negative performance issues. Considering to use the [Flyweight pattern](https://en.wikipedia.org/wiki/Flyweight_pattern) in this scenario could help load times. For *Flyweight pattern* to be successful, you will need the *Factory Method pattern* to be implemented as the *Flyweight pattern* is used within the *factory*. Since there will be factories, you will need an `IPoint` interface and simply derive `AbstractPoint` off of the interface `IPoint`. `IPoint` will simply hold `X, Y` for now. The remaining point types gain the `IPoint` interface through inheritance of `AbstractPoint`. Since there will be group of related point types, e.g. `ArbitraryPoint`, `ScreenPoint`, they can all be instantiated via an [Abstract Factory](https://en.wikipedia.org/wiki/Abstract_factory_pattern).

[Programming to interfaces, not implementations](https://stackoverflow.com/questions/2697783/what-does-program-to-interfaces-not-implementations-mean) principle will be important here. To pull off the functionality of `ToScreenPoint()` in what I am describing, I would remove `ToScreenPoint()` from the **Point** classes completely and instead, I would create an `ArbitraryTransformation` object configured upon startup. I would use [Dependency Injection](https://en.wikipedia.org/wiki/Dependency_injection) to place the `ArbitraryTransformation` object into the appropriate factory during [IOC](https://en.wikipedia.org/wiki/Inversion_of_control) configuration. Then when the *Abstract Factory* methods are called to create any new variations of your screen points… they are created **with the arbitrary transformation already calculated**, as each independent factory method within the `AbstractFactory` will use the appropriately configured `ArbitraryTransformation` to perform the calculation.

Doing all this will put less stress on your design, and will keep your objects a bit lighter and loosely coupled. I feel you are dealing with complexities here to where you can figure out what I just said above simply with the [GoF](https://en.wikipedia.org/wiki/Design_Patterns) pattern language. <strike>However, if you or anyone would rather have the coded samples, I can come back in and provide a sample solution. Just seems like a whole lot of code to link, if you do not exactly need or want what I am suggesting.</strike>

I went ahead and developed a sample solution on my GitHub called [Point Example](https://github.com/OhRyanOh/PointExample). Let me know what you think.

Also, for every design pattern added here, it will introduce extra layers of complexity to your app, so while that can be a problem in itself, I think it will lend itself to be useful for what you need.

