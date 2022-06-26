
import React from "react";
import { Link } from 'react-router-dom';
import { useDispatch, useSelector } from 'react-redux';
import { useEffect, useState } from 'react';

import '../Style/Shop.css'

//יבוא קריאות שרת
import { getAllProductsFromServer } from '../Redux/Machines/MachineThunk' //מוצרים
import {UpdateCurrentMachine} from '../Redux/Machines/MachineActions';
import {AddProdToCart,DeleteProdInCart} from '../Redux/Cart/CartActions'

//קומפוננטת חנות
const Shop = () => {

	let dispatch = useDispatch();

	//שמירת רשימת כל המוצרים מהאחסון הגלובלי
	const StoreProducts = useSelector((state) => { return state.Machines.products; })

	//פונקציה הנטענת מיד עם טעינת הקומפוננטה
	useEffect(async () => {
		await getAllProductsFromServer(dispatch); //טעינת כל המוצרים מהשרת
	}, [])
	return (
		<>
         <div className="hero-wrap hero-bread" id="div_bgCart">
                <div className="container">
                    <div className="row no-gutters slider-text align-items-center justify-content-center">
                        <div className="col-md-9 ftco-animate text-center" style={{ marginTop: "13%" }}>
                            <p className="breadcrumbs"><span className="mr-2" ><a href="index.html" style={{ color: "white" }}>Home</a></span> <span style={{ color: "white" }}>Cart</span></p>
                            <h1 className="mb-0 bread" style={{ color: "white", fontWeight: 800, fontSize: "200%" }}>SHOP</h1>
                        </div>
                    </div>
                </div>
            </div>

			<body className="goto-here">
				<section className="ftco-section">
					<div className="container">
						<div className="row">
							{
								//מעבר על כל המוצרים ממסד הנתונים
								StoreProducts.map((item, index) =>
										<Product
										machineID={item.machineID}
										machineName={item.machineName}
										machinePrice={item.machinePrice}
										machineUnitsInStack={item.machineUnitsInStack}
										machineDescription={item.machineDescription}
										machineLength={item.machineLength}
										machineWidth={item.machineWidth}
										machineHeight={item.machineHeight}
										machineWeight={item.machineWeight}
										machineImg={item.machineImg}
											index= {index}
											current={item}
										></Product>
								)
							}
						</div>
					</div>
				</section>
			</body>

		</>
	)
}
export default Shop;


const Product = (Props) => {

	let dispatch = useDispatch();

	//המכיל את צבע הכתפור "הוסף לסל" להקל על המשתמש שידע שהפריט הזה הוסף לסל useState משתנה 
	const [cartBtnColor, setCartBtnColor] = useState('#82ae46')

	// ניגש לסטור ומביא את כל מוצרי הסל קניות
	const myCart = useSelector((store) => { return store.cart.ProdInCart })

	//פונקציה המתבצעת מיד עם טעינת הקומפוננטה
	//אם המוצר הנוכחי נמצא בסל קניות-
	//יש צורך לעדכן את התווית של הוספה לסל- נוסף בהצלחה ולשנות צבע רקע של נוסף
	//נצרך לשאול זאת מכיוון שאם עברנו לסל קניות ואז חזרנו למוצרים- מעודכן
	//(מכיון שכל מעבר מרענן את הקומפוננטה)
                    useEffect(async () => {
                        myCart.forEach(element => {
                            //אם המוצר קיים בסל קניות
                            if (element.productID == Props.productID) {
                                setCartBtnColor('green')
                            }
                        });
                    }, [])

	const addToCart = () => {
		if (cartBtnColor == "#82ae46") {
			setCartBtnColor('green'); //שינוי צבע הכפתור להקל על הלקוח
			let productToAdd = {
				MachineID: Props.MachineID, //קוד מוצר
				MachineName: Props.MachineName, //שם מוצר
				MachineUnitsInStack: Props.MachineUnitsInStack, //כמות במלאי ממוצר זה
				MachinePrice: Props.MachinePrice, //תשלום ליחידה
				MachineImg: Props.MachineImg, //ניתוב תמונת מוצר
				countBuy: 1, //כמות שנוספה לסל קניות ממוצר זה
				totalPrice: Props.productPrice, //תשלום סופי עבור מוצר זה (מחיר ליחידה* כמות ממוצר זה)
				isAddToCart: 1, //האם נוסף לסל
			}
			debugger;
			//הוספת המוצר הנ"ל לסל קניות השמור במשתנה הגלובלי
			dispatch(AddProdToCart(productToAdd))
		}
		else
		{
		
			setCartBtnColor('#82ae46')
			let productToRemove = {
				MachineID: Props.MachineID, //קוד מוצר
				MachineName: Props.MachineName, //שם מוצר
				MachineUnitsInStack: Props.MachineUnitsInStack, //כמות במלאי ממוצר זה
				MachinePrice: Props.MachinePrice, //תשלום ליחידה
				MachineImg: Props.MachineImg, //ניתוב תמונת מוצר
				countBuy: 1, //כמות שנוספה לסל קניות ממוצר זה
				totalPrice: Props.productPrice, //תשלום סופי עבור מוצר זה (מחיר ליחידה* כמות ממוצר זה)
				isAddToCart: 1, //האם נוסף לסל
			  }
			  dispatch(DeleteProdInCart(productToRemove, Props.index))
		}
	}

	return <>
		<div className="col-md-6 col-lg-3 ftco-animate" >
			<div className="product" style={{ border: "1px solid rgb(230, 228, 228)", marginTop: "5%", padding: "5%" }}>
				<Link to="/Product" style={{ textDecoration: "none" }} onClick={()=>{dispatch(UpdateCurrentMachine(Props.current))}}>
					<a href="/#" className="img-prod"><img className="img-fluid" src={`https://localhost:44340/Images/${Props.machineImg}`} />
						{/* <span className="status">30%</span> */}
						<div className="overlay"></div>
					</a>
				</Link>
				<div className="text py-3 pb-3 px-3 text-center">
					<h3 style={{ color: "black", textTransform: "uppercase", fontSize: "100%" }}>{Props.machineName}</h3>
					<div className="d-flex">
						<div className="pricing">
							<p className="price" style={{ color: "grey" }}><span className="mr-2 price-dc" style={{ color: "#82ae46" }}>${Props.machinePrice}</span><span className="price-sale">units in stock: {Props.machineUnitsInStack}kg</span></p>
						</div>
					</div>
					<div className="bottom-area  px-3 d-flex"   >
						<div className=" d-flex">
							<a className="add-to-cart d-flex justify-content-center align-items-center text-center" style={{ backgroundColor: "#82ae46", color: "white", padding: "30%", paddingRight: "40%", paddingLeft: "40%", borderRadius: "50%", fontSize: "70%" }}>
								<span><i className="oi oi-menu"></i></span>
							</a>
							<a className="buy-now d-flex justify-content-center align-items-center mx-1" style={{ backgroundColor: cartBtnColor, color: "white", padding: "30%", paddingRight: "40%", paddingLeft: "40%", borderRadius: "50%", fontSize: "70%" }}  onClick={addToCart} > 
								<span><i className="ion-ios-cart"></i></span>
							</a> 
                           
							<a className="heart d-flex justify-content-center align-items-center " style={{ backgroundColor: "#82ae46", color: "white", padding: "30%", paddingRight: "40%", paddingLeft: "40%", borderRadius: "50%", fontSize: "70%" }}>
								<span><i className="ion-ios-heart"></i></span>
							</a>
						</div>
					</div>
				</div>
			</div>
		</div>
	</>
}