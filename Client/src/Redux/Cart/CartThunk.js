import axios from "axios"
import { useDispatch } from "react-redux";
import {AllProductsInCart} from '../Cart/CartActions';



export const defaultURL = `https://localhost:44340/api/Cart/AddToCart`

export const AddToCart= async(dispatch, id, newCart)=>{
    debugger
    try{
        const ProdToAdd= await axios.post(`${defaultURL}/${id}` ,newCart)
        await console.log(ProdToAdd.data);
        dispatch(AllProductsInCart(ProdToAdd.data))
        return ProdToAdd.data
    }catch(e){
        console.log(e);
    }
}