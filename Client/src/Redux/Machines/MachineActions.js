//החזרת רשימת כל המוצרים
export function LoadProducts(items) {
    return { type: "LOAD_PRODUCTS", payload: items };
}

//הוספת מוצר חדש
export function AddMachine(items) {
    return { type: "ADD_MACHINE", payload: items }
}

//עידכון פרטי מוצר
export function UpdateMachine(items) {
    return { type: "UPDATE_MACHINE", payload: items };
}

//מחיקת מוצר על פי מספר מזהה
export function DeleteMachine(item) {
    return { type: "DELETE_MACHINE", payload: item };
}

//עידכון מוצר נוכחי
export function UpdateCurrentMachine(item) {
    return { type: "UPDATE_CURRENT_MACHINE", payload: item };
}

export function CurrentToUpdate(item){
    return { type: "CURRENT_TO_UPDATE", payload: item };
}
