﻿// --------------------------------------------------------------------------------------------
// <copyright file="CachingTableDataLoaderStoreProxy.cs" company="Effort Team">
//     Copyright (C) Effort Team
//
//     Permission is hereby granted, free of charge, to any person obtaining a copy
//     of this software and associated documentation files (the "Software"), to deal
//     in the Software without restriction, including without limitation the rights
//     to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//     copies of the Software, and to permit persons to whom the Software is
//     furnished to do so, subject to the following conditions:
//
//     The above copyright notice and this permission notice shall be included in
//     all copies or substantial portions of the Software.
//
//     THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//     IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//     FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//     AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//     LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//     OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
//     THE SOFTWARE.
// </copyright>
// --------------------------------------------------------------------------------------------

namespace Effort.DataLoaders
{
    using System;
    using Effort.Internal.Caching;

    /// <summary>
    ///     Represents a proxy towards the global table data store.
    /// </summary>
    internal class CachingTableDataLoaderStoreProxy : ICachingTableDataLoaderStore
    {
        /// <summary>
        ///     Returns the stored table data.
        /// </summary>
        /// <param name="key"> 
        ///     The key that identifies the table data.
        /// </param>
        /// <param name="factoryMethod">
        ///     The factory method that initilizes the table data if has not been added to the
        ///     store yet.
        /// </param>
        /// <returns>
        ///     The table data.
        /// </returns>
        public CachingTableDataLoader GetCachedData(
            CachingTableDataLoaderKey key,
            Func<CachingTableDataLoader> factoryMethod)
        {
            return CachingTableDataLoaderStore.GetCachedData(key, factoryMethod);
        }

        /// <summary>
        ///     Determines whether the desired table data is added to store.
        /// </summary>
        /// <param name="key">
        ///     The key that identifies the table data.
        /// </param>
        /// <returns>
        ///   <c>true</c> if the store contains the data, otherwise <c>false</c>.
        /// </returns>
        public bool Contains(CachingTableDataLoaderKey key)
        {
            return CachingTableDataLoaderStore.Contains(key);
        }
    }
}
