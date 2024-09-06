// <copyright file="GermanShepherd.cs" company="APIMatic">
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
    /// GermanShepherd.
    /// </summary>
    public class GermanShepherd : Dog
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GermanShepherd"/> class.
        /// </summary>
        public GermanShepherd()
        {
            this.PetType = "GermanShepherd";
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GermanShepherd"/> class.
        /// </summary>
        /// <param name="petType">petType.</param>
        /// <param name="bark">bark.</param>
        /// <param name="weight">Weight.</param>
        /// <param name="height">Height.</param>
        public GermanShepherd(
            string petType = "GermanShepherd",
            string bark = null,
            double? weight = null,
            double? height = null)
            : base(
                petType,
                bark)
        {
            this.Weight = weight;
            this.Height = height;
        }

        /// <summary>
        /// Gets or sets Weight.
        /// </summary>
        [JsonProperty("Weight", NullValueHandling = NullValueHandling.Ignore)]
        public double? Weight { get; set; }

        /// <summary>
        /// Gets or sets Height.
        /// </summary>
        [JsonProperty("Height", NullValueHandling = NullValueHandling.Ignore)]
        public double? Height { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"GermanShepherd : ({string.Join(", ", toStringOutput)})";
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
            return obj is GermanShepherd other &&                ((this.Weight == null && other.Weight == null) || (this.Weight?.Equals(other.Weight) == true)) &&
                ((this.Height == null && other.Height == null) || (this.Height?.Equals(other.Height) == true)) &&
                base.Equals(obj);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Weight = {(this.Weight == null ? "null" : this.Weight.ToString())}");
            toStringOutput.Add($"this.Height = {(this.Height == null ? "null" : this.Height.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}