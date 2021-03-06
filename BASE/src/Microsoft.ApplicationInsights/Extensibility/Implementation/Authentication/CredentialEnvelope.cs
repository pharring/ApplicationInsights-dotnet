﻿namespace Microsoft.ApplicationInsights.Extensibility.Implementation.Authentication
{
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// This interface defines a class that can interact with Azure.Core.TokenCredential.
    /// </summary>
    public abstract class CredentialEnvelope
    {
        /// <summary>
        /// Gets the TokenCredential instance held by this class.
        /// </summary>
        internal abstract object Credential { get; }

        /// <summary>
        /// Gets an Azure.Core.AccessToken.
        /// </summary>
        /// <remarks>
        /// Whomever uses this MUST verify that it's called within <see cref="SdkInternalOperationsMonitor.Enter"/> otherwise dependency calls will be tracked.
        /// </remarks>
        /// <param name="cancellationToken">The System.Threading.CancellationToken to use.</param>
        /// <returns>A valid Azure.Core.AccessToken.</returns>
        public abstract string GetToken(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets an Azure.Core.AccessToken.
        /// </summary>
        /// <remarks>
        /// Whomever uses this MUST verify that it's called within <see cref="SdkInternalOperationsMonitor.Enter"/> otherwise dependency calls will be tracked.
        /// </remarks>
        /// <param name="cancellationToken">The System.Threading.CancellationToken to use.</param>
        /// <returns>A valid Azure.Core.AccessToken.</returns>
        public abstract Task<string> GetTokenAsync(CancellationToken cancellationToken = default);
    }
}