import React, { Component } from 'react';
import { connect } from 'react-redux';
import { bindActionCreators } from 'redux';
import { actionCreators } from '../store/Carryover';


{/*This component is a custom card component which will give a snapshot of a single personal loan detail with the ability to expand upon selecting a checkbox.*/ }
class Card extends Component {

    //this is having a local state just to handle the checkbox checked state
    constructor(props) {
        super(props);
        this.state = { isChecked: false, };
        this.handleChecked = this.handleChecked.bind(this);
    }

    handleChecked() {
        var checked = !this.state.isChecked;
        this.setState({ isChecked: checked });
        if (checked)
            this.props.increment(this.props.carryOverAmount);
        else
            this.props.decrement(this.props.carryOverAmount);
    }


    render() {
        return (
            <div>
                <section>
                    <h1 className="cardTitle">
                        {this.props.orderNumber}. Loan Account #{this.props.loanAccountNumber}
                    </h1>
                    <div>
                        <span>
                            Balance
                        </span>
                        <span>
                            {this.props.balance}
                        </span>
                        <span>
                            <input type="checkbox" onChange={this.handleChecked} />
                        </span>
                    </div>

                    {/*Upon checking the checkbox the children html is rendered here*/}
                    {this.state.isChecked &&
                        this.props.children
                    }
                </section>
            </div>);
    }
}

export default connect(
    state => state.carryOver,
    dispatch => bindActionCreators(actionCreators, dispatch)
)(Card);