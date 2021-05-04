import React,{Component} from 'react'
//import '../Stylesheets/mystyle.css'

const validateForm = (errors) => {
    let valid = true;
    Object.values(errors).forEach(
      // if we have an error string set valid to false
      (val) => val.length > 0 && (valid = false)
    );
    return valid;
  }
export class Register extends Component{
    
    constructor(props) {
        super(props);
        this.state = {
          fullName: '',
          email: '',
          password: '',
          errors: {
            fullName: '',
            email: '',
            password: '',
          }
          
        };
        this.handleChange = this.handleChange.bind(this);
        this.handleSubmit = this.handleSubmit.bind(this);
    
      }
      
      handleSubmit = (event) => {
        event.preventDefault();
        if(validateForm(this.state.errors)) {
          console.log('Valid form');
          }else{
            if(this.state.errors.fullName!=='')
            {alert(this.state.errors.fullName)}
            if(this.state.errors.email !=='')
          {alert(this.state.errors.email)}
          if(this.state.errors.password !=='')
          {alert(this.state.errors.password)}
        }
      }
    
      handleChange = (event) => {
        event.preventDefault();
        const { name, value } = event.target;
        let errors = this.state.errors;
         switch (name) {
           case 'fullName':
             errors.fullName = 
              value.length < 5
                ? 'Full Name must be 5 characters long!'
                : '';
            break;
          case 'email': 
          const validEmailRegex = 
          RegExp(/^(([^<>()\[\]\.,;:\s@\"]+(\.[^<>()\[\]\.,;:\s@\"]+)*)|(\".+\"))@(([^<>()[\]\.,;:\s@\"]+\.)+[^<>()[\]\.,;:\s@\"]{2,})$/i);
 
            errors.email = 
              validEmailRegex.test(value)
                ? ''
                : 'Email is not valid!';
            break;
          case 'password': 
            errors.password = 
              value.length < 8
                ? 'Password must be 8 characters long!'
                : '';
            break;
          default:
            break;
        }
        this.setState({errors, [name]: value}, ()=> {
            console.log(errors)
            
        })
      }
      render() {
        return (
          <div>
          <form name="validateForm" className="center" onSubmit={this.handleSubmit}>
              <table>
                  <tbody>
                  <tr>
                      <td colSpan="2" align="center">
                          <h1><font color="Red"> Register Here!!!</font> </h1>
                      </td>
                  </tr>
                  <tr>
                    <td>Name:</td>
                  <td><input type="text"  name="fullName" value={this.state.fullName} onChange={this.handleChange} /></td>
                    </tr>
                  <tr>
                  <td>  Email: </td>
                    <td><input type="text"  name="email" value={this.state.email} onChange={this.handleChange} /></td>
                 </tr>
                  <tr>
                  <td>  Password: </td>
                    <td><input type="password"  name="password" value={this.state.password} onChange={this.handleChange} /></td>
                 </tr>
                  <tr>
                <td colSpan="2" align="center"><input type="submit" value="Submit" /></td>
                  </tr>
                  </tbody>
            </table>
          </form>
          </div>
        );
      }
    
}
