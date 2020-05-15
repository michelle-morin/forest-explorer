import React from 'react';
import TrailMap from './TrailMap';
import RoutePlanner from './RoutePlanner';
import NavBar from './NavBar';
import Splash from './Splash';
import { BrowserRouter, Switch, Route } from 'react-router-dom';

function App() {
  return (
    <BrowserRouter>
      <NavBar />
      <Switch>
        <Route path="/explore">
          <TrailMap />
        </Route>
        <Route path="/plan">
          <RoutePlanner />
        </Route>
        <Route path="/">
          <Splash />
        </Route>
      </Switch>
    </BrowserRouter>
  );
}

export default App;
