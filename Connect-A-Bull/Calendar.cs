using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Connect_A_Bull
{
    public partial class Calendar : UserControl
    {
        public Calendar()
        {
            InitializeComponent();
        }

        private void Calendar_Load(object sender, EventArgs e)
        {
            var json_data = "";
            using (WebClient wc = new WebClient())
            {
                 json_data= wc.DownloadString("https://canvas.instructure.com/api/v1/users/self/courses?enrollment_state=active&access_token=13~UR54ZnsYuFhKMGipOJ9kn8yZX9gpd5IYOAp0zpYVYmZRC52GdZupc1qj4q59j8Qa");
            }

            JArray jsonArray = JArray.Parse(json_data);
            var jsonObjects = jsonArray.OfType<JObject>().ToList();

            label2.Text = jsonObjects[0].ToString();




        }
    }
}
