import AliceCarousel from 'react-alice-carousel';
import "react-alice-carousel/lib/alice-carousel.css";
import bg_1 from "../assets/images/view1.jpg";
import "../Style/SlideShow.css"


const SlideShow = () => {
  return (
    <>
     <AliceCarousel autoPlay="true" autoPlayControls autoPlayInterval="2000" disableDotsControls infinite keyboardNavigation >
      <img src={bg_1} className="sliderimg"/>
     </AliceCarousel> 
    </>
  );
}
export default SlideShow;