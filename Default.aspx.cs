using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Data;
using System.Xml.Linq;
using Newtonsoft.Json.Linq;

namespace TP02_2
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string fileName = "C:\\Users\\Luiz\\Desktop\\TP02-2\\voos.json";
                string json = (new WebClient()).DownloadString(fileName);
                List<Root> voos = JsonConvert.DeserializeObject<List<Root>>(json);
                List<string> codigos = new List<string>();
                foreach (Root voo in voos)
                {
                    codigos.Add(voo.codigo);
                }
                DropDown1.DataSource = codigos;
                DropDown1.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string fileName = "C:\\Users\\Luiz\\Desktop\\TP02-2\\voos.json";
            string json = (new WebClient()).DownloadString(fileName);
            GridView1.DataSource = JsonConvert.DeserializeObject<DataTable>(json);
            GridView1.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string fileName = "C:\\Users\\Luiz\\Desktop\\TP02-2\\voos.json";
            string json = (new WebClient()).DownloadString(fileName);
            List<Root> voos = JsonConvert.DeserializeObject<List<Root>>(json);
            List<Root> roots = new List<Root>();
            foreach(Root voo in voos)
            {
                if (voo.codigo == DropDown1.Text)
                {
                    roots.Add(voo);
                }
            }
            string output = JsonConvert.SerializeObject(roots);
            File.WriteAllText(@"C:\Users\Luiz\Desktop\TP02-2\voo.json", output);
            string fileName2 = "C:\\Users\\Luiz\\Desktop\\TP02-2\\voo.json";
            string json2 = (new WebClient()).DownloadString(fileName2);
            GridView1.DataSource = JsonConvert.DeserializeObject<DataTable>(json2);
            GridView1.DataBind();
        }
    }
}