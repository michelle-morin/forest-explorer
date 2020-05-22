import React from 'react';
import path from './../assets/img/path.png';
import tree from './../assets/img/tree.png';
import { Link } from 'react-router-dom';

function Splash() {
  const backgroundStyles = {
    position: 'relative',
    top: '0',
    bottom: '0',
    right: '0',
    left: '0',
    height: '100vh',
    width: '100vw'
  }
  const brandStyles = {
    position: 'absolute',
    fontFamily: 'Architectural',
    left: '12vw',
    top: '15vh',
    fontSize: '7rem',
    color: '#111111',
    textShadow: '2px 8px 6px rgba(0,0,0,0.2), 0px -5px 35px rgba(255,255,255,0.3)'
  }
  const linkBoxStyles = {
    position: 'absolute',
    fontFamily: 'Architectural',
    left: '12vw',
    top: '28vh',
    fontSize: '3rem'
  }
  const linkStyle = {
    color: '#111111',
    marginRight: '20%',
    textShadow: '2px 8px 6px rgba(0,0,0,0.2), 0px -5px 35px rgba(255,255,255,0.3)'
  }
  const treeOneStyle = {
    position: 'absolute',
    left: '0vw',
    top: '30vh',
    transform: 'scale(.75)'
  }
  const treeTwoStyle = {
    position: 'absolute',
    left: '25vw',
    top: '13vh',
    transform: 'scale(.55)'
  }
  const treeThreeStyle = {
    position: 'absolute',
    left: '85vw',
    top: '-15vh',
    transform: 'scale(.35)'
  }
  const treeFourStyle = {
    position: 'absolute',
    left: '50vw',
    top: '7vh',
    transform: 'scale(.45)'
  }
  const treeFiveStyle = {
    position: 'absolute',
    left: '60vw',
    top: '-18vh',
    transform: 'scale(.4)'
  }

  return (
    <React.Fragment>
      <img src={path} style={backgroundStyles} alt="watercolor running path" />
      <h1 style={brandStyles}>Forest Explorer</h1>
      <div style={linkBoxStyles}>
        <Link to="/explore" style={linkStyle}>Explore</Link>
        <Link to="/plan" style={linkStyle}>Plan</Link>
        <Link to="/about" style={linkStyle}>About</Link>
      </div>
      <img src={tree} style={treeOneStyle} alt="watercolor douglas fir tree painted with the iconic blue diamond milemarkers of Wildwood Trail" />
      <img src={tree} style={treeTwoStyle} alt="watercolor douglas fir tree painted with the iconic blue diamond milemarkers of Wildwood Trail" />
      <img src={tree} style={treeThreeStyle} alt="watercolor douglas fir tree painted with the iconic blue diamond milemarkers of Wildwood Trail" />
      <img src={tree} style={treeFourStyle} alt="watercolor douglas fir tree painted with the iconic blue diamond milemarkers of Wildwood Trail" />
      <img src={tree} style={treeFiveStyle} alt="watercolor douglas fir tree painted with the iconic blue diamond milemarkers of Wildwood Trail" />
    </React.Fragment>
  );
}

export default Splash;