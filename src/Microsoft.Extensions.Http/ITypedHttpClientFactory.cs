// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Net.Http;

namespace Microsoft.Extensions.Http
{
    public interface ITypedHttpClientFactory
    {
        T CreateClient<T>(string name, HttpClient httpClient);
    }
}
