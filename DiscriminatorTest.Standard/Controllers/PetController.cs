// <copyright file="PetController.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using APIMatic.Core;
using APIMatic.Core.Types;
using APIMatic.Core.Utilities;
using APIMatic.Core.Utilities.Date.Xml;
using DiscriminatorTest.Standard;
using DiscriminatorTest.Standard.Http.Client;
using DiscriminatorTest.Standard.Utilities;
using Newtonsoft.Json.Converters;
using System.Net.Http;

namespace DiscriminatorTest.Standard.Controllers
{
    /// <summary>
    /// PetController.
    /// </summary>
    public class PetController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PetController"/> class.
        /// </summary>
        internal PetController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// create pet.
        /// </summary>
        /// <param name="body">Required parameter: this is pet.</param>
        public void Createpet(
                Models.Pet body)
            => CoreHelper.RunVoidTask(CreatepetAsync(body));

        /// <summary>
        /// create pet.
        /// </summary>
        /// <param name="body">Required parameter: this is pet.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task CreatepetAsync(
                Models.Pet body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<VoidType>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/createpet")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}