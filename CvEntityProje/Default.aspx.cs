using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvEntityProje
{
    public partial class Default : System.Web.UI.Page
    {
        CvEntityDbEntities db = new CvEntityDbEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            Repeater1.DataSource = db.TblHakkimda.ToList();
            Repeater1.DataBind();
            Repeater2.DataSource = db.TblHakkimda.ToList();
            Repeater2.DataBind();
            Repeater3.DataSource = db.TblHakkimda.ToList();
            Repeater3.DataBind();
            Repeater4.DataSource = db.TblHakkimda.ToList();
            Repeater4.DataBind();
            Repeater5.DataSource = db.TblYetenekler.ToList();
            Repeater5.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TblIletisim t = new TblIletisim();
            t.AdSoyad = TextBox1.Text;
            t.Mail = TextBox2.Text;
            t.Konu = TextBox3.Text;
            t.Mesaj = TextBox4.Text;
            db.TblIletisim.Add(t);
            db.SaveChanges();
        }
    }
}