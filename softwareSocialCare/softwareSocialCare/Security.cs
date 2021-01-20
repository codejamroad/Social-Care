
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Security {

    public Security() {
    }

    public int key;

    public string data;

    private DatabaseHandler dbHandler;


    /// <summary>
    /// @param key 
    /// @param data
    /// </summary>
    public void encryptData(int key, string data) {
        // TODO implement here
    }

    /// <summary>
    /// @return
    /// </summary>
    public string getSecureCredentials() {
        // TODO implement here
        return "";
    }

    /// <summary>
    /// @param data 
    /// @return
    /// </summary>
    public bool updateSecurely(string data) {
        // TODO implement here
        return false;
    }

}