import React from 'react';
import './App.css';

//Componente funcional
function DataFormatada(props) {
  return <h2>Horário atual: {props.date.toLocaleTimeString()}</h2>
}

//Componente de classe
//Define a classe clock que será chamada dentro do app
class Clock extends React.Component{
  constructor(props){
    super(props);
    this.state = {
      //Define a propriedade date do state com o valor inicial como a data e hor daquele momento
      date : new Date()
    }
  }

  //Fora do construtor, definidos os ciclos de vida

  //Ciclo de vida que ocorre quando Clock é inserido na DOM
  componentDidMount(){
    this.TimerId = setInterval(() => {
      this.tick()
    }, 1000);

    console.log('Eu sou o relogio ' + this.TimerId);
  }

  //Ciclo de vida que ocorre quando clock é removido da DOM
  //Quando isso acontece, a função clearinterval() limpa o relogio criado pela função setInterval
  componentWillUnmount(){
    clearInterval(this.TimerId);
  }


  //atualiza o state date com a data e hora desse momento, quando essa função for invocada
  tick(){
    this.setState({
      date : new Date()
    })
  }

  ParaRelogio(){
    console.log(`Relógio ${this.TimerId} pausado`);
    clearInterval(this.TimerId);
  }

  RetomaRelogio(){
    console.log(`Relógio retomado!`);
    this.TimerId = setInterval(() => {
      this.tick()
    }, 1000);
    console.log(`Agora eu sou o relógio ` + this.TimerId)
  }



  render(){
    return (
      //JSX
      <div>
        <h1>Relogio  {this.TimerId}</h1>
        <DataFormatada date={this.state.date} />
        <button className="botaoPausa" onClick={() => { this.ParaRelogio() }}>Pausar</button>
        <button className="botaoRetoma" onClick={() => { this.RetomaRelogio() }}>Retomar</button>
      </div>
    )
  }
}


//Componente funcional
function App() {
  return (
    <div className="App">
      <header className="App-header">
        {/* Faz a chamada de dois relogios para mostrar a independencia destes */}
        <Clock />
        <Clock />
      </header>
    </div>
  );
}

//Declara que o componente APP pode ser utilizado fora desse escopo
export default App;
