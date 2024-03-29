# Kata 6

## Playing with digits

    Some numbers have funny properties. For example:

    89 --> 8¹ + 9² = 89 * 1

    695 --> 6² + 9³ + 5⁴= 1390 = 695 * 2

    46288 --> 4³ + 6⁴+ 2⁵ + 8⁶ + 8⁷ = 2360688 = 46288 * 51

    Given a positive integer n written as abcd... (a, b, c, d... being digits) and a positive integer p

    we want to find a positive integer k, if it exists, such that the sum of the digits of n taken to the successive powers of p is equal to k * n.

    In other words:

    Is there an integer k such as : (a ^ p + b ^ (p+1) + c ^(p+2) + d ^ (p+3) + ...) = n * k

    If it is the case we will return k, if not return -1.

    Note: n and p will always be given as strictly positive integers.

```CSharp
digPow(89, 1) should return 1 since 8¹ + 9² = 89 = 89 * 1
digPow(92, 1) should return -1 since there is no k such as 9¹ + 2² equals 92 * k
digPow(695, 2) should return 2 since 6² + 9³ + 5⁴= 1390 = 695 * 2
digPow(46288, 3) should return 51 since 4³ + 6⁴+ 2⁵ + 8⁶ + 8⁷ = 2360688 = 46288 * 51
```

[Playing with digits](https://www.codewars.com/kata/5552101f47fc5178b1000050)

---------------------------------------------------------------------------------------------

## Array.diff

  Your goal in this kata is to implement a difference function, which subtracts one list from another and returns the result.  

  It should remove all values from list a, which are present in list b keeping their order.  

```csharp
Kata.ArrayDiff(new int[] {1, 2}, new int[] {1}) => new int[] {2}
```

  If a value is present in b, all of its occurrences must be removed from the other:  

```csharp
Kata.ArrayDiff(new int[] {1, 2, 2, 2, 3}, new int[] {2}) => new int[] {1, 3}
```

[Array.diff](https://www.codewars.com/kata/523f5d21c841566fde000009)  

---------------------------------------------------------------------------------------------

## Find the unique number

  There is an array with some numbers. All numbers are equal except for one. Try to find it!

```csharp
findUniq([ 1, 1, 1, 2, 1, 1 ]) === 2
findUniq([ 0, 0, 0.55, 0, 0 ]) === 0.55
```

  It’s guaranteed that array contains at least 3 numbers.

  The tests contain some very huge arrays, so think about performance.

[Find the unique number](https://www.codewars.com/kata/585d7d5adb20cf33cb000235)  

---------------------------------------------------------------------------------------------
