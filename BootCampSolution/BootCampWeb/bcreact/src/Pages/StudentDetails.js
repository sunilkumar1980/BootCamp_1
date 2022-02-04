
import React, { useEffect, useState } from 'react'
import {Button, Card} from '@material-ui/core'
import { GetAllStudents} from '../Services/ApiService'

const StudentDetails =()=>{

    const [student,setStudentData]=useState([]);

    useEffect(()=> {
        async function fetchData() {
                const studentList=  await GetAllStudents();
                setStudentData(studentList);
        }  
        fetchData();
    },[]);

    return <div >
        <label><h3>Student Records</h3></label>
        <Card>
            <Button variant="contained" color="primary" >
                Add New
            </Button>

                <table className="table ">  
                <thead>  
                <tr>
                <th>ID</th>  
                <th>First Name</th>  
                <th>Middle Name</th>  
                <th>Last Name</th>  
                <th>DOB</th> 
                <th>Actions</th> 
                </tr>
                </thead>  
                <tbody>
                {student.map((student, index) => (  
                <tr key={index}>  
                    <td>{student.studentId}</td>  
                    <td>{student.firstName}</td>  
                    <td>{student.middleName}</td>  
                    <td>{student.lastName}</td>  
                    <td>{student.dateofBirth}</td>  
                    <td>
                        <Button variant="contained" color="primary">
                        Edit
                        </Button>
                        |
                        <Button variant="contained" color="primary">
                        Delete
                        </Button>
                    </td>
                </tr>  
                ))}  
                </tbody>
                </table>  
                </Card>
    </div>  
  
}

export default StudentDetails;