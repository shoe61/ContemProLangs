﻿// Exercise 18.6: BaseballPlayers.cs
using System;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Windows.Forms;

namespace BaseballPlayers
{
   public partial class BaseballPlayers : Form
   {
      public BaseballPlayers()
      {
         InitializeComponent();
      }

      // Entity Framework DBContext
      private BaseballExercises.BaseballEntities dbcontext = null;

      // fill our playerBindingSource with all rows, ordered by name
      private void RefreshPlayers()
      {
         // Dispose old DBContext, if any
         if ( dbcontext != null )
            dbcontext.Dispose();

         // create new DBContext so we can reorder records based on edits
         dbcontext = new BaseballExercises.BaseballEntities();

         // use LINQ to order the Addresses table contents 
         // by last name, then first name
         dbcontext.Players
            .OrderBy( entry => entry.LastName )
            .ThenBy( entry => entry.FirstName )
            .Load();

         // specify DataSource for addressBindingSource
         playerBindingSource.DataSource = dbcontext.Players.Local;
         playerBindingSource.MoveFirst(); // go to first result
         findTextBox.Clear(); // clear the Find TextBox
      } // end method RefreshContacts

      // when the form loads, fill it with data from the database
      private void BaseballPlayers_Load( object sender, EventArgs e )
      {
         RefreshPlayers();
      } // end method BaseballPlayers_Load

      // use LINQ to create a data source that contains only people
      // with last names that start with the specified text
      private void findButton_Click( object sender, EventArgs e )
      {
         // use LINQ to filter contacts with last names that
         // start with findTextBox contents
         var lastNameQuery =
            from address in dbcontext.Players
            where address.LastName.StartsWith( findTextBox.Text )
            orderby address.LastName, address.FirstName
            select address;

         // display matching contacts
         playerBindingSource.DataSource = lastNameQuery.ToList();
         playerBindingSource.MoveFirst(); // go to first result

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
         RefreshPlayers(); // change back to initial unfiltered data
      } // end method browseButton_Click

      // Click event handler for the Save Button in the 
      // BindingNavigator saves the changes made to the data
      private void playerBindingNavigatorSaveItem_Click(
         object sender, EventArgs e )
      {
         Validate(); // validate input fields
         playerBindingSource.EndEdit(); // complete current edit, if any

         // try to save changes
         try
         {
            dbcontext.SaveChanges(); // write changes to database file
         } // end try
         catch ( DbEntityValidationException )
         {
            MessageBox.Show( "Columns cannot be empty",
               "Entity Validation Exception" );
         } // end catch

         RefreshPlayers(); // change back to initial unfiltered data 
      } // end method addressBindingNavigatorSaveItem_Click   
   } // end class BaseballPlayers
} // end namespace BaseballPlayers
