import React,{Component} from 'react'


export const players=[{name:"Jack",score:50},
        {name:"Michael",score:70},
        {name:"John",score:40},
        {name:"Ann",score:61},
        {name:"vijay",score:61},
        {name:"Sachin",score:95},
        {name:"Dhoni",score:100},
        {name:"Virat",score:84},
        {name:"Jadeja",score:64},
        {name:"Raina",score:75}, 
        {name:"Rohit",score:80}];

export class ListofPlayers extends Component{
    render(){
        return(
           
            players.map((item)=>
            {
                return(
                    <div>
                    <li>Mr.{item.name}<span>  {item.score}</span></li>
                    </div>

                ) })
        );
        
    }
        
}


export class Scorebelow70 extends Component{
    render(){
        return(
           
            players.map((item)=>
            {
                if(item.score<=70)
                {
                    return(
                        <div>
                        <li>Mr.{item.name}<span>  {item.score}</span></li>
                        </div>
                    )
                   // players70.push(item);
                }
                

         })
        );
        
    }
}