# PareAqui

Voce foi contratado para desenvolver um projeto, para a empresa Pare Aqui. Precisa desenvolver um software, para controle de estacionamento.

O sistema consistirá no cadastro de veículos, emissão de ticket para entrada e saída, e calculo de preço.

Regras de négocio:

A cobrança será feita por minuto.

Cada minuto custa R$0,09.
Crie a classe Ticket que será responsável por controlar o tempo e calcular o valor a ser cobrado.

A classe deve ter as seguintes propriedades :

Entrada - DateTime

Saida - DateTime

Ativo - Boolean

Sendo Entrada representando a hora da entrada do veículo no estacionamento, a saída representando a hora de saída e Ativo representando se o ticket está ativo (true) ou não, se ele estiver ativo significa que o carro está dentro do estacionamento, caso inativo (false) siginifica que o carro já saiu.

A clase também deve possuir os Métodos: CalcularTempo() e CalcularValor();
Sendo responsáveis por calcular o tempo em minutos que o veículo ficou no estacionamento e Calcular o valor a ser cobrado, respectivamente.



Dica: para calcular o tempo que o carro ficou estacionado utilize:
var tempo = Saida - Entrada ;
a variavel tempo será do tipo TimeSpan Que representa um intervalo de tempo, ela possui a propriedade  tempo.TotalMinutes que informa o tempo decorrido em minutos, utilize ela para saber quanto tempo se passou.
Crie a classe Carro que será responsável pelos dados do veículo

A classe deve ter as seguintes propriedades :

Placa - string

Modelo - string

Cor - string

Marca - string

Tickets - List<Ticket>

A propriedade tickets será uma lista de tickets, que representará o histórico do carro, no estacionamento.
  Crie um menu da aplicação, ele será responsável por centralizar todas as funcionalidades de seu software, e deve conter as seguintes opções:

1 - Cadastrar Carro
2 - Marcar Entrada
3 - Marcar Saída
4 - Consultar histórico
5 - Sair
  O método CadastrarCarro deve obter os dados do carro via Console.ReadLine(), e inserir o carro cadastrado em uma lista estatica para que fique acessível a partir de qualquer instancia da classe durante o ciclo de vida da aplicação
  O método ObterCarro deve filtrar pela placa e retornar a instância do objeto carro, presente na lista estática carros.
  O método Gerar ticket receber como entrada via Console.ReadLine() a placa do veiculo.

Deverá consultar o método obterCarro, para validar se a placa já esta cadastrada, caso não esteja informe ao usuário que o veículo não esta cadastrado.
Caso o veiculo já esteja cadastrado, verifique se não ha nenhum ticket ativo para este veiculo, consulte a lista de tickets na classe carro. Caso haja algum ticket ativo comunique ao cliente que o veículo já possui ticket em aberto.

Caso não possua ticket em aberto crie um novo ticket, com as propriedades Entrada = DateTime.Now, e Ativo = true. e adicione o ticket a lista de tickets na classe veículo. Dica* Aplique essas configurações no construtor da classe ticket.

Por fim informe ao usuário que o ticket foi criado.
  O método Historico receber como entrada via Console.ReadLine() a placa do veículo.

Deverá consultar o método obterCarro, para validar se a placa já esta cadastrada, caso não esteja informe ao usuário que o veículo não esta cadastrado.
Caso o veiculo já esteja cadastrado, Exiba o historico de tickets que ele possui: todas as entradas, saídas e Valores pagos.
  O método FecharTicket receber como entrada via Console.ReadLine() a placa do veiculo.

Deverá consultar o método obterCarro, para validar se a placa já esta cadastrada, caso não esteja informe ao usuario que o veículo não esta cadastrado.
Caso o veiculo já esteja cadastrado, verifique se há algum ticket ativo para este veiculo, consulte a lista de tickets na classe carro. Caso não haja ticket ativo comunique ao cliente que o veículo já possui ticket em aberto.

Caso possua ticket em aberto encerre ele definido as propriedades Saida = DateTime.Now e Ativo = false *Dica: Crie um método na classe Ticket Ex. Marcar Saída para atualizar estes Valores;

E exiba para o usuário o tempo que o carro ficou estacionado e o valor cobrado;
