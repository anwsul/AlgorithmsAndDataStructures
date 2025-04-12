using System.Collections;
class Misc {
    public static int[] AddBinaries(int[] a, int[] b) {
        int[] c = new int[a.Length + 1];
        int carry = 0;
        int i;
        for (i = 0; i < a.Length; i++) {
            int sum = a[i] + b[i] + carry;
            c[i] = sum % 2;
            carry = sum / 2;
        }
        c[i + 1] = carry;
        return c;
    }

    public static void PrintArray(IEnumerable<int> array) {
        foreach (int item in array) {
            Console.WriteLine(item);
        }

    }
}