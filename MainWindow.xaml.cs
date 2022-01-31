using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static int caracter = 0;
        public static int num = 0;
        public static int resultado = 0;
        public static char operador= ' ';
        public static string numero = "";
        public static string operacion= "";

        public MainWindow()
        {
            InitializeComponent();

        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            CheckBox cb = (CheckBox)sender;

            if (cb.IsChecked == true)

                pbProgreso.Value++;

            if (cb.IsChecked == false)

                pbProgreso.Value--;

            txtProgres.Text = Convert.ToString(pbProgreso.Value);
            txtProgres.Text = txtProgres.Text + "/5";

        }

        private void rbAtletico_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton rb = (RadioButton)sender;

            if (rb.Content.ToString() == "Atletico de Madrid")

                pbProgreso.Value++;
            else
                pbProgreso.Value--;

            txtProgres.Text = Convert.ToString(pbProgreso.Value);
            txtProgres.Text = txtProgres.Text + "/5";
        }

        private void txtDescripcion_TextChanged(object sender, TextChangedEventArgs e)
        {

            if (txtDescripcion.Text != "")

                if (caracter < 1)
                {
                    pbProgreso.Value++;
                    caracter++;
                }
            if (txtDescripcion.Text == "")
            {
                pbProgreso.Value--;
                caracter--;
            }
            txtProgres.Text = Convert.ToString(pbProgreso.Value);
            txtProgres.Text = txtProgres.Text + "/5";
        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;

            txtPantalla.Text = Convert.ToString(btn.Content);
            numero = txtPantalla.Text;

            if(resultado != num) 
            {
                num = Convert.ToInt32(btn.Content);
                resultado = num;
            }
            else
            {
                num = Convert.ToInt32(btn.Content);

                txtPantalla.Text = resultado + " " + operador + " " + btn.Content;
            }
                     
        }
        private void btnoperador_Click(object sender, RoutedEventArgs e)
        {
            Button oper = (Button)sender;

            txtPantalla.Text = numero + " " + oper.Content;
            operador = Convert.ToChar(oper.Content);

            if (oper.Content.ToString() == "=")
            {
                switch (operador)
                {
                    case '+':
                        resultado = resultado + num;
                        break;
                    case '-':
                        resultado = resultado - num;
                        break;
                    case '*':
                        resultado = resultado * num;
                        break;
                    case '/':
                        resultado = resultado / num;
                        break;
                }
            }
                txtPantalla.Text = Convert.ToString(resultado);
        }
        private void btnC_Click(object sender, RoutedEventArgs e)
        {
            resultado = 0;
            txtPantalla.Text = "0";
            
        }

       
    }
}
