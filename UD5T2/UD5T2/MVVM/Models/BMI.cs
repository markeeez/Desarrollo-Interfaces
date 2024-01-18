using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UD5T2.MVVM.Models
{
    public class BMI : INotifyPropertyChanged
    {
        public float altura;
        public float Altura
        {
            get { return altura; }
            set
            {
                if (altura != value)
                {
                    altura = value;
                    OnPropertyChanged(nameof(Altura));
                    OnPropertyChanged(nameof(Resultado));
                    OnPropertyChanged(nameof(ResultadoBMI));
                }
            }
        }

        public float peso;
        public float Peso
        {
            get { return peso; }
            set
            {
                if (peso != value)
                {
                    peso = value;
                    OnPropertyChanged(nameof(Peso));
                    OnPropertyChanged(nameof(Resultado));
                    OnPropertyChanged(nameof(ResultadoBMI));
                }
            }
        }

        public float Resultado
        {
            get
            {
                if (Altura != 0)
                {
                    return Peso / (Altura * Altura) * 10000;
                }
                else
                {
                    return 0;
                }
            }
        }

        public string ResultadoBMI
        {
            get
            {
                if (Resultado <= 16)
                {
                    return "BMI: Delgado Severo";
                }
                else if (Resultado <= 17)
                {
                    return "BMI: Delgado Moderado";
                }
                else if (Resultado <= 18.5)
                {
                    return "BMI: Delgado Medio";
                }
                else if (Resultado <= 25)
                {
                    return "BMI: Normal";
                }
                else if (Resultado <= 30)
                {
                    return "BMI: Sobrepeso";
                }
                else if (Resultado <= 35)
                {
                    return "BMI: Obesidad Clase I";
                }
                else if (Resultado <= 40)
                {
                    return "BMI: Obesidad Clase II";
                }
                else
                {
                    return "BMI: Obesidad Clase III";
                }
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
