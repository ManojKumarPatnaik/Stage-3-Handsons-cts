import logo from './logo.svg';
import './App.css';
import sr from './Centeroffice.jpg'
import '../src/Stylesheets/mystyle.css'
const element="office space"
const jsxatt=<img src={sr} width="25%" height="25%" alt="Office Space"/>
const ItemName={Name: "DBS" ,Rent: 50000, Address:'Chennai'}

function App() {

let colors=[];
if(ItemName.Rent<=60000)
{
  colors.push('textRed');
}
else{
  colors.push('textGreen');
}
  return (
    <div id='root' className="Center">
    <h1>{element} , at Affordable Range </h1>
      {jsxatt}
    <h1>Name: {ItemName.Name}</h1>  
    <h3 className={colors}>Rent:Rs.{ItemName.Rent}</h3>  
    <h3> Address: {ItemName.Address}</h3>
    </div>
  );
}

export default App;
