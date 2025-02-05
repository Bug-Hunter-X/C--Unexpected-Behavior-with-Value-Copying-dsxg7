# C# Value Copying and Unexpected Behavior

This repository demonstrates a common, yet subtle, error in C# related to value copying and object references. The example showcases how modifications to an object's property after it's been copied by value might not reflect in the copy.

## Scenario

The `MyClass` class has an integer property `MyProperty`. We create two instances: `obj1` and `obj2`. `obj2` is created by passing the value of `obj1.MyProperty`. Then we modify `obj1.MyProperty`, and expect `obj2.MyProperty` to be updated. However, it remains unchanged because a value copy was made during the object creation.

## Solution

The solution demonstrates the use of passing by reference, or the use of a mutable class with appropriate properties that would cause a chain reaction in the update.  For simple values, ensure that the assignment uses the updated value directly to avoid such issues.