using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Timestreamwrite
{
    [JsiiInterface(nativeType: typeof(ITimestreamwriteTableRetentionProperties), fullyQualifiedName: "aws.timestreamwrite.TimestreamwriteTableRetentionProperties")]
    public interface ITimestreamwriteTableRetentionProperties
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/timestreamwrite_table#magnetic_store_retention_period_in_days TimestreamwriteTable#magnetic_store_retention_period_in_days}.</summary>
        [JsiiProperty(name: "magneticStoreRetentionPeriodInDays", typeJson: "{\"primitive\":\"number\"}")]
        double MagneticStoreRetentionPeriodInDays
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/timestreamwrite_table#memory_store_retention_period_in_hours TimestreamwriteTable#memory_store_retention_period_in_hours}.</summary>
        [JsiiProperty(name: "memoryStoreRetentionPeriodInHours", typeJson: "{\"primitive\":\"number\"}")]
        double MemoryStoreRetentionPeriodInHours
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ITimestreamwriteTableRetentionProperties), fullyQualifiedName: "aws.timestreamwrite.TimestreamwriteTableRetentionProperties")]
        internal sealed class _Proxy : DeputyBase, aws.Timestreamwrite.ITimestreamwriteTableRetentionProperties
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/timestreamwrite_table#magnetic_store_retention_period_in_days TimestreamwriteTable#magnetic_store_retention_period_in_days}.</summary>
            [JsiiProperty(name: "magneticStoreRetentionPeriodInDays", typeJson: "{\"primitive\":\"number\"}")]
            public double MagneticStoreRetentionPeriodInDays
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/timestreamwrite_table#memory_store_retention_period_in_hours TimestreamwriteTable#memory_store_retention_period_in_hours}.</summary>
            [JsiiProperty(name: "memoryStoreRetentionPeriodInHours", typeJson: "{\"primitive\":\"number\"}")]
            public double MemoryStoreRetentionPeriodInHours
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
