using Common;

namespace SortingAlgorithms
{
    public static class SortFactory
    {
        public static SortStrategy StrategyGenerator (string sortStrategy)
        {
            switch (sortStrategy)
            {
                case "InsertionSort":
                    return new InsertionSort();
                case "InsertionSortInverse":
                    return new InsertionSortInverse();
                case "BubbleSort":
                    return new BubbleSort();
                case "BubbleSortInverse":
                    return new BubbleSortInverse();
                case "SelectionSort":
                    return new SelectionSort();
                default:
                    return null;
            }
        }
    }
}
