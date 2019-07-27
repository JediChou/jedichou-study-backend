using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace cslab.Study201502100948
{
    /// <summary>
    /// Check sort method (simple check or use task to check).
    /// </summary>
    class SortExample
    {
        /// <summary>
        /// Simple check for Bubble Sort.
        /// </summary>
        public static void CheckBubbleSort()
        {
            var sortedList = new List<int> {5, 4, 3, 2, 1};
            Sort.BubbleSort(sortedList);
            foreach (var i in sortedList)
                Console.Write(i + ", ");
        }

        /// <summary>
        /// Simple check for Insert Sort.
        /// </summary>
        public static void CheckInsertSort()
        {
            var sortedList = new List<int> { 5, 4, 3, 2, 1 };
            Sort.InsertSort(sortedList, new CancellationToken());
            foreach (var i in sortedList)
                Console.Write(i + ", ");
        }

        /// <summary>
        /// Simple check for Pivot Sort
        /// </summary>
        public static void CheckPivotSort()
        {
            var sortedList = new List<int> { 5, 4, 3, 2, 1 };
            Sort.PivotSort(sortedList, 0, 4, 4);
            foreach (var i in sortedList)
                Console.Write(i + ", ");
        }

        /// <summary>
        /// Simple Task to check Bubble Sort method
        /// </summary>
        public static void SimpleTaskToCheckInsertSort()
        {
            var sortedList = new List<int> {5, 4, 3, 2, 1};
            var insertList = sortedList.ToList();

            // TODO： can not understand Barries class
            //var taskInsertionSort = new Task(() =>
            //{
            //    sortBarries.SignalAndWait();
            //    using (new SortResults("Insertion Sort"))
            //    {
            //        Sort.InsertSort(insertList);
            //    }
            //});
            //taskInsertionSort.Start();
            //Console.WriteLine(taskInsertionSort);
        }
    }

    /// <summary>
    /// Sorted method library
    /// </summary>
    class Sort
    {
        /// <summary>
        /// Bubble Sort for integer list.
        /// </summary>
        /// <param name="sortedList">Want to sorted list</param>
        public static void BubbleSort(List<int> sortedList)
        {
            int count = sortedList.Count;
            for (int iteration = 0; iteration < count; ++iteration)
                for (int index = 0; index + 1 < count; ++index)
                    if (sortedList[index] > sortedList[index + 1])
                    {
                        int temporary = sortedList[index];
                        sortedList[index] = sortedList[index + 1];
                        sortedList[index + 1] = temporary;
                    }
        }

        /// <summary>
        /// Insert Sort for integer list.
        /// </summary>
        /// <param name="sortedList">Want to sorted list</param>
        /// <param name="token">token for sort</param>
        public static void InsertSort(List<int> sortedList, CancellationToken token)
        {
            int count = sortedList.Count;
            int currentLocation, currentValue, insertionLocation;
            sortedList.Insert(0, 0);

            for (int location = 1; location < count + 1; ++location)
            {
                currentLocation = location;
                insertionLocation = location - 1;
                currentValue = sortedList[currentLocation];

                while (sortedList[insertionLocation] > currentValue)
                {
                    sortedList[currentLocation] = sortedList[insertionLocation];
                    --currentLocation;
                    --insertionLocation;
                }
                sortedList[currentLocation] = currentValue;
            }
            sortedList.Remove(0);
        }

        /// <summary>
        /// Pivot Sort for integer list
        /// </summary>
        /// <param name="integerList">want to sorted list</param>
        /// <param name="start">start location</param>
        /// <param name="end">end location</param>
        /// <param name="pivot"></param>
        public static void PivotSort(List<int> integerList, int start, int end, int pivot)
        {
            if (start < end)
            {
                pivot = integerList[end];
                int location = start;
                int bound = end;

                while (location < bound)
                {
                    if (integerList[location] < pivot)
                    {
                        ++location;
                    }
                    else
                    {
                        integerList[bound] = integerList[location];
                        integerList[location] = integerList[bound - 1];
                        --bound;
                    }
                }

                integerList[bound] = pivot;
                PivotSort(integerList, start, bound - 1, pivot);
                PivotSort(integerList, bound + 1, end, pivot);
            }
        } // end PivotSort

    }
}
