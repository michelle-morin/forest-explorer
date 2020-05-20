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
          <p>This is a passion project fueled by my love of trail running.</p>
          <p>Portland's west hills include a vast trail network. Forest Park spans over 5,100 acres along Portland's northwest urban boundary. Trails within the Hoyt Aboretum weave between 2,300 species of trees and shrubs from six continents. In addition to forest, Washington Park includes an immaculate rose test garden, a zoo, and museums.</p>
          <p>While this application encourages trail use, please be mindful of your impact on the trails and fragile ecosystems of our urban wilderness.</p>
        </Typist>
      </AboutWrapper>
      <Footer />
    </React.Fragment>
  );
}

export default AboutPage;