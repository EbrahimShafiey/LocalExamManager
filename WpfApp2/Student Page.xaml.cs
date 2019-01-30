using System;
using System.Collections.Generic;
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
    /// Interaction logic for Student_Page.xaml
    /// </summary>
    public partial class Student_Page : Window
    {
        string connectionString = "Server=localhost;Database=DBOnlineExam;Trusted_Connection=Yes;";
        string ExamsID;
        int num = 1;
        public Student_Page(string text)
        {
            int a;
            InitializeComponent();
            string querystring = "select ExamID from ExamII";
            SqlConnection cnn = new SqlConnection(connectionString);
            cnn.Open();
            SqlCommand command = new SqlCommand(querystring, cnn);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ExamsID +=  " - " + reader[0] + " - " + "\n";
            }
            cnn.Close();
            lblExamShow.Content = ExamsID;
            //----------------------------------------------------------------
            a = Convert.ToInt32(text);

            SqlConnection cnn1 = new SqlConnection(connectionString);
            cnn1.Open();
            string insertstring = "select * from Student where StudentID='" + a + "'";
            SqlCommand cmd = new SqlCommand(insertstring, cnn1);
            try
            {


                SqlDataReader reader1 = cmd.ExecuteReader();
                while (reader1.Read())
                {
                    studentdata.Content = "Wellcome ," + reader1[2] + "\nYour ID : " + reader1[0] + "\nYour lastname :  " + reader1[3];
                }
            }
            catch (Exception ex)
            {

            }
            cnn1.Close();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {



                SqlConnection cnn1 = new SqlConnection(connectionString);
                string query = "Insert Into Question (ExamID,QNumber,Answer) Values ('" + txtEIDEnter.Text + "','" + num.ToString() + "','" + Answertxt.Text + "')";                
                SqlCommand cmd = new SqlCommand(query, cnn1);
                cnn1.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Ok ");
                cnn1.Close();
                num++;
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطای برقراری ارتباط با پایگاه داده", "خطا", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnPrivousQ_Click(object sender, RoutedEventArgs e)
        {
            int a = 1;
            int b;
            b = a - 1;
            lblQAnswer.Content = "  جواب سوال " + b;
            a = b;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string[] array = new string[5];
            string a = "";
            string b="" ;
            try
            {
                SqlConnection cnn = new SqlConnection(connectionString);
                cnn.Open();
                string querystring = "select * from ExamII where ExamID='" + txtEIDEnter.Text + "'";
                SqlCommand command = new SqlCommand(querystring, cnn);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    a += reader[7]+" ";
                }
                cnn.Close();
                
                
                if(a.Length==5)
                {
                    MessageBox.Show("شما قبلا در این آزمون شرکت کرده اید", "خطای کاربر", MessageBoxButton.OK, MessageBoxImage.Stop);
                }
                else if (a.Length == 6||a.Length==1)
                {
                    try
                    {


                        SqlConnection cnn1 = new SqlConnection(connectionString);
                        cnn1.Open();
                        string querystring1 = "select * from ExamII where ExamID='"+txtEIDEnter.Text+"'";
                        SqlCommand command1 = new SqlCommand(querystring1, cnn1);
                        SqlDataReader reader1 = command1.ExecuteReader();
                        
                        while (reader1.Read())
                        {
                            b = reader1[8] + "";
                        }
                        cnn1.Close();
                        ImageSource img = new BitmapImage(new Uri(b));
                        QuestionPic.Source = img;
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("خطای برقراری ارتباط با پایگاه داده", "خطا", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
                else
                    MessageBox.Show("این آیدی در دیتابیس موجود نمیباشد", "خطا", MessageBoxButton.OK, MessageBoxImage.Error);


            }
            catch(Exception ex)
            {
                MessageBox.Show("خطای برقراری ارتباط با پایگاه داده", "خطا", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MessageBoxResult res = MessageBox.Show("آیا برای خروج از حساب کاربری اطمینان داررید؟", "!", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (res == MessageBoxResult.Yes)
            {
                MainWindow m1 = new MainWindow();
                m1.Show();
                this.Close();
            }
        }
    }
}
