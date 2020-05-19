import React from 'react';
import NavBar from './NavBar';
import Typist from 'react-typist';
import styled from 'styled-components';
import './../index.css';

const AboutWrapper = styled.div`
  font-family: 'Montserrat', sans-serif;
  position: absolute;
  top: 15vh;
  padding: 2%;
  font-size: 2rem;
`;

function AboutPage() {
  return (
    <React.Fragment>
      <NavBar />
      <AboutWrapper>
        <Typist>
          <p>Welcome!</p>
        </Typist>
      </AboutWrapper>
    </React.Fragment>
  );
}

export default AboutPage;