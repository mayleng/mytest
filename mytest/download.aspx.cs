using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class download : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        //下载图片
        string strResult = string.Empty;
        string strPath = Server.MapPath(@"/images");
        string strFile = string.Format(@"{0}\{1}", strPath, "640.jpg");

        using (FileStream fs = new FileStream(strFile, FileMode.Open))
        {
            byte[] bytes = new byte[(int)fs.Length];
            fs.Read(bytes, 0, bytes.Length);
            fs.Close();
            Response.ContentType = "application/octet-stream";
            Response.AddHeader("Content-Disposition", "attachment; filename=" + HttpUtility.UrlEncode("640.jpg", System.Text.Encoding.UTF8));
            Response.BinaryWrite(bytes);
           
            Response.Flush();

            Response.End();
        }
    
}
}