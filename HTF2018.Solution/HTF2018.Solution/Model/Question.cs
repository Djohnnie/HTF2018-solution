using System;
using System.Collections.Generic;
using System.Text;

namespace HTF2018.Solution.Model
{
    /// <summary>
    /// This object represents a question containing all the needed data.
    /// </summary>
    public class Question
    {
        /// <summary>
        /// The data you need to solve the challenge question.
        /// </summary>
        public List<Value> InputValues { get; set; }
    }
}