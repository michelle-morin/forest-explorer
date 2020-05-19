import React from 'react';
import NavBar from './NavBar';
import Footer from './Footer';
import Typist from 'react-typist';
import styled from 'styled-components';
import './../index.css';

const AboutWrapper = styled.div`
  font-family: 'Montserrat', sans-serif;
  position: absolute;
  top: 15vh;
  padding: 2%;
  font-size: 2rem;
  overflow-y: auto;
`;

function AboutPage() {
  return (
    <React.Fragment>
      <NavBar />
      <AboutWrapper>
        <Typist cursor={{ hideWhenDone: true }}>
          <p>Welcome!</p>
          <p>This is a passion project fueled by my love of trail running in Forest Park.</p>
          <p>Forest Park is a forested ecosystem spanning over 5,100 acres along the northwest urban boundary of Portland, Oregon.</p>
          <p>In addition to the vast trail network beneath a canopy of old growth and second growth douglas firs, Forest Park is home to a diverse range of flora and fauna.</p>
          <p>While this application encourages trail use, please be mindful of your impact on the trails and fragile ecosystems of our urban wilderness.</p>
        </Typist>
      </AboutWrapper>
      <Footer />
    </React.Fragment>
  );
}

export default AboutPage;