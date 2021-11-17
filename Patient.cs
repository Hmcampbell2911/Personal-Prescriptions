using System;
using System.Collections.Generic;

namespace GitHub
{
    public class Patient
    {
        public string PatientName {get; set;}
        public List<Prescription> Prescriptions {get; set;} = new List<Prescription>();
        public Guid PatientIdentification { get; set; } = Guid.NewGuid();
    }
}
