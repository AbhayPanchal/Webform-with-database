using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/**
 * Name: Abhay Panchal
 * Student Number: 000813104
 * 
 * Date: 11-12-2020
 * 
 * Purpose: THis file use to get data from database and put data in the appropreate fields of the form to show.
 */

namespace Lab5b
{
    public partial class Form1 : Form
    {
        //Initialing connection to connect with database
        public SqlConnection Connection;

        //List for all the Objects

        private List<Doctor> doctors = new List<Doctor>();

        private List<Campanion> campanions = new List<Campanion>();

        private List<Episode> episodes = new List<Episode>();

        //Connecting Database with the form

        String connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=COMP10204_LAB5;Integrated Security=True; MultipleActiveResultSets = True;"; //MultipleActiveResultSets use to execute more than one query in a event;
        
        /// <summary>
        /// Constructor for form
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            try
            {
                Connection = new SqlConnection();
                Connection.ConnectionString = connectionString;
                Connection.Open();
                
            }
            catch(Exception ex)
            {
                label1.ForeColor = Color.Red;
                //label1.Text = "Database Connection failed - check Connection String : " + ex.Message; //if database don't connect
            }
        }

        /// <summary>
        /// For Closing the form application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// this event manipulate the combobox and fill it with the doctor id when form loads
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command = new SqlCommand("select DOCTORID from DOCTOR", Connection);

                SqlDataReader reader;

                reader = command.ExecuteReader();

                while (reader.Read()) {
                    int id = (int)reader["DOCTORID"];
                    DoctorComboBox.Items.Add(id);
                }

            }
            catch (Exception ex)
            {
                label1.Text = ex.Message;
            }

            
        }

        /// <summary>
        /// This event help to manipulate whole form with the data.
        /// 
        /// Every time the index of the combobox gets changed this event select data from database and put it in every fields.
        /// 
        /// 
        /// This method use for both SQL queries and Linq Queries
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void DoctorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {   
            //Only while sql radio button is checked
            if (SqlRadioButton.Checked)
            {
                Connection.Close();
                CompanionListBox.Items.Clear();
                Connection.Open();
                //query to select the data
                SqlCommand command = new SqlCommand("select * from DOCTOR WHERE DOCTORID= " + DoctorComboBox.Text + ";", Connection);

                SqlDataReader reader;

                reader = command.ExecuteReader();

                //reading the data and putting it in a appropriate textbox
                while (reader.Read())
                {
                    string name = (string)reader["ACTOR"];
                    ActorTextBox.Text = name;

                    int series = (int)reader["SERIES"];
                    SeriesTextBox.Text = series.ToString();

                    int age = (int)reader["AGE"];
                    AgeTextBox.Text = age.ToString();

                    //*************************************************Image ********************************/
                    byte[] photo = (byte[])reader["Picture"];
                    MemoryStream stream = new MemoryStream(photo);
                    Image image = Image.FromStream(stream);
                    DoctorPictureBox.Image = Image.FromStream(stream);

                }

                //***********Another query with joining tables to get the year field
                command = new SqlCommand("select min(SEASONYEAR) AS year from EPISODE Join COMPANION on COMPANION.STORYID = EPISODE.STORYID  WHERE DOCTORID= " + DoctorComboBox.Text + ";", Connection);
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int year = (int)reader["year"];
                    YearTextBox.Text = year.ToString();
                }

                //*********************************************************************
                //Select query to select title from database

                command = new SqlCommand("select TITLE from EPISODE JOIN COMPANION on COMPANION.STORYID = EPISODE.STORYID where EPISODE.SEASONYEAR=" + YearTextBox.Text + "and DOCTORID= " + DoctorComboBox.Text + ";", Connection);
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string title = reader[0].ToString();
                    EpisodeTextBox.Text = title;

                }

                //************************************************************************
                //Select query for selecting the name, actor, title and seasonyear for a doctor and putting it in a listbox to display it

                command = new SqlCommand("select TITLE, SEASONYEAR, COMPANION.NAME, COMPANION.ACTOR from EPISODE JOIN COMPANION on COMPANION.STORYID = EPISODE.STORYID where DOCTORID= " + DoctorComboBox.Text + ";", Connection);
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string name = (string)reader["NAME"];

                    string actor = (string)reader["ACTOR"];

                    string title = (string)reader["TITLE"];

                    int year = (int)reader["SEASONYEAR"];

                    //***************************************************************Formatting to display in a list****************************//
                    string listItem = name + "(" + actor + ")";
                    string listItem2 = "'" + title + "'" + "(" + year + ")\n\n";

                    CompanionListBox.Items.Add(listItem);
                    CompanionListBox.Items.Add(listItem2);
                    CompanionListBox.Items.Add("  ");
                }


                //doctors.Add(new Doctor((int)reader["DOCTORID"], (string)reader["ACTOR"], (int)reader["SERIES"], (int)reader["AGE"], (Image)reader["Picture"], (string)reader["DEBUT"]));
                Connection.Close();//Connection Close
            }

            //if Linqradiobutton is checked
            if (LinqRadioButton.Checked)
            {

                Connection.Close();

                Connection.Open();

            //**************************************************************************************Selecting and putting data in a list for doctor
                SqlCommand command = new SqlCommand("SELECT * FROM DOCTOR", Connection);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Doctor d = new Doctor();

                    d.Original = (int)reader["DOCTORID"];
                    d.Actor = reader["ACTOR"].ToString();
                    d.Age = (int)reader["AGE"];
                    d.Debut = reader["DEBUT"].ToString();
                    d.Series = (int)reader["SERIES"];
                    d.Picture = (byte[])reader["PICTURE"];

                    doctors.Add(d);
                }
                


                //***************************************For EPISODE********************************************

                command = new SqlCommand("Select * from EPISODE", Connection);

                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    //Episode ep = new Episode((int)reader["STORYID"], (int)reader["SEASON"], (int)reader["SEASONYEAR"], (string)reader["TITLE"]);
                    //episodes.Add(ep);

                    Episode ep = new Episode();

                    try
                    {

                        ep.Story = (int)reader["STORYID"];
                        ep.Season = (int)reader["SEASON"];
                        ep.Year = (int)reader["SEASONYEAR"];
                        ep.Title = (string)reader["TITLE"];

                        episodes.Add(ep);
                    }catch(Exception ex)
                    {
                        label1.Text = ex.Message;
                    }
                }

                ////***********************************************For Campanions******************************************

                command = new SqlCommand("SELECT * FROM COMPANION", Connection);

                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    //Campanion ca = new Campanion((string)reader["NAME"], (string)reader["ACTOR"], (int)reader["DOCTORID"], (string)reader["DEBUT"]);
                    //campanions.Add(ca);

                    Campanion c = new Campanion();

                    try
                    {

                        c.Name = (string)reader["NAME"];
                        c.Actor = (string)reader["ACTOR"];
                        c.DoctorID = (int)reader["DOCTORID"];
                        c.Debut = (string)reader["DEBUT"];

                        campanions.Add(c);
                    }catch(Exception ex)
                    {
                        label1.Text = ex.Message;
                    }
                }

                //Linq Query

                        var dp = from d in doctors
                                 where d.Original == int.Parse(DoctorComboBox.Text)
                                 select new { s = d.Series, p= d.Picture ,dp = d.Debut };    

            }
        }

        

        
    }
}
