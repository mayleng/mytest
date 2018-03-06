using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using StackExchange.Redis;

public partial class redisTest : System.Web.UI.Page
{
    //创建静态字段作为全局变量
    public static IDatabase db;
    

   //将连接数据库的操作封装成一个方法
    protected void  GetDb(out IDatabase db)
    {
        //连接数据库
      string conn = System.Configuration.ConfigurationManager.AppSettings["redis"].ToString();
      ConnectionMultiplexer redis = ConnectionMultiplexer.Connect(conn);

        //访问数据库  给db赋值
       db = redis.GetDatabase();
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    //返回
    protected void Button5_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");
       
    }
    
    //增加
    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            GetDb(out db );
            string value = "123";
            db.StringSet("mykey", value);

            
            string s = db.StringGet("mykey");
            if (s == "123")
            {
                Response.Write("<script>alert('添加成功!')</script>");
            }
        }
        catch
        {
            Response.Write("<script>alert('添加失败!')</script>");
        }
       
    }

    //查询
    protected void Button3_Click(object sender, EventArgs e)
    {
        try
        {
            GetDb(out db);
            string value = db.StringGet("mykey");
            Response.Write("<script>alert("+value+")</script>");
        }
        catch
        {
            Response.Write("<script>alert('查询失败!')</script>");
        }
       
    }

    //加一
    protected void Button2_Click(object sender, EventArgs e)
    {
        try
        {
            GetDb(out db);
            string value = db.StringIncrement("mykey").ToString();
            Response.Write("<script>alert(" + value + ")</script>");
        }
        catch
        {
            Response.Write("<script>alert('操作失败！')</script>");
        }

    }

    //减一
    protected void Button6_Click(object sender, EventArgs e)
    {
        try
        {
            GetDb(out db);
            string value = db.StringDecrement("mykey").ToString();
            Response.Write("<script>alert(" + value + ")</script>");

        }
        catch
        {
            Response.Write("<script>alert('操作失败')</script>");
        }
    }

    //追加
    protected void Button7_Click(object sender, EventArgs e)
    {
        try
        {
            GetDb(out db);
            //追加返回的不是追加后的值 具体后期看api
            string value = db.StringAppend("mykey", "7").ToString();
            Response.Write("<script>alert(" + value + ")</script>");
        }
        catch
        {
            Response.Write("<script>alert('追加失败!')</script>");
        }
    }

    //删除
    protected void Button4_Click(object sender, EventArgs e)
    {
        try
        {
            GetDb(out db);
            bool b = db.KeyDelete("mykey");
            if (b)
            {
                Response.Write("<script>alert('删除成功!')</script>");
            }
        }
        catch
        {
            Response.Write("<script>alert('删除失败!')</script>");
        }

    }
}





