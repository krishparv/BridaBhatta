using BridaBhatta.Bll;
using BridaBhatta.Bll.Model;
using LFA.Forum.DAL.Ado;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BridaBhatta_WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void DataBindGrid()
        {
            AdultPerson _adultPerson = new AdultPerson();
            List<AdultPersonModel> lstPerson = _adultPerson.GetAllData();
            //DataTable dt = new DataTable();
            //Gv_ListOfPerson.DataSource = lstPerson;

            gvUsers.DataSource = lstPerson;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bridaBhataDataSet1.AdultPerson' table. You can move, or remove it, as needed.
            this.adultPersonTableAdapter1.Fill(this.bridaBhataDataSet1.AdultPerson);
            // TODO: This line of code loads data into the 'bridaBhataDataSet.AdultPerson' table. You can move, or remove it, as needed.
            this.adultPersonTableAdapter.Fill(this.bridaBhataDataSet.AdultPerson);

            DataBindGrid();


        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
                     
            

            AdultPersonModel person = new AdultPersonModel();
            AdultPerson adperson = new AdultPerson();
            try
            {
                string[] name = txt_fname.Text.Split(' ');

                person.FirstName = txt_fname.ToString();
                person.LastName = txt_lname.Text;
                person.DOB = DateTime.Parse(txt_dob.Text);
                person.Address = txt_address.Text;
                person.Street = txt_street.Text;
                AdultPerson personBll = new AdultPerson();
               // person.Age = personBll.CalculateAge(person);
               // txt_age.Text = person.Age.ToString();
              //  person.Amount = decimal.Parse(personBll.calculateAmount(person).ToString());
            //    txt_amount.Text = person.Amount.ToString();

                adperson.AddPersonDetails(person);
                MessageBox.Show("Sucessfully Submiteed", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Error!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            //AdultPerson personBLL = new AdultPerson();
            //AdultPersonModel person = personBLL.GetDataById(int.Parse(cmbx_search.SelectedValue.ToString()));
            //txt_fname.Text = person.FirstName + "" + person.LastName;
            //txt_age.Text = person.Age.ToString();
            //txt_street.Text = person.Street;
            //txt_address.Text = person.Address;
            //txt_dob.Text = person.DOB.ToString();
            //txt_amount.Text = person.Amount.ToString();
            AdultPerson adPerson = new AdultPerson();
            List<AdultPersonModel> _person = adPerson.GetAllData();
            List<AdultPersonModel> Selectedperson = new List<AdultPersonModel>();

            var _selectedType = cmbox_type.SelectedItem.ToString();

            switch (_selectedType)
            {
                case "Name":
                    {
                        Selectedperson = new List<AdultPersonModel>();
                        foreach (var data in _person)
                        {
                            if ((txt_search.Text == data.FirstName + " " + data.LastName) || (txt_search.Text==data.FirstName) || (txt_search.Text==data.LastName))
                                Selectedperson.Add(data);
                        }

                        break;
                    }
                case "DOB":
                    {
                        Selectedperson = new List<AdultPersonModel>();
                        foreach (var data in _person)
                        {

                            if (txt_search.Text == data.DOB.ToShortDateString())
                                Selectedperson.Add(data);
                        }

                        break;
                    }
                case "Age":
                    {
                        Selectedperson = new List<AdultPersonModel>();
                        foreach (var data in _person)
                        {

                            if (txt_search.Text == data.Age.ToString())
                                Selectedperson.Add(data);
                        }
                        break;
                    }

                case "Amount":
                    {
                        Selectedperson = new List<AdultPersonModel>();
                        foreach(var data in _person)
                        {
                            if (txt_search.Text == data.Amount.ToString())
                                Selectedperson.Add(data);
                        }
                        break;
                    }
                case "Street":
                    {
                        Selectedperson = new List<AdultPersonModel>();
                        foreach (var data in _person)
                        {

                            if (txt_search.Text == data.Street.ToString())
                                Selectedperson.Add(data);
                        }
                        break;
                    }
                default:
                    {
                        break;
                    }

            }

            gv_dataview.DataSource = Selectedperson;
            gv_dataview.Columns["Id"].Visible = false;

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bridaBhataDataSet1.AdultPerson' table. You can move, or remove it, as needed.
            this.adultPersonTableAdapter1.Fill(this.bridaBhataDataSet1.AdultPerson);
            // TODO: This line of code loads data into the 'bridaBhataDataSet.AdultPerson' table. You can move, or remove it, as needed.
            this.adultPersonTableAdapter.Fill(this.bridaBhataDataSet.AdultPerson);

            DataBindGrid();
        }



        //private void cmbox_type_SelectedValueChanged(object sender, EventArgs e)
        //{

        //    AdultPerson adperson = new AdultPerson();
        //    List<AdultPersonModel> lstPerson = new List<AdultPersonModel>();
        //    lstPerson = adperson.GetAllData();
        //    List<string> searchList = new List<string>();
        //    switch (cmbox_type.SelectedItem.ToString())
        //    {
        //        case "--Please Select--":
        //            {
        //                cmbx_search.SelectedValue = "--Please Select--";
        //                break;
        //            }

        //        case "Name":
        //            {
        //                searchList = new List<string>();
        //                foreach (var val in lstPerson)
        //                {
        //                    searchList.Add(val.FirstName + " " + val.LastName);
        //                }
        //                break;
        //            }

        //        case "DOB":
        //            {
        //                searchList = new List<string>();
        //                foreach (var val in lstPerson)
        //                {
        //                    searchList.Add(val.DOB.ToShortDateString());
        //                }
        //                break;
        //            }

        //        case "Age":
        //            {
        //                searchList = new List<string>();
        //                foreach (var val in lstPerson)
        //                {
        //                    searchList.Add(val.Age.ToString());
        //                }

        //                break;

        //            }

        //        case "Amount":
        //            {
        //                searchList = new List<string>();
        //                foreach (var val in lstPerson)
        //                {
        //                    searchList.Add(val.Amount.ToString());
        //                }
        //                break;
        //            }

        //        case "Address":
        //            {
        //                searchList = new List<string>();
        //                foreach (var val in lstPerson)
        //                {
        //                    searchList.Add(val.Address.ToString());
        //                }
        //                break;
        //            }

        //        default:
        //            {
        //                break;
        //            }

        //    }
        //    cmbx_search.DataSource = searchList.Distinct().ToList();


        //}

        private void gv_dataview_SelectionChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < gv_dataview.SelectedRows.Count; i++)
            {
                var id = gv_dataview.Rows[i].Cells["Id"].Value;
            }
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    List<string> listacolumnas = new List<string>();
        //    //  SqlHelper sql=new SqlHelper();
        //    //   var query = "select column_name from information_schema.columns where table_name = 'adultperson'";
        // //  try this one

        //    string _strConn = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=BridaBhata;Data Source=.\SQLEXPRESS2008";


        //    SqlConnection _conn = new SqlConnection();
        //    _conn.ConnectionString = _strConn;
        //    _conn.Open();

        //    //   string query= "select column_name from information_schema.columns where table_name = 'adultperson'";
        //    string query = "select * from adultperson";

        //    SqlDataAdapter sq = new SqlDataAdapter(query, _conn);
        //    DataSet ds = new DataSet();

        //    sq.Fill(ds);

        //    DataTable dt = ds.Tables[0];
        //    List<string> lsColumn = new List<string>();
        //    foreach (DataColumn column in dt.Columns)
        //    {
        //        var name = column.ColumnName;  // the column name
        //        var type = column.DataType.ToString();  // the type as string
        //        lsColumn.Add(name);
        //    }


        //    sq.Dispose();
        //    _conn.Close();
        //    cmbx_search.DataSource = lsColumn;
        //}


        //private void button1_Click(object sender, EventArgs e)
        //{

        //    SqlHelper sqlhp = new SqlHelper();
        //    var sqlr = sqlhp.ExecuteReaderProc("usp_getcolumnname");
        //    int i = 0;
        //    List<string> lsColumns = new List<string>();
        //    while (sqlr.Read())
        //    {
        //        lsColumns.Add(sqlr[0].ToString());
        //    }
        //    cmbx_search.DataSource = lsColumns;
        //}

        private void gv_dataview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            for (int i = 0; i < gv_dataview.SelectedRows.Count; i++)
            {
                var id = gv_dataview.Rows[i].Cells["Id"].Value;
            }
        }

        private void gv_dataview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var collection = gv_dataview.SelectedRows;
            var cellValue = gv_dataview.Rows[e.RowIndex].Cells[0].Value;
            fillData(int.Parse(cellValue.ToString()));
        }

        public void fillData(int id)
        {
            AdultPerson personBLL = new AdultPerson();
            AdultPersonModel person = personBLL.GetDataById(id);
            txt_fname.Text = person.FirstName;
            txt_lname.Text = person.LastName;
            txt_age.Text = person.Age.ToString();
            txt_street.Text = person.Street;
            txt_address.Text = person.Address;
            txt_dob.Text = person.DOB.ToString();
            txt_amount.Text = person.Amount.ToString();
        }

        private void btn_calculate_Click(object sender, EventArgs e)
        {
            AdultPerson personBll = new AdultPerson();
            txt_age.Text = personBll.CalculateAge(DateTime.Parse(txt_dob.Text)).ToString();
             
          txt_amount.Text   =personBll.calculateAmount(int.Parse(txt_age.Text)).ToString();

        }

        private void lb_amount_Click(object sender, EventArgs e)
        {

        }

        private void Edit_Click(object sender, EventArgs e)
        {

        }
    }

}
