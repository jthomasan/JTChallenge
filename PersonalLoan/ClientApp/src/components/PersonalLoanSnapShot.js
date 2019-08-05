import React from 'react';
import { connect } from 'react-redux';
import Card from './CustomCard';
import CarryOverDetails from './CarryOverDetails'

const PersonalLoanSnapShot = props => (

    props.Data.map(m =>
        <div key={m.orderNumber} >
            <Card orderNumber={m.orderNumber} loanAccountNumber={m.loanAccountNumber} carryOverAmount={m.carryOverAmount} balance={m.balance}>
                <CarryOverDetails
                    interest={m.interest}
                    fee={m.fee}
                    carryOverAmount={m.carryOverAmount}
                />
            </Card>
        </div>)
);
export default connect()(PersonalLoanSnapShot);