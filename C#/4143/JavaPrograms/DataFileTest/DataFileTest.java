/* author: Catherine Stringfellow
   This program reads in a file of employee data and prints it
*/

import java.io.*;
import java.util.*;
import javax.swing.*;

public class DataFileTest
{  
   public static void main(String[] args)
   {  
      try
      {  
         //read from a disk file into an array
	 String inFilename= getFilename("Please enter the input file. \n"); 
         BufferedReader in = new BufferedReader(new FileReader(inFilename));
         Employee[] staff = readData(in);           //NOTE: staff is obj ref
         in.close();

         // save all employee records to a file
	 String outFilename= getFilename("Please enter the output file. \n"); 
         PrintWriter out = new PrintWriter(new FileWriter(outFilename));
         writeData(staff, out);
         out.close();
        
      }
      catch(IOException exception)
      {
         System.out.println("Error in reading or writing to files");
      }
   }

    /**
      Reads a list of employees from a buffered reader
      @param in  an input stream
      @returns an array of Employee

   */
   static Employee[] readData(BufferedReader in)
      throws IOException
   {   
      String s;
      Employee e;
     
      //read data into arraylist
      ArrayList <Employee> list = new ArrayList <Employee> ();
      while ((s = in.readLine ()) != null)
      {
         //get name, salary, year from line  
         StringTokenizer t = new StringTokenizer (s);
         String fname= t.nextToken ();
         String lname = t.nextToken();
         String name = fname + " " + lname;
         double salary = Double.parseDouble (t.nextToken());
         int year = Integer.parseInt (t.nextToken());

         //construct an employee and add to list
         e = new Employee(name, salary, year, 1, 1);
         list.add (e);
      }
      
      //construct array and store list in array
      Employee[] staff = new Employee[list.size()];  
      list.toArray (staff);                          
      return staff;
   }

   /**
      Writes all employees in an array to a print writer
      @param e an array of employees
      @param out a print writer
   */
   static void writeData(Employee[] staff, PrintWriter out)
      throws IOException
   {
      // write number of employees
      out.println("The number of employees are: " + staff.length);

      //write out every employee on staff
      for (Employee e: staff)
         e.writeData(out);        //writeData is a method of employee
   }

   /**
        Reads in the name of the input file the user wishes to use
       @param prompt for dialog
       @returns String fileName
   */
   static String getFilename(String prompt)
   {
	String filename;

        do 
        {
           filename = JOptionPane.showInputDialog(prompt);
        }while (filename.length() == 0);

        return filename;
   }

}

