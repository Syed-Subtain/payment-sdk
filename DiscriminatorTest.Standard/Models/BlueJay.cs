// <copyright file="BlueJay.cs" company="APIMatic">
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
    /// BlueJay.
    /// </summary>
    public class BlueJay : Bird
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BlueJay"/> class.
        /// </summary>
        public BlueJay()
        {
            this.BirdType = "BlueBirdy";
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BlueJay"/> class.
        /// </summary>
        /// <param name="name">Name.</param>
        /// <param name="birdType">birdType.</param>
        /// <param name="beak">beak.</param>
        /// <param name="season">season.</param>
        public BlueJay(
            string name,
            string birdType = "BlueBirdy",
            string beak = null,
            string season = null)
            : base(
                name,
                birdType)
        {
            this.Beak = beak;
            this.Season = season;
        }

        /// <summary>
        /// Gets or sets Beak.
        /// </summary>
        [JsonProperty("beak", NullValueHandling = NullValueHandling.Ignore)]
        public string Beak { get; set; }

        /// <summary>
        /// Gets or sets Season.
        /// </summary>
        [JsonProperty("season", NullValueHandling = NullValueHandling.Ignore)]
        public string Season { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"BlueJay : ({string.Join(", ", toStringOutput)})";
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
            return obj is BlueJay other &&                ((this.Beak == null && other.Beak == null) || (this.Beak?.Equals(other.Beak) == true)) &&
                ((this.Season == null && other.Season == null) || (this.Season?.Equals(other.Season) == true)) &&
                base.Equals(obj);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Beak = {(this.Beak == null ? "null" : this.Beak)}");
            toStringOutput.Add($"this.Season = {(this.Season == null ? "null" : this.Season)}");

            base.ToString(toStringOutput);
        }
    }
}