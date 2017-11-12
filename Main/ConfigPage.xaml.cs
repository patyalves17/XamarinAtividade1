using System;
using System.Collections.Generic;
using System.ComponentModel;

using Xamarin.Forms;

namespace Main
{
    public partial class ConfigPage : ContentPage
    {
        bool recebe;
        String email;


        public String Email{
            get { return email; }
            set { 
                email = value;
            }
        }

        public bool Recebe {
            get { return recebe;  }
            set { recebe = value; }
        }

        public ConfigPage()
        {
            InitializeComponent();
            swRecebe_Switched(null, null);
        }

        public void swRecebe_Switched(Object sender, EventArgs e){
            if(swfCell.On){
                entryEmail.IsEnabled = true;
                recebe = true;
            }else{
                entryEmail.IsEnabled = false;
                recebe = false;
            }
        }

        public void email_Completed(Object sender, EventArgs e){
            email = entryEmail.Text;
        }

     

       

    }
}
