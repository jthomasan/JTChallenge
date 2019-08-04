import React, { Component } from 'react';
import { connect } from 'react-redux';
import { bindActionCreators } from 'redux';
import { actionCreators } from '../store/Carryover';

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
                            $1212
                        </span>
                        <span>
                            <input type="checkbox" onChange={this.handleChecked} />
                        </span>
                    </div>
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