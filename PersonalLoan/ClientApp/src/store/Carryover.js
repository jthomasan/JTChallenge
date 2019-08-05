export const incrementCarryOverType = 'INCREMENT_CARRYOVER';
export const decrementCarryOverType = 'DECREMENT_CARRYOVER';
export const initialiseCarryOverType = 'INITIALISE_CARRYOVER';
const initialState = { CarryOver: 0 };

{/*actions for increment and decrement of the carryover amount*/ }
export const actionCreators = {
    increment: (amount) => ({ type: incrementCarryOverType, amount: amount }),
    decrement: (amount) => ({ type: decrementCarryOverType, amount: amount }),
    initialise: () => ({ type: initialiseCarryOverType })
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

    if (action.type === initialiseCarryOverType) {
        return { ...state, CarryOver: 0 };
    }

    return state;
};
