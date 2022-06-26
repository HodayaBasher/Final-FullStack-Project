import axios from "axios";
import { LoadProducts, AddMachine, UpdateMachine, DeleteMachine } from './MachineActions'

//כתובת השרת
let defaultURL = `https://localhost:44340/api/Machine`;



//פונקציה המחזירה את כל המוצרים
export const getAllProductsFromServer = async (dispatch) => {

    try {
        const allMachines = await axios.get(`${defaultURL}/GetAllMachines`);
        await console.log(allMachines.data)
        await dispatch(LoadProducts(allMachines.data))
        return allMachines.data;
    } catch (e) {
        console.log(e)
    }
}

//פונקציה המוסיפה מוצר חדש למערכת
export const AddProdInServer = async (dispatch, newProd) => {
    debugger
    try {
        const AllMachinesAfterAdding = await axios.post(`${defaultURL}/AddMachine`, newProd);
        await console.log(AllMachinesAfterAdding.data)
        await dispatch(AddMachine(AllMachinesAfterAdding.data))
        return AllMachinesAfterAdding.data;
    } catch (e) {
        console.log(e)
    }
}

//פונקציה המעדכנת פרטי מוצר מסוים
export const UpdateProdInServer = async (dispatch, machineUpdate) => {
    try {
        const AllMachinesAfterUpdating = await axios.put(`${defaultURL}/UpdateMachine`, machineUpdate);
        await console.log(AllMachinesAfterUpdating.data)
        await dispatch(UpdateMachine(AllMachinesAfterUpdating.data))
        return AllMachinesAfterUpdating.data;
    } catch (e) {
        console.log(e)
    }
}
//פונקציה המוחקת מוצר מסוים (על פי מספר מזהה) ושומרת את המוצר האחרון שנמחק
export const DeleteProdInServer = async (dispatch, machineId) => {
    try {
        const AllMachinesAfterDeleting = await axios.delete(`${defaultURL}/DeleteMachine/${machineId}`);
        await console.log(AllMachinesAfterDeleting.data)
        await dispatch(DeleteMachine(AllMachinesAfterDeleting.data))
        return AllMachinesAfterDeleting.data;
    } catch (e) {
        console.log(e)
    }
}
