import logo from './logo.svg';
import './App.css';
import {Home} from '../src/Components/Home';
import {About} from '../src/Components/About';
import {Contact} from '../src/Components/Contact';

function App() {
  return (
    <div className="Container">
    <Home/>
    <About/>
    <Contact/>
      
    </div>
  );
}

export default App;
