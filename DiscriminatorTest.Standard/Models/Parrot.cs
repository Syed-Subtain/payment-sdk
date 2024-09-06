// <copyright file="Parrot.cs" company="APIMatic">
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
    /// Parrot.
    /// </summary>
    public class Parrot : Bird
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Parrot"/> class.
        /// </summary>
        public Parrot()
        {
            this.BirdType = "Mithu";
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Parrot"/> class.
        /// </summary>
        /// <param name="birdType">birdType.</param>
        /// <param name="beak">beak.</param>
        /// <param name="wings">wings.</param>
        public Parrot(
            string birdType = "Mithu",
            string beak = null,
            string wings = null)
            : base(
                birdType)
        {
            this.Beak = beak;
            this.Wings = wings;
        }

        /// <summary>
        /// Gets or sets Beak.
        /// </summary>
        [JsonProperty("beak", NullValueHandling = NullValueHandling.Ignore)]
        public string Beak { get; set; }

        /// <summary>
        /// Gets or sets Wings.
        /// </summary>
        [JsonProperty("wings", NullValueHandling = NullValueHandling.Ignore)]
        public string Wings { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Parrot : ({string.Join(", ", toStringOutput)})";
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
            return obj is Parrot other &&                ((this.Beak == null && other.Beak == null) || (this.Beak?.Equals(other.Beak) == true)) &&
                ((this.Wings == null && other.Wings == null) || (this.Wings?.Equals(other.Wings) == true)) &&
                base.Equals(obj);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Beak = {(this.Beak == null ? "null" : this.Beak)}");
            toStringOutput.Add($"this.Wings = {(this.Wings == null ? "null" : this.Wings)}");

            base.ToString(toStringOutput);
        }
    }
}