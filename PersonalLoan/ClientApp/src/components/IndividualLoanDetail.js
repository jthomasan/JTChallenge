import React from 'react';
import { connect } from 'react-redux';

const alStyle = {
    textAlign: 'right',
    width: 'auto',
    float: 'right',
    }

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
                    <span className="rightPositioned" style={alStyle}>$0</span>
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
    </div>
);
export default connect()(IndividualLoanDetails);