

//המוצרים בסל בקניות
export function AllProductsInCart(item) {
    console.log(item);
    return{type:'ALL_PRODUCTS_IN_CART', payload: item}  
}

//הוספת מוצר לסל קניות
export function AddProdToCart(item){
    console.log(item)
    return {type:"ADD_PROD_TO_CART",payload:item}
}

//עידכון מוצר בסל קניות
export function UpdateProdInCart(item, i){
    debugger;
    console.log(item)
    console.log(i)
    return {type:"UPDATE_PROD_IN_CART",payload:{"item":item,"index":i}}
}

//מחיקת מוצר בסל קניות
export function DeleteProdInCart(item, i){
    debugger;
    console.log(item)
    return {type:"DELETE_PROD_IN_CART",payload:{"item":item,"index":i}}
}

//ריקון הסל קניות
export function RemoveAllProductsFromCart(){
    return {type:"REMOVE_ALL_PRODUCTS_FROM_CART"}
}
