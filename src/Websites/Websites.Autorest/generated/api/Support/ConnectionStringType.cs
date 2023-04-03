// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Websites.Support
{

    /// <summary>Type of database.</summary>
    public partial struct ConnectionStringType :
        System.IEquatable<ConnectionStringType>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.Websites.Support.ConnectionStringType ApiHub = @"ApiHub";

        public static Microsoft.Azure.PowerShell.Cmdlets.Websites.Support.ConnectionStringType Custom = @"Custom";

        public static Microsoft.Azure.PowerShell.Cmdlets.Websites.Support.ConnectionStringType DocDb = @"DocDb";

        public static Microsoft.Azure.PowerShell.Cmdlets.Websites.Support.ConnectionStringType EventHub = @"EventHub";

        public static Microsoft.Azure.PowerShell.Cmdlets.Websites.Support.ConnectionStringType MySql = @"MySql";

        public static Microsoft.Azure.PowerShell.Cmdlets.Websites.Support.ConnectionStringType NotificationHub = @"NotificationHub";

        public static Microsoft.Azure.PowerShell.Cmdlets.Websites.Support.ConnectionStringType PostgreSql = @"PostgreSQL";

        public static Microsoft.Azure.PowerShell.Cmdlets.Websites.Support.ConnectionStringType RedisCache = @"RedisCache";

        public static Microsoft.Azure.PowerShell.Cmdlets.Websites.Support.ConnectionStringType ServiceBus = @"ServiceBus";

        public static Microsoft.Azure.PowerShell.Cmdlets.Websites.Support.ConnectionStringType SqlAzure = @"SQLAzure";

        public static Microsoft.Azure.PowerShell.Cmdlets.Websites.Support.ConnectionStringType SqlServer = @"SQLServer";

        /// <summary>the value for an instance of the <see cref="ConnectionStringType" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Creates an instance of the <see cref="ConnectionStringType"/> Enum class.</summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private ConnectionStringType(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Conversion from arbitrary object to ConnectionStringType</summary>
        /// <param name="value">the value to convert to an instance of <see cref="ConnectionStringType" />.</param>
        internal static object CreateFrom(object value)
        {
            return new ConnectionStringType(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type ConnectionStringType</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.Websites.Support.ConnectionStringType e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type ConnectionStringType (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is ConnectionStringType && Equals((ConnectionStringType)obj);
        }

        /// <summary>Returns hashCode for enum ConnectionStringType</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Returns string representation for ConnectionStringType</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to ConnectionStringType</summary>
        /// <param name="value">the value to convert to an instance of <see cref="ConnectionStringType" />.</param>

        public static implicit operator ConnectionStringType(string value)
        {
            return new ConnectionStringType(value);
        }

        /// <summary>Implicit operator to convert ConnectionStringType to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="ConnectionStringType" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.Websites.Support.ConnectionStringType e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum ConnectionStringType</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.Websites.Support.ConnectionStringType e1, Microsoft.Azure.PowerShell.Cmdlets.Websites.Support.ConnectionStringType e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum ConnectionStringType</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.Websites.Support.ConnectionStringType e1, Microsoft.Azure.PowerShell.Cmdlets.Websites.Support.ConnectionStringType e2)
        {
            return e2.Equals(e1);
        }
    }
}