//החזרת כל הלקוחות
export function LoadUsers(items) {
    return { type: "LOAD_USERS", payload: items };
}

//החזרת לקוח על פי שמו ומספר מזהה
//יש לשמור את הלקוח המוחזר- כדי לזהות משתמש נוכחי
export function getUserByNameAndPassword(items) {
    console.log(items)
    return { type: "GET_USER_BY_NAME_AND_PASSWORD", payload: items }
}

//הוספת לקוח חדש למערכת
export function addUser(item) {
    return { type: "ADD_USER", payload: item }
}

//עידכון סטטוס משתמש נוכחי (0-אורח, 1-משתמש קיים, 2-מנהל המערכת)
export function statusCurrentUser(item){
    return {type: "STATUS_CURRENT_USER", payload: item}
}

//עידכון שם משתמש נוכחי
export function updateNameCurrentUser(item){
    return {type: "UPDATE_NAME_CURRENT_USER", payload: item}
}