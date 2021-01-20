
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Requestor : User
{
    public RequestTracker requestTracker;
    public int requestorId;

    private readonly Reception myReception;

    public Requestor(Reception reception, RequestTracker requestTracker, int requestorId)
    {
        myReception = reception;
        this.requestTracker = requestTracker;
        this.requestorId = requestorId;
    }

    /// <summary>
    /// @param requestTracker 
    /// @return
    /// </summary>
    public bool CreateRequest()
    {
        // New Request is created
        Request request = new Request
        {
            id = 1,
            requestorId = requestorId,
            status = "Initialized",
            jobDescription = "XYZ"
        };

        requestTracker.requests.Add(request);

        bool requestStatus;
        // created request if handled by reception component
        requestStatus = myReception.HandleRequest(request);

        return requestStatus;

    }

    /// <summary>
    /// @param requestTracker 
    /// @return
    /// </summary>
    private Request UpdateRequest(Request request)
    {
        request.jobDescription = "Changing X to Y";
        return request;
    }

    public void SendFeedback(Request request)
    {
        request.feedback = "Feedback";
    }

    public void EndRequest(Request request)
    {
        request.status = "Complete";
        requestTracker.requests.Remove(request);
        Console.WriteLine("Job Completed Successfully");
    }

}