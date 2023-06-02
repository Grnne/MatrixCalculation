namespace MatrixCalculation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] firstArr = new int[10] ;

            for (int i = 0; i < firstArr.Length; i++)
            {
                firstArr[i] = 1;
            }
            
            float[] resultArr = new float[6];
            float sectionLength = (float)firstArr.Length / (float)resultArr.Length;

            resultArr[0] = FirstCellSum(sectionLength, firstArr);
            resultArr[5] = LastCellSum(sectionLength, firstArr);

            for (int i = 1; i < resultArr.Length-1; i++)
            {
                resultArr[i] = MiddleCellSum(i, sectionLength, firstArr);
            }

            foreach (var item in resultArr)
            {
                Console.WriteLine(item);
            }

        }

        public static float FirstCellSum(float sectionLength, int[] firstArr)
        {
            float sum = 0;
            int rIndex = (int)Math.Floor(sectionLength);

                for (int i = 0; i < rIndex; i++)
                {
                    sum += firstArr[i];
                }

            return sum += firstArr[rIndex] * (sectionLength - rIndex);
        }

        public static float LastCellSum(float sectionLength, int[] firstArr)
        {
            float sum = 0;
            int rIndex = (int)Math.Floor(sectionLength);

            for (int i = firstArr.Length-1; i > firstArr.Length - rIndex-1; i--)
            {
                sum += firstArr[i];
            }

            return sum += firstArr[firstArr.Length - rIndex - 1] * (sectionLength - rIndex);
        }

        public static float MiddleCellSum(int index, float sectionLength, int[] firstArr)
        {
            float sum = 0;

            float l = index * sectionLength;
            float r = (index+1) * sectionLength;

            int lIndex = (int)Math.Floor(l);
            int rIndex = (int)Math.Floor(r);

            sum += firstArr[lIndex] * (1 - (l - lIndex)) + firstArr[rIndex]*(r-rIndex);

            if (rIndex - lIndex > 1)
            {
                for (int i = lIndex+1; i < rIndex; i++)
                {
                    sum += firstArr[i];
                }
            }
            
            return sum;
        }

    }



}