const requestDetailsType = 'REQUEST_INDIVIDUAL_DETAILS';
const receiveDetailsType = 'RECEIVE_INDIVIDUAL_DETAILS';
const initialState = { id:0, data: [], isLoading: false };

export const actionCreators = {
    requestDetails: id => async (dispatch, getState) => {
        if (id === getState().individualDetails.id) {
            // Don't issue a duplicate request (we already have or are loading the requested data)
            return;
        }

        dispatch({ type: requestDetailsType, id });

        const url = `api/UserLoan/UserDetail?id=${id}`;
        const response = await fetch(url);
        const data = await response.json();

        dispatch({ type: receiveDetailsType, id, data });
    }
};

export const reducer = (state, action) => {
    state = state || initialState;

    if (action.type === requestDetailsType) {
        return {
            ...state,
            id: action.id,
            isLoading: true
        };
    }

    if (action.type === receiveDetailsType) {
        return {
            ...state,
            id: action.id,
            data: action.data,
            isLoading: false
        };
    }

    return state;
};
