using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace AppCustoViagemBySamuel.Model
{
    public class viagem
    {
        public int Id { get; set; }
        public string Origem { get; set; }
        public string Destino { get; set; }
        public double Distancia { get; set; }
        public double Consumo { get; set; }
        public double PrecoGasolina { get; set; }
    }
}
