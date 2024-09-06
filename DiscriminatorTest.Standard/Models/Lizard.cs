// <copyright file="Lizard.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APIMatic.Core.Utilities.Converters;
using DiscriminatorTest.Standard;
using DiscriminatorTest.Standard.Utilities;
using JsonSubTypes;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace DiscriminatorTest.Standard.Models
{
    /// <summary>
    /// Lizard.
    /// </summary>
    public class Lizard : Pet
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Lizard"/> class.
        /// </summary>
        public Lizard()
        {
            this.PetType = "Lizard";
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Lizard"/> class.
        /// </summary>
        /// <param name="petType">petType.</param>
        /// <param name="lovesRocks">lovesRocks.</param>
        public Lizard(
            string petType = "Lizard",
            bool? lovesRocks = null)
            : base(
                petType)
        {
            this.LovesRocks = lovesRocks;
        }

        /// <summary>
        /// Gets or sets LovesRocks.
        /// </summary>
        [JsonProperty("lovesRocks", NullValueHandling = NullValueHandling.Ignore)]
        public bool? LovesRocks { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Lizard : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (obj == this)
            {
                return true;
            }
            return obj is Lizard other &&                ((this.LovesRocks == null && other.LovesRocks == null) || (this.LovesRocks?.Equals(other.LovesRocks) == true)) &&
                base.Equals(obj);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.LovesRocks = {(this.LovesRocks == null ? "null" : this.LovesRocks.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}