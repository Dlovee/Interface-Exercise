using System;

namespace InterfaceExercise;

public interface ICompany
{
    string Logo { get; set; }
    
    DateTime DataEstablished { get; set; }
}