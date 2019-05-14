using System;

public class BinarySearch {
   /// <summary>
   ///     Performs a Binary Search on a given set
   /// </summary>
   /// <param name="a">string[] array of elements to search through. Can be modified to be generic.</param>
   /// <param name="min">The low-end check (i.e. starts as 0, will change after first iteration)</param>
   /// <param name="max">The high-end check (i.e. starts as a.Length, will change after first iteration)</param>
   /// <param name="val">The value to search for.</param>
   /// <returns>
   ///     true if value found, false if value not found.
   ///     This can be modified to return the index at which
   ///     the value was found.
   /// </returns>
   static bool Search(string[] a, int min, int max, string val)
   {
       if (max < min) return false;
       int mid = (max + min) / 2;
       var check = string.Compare(a[mid], val);
       if (check > 0)
       {
           return search(a, min, mid - 1, val);
       }
       else if (check < 0)
       {
           return search(a, mid + 1, max, val);
       }
       else
       {
           return true;
       }
   }
}
