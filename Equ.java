/*Write a Java program that accepts four integer from the user and prints equal 
if all four are equal, and not equal otherwise.*/

import java.util.Scanner;
public class Equ {
	
   public static void main(String[] args) {
		 
	Scanner cs=new Scanner(System.in);
	
		System.out.print("Enter your first number: ");
			int a=cs.nextInt();
		System.out.print("Enter your Second number: ");
			int b=cs.nextInt();
		System.out.print("Enter your third number: ");
			int c=cs.nextInt();
		System.out.print("Enter your fourth number: ");
			int d=cs.nextInt();
		
		      if(a==b && b==c && c==d)
			     System.out.print("These numbers are equall");
		         else
			        System.out.print("These numbers are not equall!!");
			

	}

}


