package linearsearch;

import java.util.Scanner;

public class LinearSearch {
    
    public static int linearSearch(int[] arr, int key) 
    {
        for (int i = 0; i < arr.length; i++) 
        {
            if (arr[i] == key) 
            {
                return i;
            }
        }
        // if element is not found
        return -1;
    }
    public static void main(String[] args) {
        Scanner s = new Scanner(System.in);
        System.out.println("Enter the length of your array: ");
        int length = s.nextInt();
        
        int[] arr = new int[length];
        for (int i=0; i<length; i++)
        {
            System.out.println("Enter the valu of array index " + i + ": ");
            arr[i] = s.nextInt();
        }
        
        System.out.println("Enter the value you want to find: ");
        int key = s.nextInt();
        
        int value = linearSearch(arr, key);
        
        if (value == -1)
        {
            System.out.println("Value not found.");
        }
        else
        {
            System.out.println("Value found at position " + (value+1));
        }
        
    }
    
}
