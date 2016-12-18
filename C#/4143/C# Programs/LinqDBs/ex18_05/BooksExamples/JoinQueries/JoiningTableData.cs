// Fig. 22.24: JoiningTableData.cs
// Using LINQ to perform a join and aggregate data across tables.
using System;
using System.Linq;
using System.Windows.Forms;

namespace JoinQueries
{
   public partial class JoiningTableData : Form
   {
      public JoiningTableData()
      {
         InitializeComponent();
      } // end constructor

      private void JoiningTableData_Load( object sender, EventArgs e )
      {
         // Entity Framework DBContext
         BooksExamples.BooksEntities dbcontext =
            new BooksExamples.BooksEntities();

         // get titles and the authors who wrote them
         var titlesAndAuthors =
            from book in dbcontext.Titles
            from author in book.Authors
            orderby book.Title1
            select new { book.Title1, author.FirstName, author.LastName };

         outputTextBox.AppendText( "Titles and Authors:" );

         // display authors and ISBNs in tabular format
         foreach ( var element in titlesAndAuthors )
         {
            outputTextBox.AppendText(
               String.Format( "\r\n\t{0,-50} {1,-10} {2,-10}",
                  element.Title1, element.FirstName, element.LastName ) );
         } // end foreach

         // get titles and the authors who wrote them
         var titlesAndAuthors2 =
            from book in dbcontext.Titles
            from author in book.Authors
            orderby book.Title1, author.LastName, author.FirstName
            select new { book.Title1, author.FirstName, author.LastName };

         outputTextBox.AppendText( "\r\n\r\nAuthors and titles with authors sorted for each title:" );

         // display authors and titles in tabular format
         foreach ( var element in titlesAndAuthors2 )
         {
            outputTextBox.AppendText(
               String.Format( "\r\n\t{0,-50} {1,-10} {2,-10}",
                  element.Title1, element.FirstName, element.LastName ) );
         } // end foreach

         // get titles and authors of each book, grouped by title
         var authorsByTitle =
            from book in dbcontext.Titles
            orderby book.Title1
            select new
            {
               Title = book.Title1,
               Authors =
                  from author in book.Authors
                  orderby author.LastName, author.FirstName
                  select new { Name = author.FirstName + " " + author.LastName }
            };
 
         outputTextBox.AppendText( "\r\n\r\nTitles grouped by author:" );

         // display authors for each title, grouped by title
         foreach ( var book in authorsByTitle )
         {
            // display book title
            outputTextBox.AppendText( "\r\n\t" + book.Title + ":" );

            // display authors for the title
            foreach ( var author in book.Authors )
            {
               outputTextBox.AppendText( "\r\n\t\t" + author.Name );
            } // end inner foreach
         } // end outer foreach

      } // end method JoiningTableData_Load
   } // end class JoiningTableData
} // end namespace JoinQueries


/**************************************************************************
 * (C) Copyright 1992-2014 by Deitel & Associates, Inc. and               *
 * Pearson Education, Inc. All Rights Reserved.                           *
 *                                                                        *
 * DISCLAIMER: The authors and publisher of this book have used their     *
 * best efforts in preparing the book. These efforts include the          *
 * development, research, and testing of the theories and programs        *
 * to determine their effectiveness. The authors and publisher make       *
 * no warranty of any kind, expressed or implied, with regard to these    *
 * programs or to the documentation contained in these books. The authors *
 * and publisher shall not be liable in any event for incidental or       *
 * consequential damages in connection with, or arising out of, the       *
 * furnishing, performance, or use of these programs.                     *
 *************************************************************************/
