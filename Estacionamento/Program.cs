

using Estacionamento.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        List<string?> veiculos = new List<string?>();
        string? placaVeiculo;
        string? opcaoUsuario;
        bool exibirMenu = true;
        decimal valorBase;
        decimal valorHora;

        Menu menu = new Menu();
        Veiculo veiculo = new Veiculo(veiculos);

        menu.ValorBase();
        while(!decimal.TryParse(Console.ReadLine(), out valorBase))
        {
            Console.WriteLine("Erro, por favor informe um valor valido.");
            Console.Write("Digite: ");
        }
        menu.ValorHora();
        while(!decimal.TryParse(Console.ReadLine(), out valorHora)){
            Console.WriteLine("Erro, por favor informe um valor valido.");
            Console.Write("Digite: ");
        }

        while (exibirMenu)
        {

            menu.Main();
            opcaoUsuario = Console.ReadLine();

            switch (opcaoUsuario)
            {
                case "1": menu.AdicionarVeiculo(); placaVeiculo = Console.ReadLine(); veiculo.AdicionarVeiculo(placaVeiculo); Console.WriteLine("\nPressione para continuar..."); Console.ReadKey(); break;
                case "2": menu.RemoverVeiculo(); Console.Write("\nPLACAS VEICULOS\n\n"); veiculo.ListarVeiculo(); Console.Write("\nDigite: "); placaVeiculo = Console.ReadLine(); veiculo.RemoverVeiculo(placaVeiculo); Console.WriteLine("\nPressione para continuar..."); Console.ReadKey(); break;
                case "3": menu.ListarVeiculo(); veiculo.ListarVeiculo(); Console.WriteLine("\nPressione para continuar..."); Console.ReadKey(); break;
                case "4":
                    menu.FecharContaVeiculo();
                    Console.Write("\nPLACAS VEICULOS\n\n"); veiculo.ListarVeiculo(); Console.Write("\nDigite: ");
                    placaVeiculo = Console.ReadLine();
                    bool validacao = veiculo.VerificarPlarcaExistente(placaVeiculo);
                    if (validacao){
                        try{
                            menu.FecharContaVeiculoHoras();
                            decimal horasVeiculo = Convert.ToDecimal(Console.ReadLine());
                            veiculo.FecharContaVeiculo(placaVeiculo,valorBase, valorHora, horasVeiculo);
                            Console.WriteLine("\nPressione para continuar..."); Console.ReadKey();
                        }
                        catch(Exception){
                            Console.WriteLine("Erro, por favor tente novamente.");
                            Console.ReadKey();
                        }
                    }
                    else{
                        Console.WriteLine("Erro, por favor tente novamente.");
                        Console.ReadKey();
                    }

                    break;
                case "5": menu.Encerrar(); exibirMenu = false; break;
                default: Console.WriteLine("\nPor favor, tente novamente..."); Console.ReadKey(); break;
            }


        }
    }
}