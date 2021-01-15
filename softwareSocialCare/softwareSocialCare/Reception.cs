
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Reception
{
    public Response response;
    private int currentRequestId;
    private Responder potentialResponder;
    private Matcher myMatcher;
    private RequestTracker myRequestTracker;
    public Request request;
    private Scheduler myScheduler;

    public Reception(Matcher matcher, RequestTracker requestTracker, Request request, Scheduler scheduler)
    {
        myMatcher = matcher;
        myRequestTracker = requestTracker;
        this.request = request;
        myScheduler = scheduler;
    }

    /// <summary>
    /// @param requestId 
    /// @param response
    /// </summary>
    public void EvaluateResponse(int requestId, Response response)
    {
        if (response.accpetedRejected == true)
        {
            request.status = "Match Found";
            myScheduler.BroadcastMatchDetails(potentialResponder, request);
        }
        else
        {
            HandleRequest();
        }
    }

    /// <summary>
    /// @return
    /// </summary>
    public Request HandleRequest()
    {
        potentialResponder = myMatcher.match(request);
        return request;
    }

    /// <summary>
    /// @param request
    /// </summary>
    public void CandidateDbLookUp(Request request)
    {
        // TODO implement here
    }

    /// <summary>
    /// @param request
    /// </summary>
    public void FindPotentialResponders(Request request)
    {
        // TODO implement here
    }

}