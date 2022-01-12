using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Datasources
{
    [JsiiClass(nativeType: typeof(aws.Datasources.DataAwsLaunchConfigurationEbsBlockDevice), fullyQualifiedName: "aws.datasources.DataAwsLaunchConfigurationEbsBlockDevice", parametersJson: "[{\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"complexComputedListIndex\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataAwsLaunchConfigurationEbsBlockDevice : HashiCorp.Cdktf.ComplexComputedList
    {
        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        public DataAwsLaunchConfigurationEbsBlockDevice(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, string complexComputedListIndex): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexComputedListIndex}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsLaunchConfigurationEbsBlockDevice(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsLaunchConfigurationEbsBlockDevice(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "deleteOnTermination", typeJson: "{\"primitive\":\"any\"}")]
        public virtual object DeleteOnTermination
        {
            get => GetInstanceProperty<object>()!;
        }

        [JsiiProperty(name: "deviceName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DeviceName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "encrypted", typeJson: "{\"primitive\":\"any\"}")]
        public virtual object Encrypted
        {
            get => GetInstanceProperty<object>()!;
        }

        [JsiiProperty(name: "iops", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Iops
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "noDevice", typeJson: "{\"primitive\":\"any\"}")]
        public virtual object NoDevice
        {
            get => GetInstanceProperty<object>()!;
        }

        [JsiiProperty(name: "snapshotId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SnapshotId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "throughput", typeJson: "{\"primitive\":\"any\"}")]
        public virtual object Throughput
        {
            get => GetInstanceProperty<object>()!;
        }

        [JsiiProperty(name: "volumeSize", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double VolumeSize
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "volumeType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VolumeType
        {
            get => GetInstanceProperty<string>()!;
        }
    }
}
