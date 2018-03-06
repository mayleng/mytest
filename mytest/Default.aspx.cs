using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }


    protected void Button2_Click(object sender, EventArgs e)
    {
        TextBox2.Text = "已确定！";
        string s = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["mysql"].ToString();
        //string s = System.Configuration.ConfigurationManager.AppSettings["mongodb"].ToString();
        TextBox3.Text = s;

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        TextBox1.Text = "提交成功！";
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        Response.Redirect("goto.html");
    }



    protected void Button4_Click(object sender, EventArgs e)
    {
        Response.Redirect("redisTest.aspx");
    }

    protected void Button5_Click(object sender, EventArgs e)
    {
        Response.Redirect("log.aspx");
    }

    protected void Button6_Click(object sender, EventArgs e)
    {
        Response.Redirect("http.aspx");
    }

    protected void Button7_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/RemoteXiazuan.ashx");
    }
}