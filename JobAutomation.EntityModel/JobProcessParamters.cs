//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
//This source code was auto-generated by MonoXSD
//



using System.ComponentModel.DataAnnotations.Schema;

public class JobProcessParamters {
    
    
    
        public long JobProcessParamtersId { get; set; }
    
    

    [ForeignKey("JobProcessId")]
    public virtual JobProcess JobProcess { get; set; }


    [ForeignKey("JobId")]
    public virtual Job Job { get; set; }

    [ForeignKey("JobParameterId")]
    public virtual JobParameter JobParameter { get; set; }

    
    
        public string JobParameterOverride { get; set; }
}
