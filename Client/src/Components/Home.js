import React from "react";
import { Link } from 'react-router-dom';
import { useDispatch, useSelector } from 'react-redux';
import { useEffect, useState } from 'react';

//יבוא קריאות שרת
//#region 
import { getAllUsersFromServer } from '../Redux/Users/UserThunk'
//#endregion

//יבוא קבצי עיצוב
//#region 
import '../Style/Home.css'
//assets/css/bootstrap
import '../assets/css/bootstrap/bootstrap-grid.css'
import '../assets/css/bootstrap/bootstrap-reboot.css'
//assets/css/css
import '../assets/css/css/mixins/_text-hide.css'
import '../assets/css/css/bootstrap-reboot.css'

// import '../assets/css/style.css'
import '../assets/css/jquery.timepicker.css'
import '../assets/css/animate.css'
import '../assets/css/aos.css'
import '../assets/css/bootstrap-datepicker.css'
import '../assets/css/bootstrap.min.css'
import '../assets/css/magnific-popup.css'
import '../assets/css/open-iconic-bootstrap.min.css'
import '../assets/css/owl.carousel.min.css'
import '../assets/css/owl.theme.default.min.css'

//font
import '../assets/fonts/flaticon/font/flaticon.css'
//  import '../assets/fonts/flaticon/font/_flaticon.scss'
import '../assets/fonts/ionicons/css/ionicons.min.css'
//#endregion

//יבוא תמונות מערכת
//#region 
import FREE_SHIPPING from '../assets/images/FREE_SHIPPING.png'
import ALWAYS_FRESH from '../assets/images/ALWAYS_FRESH.png'
import SUPERIOR_QUALITY from '../assets/images/SUPERIOR_QUALITY.png'
import SUPPORT from '../assets/images/SUPPORT.png'

//#endregion

//יבוא קומפוננטות
//#region 
import SlideShow from "./SlideShow";
//#endregion


//קומפוננטת דף הבית
const Home = ({history}) => {


	let dispatch = useDispatch();

	
	const StoreUsers = useSelector((state) => { return state.users.Users })

	//פונקציה הנטענת מיד עם טעינת הקומפוננטה
	useEffect(async () => {
		await getAllUsersFromServer(dispatch)}, [])

		
	var i = 1

	return (
		<>

			<body className="goto-here">
				<SlideShow></SlideShow>

				<section className="ftco-section" style={{ padding: "7%", paddingLeft: "15%" }}>
					<div className="container">
						<div className="row no-gutters ftco-services">
							<div className=" text-center d-flex align-self-stretch ftco-animate col-md-3">
								<div className="media block-6 services mb-md-0 mb-4">
									<div className="media-body">
										<img src={FREE_SHIPPING}></img>
										<h3 className="heading">Free Shipping</h3>
										<span>On order over $100</span>
									</div>
								</div>
							</div>

							<div className=" text-center d-flex align-self-stretch ftco-animate col-md-3">
								<div className="media block-6 services mb-md-0 mb-4">
									<div className="media-body">
										<img src={ALWAYS_FRESH}></img>
										<h3 className="heading">Always Fresh</h3>
										<span>Product well package</span>
									</div>
								</div>
							</div>
							<div className=" text-center d-flex align-self-stretch ftco-animate col-md-3">
								<div className="media block-6 services mb-md-0 mb-4">
									<div className="media-body">
										<img src={SUPERIOR_QUALITY}></img>
										<h3 className="heading">Superior Quality</h3>
										<span>Quality Products</span>
									</div>
								</div>
							</div>
							<div className=" text-center d-flex align-self-stretch ftco-animate col-md-3">
								<div className="media block-6 services mb-md-0 mb-4">
									<div className="media-body">
										<img src={SUPPORT}></img>
										<h3 className="heading">Support</h3>
										<span>24/7 Support</span>
									</div>
								</div>
							</div>
						</div>
					</div>
				</section>

				
			</body>
		</>
	)
}
export default Home;