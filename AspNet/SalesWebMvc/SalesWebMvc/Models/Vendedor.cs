using System;
using System.Collections.Generic;
using System.Linq;

namespace SalesWebMvc.Models
{
    public class Vendedor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataAniversario { get; set; }
        public double SalarioBase { get; set; }
        public Departamento Departamento { get; set; }
        public int DepartamentoId { get; set; }
        public ICollection<RegistroDeVendas> Vendas { get; set; } = new List<RegistroDeVendas>();

        public Vendedor()
        {
        }

        public Vendedor(int id, string nome, string email, DateTime dataAniversario, double salarioBase, Departamento departamento)
        {
            Id = id;
            Nome = nome;
            Email = email;
            DataAniversario = dataAniversario;
            SalarioBase = salarioBase;
            Departamento = departamento;
        }

        public void AddVendas(RegistroDeVendas rv)
        {
            Vendas.Add(rv);
        }

        public void RemoveVendas(RegistroDeVendas rv)
        {
            Vendas.Remove(rv);
        }

        public double TotalVendas(DateTime inicialDt, DateTime finalDt)
        {

            return Vendas.Where(rv => rv.Data >= inicialDt && rv.Data <= finalDt).Sum(rv => rv.Valor);
        }
    }
}
