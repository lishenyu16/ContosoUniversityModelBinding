using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ContosoUniversityModelBinding.Models;

namespace ContosoUniversityModelBinding
{
    public partial class AddStudent : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void addStudentForm_InsertItem()
        {
            var item = new Student();
            TryUpdateModel(item);
            if (ModelState.IsValid)
            {
                // Save changes here
                using (SchoolContext db = new SchoolContext())
                {
                    db.Students.Add(item);
                    db.SaveChanges();
                }

            }
        }

        protected void addStudentForm_ItemInserted(object sender, FormViewInsertedEventArgs e)
        {
            Response.Redirect("~/Students");
        }

        protected void cancelButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Students");
        }
    }
}