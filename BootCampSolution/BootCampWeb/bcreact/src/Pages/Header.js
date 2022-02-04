import React from "react";
import { AppBar, Toolbar,Grid, Input } from "@material-ui/core"
import HomeOutlined from '@material-ui/icons/HomeOutlined'

const Header =()=>{
    return (<AppBar position="static">
        <Toolbar>
            <Grid container >
            <Grid >
               Search:<Input></Input>
            </Grid>
            <Grid item xs={8}></Grid>
            <Grid >
                <HomeOutlined color="primary" />
            </Grid>
            </Grid>
        </Toolbar>
    </AppBar>)
}

export default Header;