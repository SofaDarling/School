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

namespace School
{
    /// <summary>
    /// Логика взаимодействия для Admin.xaml
    /// </summary>
    public partial class Admin : Page
    {
        List<Service> ServiswList = Base.tE.Service.ToList();
        public Admin()
        {
            InitializeComponent();
            List<Service> ServiseList = Base.tE.Service.ToList();
            DGServises.ItemsSource = ServiseList;
        }
        int i = -1;
        private void MediaElement_Initialized(object sender, EventArgs e)
        {
            if (i < ServiswList.Count)
            {
                i++;
                MediaElement ME = (MediaElement)sender;
                Service S = ServiswList[i];
                Uri U = new Uri(S.MainImagePath, UriKind.RelativeOrAbsolute);
                ME.Source = U;
                //   i++;
            }

        }

        private void StackPanel_Initialized(object sender, EventArgs e)
        {
            if (i < ServiswList.Count)
            {
                StackPanel SP = (StackPanel)sender;
                Service S = ServiswList[i];
                if (S.Discount != 0)
                {
                    SP.Background = new SolidColorBrush(Color.FromRgb(231, 250, 191));
                }
            }

        }

        private void TextBlock_Initialized(object sender, EventArgs e)
        {
            if (i < ServiswList.Count)
            {
                TextBlock TB = (TextBlock)sender;
                Service S = ServiswList[i];
                TB.Text = S.Title;
                //  i++;
            }


        }

        private void BRed_Initialized(object sender, EventArgs e)
        {
            Button BtnRed = (Button)sender;
            if (BtnRed != null)
            {
                BtnRed.Uid = Convert.ToString(i);
            }


        }

        private void BRed_Click(object sender, RoutedEventArgs e)
        {
            Button BtnRed = (Button)sender;
            int ind = Convert.ToInt32(BtnRed.Uid);
            Service S = ServiswList[ind];
            MessageBox.Show(S.Title);


        }

        private void BDel_Initialized(object sender, EventArgs e)
        {
            Button BtnDel = (Button)sender;
            if (BtnDel != null)
            {
                BtnDel.Uid = Convert.ToString(i);
            }



        }

        private void BDel_Click(object sender, RoutedEventArgs e)
        {
            Button BtnRed = (Button)sender;
            if (BtnRed != null)
            {
                BtnRed.Uid = Convert.ToString(i);
            }


        }

        private void BAdd_Initialized(object sender, EventArgs e)
        {
            Button BtnAdd = (Button)sender;
            if (BtnAdd != null)
            {
                BtnAdd.Uid = Convert.ToString(i);
            }


        }

        private void BAdd_Click(object sender, RoutedEventArgs e)
        {
            Button BtnAdd = (Button)sender;
            if (BtnAdd != null)
            {
                BtnAdd.Uid = Convert.ToString(i);
            }

        }

        private void TextBlock_Initialized_1(object sender, EventArgs e)
        {
            if (i < ServiswList.Count)
            {
                TextBlock PriceService = (TextBlock)sender;
                Service ObjectService = ServiswList[i];
                int cost = Convert.ToInt32(ObjectService.Cost);
                if (ObjectService.Discount != 0)
                {
                    PriceService.Visibility = Visibility.Visible;
                    PriceService.Text = cost.ToString();
                    PriceService.TextDecorations = TextDecorations.Strikethrough;
                }
            }
        }

        private void TextBlock_Initialized_2(object sender, EventArgs e)
        {
            if (i < ServiswList.Count)
            {
                TextBlock PriceService = (TextBlock)sender;
                Service ObjectService = ServiswList[i];
                int NewDiscount = Convert.ToInt32(ObjectService.Discount * 100);
                int NewPrice = Convert.ToInt32(ObjectService.Cost * 100 - (ObjectService.Cost * NewDiscount)) / 100;
                PriceService.Text = " " + Convert.ToString(NewPrice) + " рублей за " + ObjectService.DurationInSeconds / 60 + " минут";
            }

        }

        private void TextBlock_Initialized_3(object sender, EventArgs e)
        {
            if (i < ServiswList.Count)
            {

                TextBlock PriceService = (TextBlock)sender;
                Service ObjectService = ServiswList[i];
                if (ObjectService.Discount != 0)
                {
                    PriceService.Text = "* скидка " + ObjectService.Discount * 100 + " %";
                }

            }

        }
    }
}
