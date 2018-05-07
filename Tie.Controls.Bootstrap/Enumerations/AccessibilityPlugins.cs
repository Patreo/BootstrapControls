﻿// AccessibilityPlugins.cs

// Copyright (C) 2018 Kinsey Roberts (@kinzdesign), Weatherhead School of Management (@wsomweb)

// This program is free software; you can redistribute it and/or modify it under the terms of the GNU 
// General Public License as published by the Free Software Foundation; either version 2 of the 
// License, or (at your option) any later version.

// This program is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; without 
// even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See 
// the GNU General Public License for more details. You should have received a copy of the GNU 
// General Public License along with this program; if not, write to the Free Software Foundation, Inc., 59 
// Temple Place, Suite 330, Boston, MA 02111-1307 USA

namespace Tie.Controls.Bootstrap
{
    /// <summary>
    /// Defines the available accessibility plugins.
    /// </summary>
    public enum AccessibilityPlugins : byte
    {
        /// <summary>
        /// No accessibility plugin will be used. Not recommended.
        /// </summary>
        None = 0,

        /// <summary>
        /// https://github.com/paypal/bootstrap-accessibility-plugin
        /// </summary>
        PayPal = 1,

        /// <summary>
        /// https://github.com/jongund/bootstrap-accessibility-plugin
        /// demo at: https://jongund.github.io/aria-examples/bootstrap-carousel/carousel-3.html
        /// </summary>
        JonGund = 2
    }
}
