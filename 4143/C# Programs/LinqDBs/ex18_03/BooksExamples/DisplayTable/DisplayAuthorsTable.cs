// Fig. 22.20: DisplayAuthorsTable.cs
// Displaying data from a database table in a DataGridView.
using System;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Windows.Forms;

namespace DisplayTable
{
   public partial class DisplayAuthorsTable : Form
   {
      // constructor
      public DisplayAuthorsTable()
      {
         InitializeComponent();
      } // end constructor

      // Entity Framework DBContext
      private BooksExamples.BooksEntities dbcontext = null;

      // fill our authorBindingSource with all rows, ordered by name
      private void RefreshAuthors()
      {
         // Dispose old DBContext, if any
         if ( dbcontext != null )
            dbcontext.Dispose();

         // create new DBContext so we can reorder records based on edits
         dbcontext = new BooksExamples.BooksEntities();

         // use LINQ to order the Authors table contents 
         // by last name, then first name
         dbcontext.Authors
            .OrderBy( entry => entry.LastName )
            .ThenBy( entry => entry.FirstName )
            .Load();

         // specify DataSource for addressBindingSource
         authorBindingSource.DataSource = dbcontext.Authors.Local;
         authorBindingSource.MoveFirst(); // go to first result
         findTextBox.Clear(); // clear the Find TextBox
      } // end method RefreshAuthors

      // load data from database into DataGridView
      private void DisplayAuthorsTable_Load( object sender, EventArgs e )
      {
         RefreshAuthors(); // fill binding with data from database
      } // end method DisplayAuthorsTable_Load

      // click event handler for the Save Button in the 
      // BindingNavigator saves the changes made to the data
      private void authorBindingNavigatorSaveItem_Click(
         object sender, EventArgs e )
      {
         Validate(); // validate the input fields
         authorBindingSource.EndEdit(); // complete current edit, if any

         // try to save changes
         try
         {
            dbcontext.SaveChanges(); // write changes to database file
         } // end try
         catch( DbEntityValidationException )
         {
            MessageBox.Show( "FirstName and LastName must contain values", 
               "Entity Validation Exception" );
         } // end catch
      } // end method authorBindingNavigatorSaveItem_Click

      // use LINQ to create a data source that contains only people
      // with last names that start with the specified text
      private void findButton_Click( object sender, EventArgs e )
      {
         // use LINQ to filter authors with last names that
         // start with findTextBox contents
         var lastNameQuery =
            from address in dbcontext.Authors
            where address.LastName.StartsWith( findTextBox.Text )
            orderby address.LastName, address.FirstName
            select address;

         // display matching contacts
         authorBindingSource.DataSource = lastNameQuery.ToList();
         authorBindingSource.MoveFirst(); // go to first result

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
         RefreshAuthors(); // change back to initial unfiltered data
      } // end method browseButton_Click
   } // end class DisplayAuthorsTable
} // end namespace DisplayTable

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
