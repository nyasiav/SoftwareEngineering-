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
using System.Collections;

namespace Connect_A_Bull
{
    public partial class Calendar : UserControl
    {
        DateTime pickedDate = new DateTime();

        public Calendar()
        {
            InitializeComponent();

        }

        private void Calendar_Load(object sender, EventArgs e)
        {
            EraseOldEvents();
            GetNewEvents();
            
            treeView1.ExpandAll();
            treeView1.Nodes[0].EnsureVisible();
        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            pickedDate = dateTimePicker.Value;
            EraseOldEvents();
            GetNewEvents();
        }

        private void GetNewEvents()
        {
            if (pickedDate == DateTime.MinValue)
            {
                pickedDate = DateTime.Today;
            }

            DateTime monthDay = pickedDate.AddDays(30);
            string canvasStartDay = pickedDate.ToString("yyyy-MM-dd");
            string canvasEndDay = monthDay.ToString("yyyy-MM-dd");

            string eventLinkPart1 = "https://canvas.instructure.com/api/v1/users/self/calendar_events?type=event&type=assignment&start_date=";
            string eventLinkPart2 = "&end_date=";
            string eventLinkPart3 = "&context_codes[]=course_";
            string eventLinkPart4 = "&access_token=";

            string json_data = "";
            string canvasLinkCourses = "https://canvas.instructure.com/api/v1/users/self/courses?enrollment_state=active&access_token=";
            string brittanyCanvas = "13~rIzSCEWS3pJVUHjbhaFhp2Y1c5owCk3WmQ6Iqr1o3MvTGS6FOFONQZjfsJgsPiNA";
            string desCanvas = "13~UR54ZnsYuFhKMGipOJ9kn8yZX9gpd5IYOAp0zpYVYmZRC52GdZupc1qj4q59j8Qa";
            string chosenUser = brittanyCanvas;
            string userCourseLink = canvasLinkCourses + chosenUser;

            using (WebClient wc = new WebClient())
            {
                json_data = wc.DownloadString(userCourseLink);
            }

            JArray jsonArray = JArray.Parse(json_data);
            var jsonObjects = jsonArray.OfType<JObject>().ToList();

            ArrayList courseIDs = new ArrayList();
            ArrayList eventDates = new ArrayList();
            DataTable fullEvents = new DataTable();
            fullEvents.Columns.Add("Title", typeof(string));
            fullEvents.Columns.Add("Date", typeof(string));
            fullEvents.Columns.Add("Description", typeof(string));
            int fullEventCount = 0;

            string printTextBox = "";
            string printTextBox2 = "";
            

   
            //iterates over every course
            for (int i = 0; i < jsonObjects.Count; i++)
            {
                //1333005055 - used for retrieval of assignments
                string courseID = jsonObjects[i]["id"].ToString();
                courseIDs.Add(courseID);

                //Software Engineering - CEN 4020
                string tempCourse = "";
                tempCourse += jsonObjects[i]["name"].ToString();
                tempCourse += " - ";
                string rawCourseCode = jsonObjects[i]["course_code"].ToString();
                string rawAbreviation = rawCourseCode.Substring(0, 3);
                string rawNumber = rawCourseCode.Substring(3, 4);
                string courseCode = "No Course Code";
                if (rawNumber[0] >= '0' && rawNumber[0] <= '9')
                {
                    courseCode = "";
                    courseCode = rawAbreviation + " " + rawNumber;
                }
                tempCourse += courseCode;
                //tempCourse += " " + courseID;
                coursesCheckListBox.Items.Add(tempCourse);
                printTextBox2 += tempCourse + "\r\n";

                //Get events and assignments using current courseID
                string eventFullLink = eventLinkPart1
                     + canvasStartDay
                     + eventLinkPart2
                     + canvasEndDay
                     + eventLinkPart3
                     + courseIDs[i]
                     + eventLinkPart4
                     + chosenUser;

                //Holds all events for given course
                string json_data2 = "";
                using (WebClient wc = new WebClient())
                {
                    json_data2 = wc.DownloadString(eventFullLink);
                }

                JArray jsonArray2 = JArray.Parse(json_data2);
                var jsonObjects2 = jsonArray2.OfType<JObject>().ToList();

                
                //Iterates over all events for given course
                for (int j = 0; j < jsonObjects2.Count; j++)
                {
                    
                    //2d array, First Event is 1 array - [Event Title, Event Date/Due Date, Description]
                    object[] tempEvent = new object[3];

                    string titleEvent = jsonObjects2[j]["title"].ToString();
                    tempEvent[0] = titleEvent;
                    printTextBox += titleEvent + "\r\n";

                    string dateEvent = jsonObjects2[j]["all_day_date"].ToString();
                    tempEvent[1] = dateEvent;
                    printTextBox += dateEvent + "\r\n";

                    string descriptionEvent = jsonObjects2[j]["description"].ToString();
                    tempEvent[2] = descriptionEvent;
                    fullEventCount++;

                    fullEvents.Rows.Add(tempEvent);
                    //eventDates holds all of the event dates,
                    //knows what Dates to display in tree view
                    string tempEventDate = dateEvent; 
                    eventDates.Add(tempEventDate);

                    //printTextBox += "should match : " +  j + " " + fullEvents.Rows[courseWithEvents][0] + ", " + fullEvents.Rows[courseWithEvents][1] + "\r\n";
                }//End iteration over events for given course
            }//End iteration over every course


            //debugging tool
            //textBox1.Text = printTextBox;
            printTextBox = "";
            //textBox1.Text = printTextBox2;
            //list to sort the and weed out duplicate dates
            List<string> sortedEventDates = new List<string>();

            //iterates over all the original dates
            for (int j = 0; j < eventDates.Count; j++)
            {
                //adds the date to the new sorted/no duplicate list if doesn't exist in it already
                if (!sortedEventDates.Contains(eventDates[j]))
                {
                    sortedEventDates.Add((string)eventDates[j]);
                }
            }

            //sorts the dates
            sortedEventDates.Sort();
            
            for (int j = 0; j < sortedEventDates.Count; j++)
            {
                treeView1.Nodes.Add((string)sortedEventDates[j]);
                treeView1.Nodes[j].NodeFont = new Font("Microsoft Sans Serif", 14);
                treeView1.Nodes[j].BackColor = Color.FromArgb(0, 100, 132);
                treeView1.Nodes[j].ForeColor = Color.White;
            }

            string forAddingNodes = "";

            for (int j = 0; j < fullEventCount; j++)
            {
                int a = 0;
                foreach (TreeNode n in treeView1.Nodes)
                {
                    string compareDate = (string)fullEvents.Rows[j][1];
                    forAddingNodes += "Does \"" + compareDate + "\" equal \"" + n.Text + "\" ?\r\n";
                    if(string.Compare(compareDate, n.Text) == 0)
                    {
                        treeView1.Nodes[a].Nodes.Add((string)fullEvents.Rows[j][0]);
                    }
                    a++;
                }
                
            }
            //textBox1.Text = forAddingNodes;

            int everyDate = 0;
            foreach(TreeNode n in treeView1.Nodes)
            {
                int b = 0;

                foreach(TreeNode x in n.Nodes)
                {
                    treeView1.Nodes[everyDate].Nodes[b].NodeFont = new Font("Microsoft Sans Serif", 12);
                    treeView1.Nodes[everyDate].Nodes[b].BackColor = Color.FromArgb(0, 120, 158); ;
                    treeView1.Nodes[everyDate].Nodes[b].ForeColor = Color.White;
                    b++;
                }
                everyDate++;
            }

        }

        private void EraseOldEvents()
        {
            coursesCheckListBox.Items.Clear();
            treeView1.Nodes.Clear();
        }
    }
}
