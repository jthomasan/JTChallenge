const incrementCarryOverType = 'INCREMENT_CARRYOVER';
const decrementCarryOverType = 'DECREMENT_CARRYOVER';
const initialState = { CarryOver: 0 };

export const actionCreators = {
    increment: (amount) => ({ type: incrementCarryOverType, amount: amount }),
    decrement: (amount) => ({ type: decrementCarryOverType, amount: amount })
};

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
