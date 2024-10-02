namespace LeetCode.LeetCodeSolutions;

public class _2469_Convert_the_temperature
{
    public double[] ConvertTemperature(double celsius)
    {
        double kelvin = celsius + 273.15;

        double fahrenheit = celsius * 1.80 + 32.00;
        
        return new double[] { kelvin, fahrenheit };
    }
}