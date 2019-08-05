import React, { Component } from 'react';
import { bindActionCreators } from 'redux';
import { connect } from 'react-redux';
import IndividualLoanDetails from './IndividualLoanDetail';
import { actionCreators } from '../store/IndividualLoanDetail';


{/*This component is responsible for switching the user as well as fetching the data from API based on the selected user.*/ }
class FetchData extends Component {
    componentWillMount() {
        {/*On load of the component the data of user with id 1 is fetched from the server  by default.*/ }
        this.props.requestDetails(1);
    }

    render() {
        return (
            <div>
                <div className="flexColumn">
                    <a className={`flexItem ${this.props.id === 1 ? 'userselected' : ''}`} onClick={() => this.props.requestDetails(1)} disabled={this.props.id === 1}> User 1</a>
                    <a className={`flexItem ${this.props.id === 2 ? 'userselected' : ''}`} onClick={() => this.props.requestDetails(2)} disabled={this.props.id === 2}>User 2</a>
                    <a className={`flexItem ${this.props.id === 3 ? 'userselected' : ''}`} onClick={() => this.props.requestDetails(3)} disabled={this.props.id === 3}>User 3</a></div>

                {/*The data is only displayed if the server activity is finished and the data has been recieved. Other wise a loading message will be displayed.*/}
                {!this.props.isLoading &&
                    <IndividualLoanDetails Data={this.props.data} TotalLoans={this.props.totalLoans} />
                }
                {this.props.isLoading &&
                    <span>Loading...</span>
                }
            </div>
        );
    }
}


{/*Connects the reducer state and actions with this component*/ }
export default connect(
    state => state.individualDetails,
    dispatch => bindActionCreators(actionCreators, dispatch)
)(FetchData);
