﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ListExtensions.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DotNetScaffolder.Core.Extensions
{
    #region Usings

    using System.Collections.Generic;

    #endregion

    /// <summary>
    ///     The list extensions.
    /// </summary>
    public static class ListExtensions
    {
        #region Public methods and operators

        /// <summary>
        /// Move item.
        /// </summary>
        /// <param name="list">
        /// The list.
        /// </param>
        /// <param name="oldIndex">
        /// The old index.
        /// </param>
        /// <param name="newIndex">
        /// The new index.
        /// </param>
        /// <typeparam name="T">
        /// </typeparam>
        public static void MoveItem<T>(this List<T> list, int oldIndex, int newIndex)
        {
            T item = list[oldIndex];
            list.RemoveAt(oldIndex);
            list.Insert(newIndex, item);
        }

        #endregion
    }
}