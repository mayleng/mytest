using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class http : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
    }

    //自定义错误状态码
    protected void Button2_Click(object sender, EventArgs e)
    {
        
        Response.StatusCode = 600;
        Response.StatusDescription = "error";
        Response.Write("访问错误！600");

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.StatusCode = 222;
        Response.StatusDescription = "OK";
        Response.Write("访问页面正常！222");
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        Response.StatusCode = 999;
        Response.StatusDescription = "self";
        Response.Write("用户自定义！999");
        
    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");
    }
}