﻿import React from 'react';
import { connect } from 'react-redux';
import { bindActionCreators } from 'redux';
import PersonalLoanSnapShot from './PersonalLoanSnapShot';
import { actionCreators } from '../store/Carryover';

//The below lines are inline style. This is just to demonstrate knowledge of writing inline styles.
const alStyle = {
    textAlign: 'right',
    width: 'auto',
    float: 'right',
}

const spStyle = {
    padding: '50px',
    display: 'flex',
    paddingBottom: '10px',
    width: '68%',
}

const spRightStyle = {
    display: 'flex',
    paddingBottom: '10px',
    float: 'right',
}

//The below component is the parent component of all the other components required for this solution.
const IndividualLoanDetails = props => (
    <div>
        <h1>
            Personal Loan TopUp or Apply
        </h1>
        <div className="flex-container">
            <div className="major">
                <div className="leftPositioned">
                    To apply for a TopUp of an existing loan amount, please select the loan below, make note of the Carry-over amount before proceeding.
                </div>
                <div className="rightPositioned">
                    <span className="leftPositioned">
                        Carryover / Payout Amount
                    </span>
                    <span className="rightPositioned" style={alStyle}>${props.CarryOver}</span>
                </div>
            </div>
            <div className="minor">
                <button className="rounderCorner spaceForButton" disabled={props.CarryOver <= 0}>Apply for increased loan amount</button>
            </div>
        </div>
        <div className="flex-container">
            <div className="major">
            </div>
            <div className="minor">
                <button className="rounderCorner spaceForButton" disabled={props.TotalLoans >= 3}>Apply for new personal loan</button>
            </div>
        </div>

        <div className="flexRow">
            <span style={spStyle}>You have {props.TotalLoans} Personal Loans</span>
            {props.TotalLoans >= 3 &&
                <div className="staticCard">
                    <span style={spRightStyle}>With 3 or more current Personal Loans, a new Loan application is not possible in this flow.</span>
                </div>
            }
        </div>
        <PersonalLoanSnapShot Data={props.Data}></PersonalLoanSnapShot>
    </div>
);
export default connect(
    state => state.carryOver,
    dispatch => bindActionCreators(actionCreators, dispatch)
)(IndividualLoanDetails);