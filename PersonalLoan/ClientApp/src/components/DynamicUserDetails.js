import React, { Component } from 'react';
import { bindActionCreators } from 'redux';
import { connect } from 'react-redux';
import IndividualLoanDetails from './IndividualLoanDetail';
import { actionCreators } from '../store/IndividualLoanDetail';



class FetchData extends Component {
    componentWillMount() {
        // This method runs when the component is first added to the page
        //const startDateIndex = parseInt(this.props.match.params.startDateIndex, 10) || 0;
        this.props.requestDetails(1);
    }

    render() {
        return (
            <div>
                <div className="flexColumn">
                    <a className={`flexItem ${this.props.id === 1 ? 'userselected' : ''}`} onClick={() => this.props.requestDetails(1)} disabled={this.props.id === 1}> User 1</a>
                    <a className={`flexItem ${this.props.id === 2 ? 'userselected' : ''}`} onClick={() => this.props.requestDetails(2)} disabled={this.props.id === 2}>User 2</a>
                    <a className={`flexItem ${this.props.id === 3 ? 'userselected' : ''}`} onClick={() => this.props.requestDetails(3)} disabled={this.props.id === 3}>User 3</a></div>
                {!this.props.isLoading &&
                    <IndividualLoanDetails Data={this.props.data} />
                }
                {this.props.isLoading &&
                    <span>Loading...</span>
                }
            </div>
        );
    }
}

export default connect(
    state => state.individualDetails,
    dispatch => bindActionCreators(actionCreators, dispatch)
)(FetchData);
