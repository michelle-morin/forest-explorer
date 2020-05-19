import React from 'react';
import ReactDOM from 'react-dom';
import App from './components/App';
import * as serviceWorker from './serviceWorker';
import { createStore, applyMiddleware } from 'redux';
import thunkMiddleware from 'redux-thunk';
import trailsReducer from './reducers/trails-reducer';
import { Provider } from 'react-redux';
import 'bootstrap/dist/css/bootstrap.min.css';
import 'react-typist/dist/Typist.css';
import 'react-typist/dist/standalone/Typist.js';
import './index.css';

const store = createStore(trailsReducer, applyMiddleware(thunkMiddleware));

ReactDOM.render(
  <Provider store={store}>
    <App />
  </Provider>,
  document.getElementById('root')
);

serviceWorker.unregister();
