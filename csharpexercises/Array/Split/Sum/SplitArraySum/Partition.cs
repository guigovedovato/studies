using System;

namespace SplitArraySum
{
    class Partition
    {
        static public bool SplitArray(int[] numbers, out int[] group0, out int[] group1)
        {
            if (numbers == null)
                throw new ArgumentNullException("numbers");
            group0 = group1 = null;

            if (numbers.Length <= 1)
                return false;

            int totalSum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                int n = numbers[i];
                if (n <= 0)
                    throw new ArgumentException("Numbers is not allowed to contain values less than one.");
                totalSum += n;
            }
            if (totalSum % 2 != 0)
                return false;
            int desiredSum = totalSum / 2;

            bool[] groupPerNumber = new bool[numbers.Length];

            if (!AnalyzeCombination(numbers, groupPerNumber, 0, 0, desiredSum))
                return false;

            int groupSize0 = 0;
            for (int i = 0; i < groupPerNumber.Length; i++)
                if (!groupPerNumber[i])
                    groupSize0++;
            group0 = new int[groupSize0];
            group1 = new int[numbers.Length - groupSize0];

            int groupIndex0 = 0;
            int groupIndex1 = 0;
            for (int i = 0; i < numbers.Length; i++)
                if (!groupPerNumber[i])
                    group0[groupIndex0++] = numbers[i];
                else
                    group1[groupIndex1++] = numbers[i];
            return true;
        }

        static private bool AnalyzeCombination(int[] numbers, bool[] groupPerNumber, int position, int runningSum, int desiredSum)
        {
            if (position == numbers.Length)
                return false;

            int currentNumber = numbers[position];
            runningSum += currentNumber;
            if (runningSum < desiredSum)
            {
                groupPerNumber[position] = true;
                if (AnalyzeCombination(numbers, groupPerNumber, position + 1, runningSum, desiredSum))
                    return true;
                runningSum -= currentNumber;
                groupPerNumber[position] = false;
            }
            else if (runningSum == desiredSum)
            {
                groupPerNumber[position] = true;
                return true;
            }
            if (AnalyzeCombination(numbers, groupPerNumber, position + 1, runningSum, desiredSum))
                return true;

            return false;
        }
    
        static public bool SplitArray(int[] numbers)
        {
            if (numbers == null)
                throw new ArgumentNullException("numbers");

            if (numbers.Length <= 1)
                return false;

            int totalSum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                int n = numbers[i];
                if (n <= 0)
                    throw new ArgumentException("Numbers is not allowed to contain values less than one.");
                totalSum += n;
            }
            if (totalSum % 2 != 0)
                return false;
            int desiredSum = totalSum / 2;

            if (!AnalyzeCombination(numbers, 0, 0, desiredSum))
                return false;

            return true;
        }

        static private bool AnalyzeCombination(int[] numbers, int position, int runningSum, int desiredSum)
        {
            if (position == numbers.Length)
                return false;

            int currentNumber = numbers[position];
            runningSum += currentNumber;
            if (runningSum < desiredSum)
            {
                if (AnalyzeCombination(numbers, position + 1, runningSum, desiredSum))
                    return true;
                runningSum -= currentNumber;
            }
            else if (runningSum == desiredSum)
            {
                return true;
            }
            if (AnalyzeCombination(numbers, position + 1, runningSum, desiredSum))
                return true;

            return false;
        }
    }
}
