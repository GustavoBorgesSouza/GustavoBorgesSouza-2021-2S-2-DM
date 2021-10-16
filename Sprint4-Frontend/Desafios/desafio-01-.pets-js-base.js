// Declarar uma variável qualquer, que receba um objeto vazio.
var Qualquer = new Object();

/*
Declarar uma variável `pessoa`, que receba suas informações pessoais.
As propriedades e tipos de valores para cada propriedade desse objeto devem ser:
- `nome` - String
- `sobrenome` - String
- `sexo` - String
- `idade` - Number
- `altura` - Number
- `peso` - Number
- `andando` - Boolean - recebe "falso" por padrão
- `caminhouQuantosMetros` - Number - recebe "zero" por padrão
*/
var pessoa = new Object();
pessoa.nome = "Gustavo";
pessoa.sobrenome = "Borges";
pessoa.sexo = "Masculino";
pessoa.idade = 17;
pessoa.altura = 1.66;
pessoa.peso = 50;
pessoa.andando = false;
pessoa.caminhouQuantosMetros = 0;

/*
Adicione um método ao objeto `pessoa` chamado `fazerAniversario`. O método deve
alterar o valor da propriedade `idade` dessa pessoa, somando `1` a cada vez que
for chamado.
*/
    pessoa.fazerAniversario = function fazerAniversario(){
    pessoa.idade = pessoa.idade + 1;
};

/*
Adicione um método ao objeto `pessoa` chamado `andar`, que terá as seguintes
características:
- Esse método deve receber por parâmetro um valor que representará a quantidade
de metros caminhados;
- Ele deve alterar o valor da propriedade `caminhouQuantosMetros`, somando ao
valor dessa propriedade a quantidade passada por parâmetro;
- Ele deverá modificar o valor da propriedade `andando` para o valor
booleano que representa "verdadeiro";
*/
pessoa.andar = function andar(quantiaMetros){
    pessoa.caminhouQuantosMetros = pessoa.caminhouQuantosMetros + quantiaMetros;
    pessoa.andando = true;
};

pessoa.andar(8);

/*
Adicione um método ao objeto `pessoa` chamado `parar`, que irá modificar o valor
da propriedade `andando` para o valor booleano que representa "falso".
*/
pessoa.parar = function parar(){
    pessoa.andando = false;
};

/*
Crie um método chamado `nomeCompleto`, que retorne a frase:
- "Olá! Meu nome é [NOME] [SOBRENOME]!"
*/
pessoa.nomeCompleto = function nomeCompleto(){
   return "Olá! Meu nome é " + pessoa.nome + " " +pessoa.sobrenome + " !"
}

/*
Crie um método chamado `mostrarIdade`, que retorne a frase:
- "Olá, eu tenho [IDADE] anos!"
*/
pessoa.mostrarIdade = function mostrarIdade(){
    return "Olá, eu tenho " + pessoa.idade+ " anos!"
}

/*
Crie um método chamado `mostrarPeso`, que retorne a frase:
- "Eu peso [PESO]Kg."
*/
pessoa.mostrarPeso = function mostrarPeso(){
    return "Eu peso " + pessoa.peso + " Kg."
}

/*
Crie um método chamado `mostrarAltura` que retorne a frase:
- "Minha altura é [ALTURA]m."
*/
pessoa.mostrarAltura = function mostrarAltura(){
    return "Minha altura é " + pessoa.altura + "m."
}

/*
Agora vamos brincar um pouco com o objeto criado:
Qual o nome completo da pessoa? (Use a instrução para responder e comentários
inline ao lado da instrução para mostrar qual foi a resposta retornada)
*/
console.log(pessoa.nomeCompleto());

/*
Qual a idade da pessoa? (Use a instrução para responder e comentários
inline ao lado da instrução para mostrar qual foi a resposta retornada)
*/
console.log(pessoa.mostrarIdade());

/*
Qual o peso da pessoa? (Use a instrução para responder e comentários
inline ao lado da instrução para mostrar qual foi a resposta retornada)
*/
console.log(pessoa.mostrarPeso());

/*
Qual a altura da pessoa? (Use a instrução para responder e comentários
inline ao lado da instrução para mostrar qual foi a resposta retornada)
*/
console.log(pessoa.mostrarAltura());

/*
Faça a `pessoa` fazer 3 aniversários.
*/
pessoa.fazerAniversario();
pessoa.fazerAniversario();
pessoa.fazerAniversario();


/*
Quantos anos a `pessoa` tem agora? (Use a instrução para responder e
comentários inline ao lado da instrução para mostrar qual foi a resposta
retornada)
*/
console.log(pessoa.mostrarIdade());

/*
Agora, faça a `pessoa` caminhar alguns metros, invocando o método `andar` 3x,
com metragens diferentes passadas por parâmetro.
*/
pessoa.andar(2);
pessoa.andar(8);
pessoa.andar(6);

/*
A pessoa ainda está andando? (Use a instrução para responder e comentários
inline ao lado da instrução para mostrar qual foi a resposta retornada)
*/
console.log( "a pessoa está andando? "+ pessoa.andando);

/*
Se a pessoa ainda está andando, faça-a parar.
*/
pessoa.parar();

/*
E agora: a pessoa ainda está andando? (Use uma instrução para responder e
comentários inline ao lado da instrução para mostrar a resposta retornada)
*/
console.log( "a pessoa está andando? "+ pessoa.andando);

/*
Quantos metros a pessoa andou? (Use uma instrução para responder e comentários
inline ao lado da instrução para mostrar a resposta retornada)
*/
console.log("A pessoa caminhou " + pessoa.caminhouQuantosMetros + "m");

/*
Agora vamos deixar a brincadeira um pouco mais divertida! :D
Crie um método para o objeto `pessoa` chamado `apresentacao`. Esse método deve
retornar a string:
- "Olá, eu sou o [NOME COMPLETO], tenho [IDADE] anos, [ALTURA], meu peso é [PESO] e, só hoje, eu já caminhei [CAMINHOU QUANTOS METROS] metros!"
Só que, antes de retornar a string, você vai fazer algumas validações:
- Se o `sexo` de `pessoa` for "Feminino", a frase acima, no início da
apresentação, onde diz "eu sou o", deve mostrar "a" no lugar do "o";
- Se a idade for `1`, a frase acima, na parte que fala da idade, vai mostrar a
palavra "ano" ao invés de "anos", pois é singular;
- Se a quantidade de metros caminhados for igual a `1`, então a palavra que
deve conter no retorno da frase acima é "metro" no lugar de "metros".
- Para cada validação, você irá declarar uma variável localmente (dentro do
método), que será concatenada com a frase de retorno, mostrando a resposta
correta, de acordo com os dados inseridos no objeto.
*/

pessoa.apresentacao = function apresentacao(){
var texto = "Olá, eu sou o "+ pessoa.nome +", tenho "+ pessoa.idade +" anos, "+ pessoa.altura +"m, meu peso é "+ pessoa.peso +" e, só hoje, eu já caminhei "+ pessoa.caminhouQuantosMetros +" metros!";
var texto_atualizado = texto;
// let texto_fem = "Olá, eu sou a " + pessoa.nome +", tenho "+ pessoa.idade +" anos, "+ pessoa.altura +"m, meu peso é "+ pessoa.peso +" e, só hoje, eu já caminhei "+ pessoa.caminhouQuantosMetros +" metros!"
// let texto_ano = "Olá, eu sou o "+ pessoa.nome +", tenho "+ pessoa.idade +" ano, "+ pessoa.altura +"m, meu peso é "+ pessoa.peso +" e, só hoje, eu já caminhei "+ pessoa.caminhouQuantosMetros +" metros!"
// let texto_metro = "Olá, eu sou o "+ pessoa.nome +", tenho "+ pessoa.idade +" anos,"+ pessoa.altura +"m, meu peso é "+ pessoa.peso +" e, só hoje, eu já caminhei "+ pessoa.caminhouQuantosMetros +" metro!"

if (pessoa.sexo == "Feminino") {
    texto_atualizado = texto_atualizado.replace("Olá, eu sou o ", "Olá, eu sou a ");
};

if (pessoa.idade == 1) {
    texto_atualizado = texto_atualizado.replace(" anos, ", " ano, ");
};

if (pessoa.caminhouQuantosMetros == 1) {
    texto_atualizado = texto_atualizado.replace(" metros!", " metro!");
}

return texto_atualizado;

}

// Agora, apresente-se ;)
console.log(pessoa.apresentacao());