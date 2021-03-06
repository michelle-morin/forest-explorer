import React from 'react';
import { Link } from 'react-router-dom';
import { Navbar, Nav } from 'react-bootstrap';

function NavBar() {

  return (
    <header>
      <Navbar collapseOnSelect fixed="top" expand="lg" bg="transparent">
        <Navbar.Brand as={Link} to="/">Forest Explorer</Navbar.Brand>
        <Navbar.Toggle aria-controls="responsive-navbar-nav" />
        <Navbar.Collapse id="responsive-navbar-nav">
          <Nav className="ml-auto">
            <Nav.Link as={Link} to="/explore">Explore</Nav.Link>
            <Nav.Link as={Link} to="/plan">Plan</Nav.Link>
            <Nav.Link as={Link} to="/about">About</Nav.Link>
          </Nav>
        </Navbar.Collapse>
      </Navbar>
    </header>
  );
}

export default NavBar;