﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvEntityProje
{
	public partial class WebForm1 : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			CvEntityDbEntities db = new CvEntityDbEntities();
			Repeater1.DataSource = db.TblYetenekler.ToList();
			Repeater1.DataBind();
		}
	}
}