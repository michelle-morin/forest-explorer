import React from 'react';
import Typist from 'react-typist';
import styled from 'styled-components';
import './../index.css';

const AboutWrapper = styled.div`
  font-family: 'Montserrat', sans-serif;
`;

function AboutPage() {
  return (
    <AboutWrapper>
      <h1>Welcome</h1>
      <Typist>
        <p>[about section]</p>
      </Typist>
    </AboutWrapper>
  );
}

export default AboutPage;