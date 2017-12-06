﻿// ==========================================================================
//  IStateFactory.cs
//  Squidex Headless CMS
// ==========================================================================
//  Copyright (c) Squidex Group
//  All rights reserved.
// ==========================================================================

using System.Threading.Tasks;

namespace Squidex.Infrastructure.States
{
    public interface IStateFactory
    {
        Task<T> GetSingleAsync<T>(string key) where T : IStatefulObject;

        Task<T> CreateAsync<T>(string key) where T : IStatefulObject;
    }
}
