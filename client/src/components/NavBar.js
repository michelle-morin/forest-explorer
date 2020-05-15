import React from 'react';
import { Link } from 'react-router-dom';

function NavBar() {
  return (
    <React.Fragment>
      <h1>Forest Explorer</h1>
      <Link to="/">Home</Link>
      <Link to="/explore">Explore</Link>
      <Link to="/plan">Plan</Link>
    </React.Fragment>
  );
}

export default NavBar;