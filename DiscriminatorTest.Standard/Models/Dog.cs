// <copyright file="Dog.cs" company="APIMatic">
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
    /// Dog.
    /// </summary>
    public class Dog : Pet
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Dog"/> class.
        /// </summary>
        public Dog()
        {
            this.PetType = "dog";
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Dog"/> class.
        /// </summary>
        /// <param name="petType">petType.</param>
        /// <param name="bark">bark.</param>
        public Dog(
            string petType = "dog",
            string bark = null)
            : base(
                petType)
        {
            this.Bark = bark;
        }

        /// <summary>
        /// Gets or sets Bark.
        /// </summary>
        [JsonProperty("bark", NullValueHandling = NullValueHandling.Ignore)]
        public string Bark { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Dog : ({string.Join(", ", toStringOutput)})";
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
            return obj is Dog other &&                ((this.Bark == null && other.Bark == null) || (this.Bark?.Equals(other.Bark) == true)) &&
                base.Equals(obj);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Bark = {(this.Bark == null ? "null" : this.Bark)}");

            base.ToString(toStringOutput);
        }
    }
}