using System;
//using System.IO; // for LoadData()
// See "Learning Quickly When Irrelevant Attributes Abound: A New Linear-Threshold Algorithm"
// (1998), Nick Littlestone

namespace WinnowPredict
{
  class WinnowProgram
  {
    static void Main(string[] args)
    {
      Console.WriteLine("\nBegin Winnow algorithm prediction demo");
      Console.WriteLine("\nGoal is predict political party based on 16 votes");

      Console.WriteLine("\nExample lines of the 435-item raw data file are:\n");
      Console.WriteLine("republican,n,y,n,y,y,y,n,n,n,n,n,y,y,y,n,?");
      Console.WriteLine("democrat,?,y,y,?,y,y,n,n,n,n,y,n,y,y,n,n");
      Console.WriteLine("democrat,n,y,y,n,y,y,n,n,n,n,n,n,y,y,y,y");

      //Console.WriteLine("\nLoading and encoding data into matrix");
      //int[][] data = LoadData("..\\..\\VotingRaw.txt", 435, 17); // 435 lines, 17 columns

      Console.WriteLine("\nLoading hard-coded 100-item subset into memory");
      Console.WriteLine("All missing values ('?') replaced with 'n' (no)");
      Console.WriteLine("Moving political party to last column");
      Console.WriteLine("Encoding 'no' = 0, 'yes' = 1, 'dem' = 0, 'rep' = 1");

      int[][] data = new int[100][];
      data[0] = new int[] { 0, 1, 0, 1, 1, 1, 0, 0, 0, 1, 0, 1, 1, 1, 0, 1, 1 }; // last col is dem = 0, rep = 1
      data[1] = new int[] { 0, 1, 0, 1, 1, 1, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 1 };
      data[2] = new int[] { 0, 1, 1, 0, 1, 1, 0, 0, 0, 0, 1, 0, 1, 1, 0, 0, 0 };
      data[3] = new int[] { 0, 1, 1, 0, 0, 1, 0, 0, 0, 0, 1, 0, 1, 0, 0, 1, 0 };
      data[4] = new int[] { 1, 1, 1, 0, 1, 1, 0, 0, 0, 0, 1, 0, 1, 1, 1, 1, 0 };
      data[5] = new int[] { 0, 1, 1, 0, 1, 1, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 0 };
      data[6] = new int[] { 0, 1, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0 };
      data[7] = new int[] { 0, 1, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 1, 1, 0, 1, 1 };
      data[8] = new int[] { 0, 1, 0, 1, 1, 1, 0, 0, 0, 0, 0, 1, 1, 1, 0, 1, 1 };
      data[9] = new int[] { 1, 1, 1, 0, 0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0 };
      data[10] = new int[] { 0, 1, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 1 };
      data[11] = new int[] { 0, 1, 0, 1, 1, 1, 0, 0, 0, 0, 1, 0, 1, 1, 0, 0, 1 };
      data[12] = new int[] { 0, 1, 1, 0, 0, 0, 1, 1, 1, 0, 0, 0, 1, 0, 0, 0, 0 };
      data[13] = new int[] { 1, 1, 1, 0, 0, 1, 1, 1, 0, 1, 1, 0, 0, 0, 1, 0, 0 };
      data[14] = new int[] { 0, 1, 0, 1, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1 };
      data[15] = new int[] { 0, 1, 0, 1, 1, 1, 0, 0, 0, 1, 0, 1, 1, 0, 0, 0, 1 };
      data[16] = new int[] { 1, 0, 1, 0, 0, 1, 0, 1, 0, 1, 1, 1, 0, 0, 0, 1, 0 };
      data[17] = new int[] { 1, 0, 1, 0, 0, 0, 1, 1, 1, 0, 0, 0, 1, 0, 1, 1, 0 };
      data[18] = new int[] { 0, 1, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 1 };
      data[19] = new int[] { 1, 1, 1, 0, 0, 0, 1, 1, 1, 0, 1, 0, 0, 0, 1, 1, 0 };
      data[20] = new int[] { 1, 1, 1, 0, 0, 0, 1, 1, 0, 0, 1, 0, 0, 0, 1, 1, 0 };
      data[21] = new int[] { 1, 1, 1, 0, 0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 1, 1, 0 };
      data[22] = new int[] { 1, 0, 1, 0, 0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 1, 1, 0 };
      data[23] = new int[] { 1, 1, 1, 0, 0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 1, 1, 0 };
      data[24] = new int[] { 1, 0, 1, 0, 0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0 };
      data[25] = new int[] { 1, 0, 1, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 1, 1, 0 };
      data[26] = new int[] { 1, 0, 1, 0, 0, 0, 1, 1, 1, 0, 1, 0, 0, 0, 1, 1, 0 };
      data[27] = new int[] { 1, 1, 1, 0, 0, 0, 1, 1, 1, 0, 1, 0, 0, 0, 1, 1, 0 };
      data[28] = new int[] { 1, 0, 0, 1, 1, 0, 1, 1, 1, 0, 0, 1, 1, 1, 0, 1, 1 };
      data[29] = new int[] { 1, 1, 1, 0, 0, 0, 1, 1, 1, 0, 1, 0, 0, 0, 1, 1, 0 };
      data[30] = new int[] { 0, 1, 0, 1, 1, 1, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 1 };
      data[31] = new int[] { 1, 1, 1, 0, 0, 0, 1, 1, 1, 0, 1, 0, 0, 0, 1, 0, 0 };
      data[32] = new int[] { 1, 1, 1, 0, 0, 0, 1, 1, 1, 1, 0, 0, 1, 0, 1, 1, 0 };
      data[33] = new int[] { 0, 1, 0, 1, 1, 1, 0, 0, 0, 0, 0, 1, 1, 1, 0, 1, 1 };
      data[34] = new int[] { 1, 1, 1, 0, 0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 1, 1, 0 };
      data[35] = new int[] { 0, 1, 0, 1, 1, 1, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 1 };
      data[36] = new int[] { 1, 0, 0, 1, 1, 1, 0, 0, 0, 1, 0, 1, 0, 1, 0, 1, 1 };
      data[37] = new int[] { 1, 1, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 1, 1, 0, 1, 1 };
      data[38] = new int[] { 0, 1, 0, 1, 1, 1, 0, 0, 0, 1, 0, 1, 1, 1, 0, 0, 1 };
      data[39] = new int[] { 1, 0, 1, 0, 0, 0, 1, 1, 1, 1, 1, 0, 1, 0, 1, 1, 0 };
      data[40] = new int[] { 1, 1, 1, 0, 0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0 };
      data[41] = new int[] { 1, 1, 1, 0, 0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0 };
      data[42] = new int[] { 1, 0, 1, 0, 0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 1, 0 };
      data[43] = new int[] { 1, 0, 1, 0, 0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 1, 1, 0 };
      data[44] = new int[] { 1, 1, 1, 0, 0, 0, 1, 1, 1, 0, 1, 0, 0, 0, 0, 0, 0 };
      data[45] = new int[] { 1, 1, 1, 0, 0, 0, 1, 1, 0, 0, 1, 0, 0, 0, 1, 0, 0 };
      data[46] = new int[] { 1, 1, 1, 0, 0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 1, 0 };
      data[47] = new int[] { 1, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
      data[48] = new int[] { 1, 1, 1, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 0, 1, 0 };
      data[49] = new int[] { 0, 0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 1 };
      data[50] = new int[] { 1, 1, 1, 0, 0, 0, 1, 1, 1, 0, 1, 0, 0, 0, 1, 1, 0 };
      data[51] = new int[] { 0, 1, 0, 1, 1, 1, 0, 0, 0, 0, 0, 1, 1, 1, 0, 1, 1 };
      data[52] = new int[] { 1, 1, 1, 0, 0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0 };
      data[53] = new int[] { 1, 1, 0, 1, 1, 1, 0, 0, 0, 1, 0, 1, 1, 1, 0, 0, 1 };
      data[54] = new int[] { 1, 1, 1, 0, 0, 1, 0, 1, 0, 0, 1, 1, 0, 1, 0, 0, 0 };
      data[55] = new int[] { 0, 1, 0, 1, 1, 1, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 1 };
      data[56] = new int[] { 0, 1, 0, 1, 1, 1, 0, 0, 0, 1, 1, 1, 1, 1, 0, 1, 1 };
      data[57] = new int[] { 0, 1, 0, 1, 1, 1, 0, 0, 0, 1, 0, 1, 1, 1, 0, 1, 1 };
      data[58] = new int[] { 0, 1, 0, 1, 1, 1, 0, 0, 0, 1, 0, 1, 1, 1, 0, 1, 1 };
      data[59] = new int[] { 0, 1, 0, 1, 1, 1, 0, 0, 0, 1, 0, 1, 1, 1, 0, 0, 1 };
      data[60] = new int[] { 1, 1, 1, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 1, 0, 0 };
      data[61] = new int[] { 0, 1, 0, 1, 1, 1, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 1 };
      data[62] = new int[] { 1, 1, 1, 0, 0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0 };
      data[63] = new int[] { 1, 1, 1, 0, 0, 0, 1, 1, 1, 0, 1, 0, 0, 0, 0, 1, 0 };
      data[64] = new int[] { 1, 1, 1, 0, 0, 0, 1, 1, 1, 0, 1, 0, 0, 0, 0, 1, 0 };
      data[65] = new int[] { 1, 1, 0, 1, 1, 1, 1, 0, 0, 0, 0, 1, 1, 1, 0, 1, 1 };
      data[66] = new int[] { 0, 1, 0, 1, 1, 1, 1, 0, 0, 0, 1, 1, 1, 1, 0, 1, 1 };
      data[67] = new int[] { 0, 1, 0, 1, 1, 1, 0, 0, 0, 1, 0, 1, 1, 1, 0, 0, 1 };
      data[68] = new int[] { 1, 0, 1, 0, 0, 0, 1, 1, 1, 0, 0, 0, 1, 0, 1, 1, 0 };
      data[69] = new int[] { 1, 1, 1, 0, 0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 1, 1, 0 };
      data[70] = new int[] { 1, 0, 1, 0, 0, 0, 1, 1, 1, 0, 0, 0, 1, 0, 1, 0, 0 };
      data[71] = new int[] { 1, 1, 1, 1, 0, 0, 1, 1, 1, 1, 1, 0, 0, 1, 0, 1, 1 };
      data[72] = new int[] { 1, 1, 1, 0, 0, 0, 1, 1, 1, 0, 1, 0, 0, 0, 1, 0, 0 };
      data[73] = new int[] { 1, 0, 1, 1, 1, 0, 1, 0, 1, 1, 0, 0, 1, 1, 0, 1, 1 };
      data[74] = new int[] { 1, 0, 1, 0, 0, 1, 1, 1, 1, 1, 1, 0, 0, 1, 1, 1, 0 };
      data[75] = new int[] { 0, 1, 1, 1, 1, 1, 0, 0, 0, 1, 1, 0, 1, 1, 0, 0, 0 };
      data[76] = new int[] { 0, 1, 1, 0, 1, 1, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0 };
      data[77] = new int[] { 0, 1, 1, 1, 1, 1, 0, 1, 1, 1, 1, 1, 1, 1, 0, 1, 0 };
      data[78] = new int[] { 1, 1, 1, 0, 1, 1, 0, 0, 0, 1, 1, 0, 1, 1, 0, 1, 0 };
      data[79] = new int[] { 0, 0, 0, 1, 1, 0, 0, 0, 0, 1, 0, 1, 1, 1, 0, 0, 1 };
      data[80] = new int[] { 1, 0, 1, 0, 0, 1, 1, 1, 1, 1, 0, 1, 0, 1, 0, 0, 0 };
      data[81] = new int[] { 1, 0, 1, 0, 0, 0, 1, 1, 0, 1, 1, 1, 0, 1, 0, 1, 0 };
      data[82] = new int[] { 0, 0, 0, 1, 1, 1, 0, 0, 0, 1, 0, 1, 1, 1, 0, 1, 1 };
      data[83] = new int[] { 0, 0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 1 };
      data[84] = new int[] { 0, 0, 0, 1, 1, 1, 0, 0, 0, 1, 0, 1, 1, 1, 0, 0, 1 };
      data[85] = new int[] { 0, 0, 1, 0, 1, 1, 0, 0, 0, 1, 1, 1, 1, 1, 0, 1, 0 };
      data[86] = new int[] { 0, 0, 0, 1, 1, 1, 0, 0, 0, 1, 0, 1, 1, 1, 0, 0, 1 };
      data[87] = new int[] { 0, 0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 1 };
      data[88] = new int[] { 0, 1, 1, 0, 1, 1, 1, 0, 1, 1, 1, 0, 1, 1, 0, 1, 0 };
      data[89] = new int[] { 0, 0, 0, 1, 1, 1, 0, 0, 0, 1, 0, 0, 1, 1, 0, 0, 1 };
      data[90] = new int[] { 1, 0, 1, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 1, 1, 0 };
      data[91] = new int[] { 1, 0, 1, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 1, 1, 0 };
      data[92] = new int[] { 1, 1, 1, 0, 0, 0, 1, 1, 0, 1, 1, 0, 0, 0, 1, 1, 0 };
      data[93] = new int[] { 1, 0, 1, 0, 0, 0, 1, 0, 1, 1, 1, 0, 0, 0, 1, 1, 0 };
      data[94] = new int[] { 1, 0, 1, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0 };
      data[95] = new int[] { 1, 0, 1, 0, 1, 1, 0, 0, 0, 0, 1, 0, 0, 0, 1, 1, 0 };
      data[96] = new int[] { 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 1, 1, 1, 1, 0, 1, 0 };
      data[97] = new int[] { 1, 0, 0, 0, 1, 1, 1, 0, 0, 1, 1, 0, 0, 1, 0, 1, 0 };
      data[98] = new int[] { 1, 1, 1, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 1, 0 };
      data[99] = new int[] { 0, 0, 0, 1, 1, 1, 0, 0, 0, 1, 0, 1, 1, 1, 0, 0, 1 };

      Console.WriteLine("\nFirst few lines of all data are: \n");
      ShowMatrix(data, 4, true);

      Console.WriteLine("\nSplitting data into 80% train" + " and 20% test matrices");
      int[][] trainData = null;
      int[][] testData = null;
      MakeTrainTest(data, 0, out trainData, out testData);

      Console.WriteLine("\nEncoding 'n' and '?' = 0, 'y' = 1, 'democrat' = 0, 'republican' = 1");
      Console.WriteLine("Moving political party to last column");
      Console.WriteLine("\nFirst few rows of training data are:\n");
      ShowMatrix(trainData, 3, true);

      Console.WriteLine("\nBegin training using Winnow algorithm");
      int numInput = 16;
      Winnow w = new Winnow(numInput, 0); // rndSeed = 0
      double[] weights = w.Train(trainData);
      Console.WriteLine("Training complete");

      Console.WriteLine("\nFinal model weights are:");
      ShowVector(weights, 4, 8, true);

      double trainAcc = w.Accuarcy(trainData);
      double testAcc = w.Accuarcy(testData);

      Console.WriteLine("\nPrediction accuracy on training data = " + trainAcc.ToString("F4"));
      Console.WriteLine("Prediction accuracy on test data = " + testAcc.ToString("F4"));

      Console.WriteLine("\nPredicting party of Representative with all 'yes' votes");
      int[] unknown = new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
      int predicted = w.ComputeOutput(unknown);
      if (predicted == 0)
        Console.WriteLine("Prediction is 'democrat'");
      else
        Console.WriteLine("Prediction is 'republican'");

      Console.WriteLine("\nEnd Winnow demo\n");
      Console.ReadLine();

    } // Main

    static void MakeTrainTest(int[][] data, int seed, out int[][] trainData, out int[][] testData)
    {
      Random rnd = new Random(seed);
      int totRows = data.Length; // compute number of rows in each result
      int numTrainRows = (int)(totRows * 0.80);
      int numTestRows = totRows - numTrainRows;
      trainData = new int[numTrainRows][];
      testData = new int[numTestRows][];

      int[][] copy = new int[data.Length][]; // make a copy of data
      for (int i = 0; i < copy.Length; ++i)  // by reference to save space
        copy[i] = data[i];
      for (int i = 0; i < copy.Length; ++i) // scramble row order of copy
      {
        int r = rnd.Next(i, copy.Length);
        int[] tmp = copy[r];
        copy[r] = copy[i];
        copy[i] = tmp;
      }
      for (int i = 0; i < numTrainRows; ++i) // create training
        trainData[i] = copy[i];

      for (int i = 0; i < numTestRows; ++i) // create test
        testData[i] = copy[i + numTrainRows];
    } // MakeTrainTest

    static void ShowVector(double[] vector, int decimals, int valsPerRow, bool newLine)
    {
      for (int i = 0; i < vector.Length; ++i)
      {
        if (i % valsPerRow == 0) Console.WriteLine("");
        Console.Write(vector[i].ToString("F" + decimals).PadLeft(decimals + 4) + " ");
      }
      if (newLine == true) Console.WriteLine("");
    }

    static void ShowMatrix(int[][] matrix, int numRows, bool indices)
    {
      for (int i = 0; i < numRows; ++i)
      {
        if (indices == true)
          Console.Write("[" + i.ToString().PadLeft(2) + "]   ");
        for (int j = 0; j < matrix[i].Length; ++j)
        {
          Console.Write(matrix[i][j] + " ");
        }
        Console.WriteLine("");
      }
      int lastIndex = matrix.Length - 1;
      if (indices == true)
        Console.Write("[" + lastIndex.ToString().PadLeft(2) + "]   ");
      for (int j = 0; j < matrix[lastIndex].Length; ++j)
        Console.Write(matrix[lastIndex][j] + " ");
      Console.WriteLine("\n");
    }

    //static int[][] LoadData(string votingFile, int numRows, int numCols)
    //{
    //  // republican,n,y,n,y,y,y,n,n,n,n,n,y,y,y,n,?
    //  // democrat,?,y,y,?,y,y,n,n,n,n,y,n,y,y,n,n
    //  // etc.

    //  int[][] result = new int[numRows][];

    //  FileStream ifs = new FileStream(votingFile, FileMode.Open);
    //  StreamReader sr = new StreamReader(ifs);
    //  string line = "";
    //  string[] tokens = null;

    //  int i = 0;
    //  while ((line = sr.ReadLine()) != null)
    //  {
    //    result[i] = new int[numCols]; // data file has 17 cols
    //    tokens = line.Split(',');

    //    if (tokens[0] == "democrat") // put y-value in last col of matrix
    //      result[i][numCols-1] = 0;
    //    else if (tokens[0] == "republican")
    //      result[i][numCols-1] = 1;

    //    for (int j = 1; j < 17; ++j) // walk across tokens[]
    //    {
    //      if (tokens[j] == "n" || tokens[j] == "?") 
    //        result[i][j - 1] = 0; // set missing to 'n'
    //      else if (tokens[j] == "y")
    //        result[i][j - 1] = 1;
    //    }
    //    ++i;
    //  }

    //  sr.Close(); ifs.Close();
    //  return result; ;
    //} // LoadData

  } // Program

  public class Winnow
  {
    private int numInput;
    private double[] weights; 
    private double threshold; // to determine Y = 0 or 1
    private double alpha; // increase/decrase factor
    private static Random rnd;

    public Winnow(int numInput, int rndSeed)
    {
      this.numInput = numInput;
      this.weights = new double[numInput];
      for (int i = 0; i < weights.Length; ++i)
        weights[i] = numInput / 2.0;
      this.threshold = 1.0 * numInput;
      this.alpha = 2.0;
      rnd = new Random(rndSeed);
    }

    public int ComputeOutput(int[] xValues)
    {
      double sum = 0.0;
      for (int i = 0; i < numInput; ++i)
        sum += weights[i] * xValues[i];
      if (sum > this.threshold)
        return 1;
      else
        return 0;
    }

    public double[] Train(int[][] trainData)
    {
      int[] xValues = new int[numInput];
      int target;
      int computed;
      Shuffle(trainData);
      for (int i = 0; i < trainData.Length; ++i)
      {
        Array.Copy(trainData[i], xValues, numInput); // get the inputs
        target = trainData[i][numInput]; // last value is target
        computed = ComputeOutput(xValues);

        if (computed == 1 && target == 0) // need to decrease weights
        {
          for (int j = 0; j < numInput; ++j)
          {
            if (xValues[j] == 0) continue; // no change when xi = 0
            weights[j] = weights[j] / alpha; // demotion
          }
        }
        else if (computed == 0 && target == 1) // need to increase weights
        {
          for (int j = 0; j < numInput; ++j)
          {
            if (xValues[j] == 0) continue; // no change when xi = 0
            weights[j] = weights[j] * alpha; // promotion
          }
        }
      } // each training item

      double[] result = new double[numInput]; // = number weights
      Array.Copy(this.weights, result, numInput);
      return result;
    } // Train

    private static void Shuffle(int[][] trainData) // Fisher-Yates shuffle algorithm
    {
      for (int i = 0; i < trainData.Length; ++i)
      {
        int r = rnd.Next(i, trainData.Length);
        int[] tmp = trainData[r];
        trainData[r] = trainData[i];
        trainData[i] = tmp;
      }
    }

    public double Accuarcy(int[][] trainData)
    {
      int numCorrect = 0;
      int numWrong = 0;

      int[] xValues = new int[numInput];
      int target;
      int computed;

      for (int i = 0; i < trainData.Length; ++i)
      {
        Array.Copy(trainData[i], xValues, numInput); // get the inputs
        target = trainData[i][numInput]; // last value is target
        computed = ComputeOutput(xValues);

        if (computed == target)
          ++numCorrect;
        else
          ++numWrong;
      }
      return (numCorrect * 1.0) / (numCorrect + numWrong);
    }
  } // Winnow
} // ns
