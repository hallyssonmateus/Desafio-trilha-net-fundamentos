namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            // TODO: Pedir para o usuário digitar uma placa (ReadLine) e adicionar na lista "veiculos"
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = Console.ReadLine();
            veiculos.Add(placa);
            Console.WriteLine("Veiculos Adicionados com sucesso!");            
        }

        public void RemoverVeiculo()
        {
            // Pedir para o usuário digitar a placa e armazenar na variável placa
            Console.WriteLine("Digite a placa do veículo para remover:");
            string placa = Console.ReadLine();
            

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                // TODO: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
                Console.WriteLine("Digite a quantidade de horas que o veiculo permaneceu no estacionamento:");
                // TODO: Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal                
                int horas = 0; 
                horas = int.Parse(Console.ReadLine());
                decimal valorTotal = precoInicial + (precoPorHora*horas);

                // TODO: Remover a placa digitada da lista de veículos
                veiculos.Remove(placa);

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void AtualizarVeiculo()
        {
            Console.WriteLine("Digite a placa atual do veículo que deseja atualizar:");
            string placaAtual = Console.ReadLine();
            // Verifica se o veículo existe
    if (veiculos.Any(x => x.ToUpper() == placaAtual.ToUpper()))
    {
        Console.WriteLine("Digite a nova placa do veículo:");
        string novaPlaca = Console.ReadLine();

        // Remove a placa antiga e adiciona a nova
        int indice = veiculos.IndexOf(placaAtual);
        if (indice >= 0)
        {
            veiculos[indice] = novaPlaca;
            Console.WriteLine($"A placa do veículo foi atualizada de {placaAtual} para {novaPlaca}.");
        }
    }
    else
    {
        Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente.");
    }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                // TODO: Realizar um laço de repetição, exibindo os veículos estacionados
                foreach (string veiculo in veiculos)
                {
                    Console.WriteLine($"{veiculo}");
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
