import './App.css';
import { BrowserRouter, Route } from 'react-router-dom';
//יבוא קומפוננטות
//#region 
import Home from './Components/Home'; //קומפוננטת דף הבית
import About from './Components/About';//קומפוננטת אודות
import Head from './Components/Head'; //ראש העמוד
import Footer from './Components/Footer'; //תחתית העמוד
import Admin from './Components/Admin' //אזור אישי מנהל
import Signup from './Components/Signup';//הרשמה לאתר
import Shop from './Components/Shop';//קומפוננטת חנות
//#endregion

function App() {
  return <>
    
    <BrowserRouter>
    <Head></Head>
      <Route path='/' exact component={Home} />
      <Route path='/About' component={About} />
      <Route path='/Admin' component={Admin} />
      <Route path='/Signup' component={Signup} />
      <Route path='/Shop' component={Shop} />
      <Footer></Footer>
    </BrowserRouter>
    
  </>
}

export default App;
