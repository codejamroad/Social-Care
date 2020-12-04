
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class BrowserPlatform : ILogin {

    public BrowserPlatform() {
    }

    public int Id;

    public string email;

    public string password;

    private Security secure;

    public void validate_credential() {
        // TODO implement here
    }

    /// <summary>
    /// @return
    /// </summary>
    public bool secure_Login() {
        // TODO implement here
        return false;
    }

    /// <summary>
    /// @return
    /// </summary>
    public bool validate_credentials() {
        // TODO implement here
        return false;
    }

}