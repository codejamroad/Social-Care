
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public interface ILogin {




    /// <summary>
    /// @return
    /// </summary>
    public bool secure_Login();

    public void validate_credential();

    /// <summary>
    /// @return
    /// </summary>
    public bool validate_credentials();

}