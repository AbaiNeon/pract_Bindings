using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace pract_Bindings
{
    public class Сurrency : INotifyPropertyChanged
    {
        private int id;
        private string nameKaz;
        private string unit;
        private string ratio;
        private string nameRus;
        private string exchangeRates;
        private string code;

        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
                OnPropertyChanged("Id");
            }
        }
        [JsonProperty("name_kaz")]
        public string NameKaz
        {
            get
            {
                return nameKaz;
            }
            set
            {
                nameKaz = value;
                OnPropertyChanged("NameKaz");
            }
        }

        [JsonProperty("edinica_izmerenia")]
        public string Unit
        {
            get
            {
                return unit;
            }
            set
            {
                unit = value;
                OnPropertyChanged("Unit");
            }
        }

        [JsonProperty("sootnowenie")]
        public string Ratio
        {
            get
            {
                return ratio;
            }
            set
            {
                ratio = value;
                OnPropertyChanged("Ratio");
            }
        }

        [JsonProperty("name_rus")]
        public string NameRus
        {
            get
            {
                return nameRus;
            }
            set
            {
                nameRus = value;
                OnPropertyChanged("NameRus");
            }
        }

        [JsonProperty("kurs")]
        public string ExchangeRates
        {
            get
            {
                return exchangeRates;
            }
            set
            {
                exchangeRates = value;
                OnPropertyChanged("ExchangeRates");
            }
        }

        [JsonProperty("kod")]
        public string Code
        {
            get
            {
                return code;
            }
            set
            {
                code = value;
                OnPropertyChanged("Code");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName]string propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }

        }
    }
}
