//import logo from './logo.svg';
import './App.css';
import {ListofPlayers,players,Scorebelow70} from './Components/ListofPlayers'
import {IndianTeam,EvenPlayers,OddPlayers,IndianPlayers,ListofIndianPlayers} from '../src/Components/IndianPlayers'


function App() {
  
      var flag=true;
   //var flag=false;
      if(flag===true)
      {
  return (
    <div>
    <h1>List of Players</h1>
      <ListofPlayers players={players}/>
      <hr/>
      <h1>List of Players having Scores Less than 70</h1>
      <Scorebelow70 players={players}/>
    </div>
  )
  }
  else{
    return(
      <div>
      <div>
      <h1>Indian Team</h1>
      <h1>Odd Players</h1>
      {OddPlayers(IndianTeam)}
      <hr/>
    <h1>Even Players</h1>
      {EvenPlayers(IndianTeam)}
      </div>
      <hr/>

      <div>
      <h1>List of Indian Players Merged:</h1>
      <ListofIndianPlayers IndianPlayers={IndianPlayers}/>
      </div>
      </div>



    )
  }
}

export default App;
