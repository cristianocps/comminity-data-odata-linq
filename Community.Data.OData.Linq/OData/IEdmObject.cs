﻿// Copyright (c) Microsoft Corporation.  All rights reserved.
// Licensed under the MIT License.  See License.txt in the project root for license information.

namespace Community.OData.Linq.OData
{
    using System.Diagnostics.CodeAnalysis;

    using Microsoft.OData.Edm;

    /// <summary>
    /// Represents an instance of an <see cref="IEdmType"/>.
    /// </summary>
    public interface IEdmObject
    {
        /// <summary>
        /// Gets the <see cref="IEdmTypeReference"/> of this instance.
        /// </summary>
        /// <returns>The <see cref="IEdmTypeReference"/> of this instance.</returns>
        [SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate",
            Justification = "This should not be serialized. Having it as a method is more appropriate.")]
        IEdmTypeReference GetEdmType();
    }
}
