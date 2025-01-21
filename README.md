# Uninitialized Property Access in C#

This repository demonstrates a common yet easily overlooked error in C#: accessing a property that hasn't been explicitly initialized. While value types (like `int`, `float`, etc.) are automatically initialized to their default values, reference types (classes, strings) are not. Accessing an uninitialized reference type property can lead to a `NullReferenceException`.

The example shows a simple class with a property (`MyProperty`). The `MyMethod` attempts to use the property without first assigning a value.  While this particular example uses an integer which will not throw an exception, it highlights the risk.  Consider what would happen if `MyProperty` were instead a string or a custom class.

The solution demonstrates how to initialize the property appropriately, thus avoiding the potential exception.
