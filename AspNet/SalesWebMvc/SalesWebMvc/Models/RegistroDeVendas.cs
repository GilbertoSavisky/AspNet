using System;
using SalesWebMvc.Models.Enums;
namespace SalesWebMvc.Models
{
    public class RegistroDeVendas
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public double Valor { get; set; }
        public StatusDaVenda statusDaVenda { get; set; }
        public Vendedor Vendedor { get; set; }

        public RegistroDeVendas(){}

        public RegistroDeVendas(int id, DateTime data, double valor, StatusDaVenda statusDaVenda, Vendedor vendedor)
        {
            Id = id;
            Data = data;
            Valor = valor;
            this.statusDaVenda = statusDaVenda;
            Vendedor = vendedor;
        }
    }
}
