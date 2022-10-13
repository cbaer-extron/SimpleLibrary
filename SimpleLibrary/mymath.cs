
namespace SimpleLibrary;


public static class MyMath
{

    // Adds two integers and returns the result
    /// <summary>
    /// Adds two integers <paramref name="a"/> and <paramref name="b"/> and returns the result.
    /// </summary>
    /// <returns>
    /// The sum of two integers.
    /// </returns>
    /// <example>
    /// <code>
    /// int c = Math.AddTwoIntegers(4, 5);
    /// if (c > 10)
    /// {
    ///     Console.WriteLine(c);
    /// }
    /// </code>
    /// </example>
    /// <exception cref="System.OverflowException">Thrown when one parameter is max 
    /// and the other is greater than 0.</exception>
    /// See <see cref="MyMath.AddTwoDoubles(double, double)"/> to add doubles.
    /// <seealso cref="MyMath.MultiplyTwoIntegers(int, int)"/>
    /// <param name="a">An integer.</param>
    /// <param name="b">An integer.</param>
    public static int AddTwoIntegers(int a, int b)
    {

        return a + b;   
    }


    /// <summary>Multiplies the two integers.</summary>
    /// <param name="a">a.</param>
    /// <param name="b">The b.</param>
    /// <returns>
    ///   <br />
    /// </returns>
    public static int MultiplyTwoIntegers(int a, int b)
    {

        return a * b;
    }

    /// <summary>Adds the two doubles.</summary>
    /// <param name="a">First number to be added</param>
    /// <param name="b">Second number to be added</param>
    /// <returns>System.Double.</returns>
    public static double AddTwoDoubles(double a, double b)
    {
          return a + b;
    }

}