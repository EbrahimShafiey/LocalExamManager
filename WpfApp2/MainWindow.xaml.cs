using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        int StudentID = 1001;
        int TeacherID = 2001;
        string connectionString = "Server=localhost;Database=DBOnlineExam;Trusted_Connection=Yes;";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {



            if (rdbINTeacher.IsChecked == true)
            {
                string INPass = userINTeacher.Text;
                int i = 0;
                int count = 0;

                /* SqlConnection cnn = new SqlConnection(connectionString);
                 cnn.Open();
                 string querystring = "select count(TeacherID)from Teacher";
                 SqlCommand command = new SqlCommand(querystring, cnn);
                 SqlDataReader reader = command.ExecuteReader();

                 while (reader.Read())
                 {
                     count = Convert.ToInt32(reader[0]);
                     //MessageBox.Show(count + "");

                 }*/

                SqlConnection cnn1 = new SqlConnection(connectionString);

                //string querystring1 = "select * from Teacher";
                SqlCommand command1 = new SqlCommand();
                try
                {
                    if (userINTeacher.Text == string.Empty || PassINTeacher.Password == string.Empty)
                    {
                        MessageBox.Show("لطفا تمام فیلد های ورودی را تکمیل کنید", "خطا", MessageBoxButton.OK, MessageBoxImage.Error);
                        return;
                    }
                    command1 = new SqlCommand("select count(*) from Teacher where TeacherID='" + userINTeacher.Text +
                                                                "'and Password='" + PassINTeacher.Password + "'", cnn1);
                    //SqlDataReader reader1 = command1.ExecuteReader();

                    if (cnn1.State == ConnectionState.Closed)
                    {
                        cnn1.Open();
                        i = (int)command1.ExecuteScalar();
                    }
                    cnn1.Close();
                    if (i > 0)
                    {
                        Teacher_Page frm = new Teacher_Page(userINTeacher.Text);
                        frm.Show();

                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("نام کاربری یا رمز عبور اشتباه است", "خطای ورود", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
                finally
                {
                    i = 0;
                    cnn1.Close();
                }
               
                cnn1.Close();













                //-------------------------------------------------------------------------------------------
                /*cnn.Open();
                string querystringp = "select  Password from Teacher";
                SqlCommand commandp = new SqlCommand(querystringp, cnn);
                SqlDataReader readerp = commandp.ExecuteReader();
                while (readerp.Read()) 
                {
                     //b = readerp[1].ToString();
                }
                cnn.Close();*/
                // MessageBox.Show(a + " - " + b);

                //Teacher_Page f1 = new Teacher_Page();
                //f1.Show();
            }
            else if (rdbINStudent.IsChecked == true)
            {
               
                    string INPass = userINTeacher.Text;
                    int i = 0;
                    int count = 0;

                    /* SqlConnection cnn = new SqlConnection(connectionString);
                     cnn.Open();
                     string querystring = "select count(TeacherID)from Teacher";
                     SqlCommand command = new SqlCommand(querystring, cnn);
                     SqlDataReader reader = command.ExecuteReader();

                     while (reader.Read())
                     {
                         count = Convert.ToInt32(reader[0]);
                         //MessageBox.Show(count + "");

                     }*/

                    SqlConnection cnn1 = new SqlConnection(connectionString);

                    //string querystring1 = "select * from Teacher";
                    SqlCommand command1 = new SqlCommand();

                    try
                    {
                        if (userINTeacher.Text == string.Empty || PassINTeacher.Password == string.Empty)
                        {
                            MessageBox.Show("لطفا تمام فیلد های ورودی را تکمیل کنید", "خطا", MessageBoxButton.OK, MessageBoxImage.Error);
                            return;
                        }
                        command1 = new SqlCommand("select count(*) from Student where StudentID='" + userINTeacher.Text +
                                                                    "'and Password='" + PassINTeacher.Password + "'", cnn1);
                        //SqlDataReader reader1 = command1.ExecuteReader();

                        if (cnn1.State == ConnectionState.Closed)
                        {
                            cnn1.Open();
                            i = (int)command1.ExecuteScalar();
                        }
                        cnn1.Close();
                        if (i > 0)
                        {
                            Student_Page s2 = new Student_Page(userINTeacher.Text);
                            s2.Show();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("نام کاربری یا رمز عبور اشتباه است", "خطای ورود", MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                    }
                    finally
                    {
                        i = 0;
                        cnn1.Close();
                    }

                    cnn1.Close();

                
               

            }
            else
            {
                MessageBox.Show("لطفا سطح دسترسی خود را انتخاب کنید -استاد یا دانشجو");
            }
        }
            private void btnsignup_Click(object sender, RoutedEventArgs e)
            {



                if (SinguprdbTeacher.IsChecked == true)
                {
                    IDNum.Visibility = Visibility.Visible;
                    if (passtxt1.Password != "" && Firstnametxt.Text != "" && passtxt2.Password != "" && lastnametxt.Text != "")
                    {

                        if (passtxt1.Password == passtxt2.Password)
                        {

                            string connectionString = "Server=localhost;Database=DBOnlineExam;Trusted_Connection=Yes;";
                            SqlConnection cnn = new SqlConnection(connectionString);

                            cnn.Open();
                            string insertstring = "insert into Teacher (Password,FirstName,LastName) Values ('" + passtxt1.Password.ToString() + "','" + Firstnametxt.Text.ToString() + "','" + lastnametxt.Text.ToString() + "')";
                            SqlCommand cmd = new SqlCommand(insertstring, cnn);

                            cmd.ExecuteNonQuery();



                            MessageBox.Show("ثبت نام شما با موفقیت انجام شد \n اطلاعات وارد شده: \n Teacher ID :" + TeacherID + "\n Password :" + passtxt1.Password + "\n First Name :" + Firstnametxt.Text + "\n Last Name :" + lastnametxt.Text);

                        }
                        else
                            MessageBox.Show("دو رمز وارد شده مطابق یکدیگر نیستند");

                    }
                    else
                        MessageBox.Show("لطفا تمامی فیلد های ورودی را تکمیل کنید");
                }
                if (SignuprdbStudent.IsChecked == true)
                {

                    IDNum.Visibility = Visibility.Visible;
                    if (passtxt1.Password != "" && Firstnametxt.Text != "" && passtxt2.Password != "" && lastnametxt.Text != "")
                    {

                        if (passtxt1.Password == passtxt2.Password)
                        {

                            string connectionString = "Server=localhost;Database=DBOnlineExam;Trusted_Connection=Yes;";
                            SqlConnection cnn = new SqlConnection(connectionString);
                            cnn.Open();
                            string insertstring = "insert into Student (Password,FirstName,LastName) Values ('" + passtxt1.Password.ToString() + "','" + Firstnametxt.Text.ToString() + "','" + lastnametxt.Text.ToString() + "')";
                            SqlCommand cmd = new SqlCommand(insertstring, cnn);
                            cmd.ExecuteNonQuery();
                            cnn.Close();

                            MessageBox.Show("ثبت نام شما با موفقیت انجام شد \n اطلاعات وارد شده: \n Teacher ID :" + StudentID + "\n Password :" + passtxt1.Password + "\n First Name :" + Firstnametxt.Text + "\n Last Name :" + lastnametxt.Text);

                        }
                        else
                            MessageBox.Show("دو رمز وارد شده مطابق یکدیگر نیستند");

                    }
                    else
                        MessageBox.Show("لطفا تمامی فیلد های ورودی را تکمیل کنید");
                }

                else
                    MessageBox.Show("لطفا سطح دسترسی خود را وارد کنید");

            }

            private void SinguprdbTeacher_Checked(object sender, RoutedEventArgs e)
            {
                string connectionString = "Server=localhost;Database=DBOnlineExam;Trusted_Connection=Yes;";
                SqlConnection cnn = new SqlConnection(connectionString);
                cnn.Open();
                string querystring = "select TeacherID from Teacher";
                SqlCommand command = new SqlCommand(querystring, cnn);
                SqlDataReader reader = command.ExecuteReader();
                TeacherID = 2002;
                while (reader.Read())
                {
                    TeacherID++;
                }
                cnn.Close();
                IDNum.Visibility = Visibility.Visible;
                IDNum.Content = TeacherID.ToString();
            }

            private void SignuprdbStudent_Checked(object sender, RoutedEventArgs e)
            {
                string connectionString = "Server=localhost;Database=DBOnlineExam;Trusted_Connection=Yes;";
                SqlConnection cnn = new SqlConnection(connectionString);
                cnn.Open();
                string querystring = "select StudentID from Student";
                SqlCommand command = new SqlCommand(querystring, cnn);
                SqlDataReader reader = command.ExecuteReader();
                StudentID = 1001;
                while (reader.Read())
                {
                    StudentID++;
                }

                cnn.Close();
                IDNum.Visibility = Visibility.Visible;
                IDNum.Content = StudentID.ToString();
            }
        }
    }


