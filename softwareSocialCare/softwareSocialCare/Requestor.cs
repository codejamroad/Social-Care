
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Requestor : User
{

    private Reception myReception;
    private UserManagement myUserManagement;

    public Requestor(Reception reception, UserManagement userManagement)
    {
        myReception = reception;
        myUserManagement = userManagement;
    }

    public Request request;

    public RequestTracker requestTracker;

    public int requestorId;

    /// <summary>
    /// @param requestTracker 
    /// @return
    /// </summary>
    public Request CreateRequest(RequestTracker requestTracker)
    {
        request = new Request();
        requestTracker.requests.Add(request);
        myReception.HandleRequest();
        return request;
    }

    /// <summary>
    /// @param requestTracker 
    /// @return
    /// </summary>
    private Request UpdateRequest(RequestTracker requestTracker)
    {
        request.jobDescription = "Changing X to Y";
        return request;
    }

    public void SendFeedback()
    {
        request.feedback = "Feedback";
    }

    public void EndRequest()
    {
        request.status = "Complete";
        Console.WriteLine("Job Completed Successfully");
    }

}