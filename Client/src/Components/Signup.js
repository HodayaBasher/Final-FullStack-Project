//import jQuery from '../assets/js/jquery.easing.1.3'
import React from "react";
import '../Style/Login.css';
import Head from './Head';
import Footer from './Footer'



//יבוא קריאות שרת
import { getAllUsersFromServer, getUserByNameAndPasswordFromServer, AddUserInServer } from '../Redux/Users/UserThunk'

import { statusCurrentUser, updateNameCurrentUser } from '../Redux/Users/UserActions'

//React Hooks
//#region 
import { useDispatch, useSelector } from 'react-redux';
import { useEffect, useState } from 'react';
//#endregion

const Signup = ({ history }) => {

    let dispatch = useDispatch()

    //משתנה המכיל את קוד מנהל המערכת
    const managerPassword = useSelector((store) => { return store.users.managerPassword; })
    //משתנה המכיל את שם המנהל
    const managerName = useSelector((store) => { return store.users.managerName; })
    //משתנה המכיל את כל המשתמשים
       const users = useSelector((store) => { return store.users.Users })

    let massage = document.getElementById('massage');


    //פונקציה המתבצעת מיד עם טעינת הקומפוננטה
    useEffect(async () => {
        await getAllUsersFromServer(dispatch)
        //בעת פתיחת הטופס- מבצע התנתקות מהמשתמש הנוכחי שהיה עד כה
        dispatch(statusCurrentUser(0));
        await dispatch(updateNameCurrentUser("guest"))
        console.log(users);

    }, [])

    //
    const login = async (e) => {

        e.preventDefault();
        const user_email =e.target['user_email'].value;
        const user_login =  e.target['user_login'].value
        const userpass =  e.target['userpass'].value;
        //בדיקה האם השדות לא ריקים
        if (userpass == '' || user_login == '') {
            massage.value = "Please fill out all the fileds"
            showMassage()
        }

        else //אם השדות מלאים- בדיקה מהו המשתמש
        {
            //אם הסיסמא זהה לסיסמת המנהל- שינוי סטטוס משתמש למנהל וניתוב לאיזור מנהל
            if (userpass == managerPassword && user_login == managerName) {
                dispatch(statusCurrentUser(2));
                await dispatch(updateNameCurrentUser("Admin"))
                history.push({ pathname: "/Admin" });
            }
            //אחרת- ביצוע קריאת שרת כדי לבדוק אם המשתמש רשום במערכת
            else {
                //קריאת שרת הבודקת האם המשתמש רשום במערכת
                let current = await getUserByNameAndPasswordFromServer(dispatch, user_login, userpass);
                await console.log(current);

                //אם המשתמש אינו רשום במערכת- ניתוב המשתמש להרשמה
                if (current == "" || current == 'undefined') {
                    massage.value = "sorry you are not found, you can sign up now"
                    showMassage()
                    change()
                }

                //אם המשתמש רשום- ניתוב המשתמש לדף הבית
                else {
                    dispatch(statusCurrentUser(1));
                    massage.value = current.customerName + ", welcome to our shop"
                    updateNameCurrentUser(current)
                    history.push({ pathname: "/" })
                    //שמירה במשתנה הגלובלי את המשתמש הנוכחי
                    await dispatch(updateNameCurrentUser(current.customerName))
                }
            }
        }
    }

    //פונקצית כניסה למערכת עם שם משתמש וסיסמא - עבור משתמש קיים
    const change = (e) => {
        debugger
        const signup =  e.target['signup']
        signup.setAttribute('class', 'active11')
        const login = e.target['login']
        login.setAttribute('class', '')
        const login_tab_content =  e.target['ll']
        login_tab_content.style.display = "none"
        const signup_tab_content = e.target['signup-tab-content']
        signup_tab_content.setAttribute('class', 'active11')
    }

    //פונקציית הרשמה למערכת - עבור משתמש שאינו קיים
    const signUp = async (e) => {
        debugger; 
        //משתנה המכיל ערך בוליאני האם המשתמש הנרשם כרגע כבר תפוס- מאותחל על פנוי
        var isAlready = false;

        //יצירת אובייקט לקוח מכל שדות המילוי
        var newCustomer = {
            customerID: (Number)(e.target['user_pass'].value) ,
            customerName: e.target['user_name'].value,
            customerPassword: e.target['user_email'].value,
            creditCardNumber: "no number"
        }
        let customerID = e.target['user_email'].value
        let customerName = e.target['user_name'].value
        let customerPassword = e.target['user_pass'].value
        //בדיקה אם כל שדות המילוי מלאים- אם לא הודעה למשתמש על מילוי כל השדות והחזרתו לרישום
        if (customerID == '' || customerName == '' || customerPassword == '') {
            massage.value = "Please fill all the inputs"
            showMassage()
            return;
        }

        // מעבר על כל רשימת הלקוחות- במידה וקיים לקוח עם אותו שם ואותו סיסמא- 
        // בקשה מהשתמש להכניס סיסמא שונה כי המשתמש תפוס
        users.map((item) => {
            if (item.customerID == newCustomer.customerID && item.customerPassword == newCustomer.customerPassword) {
                //הודעה למשתמש
                massage.value = "sorry, but this user is already taken, please enter a different email & password"
                showMassage()
                //ריקון שדה הסיסמא
                e.target['user_email'].value = '';
                e.target['user_pass'].value = '';
                //המשתמש תפוס- לא תינתן לפתוח חשבון חדש על אותו משתמש כדי למנוע כפילות משתמשים
                isAlready = true;
                //ברגע שנמצא כי משתמש זה תפוס- יציאה מהלולאה
                return;
            }
        })
        //רק אם המשתמש שנרשם אינו תפוס- ביצוע הרשמה: הוספת הלקוח הזה לרשימת הלקוחות
        if (isAlready == false) {
            //הוספת לקוח חדש לבסיס הנתונים
            await AddUserInServer(dispatch, newCustomer);
            dispatch(statusCurrentUser(1));
            alert(newCustomer.customerName + ", welcome to our shop");
            updateNameCurrentUser(newCustomer.customerName)
            history.push({ pathname: "/" })
            //שמירה במשתנה הגלובלי את המשתמש הנוכחי
            await dispatch(updateNameCurrentUser(newCustomer.customerName))
        }
    }
    //פונקציה המראה הודעה למשתמש במקרה ויש בעיה ברישום
    function showMassage(e) {
        var x = e.target['massage'].value;
        x.className = "show";
        setTimeout(function () { x.className = x.className.replace("show", ""); }, 3000);
    }  
    return <>
        <body id="Loginbody">
            <div className="form-wrap">
                <div className="tabs">
                    <h3 className="signup-tab"><a href="#signup-tab-content" id="signup">Sign Up</a></h3>
                    <h3 className="login-tab"><a href="#login-tab-content" id="login" className="active11">Login</a></h3>
                </div>
                {/* < !--.tabs--> */}

                <div className="tabs-content">
                    <div id="signup-tab-content">
                        <form className="signup-form" action="" method="post" onSubmit={(e)=>{signUp(e)}}>
                            <input type="email" className="input11" placeholder="Email" name="user_email" />
                            <input type="text" className="input11" placeholder="Username" name="user_name" />
                            <input type="password" className="input11"  placeholder="Password" name="user_pass" />
                            <input type="button" className="button11" value="Sign Up" onClick={signUp} />
                        </form>
                        {/* <!--.login-form--> */}
                        <div className="help-text">
                            <p>By signing up, you agree to our</p>
                            <p><a href="#">Terms of service</a></p>
                        </div>
                    </div>
                    {/* <!--.signup-tab-content--> */}

                    <div id="ll">
                        <div id="login-tab-content" className="active11">
                            <form className="login-form" action="" method="post" onSubmit={(e)=>{login(e)}}>
                                <input type="text" className="input11" placeholder="Email or Username" name="user_login"/>
                                <input type="password" className="input11"  placeholder="Password" name="userpass"/>
                                <input type="checkbox" className="checkbox111" name="remember_me"/>
                                <label for="remember_me">Remember me</label>

                                <input type="button" className="button11" value="Login" onClick={login} />
                            </form>
                            {/* <!--.login-form--> */}

                            <div className="help-text">
                                <p><a href="#">Forget your password?</a></p>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div id="massage" className="massageBottom"></div>
        </body>
    </>
}
export default Signup;