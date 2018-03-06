using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NLog;
using System.Collections;

public partial class log : System.Web.UI.Page
{
    //将log文件的路径设定为静态变量
  //private static string filebasepath = AppDomain.CurrentDomain.BaseDirectory + "Logs\\";
 

    //加载页面
    protected void Page_Load(object sender, EventArgs e)
    {
        Response.Write("开始操作log");

        //设置cookie值
        Response.Cookies["log"].Value = "about log";
        Response.Cookies["log"].Expires = DateTime.Now.AddDays(1);
        Response.Cookies["cp"].Path = "/";

    }

    //Nlog
    protected void Button3_Click(object sender, EventArgs e)
    {

        //写日志
        //Logger logger = LogManager.GetCurrentClassLogger();
        NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

        Thread.Sleep(1000);
        //记录警告信息
        logger.Warn("this is a Nlog warn log!");

        logger.Fatal("this is a Nlog fatal log!");

        logger.Debug("this is a Nlog debug log!");

        logger.Trace("this is a Nlog trace log!");

        logger.Error("this is a Nlog error log!");
        logger.Info("this is a Nlog info log");

        //记录一般信息
        string logname = "Info"; //这里的logname可以任意字符串
        Logger loggerByName = LogManager.GetLogger(logname);
        string log2 = "this is a Nlog common log";
        loggerByName.Info(log2);

       

        //获取cookie值
       string [] ss = Request.Cookies.AllKeys;
        int i = 0;
        foreach (string s in ss)
        {
            
            try
            {
                string t = Request.Cookies[s].Value.ToString();
                Response.Write("****************************");
                Response.Write(s+"="+t);
                //logger.Info("info cookie name"+t);
            }
            catch
            {
                Response.Write(i);
                i++;
                logger.Error("获取cookie{0}失败！",s);
            }
            
        }
        
    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");
    }

    //log4Net
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("log4Net.aspx");

    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("trace.aspx");
    }
}