import React from 'react';
import path from './../assets/img/path.png';
import tree from './../assets/img/tree.png';

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
    left: '15vw',
    top: '15vh',
    fontSize: '5rem'
  }
  const treeOneStyle = {
    position: 'absolute',
    left: '0vw',
    top: '40vh',
    transform: 'scale(.5)'
  }
  const treeTwoStyle = {
    position: 'absolute',
    left: '20vw',
    top: '15vh',
    transform: 'scale(.5)'
  }
  const treeThreeStyle = {
    position: 'absolute',
    left: '85vw',
    top: '-5vh',
    transform: 'scale(.5)'
  }
  const treeFourStyle = {
    position: 'absolute',
    left: '50vw',
    top: '10vh',
    transform: 'scale(.5)'
  }
  const treeFiveStyle = {
    position: 'absolute',
    left: '60vw',
    top: '-22vh',
    transform: 'scale(.5)'
  }

  return (
    <React.Fragment>
      <img src={path} style={backgroundStyles} alt="running path" />
      <h1 style={brandStyles}>Forest Explorer</h1>
      <img src={tree} style={treeOneStyle} alt="watercolor tree" />
      <img src={tree} style={treeTwoStyle} alt="watercolor tree" />
      <img src={tree} style={treeThreeStyle} alt="watercolor tree" />
      <img src={tree} style={treeFourStyle} alt="watercolor tree" />
      <img src={tree} style={treeFiveStyle} alt="watercolor tree" />
    </React.Fragment>
  );
}

export default Splash;