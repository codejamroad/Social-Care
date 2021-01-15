
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Responder : User
{

    public Responder(Reception reception, Request request)
    {
        myReception = reception;
        myRequest = request;
    }

    public string location;

    public int requestId;

    public int responderId;
    private Response myResponse;
    private Reception myReception;
    private Request myRequest;


    /// <summary>
    /// @return
    /// </summary>
    public Response CreateResponse()
    {
        myResponse = new Response
        {
            accpetedRejected = true
        };
        myResponse = SendResponse();

        return myResponse;
    }

    /// <summary>
    /// @return
    /// </summary>
    private Response SendResponse()
    {
        myReception.EvaluateResponse(myRequest.requestId, myResponse);
        return myResponse;
    }

    public void SendFeedback()
    {
        // TODO implement here
    }

}