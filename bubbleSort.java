import java.util.*;

public class ex2 {
	  static void bubbleSort(int[] arr) {  
	        int n = arr.length;  
	        int temp = 0;  
	         for(int i=0; i < n; i++){  
	             for(int j=1; j < (n-i); j++){  
	                 if(arr[j-1] > arr[j]){  
	                                   
	                    temp = arr[j-1];  
	                    arr[j-1] = arr[j];  
	                    arr[j] = temp;  
    }                           
   }  
  }  	  
 }  
    

	public static void main(String[] args) {
		
       Scanner input = new Scanner(System.in);		
	          
       int [] num = new int[6];
       
	   System.out.println(" Please enter 6 numbers");
	      for (int i = 0; i <num.length; i++)
	        {
		       num[i] = input.nextInt();
	       }
		       
	      bubbleSort(num); 
	      System.out.println(Arrays.toString(num));
         System.out.println("the Smallest number is: "+num[0]
		   +" and the largest number is: "+num[num.length-1]);
 
 
       System.out.println("Enter a number to search");    
                int n =input.nextInt();
 
       int first  = 0;
       int last   = num.length - 1;
       int  middle = (first + last)/2;

          while( first <= last )
              {
                if ( num[middle] < n )
                first = middle + 1;    
                  else if ( num[middle] == n ) 
              {
                System.out.println(n + " is found");
                   break;
             }
                  else
                last = middle - 1;

                middle = (first + last)/2;
             }
                  if ( first > last )
                System.out.println(n +" not found");
                  
                  
       }
 }
	
	   	   
	
	

	
	


