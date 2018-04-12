// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.TeamLog
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>Set custom member space limit.</para>
    /// </summary>
    public class MemberSpaceLimitsAddCustomQuotaDetails
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<MemberSpaceLimitsAddCustomQuotaDetails> Encoder = new MemberSpaceLimitsAddCustomQuotaDetailsEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<MemberSpaceLimitsAddCustomQuotaDetails> Decoder = new MemberSpaceLimitsAddCustomQuotaDetailsDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see
        /// cref="MemberSpaceLimitsAddCustomQuotaDetails" /> class.</para>
        /// </summary>
        /// <param name="newValue">New custom quota value in bytes.</param>
        public MemberSpaceLimitsAddCustomQuotaDetails(ulong newValue)
        {
            this.NewValue = newValue;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see
        /// cref="MemberSpaceLimitsAddCustomQuotaDetails" /> class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public MemberSpaceLimitsAddCustomQuotaDetails()
        {
        }

        /// <summary>
        /// <para>New custom quota value in bytes.</para>
        /// </summary>
        public ulong NewValue { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="MemberSpaceLimitsAddCustomQuotaDetails" />.</para>
        /// </summary>
        private class MemberSpaceLimitsAddCustomQuotaDetailsEncoder : enc.StructEncoder<MemberSpaceLimitsAddCustomQuotaDetails>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(MemberSpaceLimitsAddCustomQuotaDetails value, enc.IJsonWriter writer)
            {
                WriteProperty("new_value", value.NewValue, writer, enc.UInt64Encoder.Instance);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="MemberSpaceLimitsAddCustomQuotaDetails" />.</para>
        /// </summary>
        private class MemberSpaceLimitsAddCustomQuotaDetailsDecoder : enc.StructDecoder<MemberSpaceLimitsAddCustomQuotaDetails>
        {
            /// <summary>
            /// <para>Create a new instance of type <see
            /// cref="MemberSpaceLimitsAddCustomQuotaDetails" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override MemberSpaceLimitsAddCustomQuotaDetails Create()
            {
                return new MemberSpaceLimitsAddCustomQuotaDetails();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(MemberSpaceLimitsAddCustomQuotaDetails value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "new_value":
                        value.NewValue = enc.UInt64Decoder.Instance.Decode(reader);
                        break;
                    default:
                        reader.Skip();
                        break;
                }
            }
        }

        #endregion
    }
}