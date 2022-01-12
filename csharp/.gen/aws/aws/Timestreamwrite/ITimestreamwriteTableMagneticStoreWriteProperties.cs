using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Timestreamwrite
{
    [JsiiInterface(nativeType: typeof(ITimestreamwriteTableMagneticStoreWriteProperties), fullyQualifiedName: "aws.timestreamwrite.TimestreamwriteTableMagneticStoreWriteProperties")]
    public interface ITimestreamwriteTableMagneticStoreWriteProperties
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/timestreamwrite_table#enable_magnetic_store_writes TimestreamwriteTable#enable_magnetic_store_writes}.</summary>
        [JsiiProperty(name: "enableMagneticStoreWrites", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? EnableMagneticStoreWrites
        {
            get
            {
                return null;
            }
        }

        /// <summary>magnetic_store_rejected_data_location block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/timestreamwrite_table#magnetic_store_rejected_data_location TimestreamwriteTable#magnetic_store_rejected_data_location}
        /// </remarks>
        [JsiiProperty(name: "magneticStoreRejectedDataLocation", typeJson: "{\"fqn\":\"aws.timestreamwrite.TimestreamwriteTableMagneticStoreWritePropertiesMagneticStoreRejectedDataLocation\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Timestreamwrite.ITimestreamwriteTableMagneticStoreWritePropertiesMagneticStoreRejectedDataLocation? MagneticStoreRejectedDataLocation
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ITimestreamwriteTableMagneticStoreWriteProperties), fullyQualifiedName: "aws.timestreamwrite.TimestreamwriteTableMagneticStoreWriteProperties")]
        internal sealed class _Proxy : DeputyBase, aws.Timestreamwrite.ITimestreamwriteTableMagneticStoreWriteProperties
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/timestreamwrite_table#enable_magnetic_store_writes TimestreamwriteTable#enable_magnetic_store_writes}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "enableMagneticStoreWrites", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? EnableMagneticStoreWrites
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>magnetic_store_rejected_data_location block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/timestreamwrite_table#magnetic_store_rejected_data_location TimestreamwriteTable#magnetic_store_rejected_data_location}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "magneticStoreRejectedDataLocation", typeJson: "{\"fqn\":\"aws.timestreamwrite.TimestreamwriteTableMagneticStoreWritePropertiesMagneticStoreRejectedDataLocation\"}", isOptional: true)]
            public aws.Timestreamwrite.ITimestreamwriteTableMagneticStoreWritePropertiesMagneticStoreRejectedDataLocation? MagneticStoreRejectedDataLocation
            {
                get => GetInstanceProperty<aws.Timestreamwrite.ITimestreamwriteTableMagneticStoreWritePropertiesMagneticStoreRejectedDataLocation?>();
            }
        }
    }
}
