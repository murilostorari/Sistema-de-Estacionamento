using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace Estacionamento.Models
{
    public class Veiculo
    {

        public List<string?> Veiculos { get; set; }
        public Veiculo(List<string?> veiculos)
        {
            this.Veiculos = veiculos;
        }
        public void AdicionarVeiculo(string? veiculo)
        {
            bool validacao = VerificarPlarcaExistente(veiculo);
            if (!validacao)
            {
                Veiculos.Add(veiculo);
                Console.WriteLine("\nVeículo adicionado....");
            }
            else
                Console.WriteLine("\nNão foi possivel, veiculo existente.");
        }

        public void RemoverVeiculo(string? veiculo)
        {
            bool validacao = VerificarPlarcaExistente(veiculo);
            if (validacao)
            {
                Veiculos.Remove(veiculo);
                Console.WriteLine("\nVeículo deletado....");
            }
            else
                Console.WriteLine("\nNão foi possivel, placa não existente.");
        }
        public void ListarVeiculo()
        {
            if (Veiculos.Count == 0)
            {
                Console.WriteLine("Sem veículos cadastrados.");
            }
            else
            {
                foreach (var item in Veiculos)
                {
                    Console.WriteLine(item);
                }
            }
        }

        public void FecharContaVeiculo(string? veiculo,decimal valorBase, decimal valorHoras, decimal horasVeiculo)
        {
            decimal valorTotal = (horasVeiculo * valorHoras) + valorBase;
            Console.Clear();
            Console.WriteLine("\nNOTA FISCAL");
            Console.WriteLine($"\nESTABELECIMENTO: ESTACIONAMENTO DEV FRACO");
            Console.WriteLine($"\nCPNJ: 09.401.131/0001-55");
            Console.WriteLine($"\nFORMA DE PAGAMENTO SELECIONADA: PIX");
            Console.WriteLine($"\nTOTAL A PAGAR: R${valorTotal:F2}");
            Console.WriteLine("\nPROCESSANDO PAGAMENTO.....");
            Console.WriteLine("\nPAGAMENTO REALIZADO COM SUCESSO!\n");
            Veiculos.Remove(veiculo);
        }

        public bool VerificarPlarcaExistente(string? veiculo)
        {
            if (Veiculos.Contains(veiculo))
                return true;
            else
                return false;
        }
    }
}