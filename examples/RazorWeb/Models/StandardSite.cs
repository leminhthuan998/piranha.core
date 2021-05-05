/*
 * Copyright (c) .NET Foundation and Contributors
 *
 * This software may be modified and distributed under the terms
 * of the MIT license.  See the LICENSE file for details.
 *
 * http://github.com/tidyui/coreweb
 *
 */
using RazorWeb.Models.Regions;
using Piranha.AttributeBuilder;
using Piranha.Extend;
using Piranha.Models;


namespace RazorWeb.Models
{
    /// <summary>
    /// Basic page with main content in markdown.
    /// </summary>
    [SiteType(Title = "Standard Site")]
    public class StandardSite : SiteContent<StandardSite>
    {
        /// <summary>
        /// Gets/sets the header.
        /// </summary>
        [Region(Title = "Header", SortOrder = 1)]
        public Header Header { get; set; }

        /// <summary>
        /// Gets/sets the header.
        /// </summary>
        [Region(Title = "Footer", SortOrder = 2)]
        public Footer Footer { get; set; }
    }
}
