import React, { Component } from 'react';
import { Route } from 'react-router';
import { Employees } from './components/Employees';

export default class App extends Component {
    displayName = App.name

    render() {
        return (

                <Employees />
        );
    }
}
