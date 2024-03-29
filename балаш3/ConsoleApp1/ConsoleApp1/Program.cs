using System;

class Program
{
    static int[] A = new int[1001]; // Array length increased to 1001 to match Pascal array index
    static int n;

    static void Sl(int l, int s, int r)
    {
        int[] B = new int[1001]; // Array length increased to 1001 to match Pascal array index
        int i, j, k;

        k = l;
        i = l;
        j = s;

        Array.Copy(A, B, A.Length);

        while (i <= s && j <= r)
        {
            if (A[i] < A[j])
            {
                B[k] = A[i];
                i++;
            }
            else
            {
                B[k] = A[j];
                j++;
            }
            k++;
        }

        if (i > s)
        {
            for (i = j; i <= r; i++)
            {
                B[k] = A[i];
                k++;
            }
        }
        else
        {
            for (j = i; j <= s; j++)
            {
                B[k] = A[j];
                k++;
            }
        }

        Array.Copy(B, A, B.Length);
    }

    static void SortSl(int l, int r)
    {
        int s;

        if (l < r)
        {
            s = (l + r) / 2;
            SortSl(l, s);
            SortSl(s + 1, r);
            Sl(l, s, r);
        }
    }

    static void Main()
    {
        // основная программа
        // ...

        SortSl(1, n);
        // ...

    }
}
