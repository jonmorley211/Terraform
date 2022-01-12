using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Timestreamwrite
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.timestreamwrite.TimestreamwriteTableRetentionProperties")]
    public class TimestreamwriteTableRetentionProperties : aws.Timestreamwrite.ITimestreamwriteTableRetentionProperties
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/timestreamwrite_table#magnetic_store_retention_period_in_days TimestreamwriteTable#magnetic_store_retention_period_in_days}.</summary>
        [JsiiProperty(name: "magneticStoreRetentionPeriodInDays", typeJson: "{\"primitive\":\"number\"}", isOverride: true)]
        public double MagneticStoreRetentionPeriodInDays
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/timestreamwrite_table#memory_store_retention_period_in_hours TimestreamwriteTable#memory_store_retention_period_in_hours}.</summary>
        [JsiiProperty(name: "memoryStoreRetentionPeriodInHours", typeJson: "{\"primitive\":\"number\"}", isOverride: true)]
        public double MemoryStoreRetentionPeriodInHours
        {
            get;
            set;
        }
    }
}
