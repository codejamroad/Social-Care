
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Reception
{
    public Response response;
    private Matcher myMatcher;
    private Scheduler myScheduler;

    public Reception(Matcher matcher, Scheduler scheduler)
    {
        myMatcher = matcher;
        myScheduler = scheduler;
        response = new Response();
    }

    /// <summary>
    /// @param  
    /// @param 
    /// </summary>
    ///public void EvaluateResponse(int requestId, Response response)
    ///{
    /// TODO implement here
    ///}

    /// <summary>
    /// @return
    /// </summary>
    public bool HandleRequest(Request request)
    {
        int counter = 15;

        if (counter > 0)
        {
            while (!response.accpetedRejected)
            {
                response = myMatcher.Match(request);
                counter--;
            }
            request.status = "Match Found";

            bool isMessageSent = false;
            while (!isMessageSent)
                isMessageSent = myScheduler.BroadcastMatchDetails(response.requestResponderId, request.requestorId, request);

            return isMessageSent;
        }
        return false;
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