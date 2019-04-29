using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TamagochiWork1.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Profile : ContentPage
    {
        public int ochko = 25;
        public int olvl;
        public int ohp1;
        public int oresp;
        public int osila;
        public int olovkost;
        public int Vohp1 = 14;
        public int Voresp = 24;
        public int Vosila = 6;
        public int Volovkost = 8;
        public int Vointelect;
        public int ointelect;
        public int ochar1;

        public Profile()
        {
            InitializeComponent();
        }
        private async void exp1(object sender, EventArgs e)
        {
            olvl = ochko;
            ochko1.Text = "Доступно очков :" + ochko;
            lvl1.Text = "Уровень :" + olvl;
            hp.Text = "Здоровье :" + ohp1;
            sila1.Text = "Сила :" + osila;
            lovkost1.Text = "Ловкость :" + olovkost;
            intelect1.Text = "Интелект :" + ointelect;
            await DisplayAlert("Поздравляем!", "За установку вам начислено 25 баллов!", "Ok");
        }
        private async void BOI(object sender, EventArgs e)
        {
            ochko1.IsVisible = false;
            lvl1.IsVisible = false;
            hp.IsVisible = false;


            hpP1.IsVisible = false;
            sila1.IsVisible = false;
            silaP1.IsVisible = false;

            lovkost1.IsVisible = false;
            lovkostP1.IsVisible = false;
            intelect1.IsVisible = false;

            intelectP1.IsVisible = false;
            B.IsVisible = false;

            U.IsVisible = true;
            PP.IsVisible = true;
            PP.IsVisible = true;

            PIC.IsVisible = true;
            SLOW.IsVisible = true;

            Ye.IsVisible = true;
            Vrag.IsVisible = true;
            Ye.Text = "Уровень :"+ olvl + "Здоровье :" + ohp1 + "Сила :"+ osila + "Ловкость :"+ olovkost + "Интелект :"+ ointelect;
            Vrag.Text = "Уровень :" + 14 + "Здоровье :" + Vohp1 + "Сила :" + Vosila + "Ловкость :" + Volovkost + "Интелект :" + Vointelect;
            if (ohp1 <= 0)
            {
                Ye.Text = "Вы проиграли!";
                ochko1.IsVisible = true;
                lvl1.IsVisible = true;
                hp.IsVisible = true;


                hpP1.IsVisible = true;
                sila1.IsVisible = true;
                silaP1.IsVisible = true;

                lovkost1.IsVisible = true;
                lovkostP1.IsVisible = true;
                intelect1.IsVisible = true;

                PIC.IsVisible = false;
                SLOW.IsVisible = false;
                U.IsVisible = false;
                PP.IsVisible = false;
                PP.IsVisible = false;

                B.IsVisible = true;
            }
            if (Vohp1 <= 0)
            {
                Ye.Text = "Вы победили!";
                ochko1.IsVisible = true;
                lvl1.IsVisible = true;
                hp.IsVisible = true;


                hpP1.IsVisible = true;
                sila1.IsVisible = true;
                silaP1.IsVisible = true;

                lovkost1.IsVisible = true;
                lovkostP1.IsVisible = true;
                intelect1.IsVisible = true;
                B.IsVisible = true;
                U.IsVisible = false;
                PP.IsVisible = false;
                PP.IsVisible = false;
                PIC.IsVisible = false;
                SLOW.IsVisible = false;
                intelectP1.IsVisible = true;
            }
        }
        private async void udar(object sender, EventArgs e)
        {
            Vohp1 = Vohp1 - 1;
            ohp1 = ohp1 - 1;
            Ye.Text = "Уровень : " + olvl + " Здоровье : " + ohp1 + " Сила : " + osila + " Ловкость : " + olovkost + " Интелект : " + ointelect;
            Vrag.Text = "Уровень : " + 14 + " Здоровье : " + Vohp1 + " Сила : " + Vosila + " Ловкость : " + Volovkost + " Интелект : " + Vointelect;
            if (ohp1 <= 0)
            {
                Ye.Text = "Вы проиграли!";
                ochko1.IsVisible = true;
                lvl1.IsVisible = true;
                hp.IsVisible = true;
                B.IsVisible = true;
                U.IsVisible = false;
                PP.IsVisible = false;
                PP.IsVisible = false;
                hpP1.IsVisible = true;
                sila1.IsVisible = true;
                silaP1.IsVisible = true;

                lovkost1.IsVisible = true;
                lovkostP1.IsVisible = true;
                intelect1.IsVisible = true;
                PIC.IsVisible = false;
                SLOW.IsVisible = false;
                intelectP1.IsVisible = true;
            }
            if (Vohp1 <= 0)
            {
                Ye.Text = "Вы победили!";
                ochko1.IsVisible = true;
                lvl1.IsVisible = true;
                hp.IsVisible = true;
                P.IsVisible = false;
                PP.IsVisible = false;
                PP.IsVisible = false;
                B.IsVisible = true;
                hpP1.IsVisible = true;
                sila1.IsVisible = true;
                silaP1.IsVisible = true;
                PIC.IsVisible = false;
                SLOW.IsVisible = false;
                lovkost1.IsVisible = true;
                lovkostP1.IsVisible = true;
                intelect1.IsVisible = true;

                intelectP1.IsVisible = true;
            }
        }
        private async void gd(object sender, EventArgs e)
        {
            ohp1 = ohp1 - 1;
            Ye.Text = "Уровень : " + olvl + " Здоровье : " + ohp1 + " Сила : " + osila + " Ловкость : " + olovkost + " Интелект : " + ointelect;
            Vrag.Text = "Уровень : " + 14 + " Здоровье : " + Vohp1 + " Сила : " + Vosila + " Ловкость : " + Volovkost + " Интелект : " + Vointelect;
            if (ohp1 <= 0)
            {
                Ye.Text = "Вы проиграли!";
                ochko1.IsVisible = true;
                lvl1.IsVisible = true;
                hp.IsVisible = true;
                B.IsVisible = true;
                U.IsVisible = false;
                PP.IsVisible = false;
                PP.IsVisible = false;
                hpP1.IsVisible = true;
                sila1.IsVisible = true;
                silaP1.IsVisible = true;
                PIC.IsVisible = false;
                SLOW.IsVisible = false;
                lovkost1.IsVisible = true;
                lovkostP1.IsVisible = true;
                intelect1.IsVisible = true;

                intelectP1.IsVisible = true;
            }
            if (Vohp1 <= 0)
            {
                Ye.Text = "Вы победили!";
                ochko1.IsVisible = true;
                lvl1.IsVisible = true;
                hp.IsVisible = true;
                B.IsVisible = true;
                U.IsVisible = false;
                PP.IsVisible = false;
                PP.IsVisible = false;
                hpP1.IsVisible = true;
                sila1.IsVisible = true;
                silaP1.IsVisible = true;
                PIC.IsVisible = false;
                SLOW.IsVisible = false;
                lovkost1.IsVisible = true;
                lovkostP1.IsVisible = true;
                intelect1.IsVisible = true;

                intelectP1.IsVisible = true;
            }
        }
        private async void xil(object sender, EventArgs e)
        {
            ohp1 = ohp1 + 2;
            ohp1 = ohp1 - 1;
            Ye.Text = "Уровень : " + olvl + " Здоровье : " + ohp1 + " Сила : " + osila + " Ловкость : " + olovkost + " Интелект : " + ointelect;
            Vrag.Text = "Уровень : " + 14 + " Здоровье : " + Vohp1 +  " Сила : " + Vosila + " Ловкость : " + Volovkost + " Интелект : " + Vointelect;
            if (ohp1 <= 0)
            {
                Ye.Text = "Вы проиграли!";
                ochko1.IsVisible = true;
                lvl1.IsVisible = true;
                hp.IsVisible = true;
                B.IsVisible = true;
                U.IsVisible = false;
                PP.IsVisible = false;
                PP.IsVisible = false;
                hpP1.IsVisible = true;
                sila1.IsVisible = true;
                silaP1.IsVisible = true;

                lovkost1.IsVisible = true;
                lovkostP1.IsVisible = true;
                intelect1.IsVisible = true;
                PIC.IsVisible = false;
                SLOW.IsVisible = false;
                intelectP1.IsVisible = true;
            }
            if (Vohp1 <= 0)
            {
                Ye.Text = "Вы победили!";
                ochko1.IsVisible = true;
                lvl1.IsVisible = true;
                hp.IsVisible = true;
                B.IsVisible = true;
                PIC.IsVisible = false;
                SLOW.IsVisible = false;
                hpP1.IsVisible = true;
                sila1.IsVisible = true;
                silaP1.IsVisible = true;
                U.IsVisible = false;
                PP.IsVisible = false;
                PP.IsVisible = false;
                lovkost1.IsVisible = true;
                lovkostP1.IsVisible = true;
                intelect1.IsVisible = true;

                intelectP1.IsVisible = true;
            }
        }
        private async void lvl(object sender, EventArgs e)
        {
            
            

            hpP1.IsVisible = false;

          /*  respP1.IsVisible = false;
            respL1.IsVisible = false;*/

            silaP1.IsVisible = false;

            lovkostP1.IsVisible = false;

            intelectP1.IsVisible = false;

        /*    charP1.IsVisible = false;
            charL1.IsVisible = false;*/

            lvl1.Text = "Уровень :" + olvl;
        }
        private async void lvlP(object sender, EventArgs e)
        {
            
        }
        private async void lvlL(object sender, EventArgs e)
        {
            
        }

        private async void hp1(object sender, EventArgs e)
        {

            hpP1.IsVisible = true;

          /*  respP1.IsVisible = false;
            respL1.IsVisible = false;*/

            silaP1.IsVisible = false;

            lovkostP1.IsVisible = false;

            intelectP1.IsVisible = false;

          /*  charP1.IsVisible = false;
            charL1.IsVisible = false;*/

            hp.Text = "Здоровье :" + ohp1;
        }
        private async void hpP(object sender, EventArgs e)
        {
            if (ochko>0)
            {
                ochko = ochko - 1;
                ohp1 = ohp1 + 1;
                hp.Text = "Здоровье :" + ohp1;
                ochko1.Text = "Доступно очков :" + ochko;
            }
           
        }
        private async void hpL(object sender, EventArgs e)
        {
            await DisplayAlert("Отличная работа!", "+1HP; +1LVL", "Ok");
        }

       /*private async void resp(object sender, EventArgs e)
        {
            lvlP1.IsVisible = false;
            lvlL1.IsVisible = false;

            hpP1.IsVisible = false;
            hpL1.IsVisible = false;

            respP1.IsVisible = true;
            respL1.IsVisible = true;

            silaP1.IsVisible = false;
            silaL1.IsVisible = false;

            lovkostP1.IsVisible = false;
            lovkostL1.IsVisible = false;

            intelectP1.IsVisible = false;
            intelectL1.IsVisible = false;

            charP1.IsVisible = false;
            charL1.IsVisible = false;

            resp1.Text = "Здоровье :" + ohp1;
        }
        private async void respP(object sender, EventArgs e)
        {
            ochko = ochko - 1;
            oresp = oresp + 1;
            resp1.Text = "Здоровье :" + ohp1;
        }
        private async void respL(object sender, EventArgs e)
        {
            await DisplayAlert("Отличная работа!", "+1HP; +1LVL", "Ok");
        }*/

        private async void sila(object sender, EventArgs e)
        {
            

            hpP1.IsVisible = false;

         /*   respP1.IsVisible = false;
            respL1.IsVisible = false;*/

            silaP1.IsVisible = true;

            lovkostP1.IsVisible = false;

            intelectP1.IsVisible = false;
/*
            charP1.IsVisible = false;
            charL1.IsVisible = false;*/

            sila1.Text = "Сила :" + osila;
        }
        private async void silaP(object sender, EventArgs e)
        {
            if (ochko > 0)
            {
                ochko = ochko - 1;
                osila = osila + 1;
                sila1.Text = "Сила :" + osila;
                ochko1.Text = "Доступно очков :" + ochko;
            }
                
           
        }
        private async void silaL(object sender, EventArgs e)
        {
            await DisplayAlert("Отличная работа!", "+1HP; +1LVL", "Ok");
        }

        private async void lovkost(object sender, EventArgs e)
        {
            

            hpP1.IsVisible = false;

          /*  respP1.IsVisible = false;
            respL1.IsVisible = false;*/

            silaP1.IsVisible = false;

            lovkostP1.IsVisible = true;

            intelectP1.IsVisible = false;

         /*   charP1.IsVisible = false;
            charL1.IsVisible = false;*/

            lovkost1.Text = "Ловкость :" + olovkost;
        }
        private async void lovkostP(object sender, EventArgs e)
        {
            if (ochko > 0)
            {
                ochko = ochko - 1;
                olovkost = olovkost + 1;
                lovkost1.Text = "Ловкость :" + olovkost;
                ochko1.Text = "Доступно очков :" + ochko;
            }
                
            
        }
        private async void lovkostL(object sender, EventArgs e)
        {
            await DisplayAlert("Отличная работа!", "+1HP; +1LVL", "Ok");
        }

        private async void intelect(object sender, EventArgs e)
        {
            
         

            hpP1.IsVisible = false;

         /*   respP1.IsVisible = false;
            respL1.IsVisible = false;*/

            silaP1.IsVisible = false;

            lovkostP1.IsVisible = false;

            intelectP1.IsVisible = true;

           /* charP1.IsVisible = false;
            charL1.IsVisible = false;*/

            intelect1.Text = "Интелект :" + ointelect;
        }
        private async void intelectP(object sender, EventArgs e)
        {
            if (ochko > 0)
            {
                ochko = ochko - 1;
                ointelect = ointelect + 1;
                intelect1.Text = "Интелект :" + ointelect;
                ochko1.Text = "Доступно очков :" + ochko;
            }
                
            
        }
        private async void intelectL(object sender, EventArgs e)
        {
            await DisplayAlert("Отличная работа!", "+1HP; +1LVL", "Ok");
        }

      /*  private async void char1 (object sender, EventArgs e)
        {
            lvlP1.IsVisible = false;
            lvlL1.IsVisible = false;

            hpP1.IsVisible = false;
            hpL1.IsVisible = false;

            respP1.IsVisible = false;
            respL1.IsVisible = false;

            silaP1.IsVisible = false;
            silaL1.IsVisible = false;

            lovkostP1.IsVisible = false;
            lovkostL1.IsVisible = false;

            intelectP1.IsVisible = false;
            intelectL1.IsVisible = false;

            charP1.IsVisible = true;
            charL1.IsVisible = true;

            charr.Text = "Харизма :" + ochar1;
        }
        private async void charP(object sender, EventArgs e)
        {
            ochko = ochko - 1;
            ochar1 = ochar1 + 1;
            charr.Text = "Харизма :" + ochar1;
        }
        private async void charL(object sender, EventArgs e)
        {
            await DisplayAlert("Отличная работа!", "+1HP; +1LVL", "Ok");
        }
        */
}
}