import { Link } from 'react-router-dom';
import { useSelector } from 'react-redux';

//קומפוננטת ראש העמוד- ניתוב גלובלי עבור כל קופוננטה
const Head = () => {

    //משתנה המכיל פרטים על המשתמש הנוכחי
    const currentUser= useSelector((store)=>{ return store.users.currentUser})
    return <>
    <div className="py-1" style={{ backgroundColor: "rgb(122,196,233)" }}>
            <div className="container">
                <div className="row no-gutters d-flex align-items-start align-items-center px-md-0">
                    <div className="col-lg-12 d-block">
                        <div className="row d-flex">
                            <div className="col-md pr-4 d-flex topper align-items-center">
                                <div className="icon mr-2 d-flex justify-content-center align-items-center"><span className="icon-phone2"></span></div>
                                <span className="text">+ 1235 2355 98</span>
                            </div>
                            <div className="col-md pr-4 d-flex topper align-items-center">
                                <div className="icon mr-2 d-flex justify-content-center align-items-center"><span className="icon-paper-plane"></span></div>
                                <span className="text">Zmedicair@email.com</span>
                            </div>
                            <div className="col-md-5 pr-4 d-flex topper align-items-center text-lg-right">
                                <span className="text">3-5 Business days delivery &amp; Free Returns</span>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>

        <nav className="navbar navbar-expand-lg  ftco_navbar  ftco-navbar-light" id="ftco-navbar">
            <div className="container">
                <a className="navbar-brand" href="#" style={{  position: 'absolute',left: '1%', color: "rgb(122,196,233)", fontWeight: 800, fontSize: "20px", textTransform: "uppercase" }}>Zmedicair</a>
                <button className="navbar-toggler" type="button" data-toggle="collapse" data-target="#ftco-nav" aria-controls="ftco-nav" aria-expanded="false" aria-label="Toggle navigation">
                    <span className="oi oi-menu"></span> Menu
                </button>
                <Link to="/Shop">
                <input  class="btnChangeColor" type="button" style={{ padding: "2%", textAlign: "center", width: "130%" }} value="לרכישת המכשיר" />
                </Link>



                <div className="collapse navbar-collapse" id="ftco-nav"  >
                    <ul className="navbar-nav ml-auto">

                        <li className="nav-item "><Link to="/" className="nav-link" style={{ color: "black" }}>דף הבית</Link></li>
                        <li className="nav-item"><Link  to="/Shop"  className="nav-link" style={{ color: "black" }}>חנות</Link></li>
                        <li className="nav-item"><Link to="/About" className="nav-link" style={{ color: "black" }}>אודות</Link></li>
                        <li className="nav-item"><Link to="/Signup" className="nav-link" style={{ color: "black" }}>התחברות</Link></li>
                        <li className="nav-item cta cta-colored"><Link to="/Cart" className="nav-link" style={{ color: "black" }}><span><i className="ion-ios-cart"></i>[]</span></Link></li>
                        <li className="nav-item" style={{  position: 'absolute',right: '2%',color: "rgb(122,196,233)", fontWeight: 800, fontSize: "20px" }}>{currentUser}</li>
                       
                      
                    </ul>
                </div>
            </div>
        </nav>
    </>
}
export default Head;