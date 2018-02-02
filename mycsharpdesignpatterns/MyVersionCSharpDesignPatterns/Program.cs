using MyVersionCSharpDesignPatterns.Behavioral.Chain_of_Responsability;
using MyVersionCSharpDesignPatterns.Behavioral.Command;
using MyVersionCSharpDesignPatterns.Behavioral.Interpreter;
using MyVersionCSharpDesignPatterns.Behavioral.Iterator;
using MyVersionCSharpDesignPatterns.Behavioral.Mediator;
using MyVersionCSharpDesignPatterns.Behavioral.Memento;
using MyVersionCSharpDesignPatterns.Behavioral.NullObject;
using MyVersionCSharpDesignPatterns.Behavioral.Observer;
using MyVersionCSharpDesignPatterns.Behavioral.State;
using MyVersionCSharpDesignPatterns.Behavioral.Strategy;
using MyVersionCSharpDesignPatterns.Behavioral.Template_Method;
using MyVersionCSharpDesignPatterns.Behavioral.Visitor;
using MyVersionCSharpDesignPatterns.Creational.Builder;
using MyVersionCSharpDesignPatterns.Creational.Factory;
using MyVersionCSharpDesignPatterns.Creational.Prototype;
using MyVersionCSharpDesignPatterns.Creational.Singleton;
using MyVersionCSharpDesignPatterns.Structural.Adapter;
using MyVersionCSharpDesignPatterns.Structural.Bridge;
using MyVersionCSharpDesignPatterns.Structural.Composite;
using MyVersionCSharpDesignPatterns.Structural.Decorator;
using MyVersionCSharpDesignPatterns.Structural.Flyweight;
using MyVersionCSharpDesignPatterns.Structural.Proxy;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyVersionCSharpDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Creational
            #region Builder
            //You are asked to implement the Builder design pattern for rendering simple chunks of code.
            //Sample use of the builder you are asked to create:
            //var cb = new CodeBuilder("Person").AddField("Name", "string").AddField("Age", "int");
            //Console.WriteLine(cb);
            //The expected output of the above code is:
            //public class Person
            //{
            //  public string Name;
            //  public int Age;
            //}
            //Please observe the same placement of curly braces and use two-space indentation.
            Console.WriteLine("Builder:");
            var cb = new CodeBuilder("Person").AddField("Name", "string").AddField("Age", "int");
            Console.WriteLine(cb);
            #endregion Builder

            #region Factory
            //You are given a class called Person.The person has two fields: Id , and Name.
            //Please implement a non-static PersonFactory that has a CreatePerson()  method that takes a person's name.
            //The Id of the person should be set as a 0-based index of the object created.
            //So, the first person the factory makes should have Id = 0, second Id = 1 and so on.
            Console.WriteLine("Factory:");
            var pf = new PersonFactory();
            var p1 = pf.CreatePerson("Rodrigo");
            Console.WriteLine(p1);
            var p2 = pf.CreatePerson("Vedovato");
            Console.WriteLine(p2);
            Console.WriteLine();
            #endregion Factory

            #region Prototype
            //Given the definitions above, you are asked to implement Line.DeepCopy() to perform a deep copy 
            //of the current Line object.
            Console.WriteLine("Prototype");
            var l1 = new Line { Start = new Point { X = 1, Y = 1 }, End = new Point { X = 10, Y = 10 } };
            Console.WriteLine(l1);
            var l2 = l1.DeepCopy();
            l2.Start.X = 5;
            l2.Start.Y = 5;
            Console.WriteLine(l2);
            Console.WriteLine();
            #endregion Prototype

            #region Singleton
            //Since implementing a singleton is easy, you have a different challenge: write a method 
            //called IsSingleton().This method takes a factory method that returns an object and 
            //it's up to you to determine whether or not that object is a singleton instance.
            Console.WriteLine("Singleton:");
            var sing = new object();
            Console.WriteLine(SingletonTester.IsSingleton(() => sing));
            Console.WriteLine(SingletonTester.IsSingleton(() => new object()));
            Console.WriteLine();
            #endregion Singleton
            #endregion Creational

            #region Structural
            #region Adapter
            //Here's a very synthetic example for you to try.
            //You are given an IRectangle  interface and an extension method on it.Try to define a 
            //SquareToRectangleAdapter that adapts the Square to the IRectangle interface.
            Console.WriteLine("Adapter");
            var sq = new Structural.Adapter.Square { Side = 11 };
            var adapter = new SquareToRectangleAdapter(sq);
            Console.WriteLine(adapter.Area());
            Console.WriteLine();
            #endregion Adapter

            #region Bridge
            //You are given an example of an inheritance hierarchy which results in Cartesian - product duplication.
            //Please refactor this hierarchy, giving the base class Shape a constructor that takes an interface 
            //IRenderingStrategy defined as 
            // interface IRenderer
            // {
            //    string WhatToRenderAs { get; }
            // }
            //as well as VectorRenderer and RasterRenderer classes. Each implementer of the IShape  
            //interface should have a constructor that takes an IRenderer such that, subsequently, 
            //each constructed object's ToString() operates correctly, for example,
            //new Triangle(new RasterRenderer()).ToString() // returns "Drawing Triangle as pixels"
            Console.WriteLine("Bridge:");
            var sqb = new Structural.Bridge.Square(new VectorRenderer());
            Console.WriteLine(sqb.ToString());
            var tr = new Triangle(new RasterRenderer());
            Console.WriteLine(tr.ToString());
            Console.WriteLine();
            #endregion Bridge

            #region Composite
            //Consider the code presented below.The Sum() extension method adds up all the values in a list of 
            //IValueContainer elements it gets passed. We can have a single value or a set of values.
            //Complete the implementation of the interfaces so that Sum()  begins to work correctly.
            Console.WriteLine("Composite");
            var singleValue = new SingleValue { Value = 11 };
            var otherValues = new ManyValues();
            otherValues.Add(22);
            otherValues.Add(33);
            var sum = new List<IValueContainer> { singleValue, otherValues }.Sum();
            Console.WriteLine(sum);
            Console.WriteLine();
            #endregion Composite

            #region Decorator
            //The following code scenario shows a Dragon which is both a Bird and a Lizard . 
            //Complete the Dragon 's interface (there's no need to extract IBird  or ILizard ). Take special care 
            //when implementing the Age property!
            Console.WriteLine("Decorator");
            var dragon = new Dragon();
            Console.WriteLine(dragon.Fly());
            Console.WriteLine(dragon.Crawl());
            dragon.Age = 20;
            Console.WriteLine(dragon.Fly());
            Console.WriteLine(dragon.Crawl());
            Console.WriteLine();
            #endregion Decorator

            #region Facade

            #endregion Facade

            #region Flyweight
            //You are given a class called Sentence , which takes a string such as "hello world". 
            //You need to provide an interface such that the indexer returns a WordToken  
            //which can be used to capitalize a particular word in the sentence.
            //Typical use would be something like:
            //  var sentence = new Sentence("hello world");
            //  sentence[1].Capitalize = true;
            //  WriteLine(sentence); // writes "hello WORLD"
            Console.WriteLine("Flyweight");
            var s = new Sentence("alpha beta gamma");
            s[1].Capitalize = true;
            Console.WriteLine(s.ToString());
            Console.WriteLine();
            #endregion Flyweight

            #region Proxy
            //You are given the Person  class and asked to write a ResponsiblePerson proxy that does the following:
            //  Allows person to vote unless they are younger than 18 (in that case, return "too young")
            //  Allows person to drive unless they are younger than 16 (otherwise, "too young")
            //  In case of driving while drink, returns "dead"
            Console.WriteLine("Proxy");
            var p = new Structural.Proxy.Person { Age = 10 };
            var rp = new ResponsiblePerson(p);
            Console.WriteLine(rp.Drive());
            Console.WriteLine(rp.Drink());
            Console.WriteLine(rp.DrinkAndDrive());
            rp.Age = 20;
            Console.WriteLine(rp.Drive());
            Console.WriteLine(rp.Drink());
            Console.WriteLine(rp.DrinkAndDrive());
            Console.WriteLine();
            #endregion Proxy
            #endregion Structural

            #region Behavioral
            #region Chain of Responsability
            //You are given a game scenario with classes Goblin and GoblinKing.Please implement the following rules:
            //  A goblin has base 1 attack / 1 defense(1 / 1), a goblin king is 3 / 3.
            //  When the Goblin King is in play, every other goblin gets +1 Attack.
            //  Goblins get + 1 to Defense for every other Goblin in play(a GoblinKing is a Goblin!).
            //Example:
            //  Suppose you have 3 ordinary goblins in play.Each one is a 1 / 3(1 / 1 + 0 / 2 defense bonus).
            //  A goblin king comes into play.Now every goblin is a 2 / 4(1 / 1 + 0 / 3 defense bonus 
            //from each other +1 / 0 from goblin king)
            //The state of all the goblins has to be consistent as goblins are added and removed from the game.
            //Here is an example of the kind of test that will be run on the system:
            //  [Test]
            //  public void Test()
            //  {
            //      var game = new Game();
            //      var goblin = new Goblin(game);
            //      game.Creatures.Add(goblin);
            //      Assert.That(goblin.Attack, Is.EqualTo(1));
            //      Assert.That(goblin.Defense, Is.EqualTo(1));
            //  }
            Console.WriteLine("Chain of Responsability:");
            var game = new Behavioral.Chain_of_Responsability.Game();
            var goblin = new Goblin(game);
            game.Creatures.Add(goblin);

            Console.WriteLine(goblin.Attack);
            Console.WriteLine(goblin.Defense);

            var goblin2 = new Goblin(game);
            game.Creatures.Add(goblin2);

            Console.WriteLine(goblin.Attack);
            Console.WriteLine(goblin.Defense);

            var goblin3 = new GoblinKing(game);
            game.Creatures.Add(goblin3);

            Console.WriteLine(goblin.Attack);
            Console.WriteLine(goblin.Defense);
            Console.WriteLine();
            #endregion Chain of Responsability

            #region Command
            //Implement the Account.Process()  method to process different account commands. The rules are obvious:
            //Success indicates whether the operation was successful
            //You can only withdraw money if you have enough in your account
            Console.WriteLine("Command:");
            var a = new Behavioral.Command.Account();

            var command = new Command { Amount = 100, TheAction = Command.Action.Deposit };
            a.Process(command);

            Console.WriteLine(a.Balance);
            Console.WriteLine(command.Success);

            command = new Command { Amount = 50, TheAction = Command.Action.Withdraw };
            a.Process(command);

            Console.WriteLine(a.Balance);
            Console.WriteLine(command.Success);

            command = new Command { Amount = 150, TheAction = Command.Action.Withdraw };
            a.Process(command);

            Console.WriteLine(a.Balance);
            Console.WriteLine(command.Success);

            Console.WriteLine();
            #endregion Command

            #region Interpreter
            //You are asked to write an expression processor for simple numeric expressions with the following constraints:
            //  Expressions use integral values(e.g., '13'), single - letter variables defined in Variables, as well as + and - operators only
            //  There is no need to support braces or any other operations
            //  If a variable is not found in Variables(or if we encounter a variable with > 1 letter, e.g.ab), the evaluator returns 0(zero)
            //  In case of any parsing failure, evaluator returns 0
            //Example:
            //  Calculate("1+2+3")  should return 6
            //  Calculate("1+2+xy")  should return 0
            //  Calculate("10-2-x")  when x = 3 is in Variables should return 5
            Console.WriteLine("Interpreter:");
            var ep = new ExpressionProcessor();
            ep.Variables.Add('x', 5);

            Console.WriteLine(ep.Calculate("1"));
            Console.WriteLine(ep.Calculate("1+2"));
            Console.WriteLine(ep.Calculate("1+x"));
            Console.WriteLine(ep.Calculate("1+xy"));
            
            Console.WriteLine();
            #endregion Interpreter

            #region Iterator
            //Given the following definition of a Node<T>, implement preorder traversal that returns a sequence of Ts.
            Console.WriteLine("Iterator:");
            var node = new Node<char>('a',
                new Node<char>('b',
                new Node<char>('c'),
                new Node<char>('d')),
                new Node<char>('e'));
            Console.WriteLine(new string(node.PreOrder.ToArray()));
            Console.WriteLine();
            #endregion Iterator

            #region Mediator
            //Our system has any number of instances of Participant classes. Each Participant has a Value integer, initially zero.
            //A participant can Say()  a particular value, which is broadcast to all other participants.At this point in time, every other participant is obliged to increase their Value by the value being broadcast.
            //Example:
            //    Two participants start with values 0 and 0 respectively
            //    Participant 1 broadcasts the value 3.We now have Participant 1 value = 0, Participant 2 value = 3
            //    Participant 2 broadcasts the value 2.We now have Participant 1 value = 2, Participant 2 value = 3
            Console.WriteLine("Mediator:");
            Mediator mediator = new Mediator();
            var pa1 = new Participant(mediator);
            var pa2 = new Participant(mediator);

            Console.WriteLine(pa1.Value);
            Console.WriteLine(pa2.Value);

            pa1.Say(2);

            Console.WriteLine(pa1.Value);
            Console.WriteLine(pa2.Value);

            pa2.Say(4);

            Console.WriteLine(pa1.Value);
            Console.WriteLine(pa2.Value);
            Console.WriteLine();
            #endregion Mediator

            #region Memento
            //A TokenMachine  is in charge of keeping tokens. Each Token  is a reference type with a single 
            //numerical value. The machine supports adding tokens and, when it does, it returns a memento 
            //representing the state of that system at that given time.
            //You are asked to fill in the gaps and implement the Memento design pattern for this scenario.
            //Pay close attention to the situation where a token is fed in as a reference and its value is 
            //subsequently changed on that reference - you still need to return the correct system snapshot!
            Console.WriteLine("Memento:");
            Console.WriteLine("SingleToken:");
            var tm = new TokenMachine();
            var m = tm.AddToken(123);
            tm.AddToken(456);
            tm.Revert(m);
            Console.WriteLine(tm.Tokens.Count);
            Console.WriteLine(tm.Tokens[0].Value);
            Console.WriteLine("TwoToken:");
            var tmt = new TokenMachine();
            tmt.AddToken(1);
            var mt = tmt.AddToken(2);
            tmt.AddToken(3);
            tmt.Revert(mt);
            Console.WriteLine(tmt.Tokens.Count);
            Console.WriteLine(tmt.Tokens[0].Value);
            Console.WriteLine(tmt.Tokens[1].Value);
            Console.WriteLine("FiddledToken:");
            var tmf = new TokenMachine();
            Console.WriteLine("Made a token with value 111 and kept a reference");
            var token = new Token(111);
            Console.WriteLine("Added this token to the list");
            tmf.AddToken(token);
            var mf = tmf.AddToken(222);
            Console.WriteLine("Changed this token's value to 333 :)");
            token.Value = 333;
            tmf.Revert(mf);
            Console.WriteLine(tmf.Tokens.Count);
            Console.WriteLine(tmf.Tokens[0].Value);
            Console.WriteLine();
            #endregion Memento

            #region NullObject
            //In this example, we have a class Account  that is very tightly coupled to an ILog...it also 
            //breaks SRP by performing all sorts of weird checks in SomeOperation() .
            //Your mission, should you choose to accept it, is to implement a NullLog  class that can be 
            //fed into an Account  and that doesn't throw any exceptions.
            Console.WriteLine("NullObject:");
            Console.WriteLine("SingleCall");
            var ans = new Behavioral.NullObject.Account(new NullLog());
            ans.SomeOperation();
            Console.WriteLine("ManyCalls");
            var anm = new Behavioral.NullObject.Account(new NullLog());
            for (int i = 0; i < 100; ++i)
                anm.SomeOperation();
            Console.WriteLine();
            #endregion NullObject

            #region Observer
            //Imagine a game where one or more rats can attack a player. Each individual rat has an Attack value of 1.
            //However, rats attack as a swarm, so each rat's Attack value is equal to the total number of rats in play.
            //Given that a rat enters play through the constructor and leaves play(dies) via its Dispose() method, please 
            //implement the Game and Rat classes so that, at any point in the game, the Attack value of a rat is always consistent.
            //This exercise has two simple rules:
            //    The Game class cannot have properties or fields.It can only contain events and methods.
            //    The Rat class' Attack field is strictly a field, not a property.
            Console.WriteLine("Observer:");
            var gameO = new Behavioral.Observer.Game();

            var rat = new Rat(gameO);
            Console.WriteLine($"Attack is: {rat.Attack}");

            var rat2 = new Rat(gameO);
            Console.WriteLine($"Attack is: {rat.Attack}");
            Console.WriteLine($"Attack 2 is: {rat2.Attack}");

            using (var rat3 = new Rat(gameO))
            {
                Console.WriteLine($"Attack is: {rat.Attack}");
                Console.WriteLine($"Attack 2 is: {rat2.Attack}");
                Console.WriteLine($"Attack 3 is: {rat3.Attack}");
            }

            Console.WriteLine($"Attack is: {rat.Attack}");
            Console.WriteLine($"Attack 2 is: {rat2.Attack}");
            Console.WriteLine();
            #endregion Observer

            #region State
            //A combination lock is a lock that opens after the right digits have been entered. 
            //A lock is preprogrammed with a combination(e.g., 12345 ) and the user is expected to 
            //enter this combination to unlock the lock.
            //The lock has a Status field that indicates the state of the lock.The rules are:
            //    If the lock has just been locked(or at startup), the status is LOCKED.
            //    If a digit has been entered, that digit is shown on the screen. As the user enters more digits, 
            //they are added to Status.
            //    If the user has entered the correct sequence of digits, the lock status changes to OPEN.
            //    If the user enters an incorrect sequence of digits, the lock status changes to ERROR.
            //Please implement the CombinationLock  class to enable this behavior.Be sure to test both correct 
            //and incorrect inputs.
            Console.WriteLine("State:");
            Console.WriteLine("Success:");
            var cl = new CombinationLock(new[] { 1, 2, 3, 4, 5 });
            Console.WriteLine(cl.Status);
            cl.EnterDigit(1);
            Console.WriteLine(cl.Status);
            cl.EnterDigit(2);
            Console.WriteLine(cl.Status);
            cl.EnterDigit(3);
            Console.WriteLine(cl.Status);
            cl.EnterDigit(4);
            Console.WriteLine(cl.Status);
            cl.EnterDigit(5);
            Console.WriteLine(cl.Status);
            Console.WriteLine("Failure:");
            cl = new CombinationLock(new[] { 1, 2, 3 });
            Console.WriteLine(cl.Status);
            cl.EnterDigit(1);
            Console.WriteLine(cl.Status);
            cl.EnterDigit(2);
            Console.WriteLine(cl.Status);
            cl.EnterDigit(5);
            Console.WriteLine(cl.Status);
            Console.WriteLine();
            #endregion State

            #region Strategy
            //The part b ^ 2 - 4 * a * c is called the discriminant.Suppose we want to provide an API with two 
            //different strategies for calculating the discriminant:
            //    In OrdinaryDiscriminantStrategy, If the discriminant is negative, we return it as-is.
            //        This is OK, since our main API returns Complex  numbers anyway.
            //    In RealDiscriminantStrategy, if the discriminant is negative, the return value is 
            //        NaN (not a number). NaN propagates throughout the calculation, so the equation solver gives two NaN values.
            //Please implement both of these strategies as well as the equation solver itself.With regards to 
            //plus-minus in the formula, please return the + result as the first element and - as the second.
            Console.WriteLine("Strategy:");
            Console.WriteLine("PositiveOrdinaryStrategy:");
            var strategy = new OrdinaryDiscriminantStrategy();
            var solver = new QuadraticEquationSolver(strategy);
            var results = solver.Solve(1, 10, 16);
            Console.WriteLine(results.Item1);
            Console.WriteLine(results.Item2);
            Console.WriteLine("PositiveRealStrategy:");
            var strategypr = new RealDiscriminantStrategy();
            var solverpr = new QuadraticEquationSolver(strategypr);
            var resultspr = solverpr.Solve(1, 10, 16);
            Console.WriteLine(resultspr.Item1);
            Console.WriteLine(resultspr.Item2);
            Console.WriteLine("NegativeOrdinaryStrategy:");
            var strategyno = new OrdinaryDiscriminantStrategy();
            var solverno = new QuadraticEquationSolver(strategyno);
            var resultsno = solverno.Solve(1, 4, 5);
            Console.WriteLine(resultsno.Item1);
            Console.WriteLine(resultsno.Item2);
            Console.WriteLine("NegativeRealStrategy:");
            var strategynr = new RealDiscriminantStrategy();
            var solvernr = new QuadraticEquationSolver(strategynr);
            var resultsnr = solvernr.Solve(1, 4, 5);
            var complexNaN = new System.Numerics.Complex(double.NaN, double.NaN);

            Console.WriteLine(resultsnr.Item1);
            Console.WriteLine(resultsnr.Item2);

            Console.WriteLine(double.IsNaN(resultsnr.Item1.Real));
            Console.WriteLine(double.IsNaN(resultsnr.Item1.Imaginary));
            Console.WriteLine(double.IsNaN(resultsnr.Item2.Real));
            Console.WriteLine(double.IsNaN(resultsnr.Item2.Imaginary));
            Console.WriteLine();
            #endregion Strategy

            #region Template Method
            //Imagine a typical collectible card game which has cards representing creatures.
            //Each creature has two values: Attack and Health.Creatures can fight each other, dealing 
            //their Attack damage, thereby reducing their opponent's health.
            //The class CardGame implements the logic for two creatures fighting one another.
            //However, the exact mechanics of how damage is dealt is different:
            //    TemporaryCardDamage : In some games(e.g., Magic: the Gathering), unless the 
            //creature has been killed, its health returns to the original value at the end of combat.
            //    PermanentCardDamage : In other games(e.g., Hearthstone), health damage persists.
            //You are asked to implement classes TemporaryCardDamageGame and PermanentCardDamageGame that 
            //would allow us to simulate combat between creatures.
            //Some examples:
            //    With temporary damage, creatures 1/2 and 1/3 can never kill one another.With permanent 
            //damage, second creature will win after 2 rounds of combat.
            //    With either temporary or permanent damage, two 2/2 creatures kill one another.
            Console.WriteLine("Template Method:");
            Console.WriteLine("Impasse:");
            var c1 = new Behavioral.Template_Method.Creature(1, 2);
            var c2 = new Behavioral.Template_Method.Creature(1, 2);
            CardGame gamei = new TemporaryCardDamageGame(new[] { c1, c2 });
            Console.WriteLine(gamei.Combat(0, 1));
            Console.WriteLine(gamei.Combat(0, 1));
            Console.WriteLine("TemporaryMurder:");
            var c1t = new Behavioral.Template_Method.Creature(1, 1);
            var c2t = new Behavioral.Template_Method.Creature(2, 2);
            CardGame gamet = new TemporaryCardDamageGame(new[] { c1t, c2t });
            Console.WriteLine(gamet.Combat(0, 1));
            Console.WriteLine("DoubleMurder:");
            var c1d = new Behavioral.Template_Method.Creature(2, 2);
            var c2d = new Behavioral.Template_Method.Creature(2, 2);
            CardGame gamed = new TemporaryCardDamageGame(new[] { c1d, c2d });
            Console.WriteLine(gamed.Combat(0, 1));
            Console.WriteLine("PermanentDamageDeath:");
            var c1p = new Behavioral.Template_Method.Creature(1, 2);
            var c2p = new Behavioral.Template_Method.Creature(1, 3);
            CardGame gamep = new PermanentCardDamage(new[] { c1p, c2p });
            Console.WriteLine(gamep.Combat(0, 1));
            Console.WriteLine(gamep.Combat(0, 1));
            Console.WriteLine();
            #endregion Template Method

            #region Visitor
            //You are asked to implement a double-dispatch visitor called ExpressionPrinter for printing different 
            //mathematical expressions.The range of expressions covers addition and multiplication - please 
            //put round brackets after around addition operations(but not multiplication ones)!Also, please avoid 
            //any blank spaces in output.
            //Example:
            //    Input: AdditionExpression(Literal(2), Literal(3))
            //    Output: (2 + 3)
            Console.WriteLine("Visitor:");
            Console.WriteLine("SimpleAddition");
            var simple = new AdditionExpression(new Value(2), new Value(3));
            var eps = new ExpressionPrinter();
            eps.Accept(simple);
            Console.WriteLine(eps.ToString());
            Console.WriteLine("ProductOfAdditionAndValue");
            var expr = new MultiplicationExpression(
              new AdditionExpression(new Value(2), new Value(3)),
              new Value(4)
              );
            var epp = new ExpressionPrinter();
            epp.Accept(expr);
            Console.WriteLine(epp.ToString());
            Console.WriteLine();
            #endregion Visitor
            #endregion Behavioral
        }
    }
}
