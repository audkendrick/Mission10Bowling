import './App.css';
import BowlerList from './BowlerList';

function Welcome() {
  return (
    <>
      <h1> Welcome to our Bowler Website!</h1>
      <h3> Take a look at your favorite players below.</h3>
      <br />
      <br />
      <br />
    </>
  );
}

function App() {
  return (
    <>
      <Welcome />
      <BowlerList />
    </>
  );
}

export default App;
