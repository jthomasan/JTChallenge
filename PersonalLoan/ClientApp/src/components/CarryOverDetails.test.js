import React from 'react';
import ReactDOM from 'react-dom';
import CarryOverDetails from './CarryOverDetails';

it('renders without crashing', () => {
    const div = document.createElement('div');
    ReactDOM.render(<CarryOverDetails />, div);
});
