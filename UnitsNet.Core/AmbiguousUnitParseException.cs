﻿// Licensed under MIT No Attribution, see LICENSE file at the root.
// Copyright 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com). Maintained at https://github.com/angularsen/UnitsNet.

using System;

namespace UnitsNet
{
    /// <summary>
    ///     Unable to parse because more than one unit of the given quantity type had this exact unit abbreviation.
    ///     Example: Length.Parse("1 pt") will throw <see cref="AmbiguousUnitParseException" />, because both
    ///     LengthUnit.DtpPoint and
    ///     LengthUnit.PrinterPoint have "pt" as their abbreviation.
    /// </summary>
    public class AmbiguousUnitParseException : UnitsNetException
    {
        /// <inheritdoc />
        public AmbiguousUnitParseException(string message) : base(message)
        {
            HResult = 2;
        }

        /// <inheritdoc />
        public AmbiguousUnitParseException(string message, Exception innerException) : base(message, innerException)
        {
            HResult = 2;
        }
    }
}