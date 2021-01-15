
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Scheduler
{

    public Scheduler()
    {
    }

    public int requestorFeeback;

    public bool responderAvailibility;

    public int responderFeeback;

    /// <summary>
    /// @param responder 
    /// @param requestor 
    /// @param request 
    /// @return
    /// </summary>
    public void BroadcastMatchDetails(Responder responder, Request request)
    {
        // broadcast message to responder and creator of request
        // TODO implement here

    }

    public void GetFeeback()
    {
        // TODO implement here
    }

}