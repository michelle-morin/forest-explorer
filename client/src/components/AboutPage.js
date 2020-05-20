import React from 'react';
import NavBar from './NavBar';
import Footer from './Footer';
import styled from 'styled-components';
import Typing from 'react-typing-animation';
import './../index.css';

const AboutWrapper = styled.div`
  font-family: 'Montserrat', sans-serif;
  position: relative;
  top: 15vh;
  padding: 2%;
  padding-bottom: 2rem;
  font-size: 2rem;
  height: auto;
  @media (max-width: 500px) {
    top: 20vh;
  }
  @media (max-width: 360px) {
    top: 22vh;
  }
  @media (max-width: 320px) {
    top: 25vh;
  }
`;

const PageWrapper = styled.div`
  position: relative;
  min-height: 100vh;
`;

function AboutPage() {
  return (
    <PageWrapper>
      <NavBar />
      <AboutWrapper>
        <Typing>
          <p>Welcome!</p>
          <p>This is a passion project fueled by my love of trail running.</p>
          <p>Portland's west hills include a vast trail network. Forest Park spans over 5,100 acres along Portland's northwest urban boundary. Trails within the Hoyt Aboretum weave between 2,300 species of trees and shrubs from six continents. In addition to forest, Washington Park includes an immaculate rose test garden, a zoo, and museums.</p>
          <p>While this application encourages trail use, please be mindful of your impact on the trails and fragile ecosystems of our urban wilderness.</p>
        </Typing>
      </AboutWrapper>
      <Footer />
    </PageWrapper>
  );
}

export default AboutPage;