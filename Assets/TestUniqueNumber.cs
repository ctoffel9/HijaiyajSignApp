using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestUniqueNumber : MonoBehaviour
{
    // List to hold the range of numbers
    private List<int> numbers;
    public int minRange;
    public int maxRange;
    public int numbersToGenerate;
    [SerializeField] GameSceneController GSC;

    // Array to store unique random numbers
    public int[] uniqueRandomNumbers;

    // Start is called before the first frame update
    void Awake()
    {
        // Initialize the list with a specified range
        //int minRange = 0;
        //int maxRange = 29;
        InitializeNumbers(minRange, maxRange);

        // Define how many unique random numbers you want to generate
        //int numbersToGenerate = 6;

        // Initialize the array with the specified length
        uniqueRandomNumbers = new int[numbersToGenerate];

        // Generate unique random numbers and store them in the array
        for (int i = 0; i < numbersToGenerate; i++)
        {
            uniqueRandomNumbers[i] = GetUniqueRandomNumber();
            //Debug.Log(uniqueRandomNumbers[i]);
        }
    }
    void RandomingNumber()
    {
        InitializeNumbers(minRange, maxRange);
        uniqueRandomNumbers = new int[numbersToGenerate];
        for (int i = 0; i < numbersToGenerate; i++)
        {
            uniqueRandomNumbers[i] = GetUniqueRandomNumber();
        }
    }

    // Method to initialize the list with a range of numbers
    void InitializeNumbers(int min, int max)
    {
        numbers = new List<int>();
        for (int i = min; i <= max; i++)
        {
            numbers.Add(i);
        }
    }

    // Method to get a unique random number
    int GetUniqueRandomNumber()
    {
        if (numbers.Count == 0)
        {
            //Debug.LogError("No more unique numbers available.");
            return -1; // Or handle the case appropriately
        }

        int index = Random.Range(0, numbers.Count);
        int uniqueNumber = numbers[index];

        // Remove the selected number from the list
        numbers.RemoveAt(index);

        return uniqueNumber;
    }
}
