using System;

namespace Medicine_label
{
  class Program
  {
    static string AddS(string dosage, int dosageNumber)
    { 
        if (dosageNumber > 1)
        {
            dosage += 's';
        }
        return dosage;
    }
    static void Main()
    {
      Console.WriteLine("What is the name of the patient");
      string PatientName = Console.ReadLine();

      Console.WriteLine($"Enter the medicine prescribed to {PatientName}");
      string medicineName = Console.ReadLine();
      
      
      Console.WriteLine("Please choose the appropriate dosage form from the list:\n");
      string[] dosageForms = {"tablet", "capsule", "caplet", "sachet"};
    
      foreach (String dosage in dosageForms)
      {
        Console.WriteLine(dosage + "\n");
      }
      string typedInDosageForm = Console.ReadLine().ToLower();
      bool checkFormExist = dosageForms.Contains(typedInDosageForm);
      while(!checkFormExist)
      {
        Console.WriteLine($"{typedInDosageForm} does not exist. Please try again");
        typedInDosageForm = Console.ReadLine().ToLower();
        checkFormExist = dosageForms.Contains(typedInDosageForm);
        
      }

      Console.WriteLine($"How many {medicineName} does {PatientName} needs to take per day?");
      int numOfDosageForm = Convert.ToInt32(Console.ReadLine());
      typedInDosageForm = AddS(typedInDosageForm, numOfDosageForm);
      Console.WriteLine($"\nPatient name: {PatientName}\nMedicine Prescribed: {medicineName}\nInstruction: Take {numOfDosageForm} {typedInDosageForm} per day");
      
    }
  }
}
