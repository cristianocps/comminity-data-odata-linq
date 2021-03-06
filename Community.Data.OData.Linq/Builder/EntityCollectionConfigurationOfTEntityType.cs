﻿// Copyright (c) Microsoft Corporation.  All rights reserved.
// Licensed under the MIT License.  See License.txt in the project root for license information.

namespace Community.OData.Linq.Builder
{
    using System.Collections.Generic;

    /// <summary>
    /// EntityCollectionConfiguration represents a Collection of Entities.
    /// This class can be used to configure things that get bound to entities, like Actions bound to a collection.
    /// </summary>
    /// <typeparam name="TEntityType">The EntityType that is the ElementType of the EntityCollection</typeparam>
    public class EntityCollectionConfiguration<TEntityType> : CollectionTypeConfiguration
    {
        internal EntityCollectionConfiguration(EntityTypeConfiguration elementType)
            : base(elementType, typeof(IEnumerable<TEntityType>))
        {
        }
    }
}