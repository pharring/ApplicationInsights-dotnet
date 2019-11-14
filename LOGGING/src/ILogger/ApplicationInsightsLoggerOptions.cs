﻿// -----------------------------------------------------------------------
// <copyright file="ApplicationInsightsLoggerOptions.cs" company="Microsoft">
// Copyright (c) Microsoft Corporation. 
// All rights reserved.  2013
// </copyright>
// -----------------------------------------------------------------------

namespace Microsoft.Extensions.Logging.ApplicationInsights
{
    using Microsoft.ApplicationInsights.DataContracts;

    /// <summary>
    /// <see cref="ApplicationInsightsLoggerOptions"/> defines the custom behavior of the tracing information sent to Application Insights.
    /// </summary>
    public class ApplicationInsightsLoggerOptions
    {
        /// <summary>
        /// Gets or sets a value indicating whether to track exceptions as <see cref="ExceptionTelemetry"/>.
        /// Defaults to true.
        /// </summary>
        public bool TrackExceptionsAsExceptionTelemetry { get; set; } = true;

        /// <summary>
        /// Gets or sets a value indicating whether the Scope information is included from telemetry or not.
        /// Defaults to true.
        /// </summary>
        public bool IncludeScopes { get; set; } = true;

        /// <summary>
        /// Gets or sets a value indicating whether the operation context is included or not.
        /// The operation context is extracted from <see cref="System.Diagnostics.Activity.Current"/>.
        /// </summary>
        public bool IncludeOperationContextFromActivity { get; set; } = true;
    }
}