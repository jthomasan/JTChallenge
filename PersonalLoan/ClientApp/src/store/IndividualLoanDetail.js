const requestDetailsType = 'REQUEST_INDIVIDUAL_DETAILS';
const receiveDetailsType = 'RECEIVE_INDIVIDUAL_DETAILS';
const initialState = { id:0, data: [], isLoading: false, totalLoans: 0, };


{/*action responsible for fetching data from server.*/ }
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

{/*Logic for updating the state based on the progressand response of action*/ }
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
            isLoading: false,
            totalLoans: action.data.length,
        };
    }

    return state;
};
