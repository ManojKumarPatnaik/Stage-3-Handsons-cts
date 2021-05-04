import React from 'react';
//import '../Stylesheets/mystyle.css'
export class Getuser extends React.Component{
    state={
        loading:true,
        person:null
    }
    async componentDidMount()
    {
        const url="https://api.randomuser.me/";
        const response=await fetch(url);
        const data=await response.json();
        this.setState({person:data.results[0],loading:false});
        console.log(data.results[0]);
    }
    render()
    {
        return (<div className="center">
            {this.state.loading || !this.state.person?
            ( <div> loading...</div> ): 
            (<div>
            <h1> {this.state.person.name.title} 
            <span> {this.state.person.name.first} </span>
            <span> {this.state.person.name.last} </span></h1>
            <img src={this.state.person.picture.large} alt="hi"/>
            </div>)
            } 
            </div>);
    }

}


