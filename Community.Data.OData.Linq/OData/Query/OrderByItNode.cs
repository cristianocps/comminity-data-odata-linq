﻿// Copyright (c) Microsoft Corporation.  All rights reserved.
// Licensed under the MIT License.  See License.txt in the project root for license information.

namespace Community.OData.Linq.OData.Query
{
    using Microsoft.OData.UriParser;

    /// <summary>
    /// Represents the order by expression '$it' in the $orderby clause.
    /// </summary>
    public class OrderByItNode : OrderByNode
    {
        /// <summary>
        /// Instantiates a new instance of <see cref="OrderByItNode"/> class.
        /// </summary>
        /// <param name="direction">The <see cref="OrderByDirection"/> for this node.</param>
        public OrderByItNode(OrderByDirection direction)
            : base(direction)
        {
        }
    }
}
