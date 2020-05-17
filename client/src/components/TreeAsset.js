import React from 'react';
import tree from './../assets//img/tree.png';

function TreeAsset() {
  const treeStyle = {
    transform: 'scale(.5)'
  }

  return (
    <img src={tree} style={treeStyle} alt="watercolor tree" />
  );
}

export default TreeAsset;