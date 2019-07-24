function getRequest(location, callback){
    console.log(location)
    fetch(location)   
     .then(response => response.json())
     .then(jsonData => callback(jsonData))
     .catch(err => console.log(err))
 }
 
 function postRequest(location, requestBody, callback){
    fetch(location,{
        method: "POST",
        headers: {"Content-Type" : "application/json"},
        body: JSON.stringify(requestBody)
    })
    .then(response => response.json())
    .then(jsonData => callback(jsonData))
    .catch(err => console.log(err));
 }
 
 function deleteRequest(location, requestBody, callback){
    fetch(location,{
        method: "DELETE",
        headers: {"Content-Type" : "application/json"},
        body: JSON.stringify(requestBody)
    })
    .then(response => response.json())
    .then(jsonData => callback(jsonData))
    .catch(err => console.log(err));
 }
 
 function putRequest(location, requestBody, callback){
    console.log("trying to fetch");
    fetch(location,{
        method: "PUT",
        headers: {"Content-Type" : "application/json"},
        body: JSON.stringify(requestBody)
    })
    .then(returned => console.log("after fetch: " + returned))
    .then(response => response.json())
    .then(res => console.log("after json conversion: " + res))
    .then(jsonData => callback(jsonData))
    .catch(err => console.log(err));
 }
 
 export default{
    getRequest,
    postRequest,
    deleteRequest,
    putRequest
 }