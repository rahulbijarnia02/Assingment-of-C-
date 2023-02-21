using System;
using System.ComponentModel.DataAnnotations;



public class Registration {  
    [Required]
    [StringLength(100)]
    public string FirstName {  
        get;  
        set;  
    }  
    public string LastName {  
        get;  
        set;  
    }  
    public int UserId {  
        get;  
        set;  
    }  
    public string Password {  
        get;  
        set;  
    }  
    public string Email {  
        get;  
        set;  
    }  
    public string Contact {  
        get;  
        set;  
    }  
}