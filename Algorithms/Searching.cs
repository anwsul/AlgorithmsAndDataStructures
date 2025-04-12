class Searching {
    public static int? LinearSearch(List<int> array, int target) {
        int i = 0, size = array.Count;
        while (i < size && array[i] != target) {
            i++;
        }
        if (i == size) {
            return null;
        }
        return i;
    }
}