
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Matcher
{

    public Matcher(Responder responder)
    {
        myResponder = responder;
    }

    public Request request;

    public List<int> learningParameters;

    public Preference preference;

    public List<Responder> candidatesResponder;
    private Responder myResponder;


    /// <summary>
    /// @param request 
    /// @return
    /// </summary>
    public Responder match(Request request)
    {
        myResponder.CreateResponse();
        return myResponder;
    }

}