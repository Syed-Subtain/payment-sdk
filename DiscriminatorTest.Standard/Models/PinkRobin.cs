// <copyright file="PinkRobin.cs" company="APIMatic">
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
    /// PinkRobin.
    /// </summary>
    public class PinkRobin : Bird
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PinkRobin"/> class.
        /// </summary>
        public PinkRobin()
        {
            this.BirdType = "PinkRobin";
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PinkRobin"/> class.
        /// </summary>
        /// <param name="birdType">birdType.</param>
        /// <param name="beak">beak.</param>
        /// <param name="countries">countries.</param>
        public PinkRobin(
            string birdType = "PinkRobin",
            string beak = null,
            string countries = null)
            : base(
                birdType)
        {
            this.Beak = beak;
            this.Countries = countries;
        }

        /// <summary>
        /// Gets or sets Beak.
        /// </summary>
        [JsonProperty("beak", NullValueHandling = NullValueHandling.Ignore)]
        public string Beak { get; set; }

        /// <summary>
        /// Gets or sets Countries.
        /// </summary>
        [JsonProperty("countries", NullValueHandling = NullValueHandling.Ignore)]
        public string Countries { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"PinkRobin : ({string.Join(", ", toStringOutput)})";
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
            return obj is PinkRobin other &&                ((this.Beak == null && other.Beak == null) || (this.Beak?.Equals(other.Beak) == true)) &&
                ((this.Countries == null && other.Countries == null) || (this.Countries?.Equals(other.Countries) == true)) &&
                base.Equals(obj);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Beak = {(this.Beak == null ? "null" : this.Beak)}");
            toStringOutput.Add($"this.Countries = {(this.Countries == null ? "null" : this.Countries)}");

            base.ToString(toStringOutput);
        }
    }
}