// <copyright file="Bird.cs" company="APIMatic">
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
    /// Bird.
    /// </summary>
    [JsonConverter(typeof(JsonSubtypes), "birdType")]
    [JsonSubtypes.KnownSubType(typeof(Parrot), "Mithu")]
    [JsonSubtypes.KnownSubType(typeof(BlueJay), "BlueBirdy")]
    [JsonSubtypes.KnownSubType(typeof(PinkRobin), "PinkRobin")]
    public class Bird
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Bird"/> class.
        /// </summary>
        public Bird()
        {
            this.BirdType = "Bird";
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Bird"/> class.
        /// </summary>
        /// <param name="name">Name.</param>
        /// <param name="birdType">birdType.</param>
        public Bird(
            string name,
            string birdType = "Bird")
        {
            this.BirdType = birdType;
            this.Name = name;
        }

        /// <summary>
        /// Gets or sets BirdType.
        /// </summary>
        [JsonProperty("birdType", NullValueHandling = NullValueHandling.Ignore)]
        public string BirdType { get; set; }

        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        [JsonProperty("Name")]
        public string Name { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Bird : ({string.Join(", ", toStringOutput)})";
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
            return obj is Bird other &&                ((this.BirdType == null && other.BirdType == null) || (this.BirdType?.Equals(other.BirdType) == true)) &&
                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.BirdType = {(this.BirdType == null ? "null" : this.BirdType)}");
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name)}");
        }
    }
}