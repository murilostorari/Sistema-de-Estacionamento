using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace Estacionamento.Models
{
    public class Menu
    {
        public void Main()
        {
            Console.Clear();
            Console.WriteLine("\nEscolha uma opção: \n");
            Console.WriteLine("\n1 - Adicionar um veículo");
            Console.WriteLine("\n2 - Remover um veículo");
            Console.WriteLine("\n3 - Listar veículos");
            Console.WriteLine("\n4 - Fechar conta veículo");
            Console.WriteLine("\n5 - Encerrar");
            Console.Write("\nDigite: ");
        }

        public void ValorBase()
        {
            Console.Clear();
            Console.WriteLine("\nBem-vindo");
            Console.WriteLine("\nPara continuar, por favor informe o valor base do estacionamento...");
            Console.Write("\nValor Base: ");
        }
        public void ValorHora()
        {
            Console.Clear();
            Console.WriteLine("\nTudo certo...");
            Console.WriteLine("\nAgora informe o valor da hora do estacionamento...");
            Console.Write("\nValor Hora: ");
        }
        public void AdicionarVeiculo()
        {
            Console.Clear();
            Console.WriteLine("--------------------------");
            Console.WriteLine("\nADICIONANDO VEÍCULO\n");
            Console.WriteLine("\nPor Favor, informe a placa do veiculo.");
            Console.Write("\nDigite: ");
        }
        public void RemoverVeiculo()
        {
            Console.Clear();
            Console.WriteLine("--------------------------");
            Console.WriteLine("\nREMOVENDO VEÍCULO");
            Console.WriteLine("\nPor Favor, informe a placa do veiculo.\n");
        }
        public void ListarVeiculo()
        {
            Console.Clear();
            Console.WriteLine("--------------------------");
            Console.WriteLine("\nLISTANDO VEÍCULOS\n");
        }
        public void FecharContaVeiculo(){
            Console.Clear();
            Console.WriteLine("--------------------------");
            Console.WriteLine("\nFECHAMENTO CONTA VEÍCULO\n");
            Console.WriteLine("\nPor Favor, informe a placa do veiculo.");
        }
        public void FecharContaVeiculoHoras(){
            Console.Clear();
            Console.WriteLine("--------------------------");
            Console.WriteLine("\nFECHAMENTO CONTA VEÍCULO\n");
            Console.WriteLine("\nPor Favor, informe as horas permanecidas no estacionamento...");
            Console.Write("\nDigite: ");
        }
        public void Encerrar()
        {
            Console.Clear();
            Console.WriteLine("--------------------------");
            Console.WriteLine("\nENCERRANDO\n");
            Console.WriteLine("\nOBRIGADO POR UTILIZAR NOSSO SISTEMA!");
        }

    }
}