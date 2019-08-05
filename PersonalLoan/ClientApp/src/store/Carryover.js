export const incrementCarryOverType = 'INCREMENT_CARRYOVER';
export const decrementCarryOverType = 'DECREMENT_CARRYOVER';
const initialState = { CarryOver: 0 };

{/*actions for increment and decrement of the carryover amount*/ }
export const actionCreators = {
    increment: (amount) => ({ type: incrementCarryOverType, amount: amount }),
    decrement: (amount) => ({ type: decrementCarryOverType, amount: amount })
};


{/*Logic for updating the state based on the action.*/ }
export const reducer = (state, action) => {
    state = state || initialState;

    if (action.type === incrementCarryOverType) {
        return { ...state, CarryOver: state.CarryOver + action.amount };
    }

    if (action.type === decrementCarryOverType) {
        return { ...state, CarryOver: state.CarryOver - action.amount };
    }

    return state;
};
