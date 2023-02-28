import User from "../models/userData";

async function getNewRandos(){
    const response = await fetch('https://randomuser.me/api/?results=6');
    const data = await response.json();
    const usersList = data.results.map(user => new User(user.picture.large, user.name.first, user.name.last, user.location.country, user.location.city, user.email, user.gender))
    return usersList;
} 

async function getNewRando(){
    const response = await fetch('https://randomuser.me/api/?results=1');
    const data = await response.json();
    return  data.results[0];
}




export {getNewRandos, getNewRando}