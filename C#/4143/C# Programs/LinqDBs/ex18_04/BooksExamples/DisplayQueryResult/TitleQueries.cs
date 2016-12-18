// Fig. 22.22: TitleQueries.cs
// Displaying the result of a user-selected query in a DataGridView.
using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace DisplayQueryResult
{
   public partial class TitleQueries : Form
   {
      public TitleQueries()
      {
         InitializeComponent();
      } // end constructor

      // Entity Framework DBContext
      private BooksExamples.BooksEntities dbcontext = null;

      // load data from database into DataGridView
      private void TitleQueries_Load( object sender, EventArgs e )
      {
        RefreshTitles(); // load Titles table into memory

         // set the ComboBox to show the default query that
         // selects all books from the Titles table
         queriesComboBox.SelectedIndex = 0;
      } // end method TitleQueries_Load

      // loads data into titleBindingSource based on user-selected query
      private void queriesComboBox_SelectedIndexChanged(
         object sender, EventArgs e )
      {
         // set the data displayed according to what is selected
         switch ( queriesComboBox.SelectedIndex )
         {
            case 0: // all titles
               // use LINQ to order the books by title
               titleBindingSource.DataSource =
                  dbcontext.Titles.Local.OrderBy( book => book.Title1 );
               break;
            case 1: // titles with 2014 copyright
               // use LINQ to get titles with 2014
               // copyright and sort them by title
               titleBindingSource.DataSource =
                  dbcontext.Titles.Local
                     .Where( book => book.Copyright == "2014" )
                     .OrderBy( book => book.Title1 );
               break;
            case 2: // titles ending with "How to Program"
               // use LINQ to get titles ending with
               // "How to Program" and sort them by title
               titleBindingSource.DataSource =
                  dbcontext.Titles.Local
                     .Where( book => 
                        book.Title1.EndsWith( "How to Program" ) )
                     .OrderBy( book => book.Title1 );
               break;
         } // end switch

         titleBindingSource.MoveFirst(); // move to first entry
      } // end method queriesComboBox_SelectedIndexChanged

      // use LINQ to create a data source that contains only titles
      // containing the specified text
      private void findButton_Click( object sender, EventArgs e )
      {
         // use LINQ to filter authors with last names that
         // start with findTextBox contents
         var titlesQuery =
            from book in dbcontext.Titles
            where book.Title1.Contains( findTextBox.Text )
            orderby book.Title1
            select book;

         // display matching contacts
         titleBindingSource.DataSource = titlesQuery.ToList();
         titleBindingSource.MoveFirst(); // go to first result

         // don't allow add/delete when contacts are filtered
         bindingNavigatorAddNewItem.Enabled = false;
         bindingNavigatorDeleteItem.Enabled = false;
      } // end method findButton_Click

      // reload addressBindingSource with all rows
      private void browseAllButton_Click( object sender, EventArgs e )
      {
         // allow add/delete when contacts are not filtered
         bindingNavigatorAddNewItem.Enabled = true;
         bindingNavigatorDeleteItem.Enabled = true;
         RefreshTitles(); // change back to initial unfiltered data
      } // end method browseButton_Click

      // fill our titleBindingSource with all rows, ordered by title
      private void RefreshTitles()
      {
         // Dispose old DBContext, if any
         if ( dbcontext != null )
            dbcontext.Dispose();

         // create new DBContext so we can reorder records based on edits
         dbcontext = new BooksExamples.BooksEntities();

         // use LINQ to order the Titles table contents by title
         dbcontext.Titles
            .OrderBy( book => book.Title1 )
            .Load();

         // specify DataSource for addressBindingSource
         titleBindingSource.DataSource = dbcontext.Titles.Local;
         titleBindingSource.MoveFirst(); // go to first result
         findTextBox.Clear(); // clear the Find TextBox
      } // end method RefreshTitles

   } // end class TitleQueries
} // end namespace DisplayQueryResult

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
