import React from 'react';
import './App.css';

function DataFormatada(props) {
  return <h2>Horário atual: {props.date.toLocaleTimeString()}</h2>
}

class Clock extends React.Component{
  constructor(props){
    super(props);
    this.state = {
      //Definimos o estado date pegando a data atual
      date : new Date()
    }
  }

  //Fora do construtor, definidos os ciclos de vida

  //Ciclo de vida que ocorre quando Clock é inserido na DOM
  componentDidMount(){
    setInterval(() => {
      this.tick()
    }, 1000);
  }

  //Ciclo de vida que ocorre quando clock é removido da DOM
  componentWillUnmount(){

  }

  tick(){
    this.setState({
      date : new Date()
    })
  }

  render(){
    return (
      <div>
        <h1>Relogio</h1>
        <DataFormatada date={this.state.date} />
      </div>
    )
  }
}

function App() {
  return (
    <div className="App">
      <header className="App-header">
        {/* Faz a chamada de dois relogios para mostrar a independencia destes */}
        <Clock />
      </header>
    </div>
  );
}

export default App;
