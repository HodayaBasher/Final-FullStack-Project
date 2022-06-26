import produce from 'immer';


const CartInitialState = {
    cart: [],
    isCart: [],
    ProdInCart: [],
    totalPricePerProd: 0,
    totalPrice: 0,
    CurentProd: [],
    count: 0,
    //סימון בדף המוצרים- כמה סוגי מוצרים נוספו לסל
    seeProductsCount: 0,
}

export const CartReducer = produce((state, action) => {

    switch (action.type) {

        //מוצרים בסל קניות
        case 'ALL_PRODUCTS_IN_CART': { state.cart = action.payload }


        //הוספת מוצר לסל
        case 'ADD_PROD_TO_CART': {
            debugger;
            //הוספה למערך המוצרים את המוצר להוספה
            state.ProdInCart.push(action.payload)
            //הוספה לתווית מעל הסל קניות
            state.seeProductsCount++
            //אם ניתן לבצע את הקנייה- חישוב תשלום קנייה
            if (action.payload.unitsInStock > 0)
                state.totalPrice += action.payload.productPrice
            break;
        }
        //עידכון מוצר בסל קניות
        case 'UPDATE_PROD_IN_CART': {
            debugger
            //אם העלו את כמות ההזמנה
            //יש צורך להמיר את הכמויות- מכיוון שהמערכת מחשבת אותם כמו מחרוזות
            //הבעיה נוצרת כאשר עדכנו את כמות ההזמנה מ9 ל10
            //בסדר מילוני 9 יותר גדול ולכן לא יכנס לתנאי הזה
            //הפתרון: המרת הכמויות ממחרוזות למספרים
            if (Number(state.ProdInCart[action.payload.index].countBuy) < Number(action.payload.item)) {
                //מעדכן את כמות ההזמנה במשתנה הגלובלי
                state.ProdInCart[action.payload.index].countBuy = Number(action.payload.item)
                //מחשב את התשלום עבור מוצר זה
                state.totalPricePerProd = (state.ProdInCart[action.payload.index].countBuy * state.ProdInCart[action.payload.index].productPrice)
                //מכניס את התשלום הסופי עבור מוצר זה למערך
                state.ProdInCart[action.payload.index].totalPrice = state.totalPricePerProd
                //מחשב את כל התשלום הסופי ושומר אותו במשתנה הגלובלי
                state.totalPrice += state.ProdInCart[action.payload.index].productPrice
                //הוספה לתווית מעל הסל קניות
                // state.seeProductsCount++;
            }

            //אם הורידו את כמות ההזמנה
            else {
                //מעדכן את כמות ההזמנה במשתנה הגלובלי
                state.ProdInCart[action.payload.index].countBuy = action.payload.item
                //מחשב את התשלום עבור מוצר זה
                state.totalPricePerProd = state.ProdInCart[action.payload.index].countBuy * state.ProdInCart[action.payload.index].productPrice
                //מכניס את התשלום הסופי עבור מוצר זה למערך
                state.ProdInCart[action.payload.index].totalPrice = state.totalPricePerProd
                //עידכון המחיר הסופי
                state.totalPrice -= state.ProdInCart[action.payload.index].productPrice
                //הורדה מהתווית מעל סל הקניות
                // state.seeProductsCount--;
            }
            break;
        }

        //מחיקת מוצר בסל קניות
        case 'DELETE_PROD_IN_CART': {
            debugger;
            state.ProdInCart.forEach(element => {
                if (element.productID == action.payload.item.productID) {
                    //הורדה מהתווית מעל סל הקניות את כמות המוצרים שהוזמנו ממוצר זה
                    // state.seeProductsCount -= action.payload.item.countBuy
                    state.seeProductsCount--
                    //עידכון המחיר הסופי
                    state.totalPrice -= action.payload.item.countBuy * action.payload.item.productPrice;
                    //מחיקת המוצר מסל הקניות
                    //המחיקה מתבצעת על פי אינדקס המוצר בסל קניות ולא על פי אינדקס המוצר במסד הנתונים
                    state.ProdInCart.splice(action.payload.index, 1)
                }
            });
            break;
        }
        case 'REMOVE_ALL_PRODUCTS_FROM_CART': {
            state.cart= [];
            state.isCart= [];
            state.ProdForCart= [];
            state.totalPricePerProd= 0;
            state.totalPrice= 0;
            state.CurentProd=[];
            state.count= 0;
            state.seeProductsCount=0;
            break;
        }
    }
}, CartInitialState)