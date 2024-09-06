// <copyright file="Pet.cs" company="APIMatic">
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
    /// Pet.
    /// </summary>
    [JsonConverter(typeof(JsonSubtypes), "petType")]
    [JsonSubtypes.KnownSubType(typeof(Cat), "meow")]
    [JsonSubtypes.KnownSubType(typeof(Lizard), "Lizard")]
    [JsonSubtypes.KnownSubType(typeof(Dog), "dog")]
    [JsonSubtypes.KnownSubType(typeof(Husky), "Husky")]
    [JsonSubtypes.KnownSubType(typeof(GermanShepherd), "GermanShepherd")]
    public class Pet
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Pet"/> class.
        /// </summary>
        public Pet()
        {
            this.PetType = "Pet";
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Pet"/> class.
        /// </summary>
        /// <param name="petType">petType.</param>
        public Pet(
            string petType = "Pet")
        {
            this.PetType = petType;
        }

        /// <summary>
        /// Gets or sets PetType.
        /// </summary>
        [JsonProperty("petType", NullValueHandling = NullValueHandling.Ignore)]
        public string PetType { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Pet : ({string.Join(", ", toStringOutput)})";
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
            return obj is Pet other &&                ((this.PetType == null && other.PetType == null) || (this.PetType?.Equals(other.PetType) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.PetType = {(this.PetType == null ? "null" : this.PetType)}");
        }
    }
}