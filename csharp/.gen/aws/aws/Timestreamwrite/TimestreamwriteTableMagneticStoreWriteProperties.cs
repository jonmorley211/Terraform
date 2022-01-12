using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Timestreamwrite
{
    [JsiiByValue(fqn: "aws.timestreamwrite.TimestreamwriteTableMagneticStoreWriteProperties")]
    public class TimestreamwriteTableMagneticStoreWriteProperties : aws.Timestreamwrite.ITimestreamwriteTableMagneticStoreWriteProperties
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/timestreamwrite_table#enable_magnetic_store_writes TimestreamwriteTable#enable_magnetic_store_writes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "enableMagneticStoreWrites", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true, isOverride: true)]
        public object? EnableMagneticStoreWrites
        {
            get;
            set;
        }

        /// <summary>magnetic_store_rejected_data_location block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/timestreamwrite_table#magnetic_store_rejected_data_location TimestreamwriteTable#magnetic_store_rejected_data_location}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "magneticStoreRejectedDataLocation", typeJson: "{\"fqn\":\"aws.timestreamwrite.TimestreamwriteTableMagneticStoreWritePropertiesMagneticStoreRejectedDataLocation\"}", isOptional: true, isOverride: true)]
        public aws.Timestreamwrite.ITimestreamwriteTableMagneticStoreWritePropertiesMagneticStoreRejectedDataLocation? MagneticStoreRejectedDataLocation
        {
            get;
            set;
        }
    }
}
