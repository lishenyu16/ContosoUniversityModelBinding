﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ContosoUniversityModelBinding.Models;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Web.ModelBinding;


namespace ContosoUniversityModelBinding
{
    public partial class Students : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void studentsGrid_CallingDataMethods(object sender, CallingDataMethodsEventArgs e)
        {
            e.DataMethodsObject = new BLL.SchoolBL();
        }
    }
}