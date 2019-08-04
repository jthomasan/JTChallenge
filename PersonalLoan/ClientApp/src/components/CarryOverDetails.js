import React from 'react';
import { connect } from 'react-redux';

const CarryOverDetails = props => (
    <section>
        <div>
            <span className="firstSpan">
                Balance includes interest of
            </span>
            <span>
                {props.interest}
            </span>
            <span>
                
            </span>
        </div>
        <div>
            <span className="firstSpan">
                Early repayment fee
            </span>
            <span>
                {props.fee}
             </span>
            <span>
                
            </span>
        </div>
        <div>
            <span className="firstSpan">
                Payout / Carryover amount
            </span>
            <span>
                {props.carryOverAmount}
            </span>
            <span>
                <b>This amount will be carried over</b>
            </span>
        </div>
    </section>
);
export default connect()(CarryOverDetails);