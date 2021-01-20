
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Responder : User
{
    public string location;
    public int requestId;
    public int responderId;

    public Responder(string location, int responderId)
    {
        this.location = location;
        this.responderId = responderId;
    }


    /// <summary>
    /// @return
    /// </summary>
    public Response GetResponse(Request request)
    {
        bool result = EvaluateRequest(request);
        Response response = new Response
        {
            // input from the UI
            requestResponderId = responderId,
            accpetedRejected = result
        };
        return response;
    }

    private bool EvaluateRequest(Request request)
    {
        // Using responder location and job description from request, the responder will decide to accept or reject request
        // Default returning true i.e job accepted
        return true;
    }
    public void SendFeedback(Request request)
    {
        // sends feedback for the request 
    }

}