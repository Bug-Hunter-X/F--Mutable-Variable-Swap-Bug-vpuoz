# F# Mutable Variable Swap Bug

This repository demonstrates a common error in F# when working with mutable variables and functions that modify them.  The bug involves an incorrect implementation of a swap function that doesn't correctly swap the values if you don't return the values. The solution demonstrates the correct approach, emphasizing the importance of returning the modified values.

## Bug
The `swap` function attempts to swap the values of two mutable variables, `x` and `y`.  However, because of the way that F# handles mutable variables, the swap isn't completed correctly without returning the new values. 

## Solution
The `swapCorrect` function shows the corrected implementation. By returning a tuple containing the swapped values, the function correctly updates the variables and returns the swapped values. This is a crucial aspect of managing side effects and ensuring functional correctness when dealing with mutable state in F#.
