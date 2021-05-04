import React from 'react'
//import '../StyleSheets/mystyle.css'

export class ComplaintRegister extends React.Component {
    constructor(props) {
      super(props);
      this.state = {
        ename:'',
        complaint: ''
      };
  
      this.handleChange = this.handleChange.bind(this);
      this.handleSubmit = this.handleSubmit.bind(this);
    }
  
    handleChange(event) {
        this.setState({ [event.target.name] : event.target.value});
      }
      
      GenerateRandomNumber=()=>
    {
        var RandomNumber = Math.floor(Math.random() * 100) + 1 ;
        this.setState({
          NumberHolder : RandomNumber
          })
    }
  
    handleSubmit(event) {
        var msg='Thanks '+ this.state.ename +' \n Your Complaint was Submitted. \n' +'Transaction ID is: ' + this.state.NumberHolder;
        alert(msg);
      event.preventDefault();
    }
  
    render() {
      return (
        <div className="center">
        <form className="center" onSubmit={this.handleSubmit}>
            <table>
                <tr>
                    <td colspan="2" align="center">
                        <h1><font color="Red"> Register your complaints here!!!</font> </h1>
                    </td>
                </tr>
                <tr>
                  <td>Name:</td>
                <td><input type="text" name="ename" value={this.state.ename} onChange={this.handleChange} /></td>
                </tr>
                <tr>
                <td>  Complaint: </td>
                  <td><textarea type="text" name="complaint" value={this.state.complaint} onChange={this.handleChange} /></td>
               </tr>
                <tr>
              <td colspan="2" align="center"><input type="submit" value="Submit" onClick={this.GenerateRandomNumber} /></td>
                </tr>
          </table>
        </form>
        </div>
      );
    }
  }

