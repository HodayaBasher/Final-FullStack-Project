import produce from 'immer';

const ProductIntialState = {

    //שמירת כל נתוני המוצרים במשתנה הגלובלי
    products: [],
    //שמירת המוצר הנבחר על פי מספר מזהה
    currentprod: {productName:" "},
    //שמירת המוצר האחרון שנמחק
    lastDeleted: [],//prodDelete was

    current:{}
}

export const MachineReducer = produce((state, action) => {
    debugger
    switch (action.type) {

        //פונקציה המחזירה את כל המוצרים
        case 'LOAD_PRODUCTS': { state.products = action.payload; break; }

        //פונקציה המוסיפה מוצר חדש למערכת
        case 'ADD_MACHINE': { state.products = action.payload; break; }

        //פונקציה המעדכנת פרטי מוצר מסוים
        case 'UPDATE_MACHINE': { state.products = action.payload; break; }
        //
        case 'UPDATE_CURRENT_MACHINE': {state.currentprod = action.payload; break;}

        //פונקציה המוחקת מוצר מסוים (על פי מספר מזהה) ושומרת את המוצר האחרון שנמחק
        case 'DELETE_MACHINE': {
            debugger
            state.lastDeleted = action.payload;
            for (let index = 0; index < state.products.length; index++) {
                debugger
                if (state.products[index].prodId === state.lastDeleted.prodId)
                {
                    state.products.splice(index)
                    break;
                }
            }
            break;
        }
        case 'CURRENT_TO_UPDATE':{state.current= action.payload; break}
    }
}, ProductIntialState)