// <copyright file="Husky.cs" company="APIMatic">
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
    /// Husky.
    /// </summary>
    public class Husky : Dog
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Husky"/> class.
        /// </summary>
        public Husky()
        {
            this.PetType = "Husky";
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Husky"/> class.
        /// </summary>
        /// <param name="petType">petType.</param>
        /// <param name="bark">bark.</param>
        /// <param name="weight">Weight.</param>
        /// <param name="color">Color.</param>
        public Husky(
            string petType = "Husky",
            string bark = null,
            double? weight = null,
            string color = null)
            : base(
                petType,
                bark)
        {
            this.Weight = weight;
            this.Color = color;
        }

        /// <summary>
        /// Gets or sets Weight.
        /// </summary>
        [JsonProperty("Weight", NullValueHandling = NullValueHandling.Ignore)]
        public double? Weight { get; set; }

        /// <summary>
        /// Gets or sets Color.
        /// </summary>
        [JsonProperty("Color", NullValueHandling = NullValueHandling.Ignore)]
        public string Color { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Husky : ({string.Join(", ", toStringOutput)})";
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
            return obj is Husky other &&                ((this.Weight == null && other.Weight == null) || (this.Weight?.Equals(other.Weight) == true)) &&
                ((this.Color == null && other.Color == null) || (this.Color?.Equals(other.Color) == true)) &&
                base.Equals(obj);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Weight = {(this.Weight == null ? "null" : this.Weight.ToString())}");
            toStringOutput.Add($"this.Color = {(this.Color == null ? "null" : this.Color)}");

            base.ToString(toStringOutput);
        }
    }
}