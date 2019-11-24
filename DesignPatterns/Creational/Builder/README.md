# Builder
* When construction gets a little bit too complicated.
* When piecewise object construction is complicated, provide an API for doing it step-by-step (succinctly).

## Motivation
* Some objects are simple and can be created in a single constructor call;
* Other objects require a lot of ceremony to create;
* Having an object with 10 constructor arguments is not productive.

## Summary
* A builder is a separate component for building an object;
* Can either give builder a constructor or return it via a static function;
* To make builder fluent, return this;
* Different facets os an object can be build with different builders working in tandem via a base class.