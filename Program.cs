using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace GitHub
{
    class Program
    {
        static List<Patient> Patients {get; set;}

        static void Main(string[] args)
        {
            LoadData();
            bool masterLoop = true;
            while (masterLoop){
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("1-Add New Patient");
                Console.WriteLine("2-Add New Prescription");
                Console.WriteLine("3-View a List of Patients");
                Console.WriteLine("4-View a List of Prescriptions");
                Console.WriteLine("Type Q to Exit");
                string answer = Console.ReadLine();
                if (answer == "1") 
                {
                    StartPatientQuestionaire();
                }
                else if (answer=="2")
                {
                    Guid PatientIdentification = SelectPatient();
                    StartPrescriptionQuestionaire(PatientIdentification);
                }
                else if (answer=="3")
                {
                    ShowPatients();
                }
                else if (answer=="4")
                {
                    Guid PatientIdentification = SelectPatient();
                    ShowPrescriptions(PatientIdentification);
                }
                else if(answer=="Q")
                {
                    masterLoop = false;
                }
                else
                {
                    Console.WriteLine ("You did something wrong, try again!");
                    LogError("Invalid Input", answer);
                }
            }
            SaveData();
        }

        private static void SaveData()
        {
           string jsonString = JsonSerializer.Serialize(Patients);
           File.WriteAllText("PatientList.txt",jsonString);
        }

        private static void LoadData()
        {
            if(File.Exists("PatientList.txt"))
            {
                try
                {
                    string jsonString = File.ReadAllText("PatientList.txt");
                    Patients = JsonSerializer.Deserialize<List<Patient>>(jsonString);
                } catch (Exception ex){
                    LogError("bad file", ex.ToString());
                }
            }
            else{
                Patients =new List<Patient>();
            }
        }

        private static void LogError(string type, string message)
        {
            File.WriteAllText("Errors.txt",$"{type}: {message}\r\n");
        }

        private static void ShowPrescriptions(Guid patientIdentification)
        {
            //get patient from patients property by id
            var Patient = Patients.FirstOrDefault(x=>x.PatientIdentification==patientIdentification);
            //loop over the prescription on patient

            //console.writeline the prescription data

        }

        private static void ShowPatients()
        {
            //loop over the patients on patient

            //console.writeline the patient data
        }

        private static Guid SelectPatient()
        {
            ShowPatients();
            //ask user which patient to select. . . 1,2,3,4
            //get user at index Patients[index-1]
            throw new NotImplementedException();
        }

        private static void StartPatientQuestionaire()
        {
            //check out patient questionaire (get data)
            //add new patient to patients list
        }

        private static void StartPrescriptionQuestionaire(Guid PatientIdentification)
        {
            // Prescription #.
            int PrescriptionNumber = GetPrescriptionNumber();
            
            // Reason for Medication.
            string Medication = ReasonforMedication();
            
            // Refill on Date:
            DateTime Refill = GetRefillDate();
           
            // Strength/dosage.
            int Strength = GetStrength();
            int Dosage = GetDosage();

            // Time of day.
            int TimeTaken = GetTimeTakenEachDay();

            AddNewPrescriptionToPatient(
                PatientIdentification,
                PrescriptionNumber,
                Medication,
                Refill,
                Strength,
                Dosage,
                TimeTaken
            );
        }

        private static void AddNewPrescriptionToPatient(Guid patientIdentification, int prescriptionNumber, string medication, DateTime refill, int strength, int dosage, int timeTaken)
        {
            //get patient by id, 
            //add prescription data to the prescriptions list.
        }

        private static DateTime GetRefillDate()
        {
            //ask user for the refill date
            //return date if valid
            //loop until valid, log error?
            throw new NotImplementedException();
        }

        private static int GetDosage()
        {
            //ask user for the dosage 
            //return int if valid
            //loop until valid, log error?
                 throw new NotImplementedException();
        }

        private static int GetStrength()
        {
            //ask user for the strength 
            //return int if valid
            //loop until valid, log error?
            throw new NotImplementedException();
        }

        private static int GetTimeTakenEachDay()
        {
            //ask user for the timeTaken (0-23)
            //return int if valid
            //loop until valid, log error?
            throw new NotImplementedException();
        }

        private static string ReasonforMedication()
        {
            //ask user for the reason 
            throw new NotImplementedException();
        }

        private static int GetPrescriptionNumber()
        { //ask user for the timeTaken (0-23)
            //return int if valid
            //loop until valid, log error?

            throw new NotImplementedException();
        }
    }
}


  