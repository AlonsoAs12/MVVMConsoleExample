using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMConsoleExample
{
    public class MainViewModel
    {
        private Model _model;

        public MainViewModel()
        {
            _model = new Model();
        }

        public double Valor1
        {
            get { return _model.Valor1; }
            set
            {
                _model.Valor1 = value;
                ActualizarResultados();
            }
        }

        public double Valor2
        {
            get { return _model.Valor2; }
            set
            {
                _model.Valor2 = value;
                ActualizarResultados();
            }
        }

        public double Valor3
        {
            get { return _model.Valor3; }
            set
            {
                _model.Valor3 = value;
                ActualizarResultados();
            }
        }

        public double Suma { get; private set; }
        public double Producto { get; private set; }

        private void ActualizarResultados()
        {
            Suma = Valor1 + Valor2 + Valor3;
            Producto = Valor1 * Valor2 * Valor3;
        }
    }
}