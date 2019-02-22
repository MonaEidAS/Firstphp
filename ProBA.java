import java.io.*;
import java.util.Scanner;



public class ProBA {

	public static void main(String[]args) throws FileNotFoundException {


	File text = new File ("B.in");
	Scanner Sc= new Scanner (text);
	int Linenumber=1;
	 Linenumber=Sc.nextInt();





	 for ( int i=1; i<=Linenumber; i++){
	int k = Sc.nextInt();
	int n = Sc.nextInt();
	int m = Sc.nextInt();

	if(k<n & n<m || k>n &n>m){

		System.out.println("Ordered");

	}

	else {
		System.out.println("Unordered");

	}






}

	}

}
