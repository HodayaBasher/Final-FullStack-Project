

const Footer = () => {
    return <>
        <hr />

        {/* <section className="ftco-section ftco-partner">
            <div className="container">
                <div className="row">
                    <div className="col-sm ftco-animate">
                        <a href="/#" className="partner"><img src={partner_1} className="img-fluid" alt="Colorlib Template" /></a>
                    </div>
                    <div className="col-sm ftco-animate">
                        <a href="/#" className="partner"><img src={partner_2} className="img-fluid" alt="Colorlib Template" /></a>
                    </div>
                    <div className="col-sm ftco-animate">
                        <a href="/#" className="partner"><img src={partner_3} className="img-fluid" alt="Colorlib Template" /></a>
                    </div>
                    <div className="col-sm ftco-animate">
                        <a href="/#" className="partner"><img src={partner_4} className="img-fluid" alt="Colorlib Template" /></a>
                    </div>
                    <div className="col-sm ftco-animate">
                        <a href="/#" className="partner"><img src={partner_5} className="img-fluid" alt="Colorlib Template" /></a>
                    </div>
                </div>
            </div>
        </section> */}
        <section className="ftco-section ftco-no-pt ftco-no-pb py-5 bg-light">
            <div className="container py-4">
                <div className="row d-flex justify-content-center py-5">
                    <div className="col-md-6">
                        <h2 style={{ fontSize: '22px' }} className="mb-0">Subcribe to our Newsletter</h2>
                        <span>Get e-mail updates about our latest shops and special offers</span>
                    </div>
                    <div className="col-md-6 d-flex align-items-center">
                        <form action="/#" className="subscribe-form" style={{width:"110%"}}>
                            <div class="form-group d-flex">
                                <input type="text" className="form-control" placeholder="Enter email address" />
                                <input type="submit" value="Subscribe" className="btnChangeColor" style={{ padding:"2%", borderRadius:"0.1px"}} />
                            </div>
                        </form>
                    </div>
                </div>
            </div>
        </section>
        <footer className="ftco-footer ftco-section">
            <div className="container">
                <div className="row">
                    <div className="mouse" style={{margin:"auto", marginTop:"-3%"}}>
                        <a href="/#" className="mouse-icon">
                            <div style={{backgroundColor:"#50c0e5", padding:"18px", paddingLeft:"30px", paddingRight:"30px", borderRadius:"50%"}}><span className="ion-ios-arrow-up" style={{color:"white"}}></span></div>
                        </a>
                    </div>
                </div>
                <div className="row mb-5" style={{marginTop:"3%"}}>
                    <div className="col-md">
                        <div className="ftco-footer-widget mb-4">
                            <h2 className="ftco-heading-2">Vegefoods</h2>
                            <p>Far far away, behind the word mountains, far from the countries Vokalia and Consonantia.</p>
                            <ul className="ftco-footer-social list-unstyled float-md-left float-lft mt-5">
                                <li className="ftco-animate"><a href="/#"><span className="icon-twitter"></span></a></li>
                                <li className="ftco-animate"><a href="/#"><span className="icon-facebook"></span></a></li>
                                <li className="ftco-animate"><a href="/#"><span className="icon-instagram"></span></a></li>
                            </ul>
                        </div>
                    </div>
                    <div className="col-md">
                        <div className="ftco-footer-widget mb-4 ml-md-5">
                            <h2 className="ftco-heading-2">Menu</h2>
                            <ul className="list-unstyled">
                                <li><a className="py-2 d-block">Shop</a></li>
                                <li><a className="py-2 d-block">About</a></li>
                                <li><a className="py-2 d-block">Journal</a></li>
                                <li><a className="py-2 d-block">Contact Us</a></li>
                            </ul>
                        </div>
                    </div>
                    <div className="col-md-4">
                        <div className="ftco-footer-widget mb-4">
                            <h2 className="ftco-heading-2">Help</h2>
                            <div className="d-flex">
                                <ul className="list-unstyled mr-l-5 pr-l-3 mr-4">
                                    <li><a href="" className="py-2 d-block">Shipping Information</a></li>
                                    <li><a className="py-2 d-block">Returns &amp; Exchange</a></li>
                                    <li><a className="py-2 d-block">Terms &amp; Conditions</a></li>
                                    <li><a className="py-2 d-block">Privacy Policy</a></li>
                                </ul>
                                <ul className="list-unstyled">
                                    <li><a className="py-2 d-block">FAQs</a></li>
                                    <li><a className="py-2 d-block">Contact</a></li>
                                </ul>
                            </div>
                        </div>
                    </div>
                    <div className="col-md">
                        <div className="ftco-footer-widget mb-4">
                            <h2 className="ftco-heading-2">Have a Questions?</h2>
                            <div className="block-23 mb-3">
                                <ul>
                                    <li><span className="icon icon-map-marker"></span><span className="text">203 Fake St. Mountain View, San Francisco, California, USA</span></li>
                                    <li><a ><span className="icon icon-phone"></span><span className="text">+2 392 3929 210</span></a></li>
                                    <li><a ><span className="icon icon-envelope"></span><span className="text">info@yourdomain.com</span></a></li>
                                </ul>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-12 text-center">

                        <p>
                            VegeFoods &copy;<script>document.write(new Date().getFullYear());</script> All rights reserved | Powered <i className="icon-heart color-danger" aria-hidden="true"></i> by <a href="https://colorlib.com" target="_blank">Hodaya Basher</a>

                        </p>
                    </div>
                </div>
            </div>
        </footer>
    </>
}
export default Footer;