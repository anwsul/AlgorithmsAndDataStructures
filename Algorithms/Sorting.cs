class Sorting {
    public static List<int> InsertionSort(List<int> array) {
        for (int i = 1; i < array.Count; i++) {
            int current = array[i];
            int j = i - 1;
            while (j >= 0 && array[j] > current) {
                array[j + 1] = array[j];
                j--;
            }
            array[j + 1] = current;
        }
        return array;
    }

    public static void SelectionSort(int[] array) {
        for (int i = 0; i < array.Length - 1; i++) {
            int smallestIndex = i;
            for (int j = i + 1; j < array.Length; j++) {
                if (array[j] < array[smallestIndex]) {
                    smallestIndex = j;
                }
            }
            (array[i], array[smallestIndex]) = (array[smallestIndex], array[i]);
        }
    }
}
