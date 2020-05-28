import React from 'react';
import path from './../assets/img/path.png';
import tree from './../assets/img/tree.png';
import { Link } from 'react-router-dom';
import styled from 'styled-components';

const RunningPath = styled.img`
  position: relative;
  top: 0;
  left: 0;
  bottom: 0;
  right: 0;
  height: 100vh;
  width: 100vw;
  @media (max-width: 500px) {
    top: 20vh;
    height: 80vh;
  }
`;

const SplashTitle = styled.h1`
  position: absolute;
  font-family: 'Architectural';
  left: 12vw;
  top: 15vh;
  font-size: 7rem;
  color: #111111;
  text-shadow: 2px 8px 6px rgba(0,0,0,0.2), 0px -5px 35px rgba(255,255,255,0.3);
  @media (max-width: 500px) {
    font-size: 4rem;
    z-index: 10000;
  }
`;

const LinkBox = styled.div`
  position: absolute;
  font-family: 'Architectural';
  left: 12vw;
  top: 28vh;
  font-size: 3rem;
  z-index: 1000;
  @media (max-width: 500px) {
    top: 35vh;
    font-size: 2rem;
    z-index: 10000;
>>>>>>> responsiveSplash
  }
`;

const TreeOne = styled.img`
  position: absolute;
  left: 0vw;
  bottom: 0vh;
  max-height: 75%;
  width: auto;
  @media (max-width: 1024px) and (max-height: 1366px) {
    max-height: 40%;
    height: auto;
    left: -2vw;
  }
  @media (max-width: 768px) {
    max-height: 40%;
    height: auto;
    left: -2vw;
  }
`;

const TreeTwo = styled.img`
  position: absolute;
  left: 35vw;
  top: 24vh;
  max-height: 50%;
  width: auto;
  @media (max-width: 1024px) and (max-height: 1366px) {
    display: none;
  }
  @media (max-width: 768px) {
    display: none;
  }
`;

const TreeThree = styled.img`
  position: absolute;
  left: 90vw;
  top: 5vh;
  max-height: 30%;
  width: auto;
  @media (max-width: 1024px) and (max-height: 1366px) {
    max-height: 20%;
    top: 10vh;
    left: 85vw;
  }
  @media (max-width: 768px) {
    max-height: 20%;
    top: 10vh;
    left: 85vw;
  }
`;

const TreeFour = styled.img`
  position: absolute;
  left: 58vw;
  top: 28vh;
  max-height: 40%;
  width: auto;
  @media (max-width: 1024px) and (max-height: 1366px) {
    max-height: 25%;
    top: 50vh;
    left: 55vw;
  }
  @media (max-width: 768px) {
    max-height: 25%;
    top: 50vh;
    left: 55vw;
  }
`;

const TreeFive = styled.img`
  position: absolute;
  left: 70vw;
  top: 1vh;
  max-height: 35%;
  width: auto;
  @media (max-width: 1024px) and (max-height: 1366px) {
    display: none;
>>>>>>> responsiveSplash
  }
  @media (max-width: 768px) {
    display: none;
  }
`;

function Splash() {
  const linkStyle = {
    color: '#111111',
    marginRight: '20%',
    textShadow: '2px 8px 6px rgba(0,0,0,0.2), 0px -5px 35px rgba(255,255,255,0.3)'
  }

  return (
    <React.Fragment>
      <RunningPath src={path} alt="watercolor running path" />
      <SplashTitle>Forest Explorer</SplashTitle>
      <LinkBox>
        <Link to="/explore" style={linkStyle}>Explore</Link>
        <Link to="/plan" style={linkStyle}>Plan</Link>
        <Link to="/about" style={linkStyle}>About</Link>
      </LinkBox>
      <TreeOne src={tree} alt="watercolor douglas fir tree painted with the iconic blue diamond milemarkers of Wildwood Trail" />
      <TreeTwo src={tree} alt="watercolor douglas fir tree painted with the iconic blue diamond milemarkers of Wildwood Trail" />
      <TreeThree src={tree} alt="watercolor douglas fir tree painted with the iconic blue diamond milemarkers of Wildwood Trail" />
      <TreeFour src={tree} alt="watercolor douglas fir tree painted with the iconic blue diamond milemarkers of Wildwood Trail" />
      <TreeFive src={tree} alt="watercolor douglas fir tree painted with the iconic blue diamond milemarkers of Wildwood Trail" />
    </React.Fragment>
  );
}

export default Splash;