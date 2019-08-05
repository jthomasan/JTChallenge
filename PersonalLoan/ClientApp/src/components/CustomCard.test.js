import React from 'react';
import ReactDOM from 'react-dom';
import CustomCard from './CustomCard';
import configureStore from '../store/configureStore';
import { Provider } from 'react-redux';
import { ConnectedRouter } from 'react-router-redux';

const data = { carryOver: 10 };
const initialState = data;
const store = configureStore(initialState);
it('renders without crashing', () => {
    const div = document.createElement('div');
    ReactDOM.render(
        <Provider store={store}><CustomCard /></Provider>, div);
});
