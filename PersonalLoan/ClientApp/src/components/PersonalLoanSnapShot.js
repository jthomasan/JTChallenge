import React from 'react';
import { connect } from 'react-redux';
import Card from './CustomCard';

const PersonalLoanSnapShot = props => (

    props.Data.map(m =>
        <div key={m.orderNumber} >
            <Card orderNumber={m.orderNumber} loanAccountNumber={m.loanAccountNumber}>

            </Card>
        </div>)
);
export default connect()(PersonalLoanSnapShot);