import Head from "./Head"
import Footer from "./Footer"

//יבוא תמונות מערכת
//#region 
import FREE_SHIPPING from '../assets/images/FREE_SHIPPING.png'
import ALWAYS_FRESH from '../assets/images/ALWAYS_FRESH.png'
import SUPERIOR_QUALITY from '../assets/images/SUPERIOR_QUALITY.png'
import SUPPORT from '../assets/images/SUPPORT.png'
import AboutImg from '../assets/images/nice.jpg'
//#endregion

const About = ({history}) => {
    return <>
        <body className="goto-here">


            <div className="hero-wrap hero-bread" id="div_bgCart">
                <div className="container">
                    <div className="row no-gutters slider-text align-items-center justify-content-center">
                        <div className="col-md-9 ftco-animate text-center" style={{ marginTop: "13%" }}>
                            <p className="breadcrumbs"><span className="mr-2" ><a href="index.html" style={{ color: "white" }}>Home</a></span> <span style={{ color: "white" }}>Cart</span></p>
                            <h1 className="mb-0 bread" style={{ color: "white", fontWeight: 800, fontSize: "200%" }}>ABOUT US</h1>
                        </div>
                    </div>
                </div>
            </div>

            <section className="ftco-section ftco-no-pb ftco-no-pt bg-light">
                <div className="container" >
                    <div className="row" style={{ marginTop: "5%" }}>
                        <div className="col-md-5 p-md-5 img img-2 d-flex justify-content-center align-items-center" >
                            <img src={AboutImg} style={{ width: "95%" }}></img>
                            <a href="https://vimeo.com/45830194" className="icon popup-vimeo d-flex justify-content-center align-items-center" style={{ color: "white", backgroundColor: "rgb(122,196,233)", padding: "7%", borderRadius: "50%", marginLeft: "-60%", marginRight: "30%" }}>
                                <span className="icon-play">▷</span>
                            </a>
                        </div>
                        <div className="col-md-7 py-5 wrap-about pb-md-5 ftco-animate" >
                            <div className="heading-section-bold mb-4 mt-md-5">
                                <div className="ml-md-0">
                                    <h2 className="mb-4" style={{ fontWeight: "670", fontSize: "250%" }}>Welcome to Vegefoods an eCommerce website</h2>
                                </div>
                            </div>
                            <div className="pb-md-5">
                                <p>Far far away, behind the word mountains, far from the countries Vokalia and Consonantia, there live the blind texts. Separated they live in Bookmarksgrove right at the coast of the Semantics, a large language ocean.</p>
                                <p>But nothing the copy said could convince her and so it didn’t take long until a few insidious Copy Writers ambushed her, made her drunk with Longe and Parole and dragged her into their agency, where they abused her for their.</p>
                                <input className="btnChangeColor" type="button" style={{ padding: "2%", textAlign: "center", width: "50%" }} value="Shop now"  onClick={() => {history.push({ pathname: "/Shop" })}} />
                            </div>
                        </div>
                    </div>
                </div>
            </section>
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

            <section className="ftco-section ftco-counter img" id="divBg_3">
                <div className="container">
                    <div className="row justify-content-center py-5">
                        <div className="col-md-10">
                            <div className="row">
                                <div className="col-md-3 d-flex justify-content-center counter-wrap ftco-animate">
                                    <div className="block-18 text-center">
                                        <div className="text">
                                            <strong className="number" data-number="10000">0</strong>
                                            <span>Happy Customers</span>
                                        </div>
                                    </div>
                                </div>
                                <div className="col-md-3 d-flex justify-content-center counter-wrap ftco-animate">
                                    <div className="block-18 text-center">
                                        <div className="text">
                                            <strong className="number" data-number="100">0</strong>
                                            <span>Branches</span>
                                        </div>
                                    </div>
                                </div>
                                <div className="col-md-3 d-flex justify-content-center counter-wrap ftco-animate">
                                    <div className="block-18 text-center">
                                        <div className="text">
                                            <strong className="number" data-number="1000">0</strong>
                                            <span>Partner</span>
                                        </div>
                                    </div>
                                </div>
                                <div className="col-md-3 d-flex justify-content-center counter-wrap ftco-animate">
                                    <div className="block-18 text-center">
                                        <div className="text">
                                            <strong className="number" data-number="100">0</strong>
                                            <span>Awards</span>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </section>

        </body>
    </>
}
export default About