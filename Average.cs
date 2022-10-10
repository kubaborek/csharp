namespace SredniaOcen
{
 
    public class Average
    {
        public double AverageCounting(int[] marks, int[] weights, int marksCount)
        {
            int marksSum = 0;
            int weightsSum = 0;

            for (int i = 0; i < marksCount; i++)
            {
                marksSum += marks[i] * weights[i];
                weightsSum += weights[i];
            }
            double result = marksSum / weightsSum;
            return result;
        }
    }
}

