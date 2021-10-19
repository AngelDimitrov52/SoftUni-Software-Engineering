using System;
using System.Collections.Generic;
using System.Text;

namespace P07.MilitaryElite.Abstractclasses
{
    public class Mission
    {
        private string state;
        public Mission(string code , string state)
        {
            CodeName = code;
            State = state;
        }
        public string CodeName { get; set; }
        public string State
        {
            get => state;
            set
            {
                if (value == "inProgress")
                {
                    state = value;
                }
                else if (value == "finished")
                {
                    state = value;
                }
                else
                {
                    throw new ArgumentException("Invalid mission");
                }
            }
        }

        public void CompleteMission()
        {
            this.State = "finished";
        }
        public override string ToString()
        {
            return $"Code Name: {CodeName} State: {State}";
        }
    }
}
