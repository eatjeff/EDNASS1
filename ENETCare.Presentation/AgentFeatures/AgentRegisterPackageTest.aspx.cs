﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ENETCare.Presentation.AgentFeatures
{
    public partial class AgentRegisterPackageTest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LogIn(object sender, EventArgs e)
        {
            //what's this for?
            if (IsValid)
            {
                var test = NedPackageRegisterFormPackageType.Text;
            }
        }
    }
}