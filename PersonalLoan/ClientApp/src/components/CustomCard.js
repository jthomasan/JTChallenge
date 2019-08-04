import React from 'react';
import { connect } from 'react-redux';

const Card = props => (
    <div>
        <section>
            <h1 className="cardTitle">
                {props.orderNumber}. Loan Account #{props.loanAccountNumber}
            </h1>
            <div>
                <span>
                    Balance
                </span>
                <span>
                    $1212
                </span>
                <span>
                    <input type="checkbox" />
                </span>
            </div>
        </section>
    </div>
);
export default connect()(Card);