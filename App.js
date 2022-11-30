import React, { useState } from 'react';
import axios from 'axios';
import "./App.css"

function App() {
  const [data, setData] = useState({})
  const [location, setLocation] = useState('')
  
  const url = `https://localhost:7045/api/cocktail/GetCocktail/${location}`

  const searchLocation = (event) => {
    if (event.key === 'Enter') {
      axios.get(url).then((response) => {
        setData(response.data)
        console.log(response.data)
      })
     
    }
  }
  return (
    <div className="app">
    <div className="search">
        <input
          value={location}
          onChange={event => setLocation(event.target.value)}
          onKeyPress={searchLocation}
          placeholder='Enter CocktailName'
          type="text" />
      </div> 
      <div className='text-align'>       
          <p>{data.info}</p>         
          <p>{data.glass}</p>   
          <p>{data.instructions}</p>          
          <p>{ data.ingredients}</p>  
          <p>{ data.images}</p>
      </div> 
      </div>   
        );
        <div>
          <a href='https://images.unsplash.com/photo-1514362545857-3bc16c4c7d1b?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxzZWFyY2h8Mnx8Y29ja3RhaWx8ZW58MHx8MHx8&w=1000&q=80'></a>
  </div>      
}
export default App;
