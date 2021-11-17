using System;

namespace GitHub
{
    public class Prescription
  {

	// Prescription #.
    public string PrescriptionNumber {get; set;}
	// Reason for Medication.
    public string ReasonForMedication {get; set;}
	// Refill on Date:
    public DateTime Refill {get; set;}
	// Strength/dosage.
    public int Strength {get; set;}
    public int Dosage {get; set;}
	// Time of day.
    public int TimeTaken  {get; set;}
  }
}