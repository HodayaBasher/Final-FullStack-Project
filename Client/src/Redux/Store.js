import { combineReducers, createStore } from "redux";
import { UserReducer } from "./Users/UserReducer";
import {MachineReducer} from './Machines/MachineReducer';
import {CartReducer} from './Cart/CartReducer';

//פונקצייה שמחברת את כל הרדורסרים לרכיב אחד
//מקובל לקרוא לו-reducers
const reducers = combineReducers(
    {
        users:UserReducer,
        Machines:MachineReducer,
        cart:CartReducer,
    
    })

//פונקציה שבונה בפועל את הסטור!!!
export const store = createStore(reducers)
//עמ לבדוק בדפדפן את התוכלה של הסטור
window.store = store;


