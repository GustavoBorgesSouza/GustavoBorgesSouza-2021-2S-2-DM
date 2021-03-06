/*
Declare uma variável chamada `isTruthy`, e atribua a ela uma função que recebe
um único parâmetro como argumento. Essa função deve retornar `true` se o
equivalente booleano para o valor passado no argumento for `true`, ou `false`
para o contrário.
*/


// Invoque a função criada acima, passando todos os tipos de valores `falsy`.


/*
Invoque a função criada acima passando como parâmetro 10 valores `truthy`.
*/


/*
Declare uma variável chamada `carro`, atribuindo à ela um objeto com as
seguintes propriedades (os valores devem ser do tipo mostrado abaixo):
- `marca` - String
- `modelo` - String
- `placa` - String
- `ano` - Number
- `cor` - String
- `quantasPortas` - Number
- `assentos` - Number - cinco por padrão
- `quantidadePessoas` - Number - zero por padrão
*/
var Carro = new Object();
Carro.marca = "Fiat";
Carro.modelo = "Argo";
Carro.placa = "day5310";
Carro.ano = 2016;
Carro.cor = "preto";
Carro.quantasPortas = 4;
Carro.assentos = 5;
Carro.quantidadePessoas = 0;

/*
Crie um método chamado `mudarCor` que mude a cor do carro conforme a cor
passado por parâmetro.
*/
Carro.mudarCor = function mudarCor(corEscolhida){
    this.cor = corEscolhida;
}

/*
Crie um método chamado `obterCor`, que retorne a cor do carro.
*/
Carro.obterCor = function obterCor(){
    return "A cor do carro é " + Carro.cor;
}

/*
Crie um método chamado `obterModelo` que retorne o modelo do carro.
*/
Carro.obterModelo = function obterModelo(){
    return Carro.modelo;
}

/*
Crie um método chamado `obterMarca` que retorne a marca do carro.
*/
Carro.obterMarca = function obterMarca(){
    return Carro.marca;
}

/*
Crie um método chamado `obterMarcaModelo`, que retorne:
"Esse carro é um [MARCA] [MODELO]"
Para retornar os valores de marca e modelo, utilize os métodos criados.
*/
Carro.obterMarcaModelo = function obterMarcaModelo(){
    return `Esse carro é um ${Carro.obterMarca()} ${Carro.obterModelo()} `;
}

/*
Crie um método que irá adicionar pessoas no carro. Esse método terá as
seguintes características:
- Ele deverá receber por parâmetro o número de pessoas entrarão no carro. Esse
número não precisa encher o carro, você poderá acrescentar as pessoas aos
poucos.
- O método deve retornar a frase: "Já temos [X] pessoas no carro!"
- Se o carro já estiver cheio, com todos os assentos já preenchidos, o método
deve retornar a frase: "O carro já está lotado!"
- Se ainda houverem lugares no carro, mas a quantidade de pessoas passadas por
parâmetro for ultrapassar o limite de assentos do carro, então você deve
mostrar quantos assentos ainda podem ser ocupados, com a frase:
"Só cabem mais [QUANTIDADE_DE_PESSOAS_QUE_CABEM] pessoas!"
- Se couber somente mais uma pessoa, mostrar a palavra "pessoa" no retorno
citado acima, no lugar de "pessoas".
*/


/*
Agora vamos verificar algumas informações do carro. Para as respostas abaixo,
utilize sempre o formato de invocação do método (ou chamada da propriedade),
adicionando comentários _inline_ ao lado com o valor retornado, se o método
retornar algum valor.

Qual a cor atual do carro?
*/
console.log("Qual a cor atual do carro?")
console.log(Carro.obterCor())

// Mude a cor do carro para vermelho.
Carro.mudarCor("vermelho")

// E agora, qual a cor do carro?
console.log(Carro.obterCor())

// Mude a cor do carro para verde musgo.
Carro.mudarCor("verde musgo")

// E agora, qual a cor do carro?
console.log(Carro.obterCor())

// Qual a marca e modelo do carro?
console.log(Carro.obterMarcaModelo())

// Adicione 2 pessoas no carro.


// Adicione mais 4 pessoas no carro.


// Faça o carro encher.


// Tire 4 pessoas do carro.


// Adicione 10 pessoas no carro.


// Quantas pessoas temos no carro?
