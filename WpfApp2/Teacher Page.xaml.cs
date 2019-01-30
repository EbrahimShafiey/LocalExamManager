using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Data.SqlClient;
using Microsoft.Win32;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp2
{


    /// <summary>
    /// Interaction logic for Teacher_Page.xaml
    /// </summary>
    public partial class Teacher_Page : Window
    {
        int a;
        string connectionString = "Server=localhost;Database=DBOnlineExam;Trusted_Connection=Yes;";
        public Teacher_Page(string text)
        {
            InitializeComponent();
            a = Convert.ToInt32(text);

            SqlConnection cnn = new SqlConnection(connectionString);
            cnn.Open();
            string insertstring = "select * from teacher where TeacherID='" + a + "'";
            SqlCommand cmd = new SqlCommand(insertstring, cnn);
            try
            {


                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    lblusershow.Content = "Wellcome ," + reader[2] + "\nYour ID : " + reader[0] + "\nYour lastname :  " + reader[3];
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(Totalscore.Text==""||Qmount.Text=="")
            {
                MessageBox.Show("ابتدا تمامی فیلد های ورودی را تکمیل کنید", "خطا", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
               
                    Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
                    dlg.Filter = "JPG Files|*.jpg|PNG Files|*.png|JPEG Files|*.jpeg";
                    dlg.Title = "Select Questions Picture...";
                    if (dlg.ShowDialog() != null)
                    {
                        try
                        {



                            SqlConnection cnn1 = new SqlConnection(connectionString);
                            string query = "Insert Into ExamII (TeacherID,TotalScore,QuestionMount,QuestionPic) Values ('" + a.ToString() + "','" + Totalscore.Text + "','" + Qmount.Text + "','" + dlg.FileName + "')";
                            ImageSource img = new BitmapImage(new Uri(dlg.FileName));
                            PictureBoxQ.Source = img;
                            SqlCommand cmd = new SqlCommand(query, cnn1);
                            cnn1.Open();
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Ok ");
                            cnn1.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("خطای برقراری ارتباط با پایگاه داده", "خطا", MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                    }

                    
                
            }
           

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

            /*
            if(dlg.ShowDialog()!=null)
            {
                try
                {
                    SqlConnection cnn1 = new SqlConnection(connectionString);
                    string query = "Insert Into Exam (QuestionPic) Values (@PersonImage)";
                    SqlCommand command = new SqlCommand(query, cnn1);
                    ImageSource img = new BitmapImage(new Uri(dlg.FileName));
                    PictureBoxQ.Source = img;
                    string filename = dlg.FileName;
                    command.Parameters.AddWithValue("@PersonImage", ImageToByte(PictureBoxQ.Source));
                    cnn1.Open();
                    command.ExecuteNonQuery();
                    cnn1.Close();
                    BindGrid();

                    MessageBox.Show(dlg.FileName + "1");
                }
                catch(Exception ex)
                {
                    MessageBox.Show("خطای برقراری ارتباط با پایگاه داده","خطا",MessageBoxButton.OK,MessageBoxImage.Error);
                }
            }*/
           



        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            MessageBoxResult res= MessageBox.Show("آیا برای خروج از حساب کاربری اطمینان داررید؟", "!", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (res == MessageBoxResult.Yes)
            {
                MainWindow m1 = new MainWindow();
                m1.Show();
                this.Close();
            }
        }
    }
}

