import React from 'react';
import TreeAsset from './TreeAsset';
import styled from 'styled-components';
import path from './../assets/img/path.png';

const SplashWrapper = styled.div`
  position: relative;
  height: 100vh;
  width: 100%;
  background-image: url(${path});
  background-position: center;
  background-size: cover;
  background-attatchment: fixed;
  font-family: Architectural;
`;

function Splash() {
  const brandStyles = {
    position: 'absolute',
    left: '15%',
    top: '15%',
    fontSize: '5rem'
  }

  return (
    <SplashWrapper>
      <h1 style={brandStyles}>Forest Explorer</h1>
      <TreeAsset />
      <TreeAsset />
      <TreeAsset />
      <TreeAsset />
      <TreeAsset />
    </SplashWrapper>
  );
}

export default Splash;