﻿using System.Runtime.Serialization;

namespace EFAssessment.Services
{
    [Serializable]
    internal class PatientNameEmptyException : Exception
    {
        public PatientNameEmptyException() : base(" PatientName should not be empty !!! ")
        {
        }
    }
}