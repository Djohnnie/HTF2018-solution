﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HTF2018.Solution.Model
{
    /// <summary>
    /// This object represents a key-value pair where the key is named "Name" and the value is named "Data".
    /// </summary>
    public class Value
    {
        /// <summary>
        /// The key-part of this key-value pair.
        /// </summary>
        public String Name { get; set; }

        /// <summary>
        /// The value-part of this key-value pair.
        /// </summary>
        public String Data { get; set; }
    }
}