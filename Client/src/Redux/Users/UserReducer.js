import produce from 'immer';

const UsersIntialState = {
    //שמירת כל הלקוחות
    Users: [],

    // correntUser: 'guest',
    //שמירת משתמש האחרון שנוסף למערכת
    UserAdding: [],

    managerName: "Hodaya Basher",
    managerPassword: "12345",
    statusCurrentUser: "0",
    
    //שמירת משתמש נוכחי- מצב התחלתי- אורח
    currentUser:"guest"
}

export const UserReducer = produce((state, action) => {
    debugger
    switch (action.type) {

        //פונקציה המחזירה את כל רשימת הלקוחות
        case 'LOAD_USERS': { state.Users = action.payload; break; }

        //פונקציה המחזירה לקוח על פי שמו ומספר מזהה
        //יש לשמור את הלקוח המוחזר- כדי לזהות משתמש נוכחי
        case 'GET_USER_BY_NAME_AND_PASSWORD': { state.currentUser = action.payload; break; }

        //פונקציה המוסיפה לקוח חדש למערכת
        case 'ADD_USER': { state.Users= action.payload; break; }

        //פונקציה המעדכנת את סטטוס משתמש נוכחי (0-אורח, 1-משתמש קיים, 2-מנהל המערכת)
        case 'STATUS_CURRENT_USER': { state.statusCurrentUser = action.payload; break; }

        //פונקציה המעדכנת את שם משתמש נוכחי (הסטטוס =1)
        case 'UPDATE_NAME_CURRENT_USER': { state.currentUser = action.payload; break; }
    }
}, UsersIntialState)