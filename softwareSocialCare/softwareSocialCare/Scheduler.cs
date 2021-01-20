
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Scheduler
{
    public int requestorFeeback;

    public bool responderAvailibility;

    public int responderFeeback;

    public Scheduler()
    {
    }



    /// <summary>
    /// This method will broadcast message to person who accepted and to the peroson who created the job request
    /// Message should be like "Request Id: 123 has found the match by system. Details of Person Accepted: Name, Age, Loaction
    /// Details of job location and time." 

    /// This implememtation would be similar to code 
    /// https://snippetbank.blogspot.com/2014/04/csharp-client-server-broadcast-example-1.html
    /// There would be two asynchronous calls to - Requestor and Responder
    /// This method will inform both entities about the job match
    /// @param responder 
    /// @param requestor 
    /// @param request 
    /// @return
    /// Methods return status if broadcast is successfull then return true
    /// if broadcast fails then return false
    /// </summary>
    public bool BroadcastMatchDetails(int responderId, int resquestorId, Request request)
    {
        // TODO implement here
        // Default: Broadcast is successful and method return true
        return true;
    }

    public void GetFeeback()
    {
        // TODO implement here
    }

}