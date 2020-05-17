import React from 'react';
import TreeAsset from './TreeAsset';
import styled from 'styled-components';
import path from './../assets/path.png';

const SplashWrapper = styled.div`
  height: 100vh;
  width: 100%;
  background-image: url(${path});
  background-position: center;
  background-size: cover;
  background-attatchment: fixed;
`;

function Splash() {
  return (
    <SplashWrapper>
      <TreeAsset />
    </SplashWrapper>
  );
}

export default Splash;