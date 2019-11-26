# Factory
* Factory Method and Abstract Factory.
* A component responsible solely for the wholesale (not piecewise) creation of objects:
   * A separate function (Factory Method);
   * That may exist in a separate class (Factory)
   * Can create hierarchy os factories with Abstract Factory.

## Motivation
* Object creation logic becomes too convoluted;
* Constructor is not descriptive:
   * Name mandated by name of containing type;
   * Cannot overload with same sets of arguments with different names;
   * Can turn into 'optional parameter hell'.

## Summary
* A factory method is a static method that creates objects;
* A factory can take care of objects creation;
* A factory can be external or reside inside the object as an inner class;
* Hierarchies of factories can be used to create related objects.