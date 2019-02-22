//Import Runtime Pakage
import java.lang.Runtime;

public class RuntimeT{

  public static void main(String[] args)
      {

//ّInstantiate a runtime object that associated with the current Java application
  Runtime run = Runtime.getRuntime();

//Display the amount of free memory in the Java Virtual Machine.
 System.out.println("Free Memory: " + run.freeMemory());

//Display the total amount of memory in the Java virtual machine.
 System.out.println("Total Memory : " + run.totalMemory());

//Display the maximum amount of memory that the Java virtual machine will attempt to use.
 System.out.println("Max Memory: " + run.maxMemory());

//Display the number of processors available to the Java virtual machine.
 System.out.println("Available Processors: " + run.availableProcessors());



      try
      {
//create a process and execute Safari.app
          Process Proc =run.exec("open /Applications/Safari.app");
// print a message after opening Safari
          System.out.println("Safari successfully started");
       }

      catch (Exception e)
      {

          e.printStackTrace();
      }


//cause the program to exit
      run.exit(0);

//try to print something
      System.out.println("Program Running Check");

  }
}
