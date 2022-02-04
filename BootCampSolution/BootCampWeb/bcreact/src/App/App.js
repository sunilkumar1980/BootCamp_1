import SideMenu from '../Pages/SideMenu'
import '../App/App.css';
import React from 'react';
import { CssBaseline, makeStyles } from '@material-ui/core';
import Header from '../Pages/Header';
import StudentDetail from '../Pages/StudentDetails'
const style=makeStyles({
  appMain:{
    paddingLeft:'200px',
    width:'100%'
  },
  pageStyle:{
    padding:'5px',
    margin:'10px'
  }
});


function App() {

  const customStyle=style();

  return (
    <React.Fragment>
      <SideMenu/>
     
      <div className={customStyle.appMain} > 
        <Header/>
        <div className={customStyle.pageStyle}>
          <StudentDetail/>
        </div>
         
      </div>
      <CssBaseline/>
    </React.Fragment>
  );
}

export default App;
