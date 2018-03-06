<%@ WebHandler Language="C#" Class="RemoteXiazuan" %>

using System;
using System.Web;
using System.IO;
using System.Threading;

public class RemoteXiazuan : IHttpHandler {

    public void ProcessRequest (HttpContext context) {
        context.Response.ContentType = "text/html";
        //context.Response.Write("Hello World");
        string filepath = context.Request.MapPath("~/a/b/c/d/e/RemoteTest.html");
        string strhtml = File.ReadAllText(filepath);

        Thread.Sleep(200);
        strhtml = strhtml.Replace("$pagemessage", "该网页用来测试远程连接和下钻！");
        context.Response.Write(strhtml);
    }

    public bool IsReusable {
        get {
            return false;
        }
    }

}