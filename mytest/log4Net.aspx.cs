using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using log4net;


public partial class log4Net : System.Web.UI.Page
{
   
    protected void Page_Load(object sender, EventArgs e)
    {
        Response.Write("log4net!");


        //我们会以类（class）的类型（type）为参数来调用GetLogger()，
        //以便跟踪我们正在进行日志记录的类。传递的类(class)的类型(type)可以用typeof(Classname)方法来获得
        // log4net.ILog log = log4net.LogManager.GetLogger(typeof(log4Net));
    
     //也可以通过反射获得 
    log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        log.Error("log4net error", new Exception("在这里发生了一个error异常！"));
        log.Fatal("log4net  fatal", new Exception("在发生了一个致命fatal错误"));
        log.Info("log4net info 提示：系统正在运行");
        log.Debug("log4net 调试信息：debug");
        log.Warn("log4net 警告：warn");

        int n = 0;
        for (n = 1; n <= 10; n++)
        {
            if (n % 2 == 0){
                string s = n.ToString();
                log.Info(s+"为偶数");
            }
            else
            {
                string s = n.ToString();
                log.Warn(s + "为奇数");
                    
            }
        }

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("log.aspx");
    }
}