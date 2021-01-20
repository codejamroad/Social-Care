
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Matcher
{
    public List<int> myLearningParameters;
    public Preference myPreference;
    public List<Responder> myCandidatesResponder;

    private readonly Responder myResponder;

    public Matcher(Responder responder, List<int> learningParameters, Preference preference, List<Responder> candidatesResponder)
    {
        myResponder = responder;
        myLearningParameters = learningParameters;
        myPreference = preference;
        myCandidatesResponder = candidatesResponder;
    }

    /// <summary>
    /// @param request 
    /// @return
    /// </summary>
    public Response Match(Request request)
    {
        Response response = myResponder.GetResponse(request);

        return response;
    }

}