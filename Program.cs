class Program {
    public static void Main() {
        List<int> sortedItems = Sorting.InsertionSort([3, 1, 2, 5, 4]);
        foreach (int item in sortedItems) {
            Console.WriteLine(item);
        }
    }
}