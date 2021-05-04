import React, { Component } from 'react';
import "../StyleSheets/MyStyle.css";

class CountPeople extends Component{
    constructor(){
        super();
        this.state={
            entrycount:0,
            exitcount:0,
            c:0
        };
    }
    updateEntry(){
        this.setState((prevState,props)=>{
            return{entrycount:prevState.entrycount+1}
        });
    }
    updateExit(){
        this.setState((prevState,props)=>{
            return{exitcount: prevState.exitcount+1}
        });
}
render(){
    return(<div className="container">
        <button className="button"
         onClick={()=> this.updateEntry()}>Login</button>
         <span>{this.state.entrycount} People Entered!</span>
         <button className="button"
         onClick={()=> this.updateExit()}>Exit</button>
         <span>{this.state.exitcount} People left!</span>
    </div>
    )
}
}
export default CountPeople;