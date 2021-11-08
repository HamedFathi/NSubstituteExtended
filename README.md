![nsubstitute-100x100](https://user-images.githubusercontent.com/8418700/140823034-8cf6479c-b55d-4b1e-8783-3df9a1338a8e.png)

`NSubstituteExtended` is a library to extend [NSubstitute](https://github.com/nsubstitute/NSubstitute) functionalities.

### Protected support

`Protected` extension method helps you to mock protected methods.

It get a method name as string and related arguments as array of objects.

* string methodName
* params object[] args

```cs
// Sample #1
var sub = Substitute.For<Foo>();
sub.Protected("DoStuff", Arg.Is<int>(x => x < 10)).Returns(x => x.Arg<int>().ToString());

// Sample #2
var sub = Substitute.For<Foo>();
sub.ReallyDoStuff(5);
sub.Received().Protected("DoStuff", 5);
sub.DidNotReceive().Protected("DoStuff", 2);
```

