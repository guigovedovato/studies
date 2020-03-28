# Prototype
* When it's easier to copy an existing object to fully initialize a new one.
* A partially or fully initialized object that you copy (clone) and make use of.

## Motivation
* Complicated objects aren't designed from scratch:
   * They reiterate existing designs
* An existing design is a Prototype;
* We make a copy the prototype and customize it:
   * Requires 'deep copy' support

## Summary
* To implement a prototype, partially construct an object and store it somewhere;
* Clone the prototype:
   * Implement your own deep copy funcionality;
   * Serialize and deserialize
* Customize the result instance.