import React from 'react';
import styled from 'styled-components';

function Footer() {

  const FooterWrapper = styled.div`
    position: fixed;
    left: 0;
    bottom: 0;
    width: 100%;
    border-top: 2px solid rgba(0,0,0,.75);
    color: rgba(0,0,0,.75);
    text-align: center;
    font-family: 'Montserrat', sans-serif;
    padding-top: 1%;
    padding-bottom: 1%;
  `;

  const linkStyle = {
    color: 'rgba(0,0,0)',
    fontWeight: 'bolder'
  };

  return (
    <FooterWrapper>
      <p>Design & Development by <a style={linkStyle} href="https://www.michelle-morin.com/" target="_blank" rel="noopener noreferrer">Michelle Morin</a> | &copy; 2020 - All Rights Reserved | <a style={linkStyle} href="https://github.com/michelle-morin/forest-park-trails" target="_blank" rel="noopener noreferrer">View Source Code</a></p>
    </FooterWrapper>
  );
}

export default Footer;