
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Reception {

    public Reception() {
    }

    public Request request;

    public Response response;

    private int currentRequestId;





    /// <summary>
    /// @param requestId 
    /// @param response
    /// </summary>
    public void evaluateResponse(int requestId, Response response) {
        // TODO implement here
    }

    /// <summary>
    /// @return
    /// </summary>
    public Request handleRequest() {
        // TODO implement here
        return null;
    }

    /// <summary>
    /// @param request
    /// </summary>
    public void candidateDbLookUp(Request request) {
        // TODO implement here
    }

    /// <summary>
    /// @param request
    /// </summary>
    public void findPotentialResponders(Request request) {
        // TODO implement here
    }

}