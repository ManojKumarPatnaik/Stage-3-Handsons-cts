import logo from './logo.svg';
import './App.css';

import {CalculateScore} from '../src/Components/CalculateScore'

function App() {
  return (
    <div className="App">
     <CalculateScore Name={"steeve"}
     School={"DNV Public SCHOOL"}
     total={284}
     goal={3}
     />
    </div>
  );
}

export default App;
