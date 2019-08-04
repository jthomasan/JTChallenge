import React from 'react';
import { connect } from 'react-redux';
import { bindActionCreators } from 'redux';
import PersonalLoanSnapShot from './PersonalLoanSnapShot';
import { actionCreators } from '../store/Carryover';

//The below line is an inline style. This is just to demonstrate knowledge of writing inline styles.
const alStyle = {
    textAlign: 'right',
    width: 'auto',
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
                <button className="rounderCorner spaceForButton">Apply for increased loan amount</button>
            </div>
        </div>
        <div className="flex-container">
            <div className="major">
            </div>
            <div className="minor">
                <button className="rounderCorner spaceForButton">Apply for new personal loan</button>
            </div>
        </div>

        <PersonalLoanSnapShot Data={props.Data}></PersonalLoanSnapShot>
    </div>
);
export default connect(
    state => state.carryOver,
    dispatch => bindActionCreators(actionCreators, dispatch)
)(IndividualLoanDetails);