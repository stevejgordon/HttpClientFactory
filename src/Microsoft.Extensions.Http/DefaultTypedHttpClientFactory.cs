// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Net.Http;
using Microsoft.Extensions.DependencyInjection;

namespace Microsoft.Extensions.Http
{
    internal class DefaultTypedHttpClientFactory : ITypedHttpClientFactory
    {
        private readonly IServiceProvider _services;

        public DefaultTypedHttpClientFactory(IServiceProvider services)
        {
            if (services == null)
            {
                throw new ArgumentNullException(nameof(services));
            }

            _services = services;
        }

        public T CreateClient<T>(string name, HttpClient httpClient)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            if (httpClient == null)
            {
                throw new ArgumentNullException(nameof(httpClient));
            }

            return ActivatorUtilities.CreateInstance<T>(_services, httpClient);
        }
    }
}
