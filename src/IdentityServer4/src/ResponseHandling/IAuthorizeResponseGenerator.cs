﻿// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


using IdentityServerX.Validation;
using System.Threading.Tasks;

namespace IdentityServerX.ResponseHandling
{
    /// <summary>
    /// Interface for the authorize response generator
    /// </summary>
    public interface IAuthorizeResponseGenerator
    {
        /// <summary>
        /// Creates the response
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        Task<AuthorizeResponse> CreateResponseAsync(ValidatedAuthorizeRequest request);
    }
}