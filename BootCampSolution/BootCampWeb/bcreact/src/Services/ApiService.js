import axios from 'axios';

export async function GetAllStudents()
{
    var response;

     await axios.get('http://localhost:5042/Api/AllStudents').then(res=>{
                response=res.data;
            }).catch(error => {
        return error;
        });
      
      return response;
}

