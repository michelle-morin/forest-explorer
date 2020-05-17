import React from 'react';
import Explore from './Explore';
import Planner from './Planner';
import Splash from './Splash';
import AboutPage from './AboutPage';
import { BrowserRouter, Switch, Route } from 'react-router-dom';

function App() {
  return (
    <BrowserRouter>
      <Switch>
        <Route path="/explore">
          <Explore />
        </Route>
        <Route path="/plan">
          <Planner />
        </Route>
        <Route path="/about">
          <AboutPage />
        </Route>
        <Route path="/">
          <Splash />
        </Route>
      </Switch>
    </BrowserRouter>
  );
}

export default App;
