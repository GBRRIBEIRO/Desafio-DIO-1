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
            //Pedir para o usuário digitar uma placa (ReadLine) e adicionar na lista "veiculos"

            Console.WriteLine("Digite a placa do veículo para estacionar:");
            var placaInput = Console.ReadLine();
            veiculos.Add(placaInput);
            Console.WriteLine("Sucesso!");
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            // Pedir para o usuário digitar a placa e armazenar na variável placa
            var placaInput = Console.ReadLine();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placaInput.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                // Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
                Console.WriteLine("Insira quantas horas o veículo ficou estacionado:");
                int horas = Convert.ToInt32(Console.ReadLine());
                // Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal
                
                decimal valorTotal = horas * precoPorHora + precoInicial; 

                // Remover a placa digitada da lista de veículos
                veiculos.Remove(placaInput);

                Console.WriteLine($"O veículo {placaInput} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                // Realizar um laço de repetição, exibindo os veículos estacionados
                foreach (var placa in veiculos)
                {
                    Console.WriteLine($"Veiculo de placa: {placa}");
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
