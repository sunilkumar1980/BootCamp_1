import React from "react";

import {makeStyles,withStyles} from '@material-ui/core'

const sidebarStyles=makeStyles({
    sideMenuClass:{
        display: 'flex',
        flexDirection: 'column',
        position: 'absolute',
        width: '200px',
        height: '100%',
        left:'0px',
        backgroundColor: 'gray'
    }
});


const SideMenu =()=>{

    
    const customStyles= sidebarStyles();
    
    return <div className={customStyles.sideMenuClass}>
    This is side menu
    </div>

}

export default SideMenu;