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
    /// <para>Removed the expiry of the link for the shared file or folder.</para>
    /// </summary>
    public class SharedContentRemoveLinkExpiryDetails
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<SharedContentRemoveLinkExpiryDetails> Encoder = new SharedContentRemoveLinkExpiryDetailsEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<SharedContentRemoveLinkExpiryDetails> Decoder = new SharedContentRemoveLinkExpiryDetailsDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see
        /// cref="SharedContentRemoveLinkExpiryDetails" /> class.</para>
        /// </summary>
        /// <param name="targetIndex">Target asset index.</param>
        /// <param name="originalFolderName">Original shared folder name.</param>
        /// <param name="sharedFolderType">Shared folder type. Might be missing due to
        /// historical data gap.</param>
        public SharedContentRemoveLinkExpiryDetails(long targetIndex,
                                                    string originalFolderName = null,
                                                    string sharedFolderType = null)
        {
            this.TargetIndex = targetIndex;
            this.OriginalFolderName = originalFolderName;
            this.SharedFolderType = sharedFolderType;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see
        /// cref="SharedContentRemoveLinkExpiryDetails" /> class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public SharedContentRemoveLinkExpiryDetails()
        {
        }

        /// <summary>
        /// <para>Target asset index.</para>
        /// </summary>
        public long TargetIndex { get; protected set; }

        /// <summary>
        /// <para>Original shared folder name.</para>
        /// </summary>
        public string OriginalFolderName { get; protected set; }

        /// <summary>
        /// <para>Shared folder type. Might be missing due to historical data gap.</para>
        /// </summary>
        public string SharedFolderType { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="SharedContentRemoveLinkExpiryDetails" />.</para>
        /// </summary>
        private class SharedContentRemoveLinkExpiryDetailsEncoder : enc.StructEncoder<SharedContentRemoveLinkExpiryDetails>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(SharedContentRemoveLinkExpiryDetails value, enc.IJsonWriter writer)
            {
                WriteProperty("target_index", value.TargetIndex, writer, enc.Int64Encoder.Instance);
                if (value.OriginalFolderName != null)
                {
                    WriteProperty("original_folder_name", value.OriginalFolderName, writer, enc.StringEncoder.Instance);
                }
                if (value.SharedFolderType != null)
                {
                    WriteProperty("shared_folder_type", value.SharedFolderType, writer, enc.StringEncoder.Instance);
                }
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="SharedContentRemoveLinkExpiryDetails" />.</para>
        /// </summary>
        private class SharedContentRemoveLinkExpiryDetailsDecoder : enc.StructDecoder<SharedContentRemoveLinkExpiryDetails>
        {
            /// <summary>
            /// <para>Create a new instance of type <see
            /// cref="SharedContentRemoveLinkExpiryDetails" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override SharedContentRemoveLinkExpiryDetails Create()
            {
                return new SharedContentRemoveLinkExpiryDetails();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(SharedContentRemoveLinkExpiryDetails value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "target_index":
                        value.TargetIndex = enc.Int64Decoder.Instance.Decode(reader);
                        break;
                    case "original_folder_name":
                        value.OriginalFolderName = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "shared_folder_type":
                        value.SharedFolderType = enc.StringDecoder.Instance.Decode(reader);
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
