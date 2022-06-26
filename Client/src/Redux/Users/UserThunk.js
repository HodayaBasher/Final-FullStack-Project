import axios from "axios";
import {LoadUsers,getUserByNameAndPassword, addUser} from './UserActions';

//כתובת השרת
let defaultURL = `https://localhost:44340/api/User`;

//פונקציה המחזירת את רשימת כל הלקוחות
export const getAllUsersFromServer = async (dispatch) => {
    try {
        const allUsers = await axios.get(`${defaultURL}/GetAllUsers`);
        await console.log(allUsers.data)
        await dispatch(LoadUsers(allUsers.data))
        return allUsers.data;
    } catch (e) {
        console.log(e)
    }
}

//פונקציה המחזירה לקוח מסוים על פי שמו ומספר מזהה
export const getUserByNameAndPasswordFromServer = async (dispatch, userName ,password) => {

    try {
        const userByNameAndPassword = await axios.get(`${defaultURL}/GetUserByNameAndPassword/${userName}/${password}`);
        await console.log(userByNameAndPassword.data)
        await dispatch(getUserByNameAndPassword(userByNameAndPassword.data))
        return userByNameAndPassword.data;
    } catch (e) {
        console.log(e)
    }
}

//פונקציה המוסיפה לקוח חדש למערכת
export const AddUserInServer = async (dispatch, newUser) => {
    try {
        const allUsersAfterAdding = await axios.post(`${defaultURL}/AddUser`,newUser);
        await console.log(allUsersAfterAdding.data)
        await dispatch(addUser(allUsersAfterAdding.data))
        return allUsersAfterAdding.data; 
    } catch (e) {
        console.log(e)
    }
}
