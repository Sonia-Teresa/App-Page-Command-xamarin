using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace AppBindinCommands
{


    public class MainPageViewModel : INotifyPropertyChanged 
     
    {
        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name)); 
        }
        public ICommand ShowMessegeCommand; //declaraçaõ de como se fosse um botão 
        private string name =  string .Empty;// Ctrol+R+E para criar a propriedede
        public string Name 
        {
            get { return  name; } //get => name

            set
            {
                if (name == null)
                    return; 
              name = value;

              name = value; 
                OnPropertyChanged(nameof(name));
                OnPropertyChanged(nameof(DisplayName));


            }
        }

        public string DisplayName => $"Nome digitado: {Name}"; //pront+tab 


        string displayMessege = string.Empty;

        public string DisplayMesege
        {
            get => displayMessege;
            set
            {
                if (displayMessege == null)
                    return;
                displayMessege = value;
                OnPropertyChanged(nameof(DisplayMesege));
            }
        }
        public void ShowMessege()
        {
            string dataProperty = Application.Current.Properties["dtAtual"].ToString();
            displayMessege = $"Boa noite {Name}. Hoje é {dataProperty}.";
        }

        public MainPageViewModel ()
        {
            ShowMessegeCommand = new Command(ShowMessege);
        }



    }

       
}

