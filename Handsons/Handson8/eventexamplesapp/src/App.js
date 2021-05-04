
import React, { useState } from "react";
//import '../src/StyleSheets/mystyle1.css'
import { CurrencyConvertor } from "./CurrencyConvertor";

const App = () => {
    const [count, setCount] = useState(0);
  const sayHello = (name) => {
    return(
          alert(`Hello! ${name}`));
  };
  const CustomButton = ({ onPress }) => {
    return (
      <button type="button" onClick={onPress}>
        Click on me
      </button>
    );
  }
  
  const handleEvent = () => {
      alert("I was clicked");
    };
  
    
  return (
    <div>
      <p>{count}</p>
      <button onClick={() =>{sayHello("Member1");setCount(count + 1)}}>Increment</button><br/>
      <button onClick={() => setCount(count - 1)}>Decrement</button><br/>
      <button value="Welcome" onClick={(e) => alert(e.target.value)}>
      Say Welcome
      </button><br/>
      <CustomButton onPress={handleEvent} /><br/>
      <CurrencyConvertor/>
    </div>
  );

  }
export default App;




