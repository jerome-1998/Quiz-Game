//------------------------------------------------------------------------------
// <auto-generated>
//     Der Code wurde von einer Vorlage generiert.
//
//     Manuelle Änderungen an dieser Datei führen möglicherweise zu unerwartetem Verhalten der Anwendung.
//     Manuelle Änderungen an dieser Datei werden überschrieben, wenn der Code neu generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuizGame
{
    using System;
    using System.Collections.Generic;
    
    public partial class Results
    {
        public int rID { get; set; }
        public string resultONE { get; set; }
        public string relultTWO { get; set; }
        public string resultTHREE { get; set; }
        public string trueRESULT { get; set; }
        public Nullable<int> qid { get; set; }
    
        public virtual Questions Questions { get; set; }
    }
}