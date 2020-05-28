import React from 'react';
import path from './../assets/img/path.png';
import tree from './../assets/img/tree.png';
import { Link } from 'react-router-dom';
import styled from 'styled-components';

const SplashWrapper = styled.div`
  height: 100vh;
  width: 100vw;
  overflow: hidden;
`;

const RunningPath = styled.img`
  position: relative;
  top: 0;
  bottom: 0;
  right: 0;
  left: 0;
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
  }
`;

const TreeOne = styled.img`
  position: absolute;
  left: -2vw;
  top: 11.5vh;
  transform: scale(.75);
  @media (max-width: 700px) {
    transform: scale(.35);
    bottom: 0;
    left: -38vw;
  }
`;

const TreeTwo = styled.img`
  position: absolute;
  left: 25vw;
  top: 13vh;
  transform: scale(.55);
  @media (max-width: 700px) {
    display: none;
  }
`;

const TreeThree = styled.img`
  position: absolute;
  left: 85vw;
  top: -25vh;
  transform: scale(.35);
  @media (max-width: 700px) {
    transform: scale(.2);
    top: 5vh;
    left: 15vw;
  }
`;

const TreeFour = styled.img`
  position: absolute;
  left: 50vw;
  top: 7vh;
  transform: scale(.45);
  @media (max-width: 700px) {
    transform: scale(.15);
    top: -29vh;
    left: 40vw;
  }
`;

const TreeFive = styled.img`
  position: absolute;
  left: 60vw;
  top: -18vh;
  transform: scale(.4);
  @media (max-width: 700px) {
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
    <SplashWrapper>
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
    </SplashWrapper>
  );
}

export default Splash;