using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Kms
{
    [JsiiClass(nativeType: typeof(aws.Kms.DataAwsKmsKeyMultiRegionConfiguration), fullyQualifiedName: "aws.kms.DataAwsKmsKeyMultiRegionConfiguration", parametersJson: "[{\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"complexComputedListIndex\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataAwsKmsKeyMultiRegionConfiguration : HashiCorp.Cdktf.ComplexComputedList
    {
        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        public DataAwsKmsKeyMultiRegionConfiguration(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, string complexComputedListIndex): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexComputedListIndex}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsKmsKeyMultiRegionConfiguration(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsKmsKeyMultiRegionConfiguration(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "multiRegionKeyType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MultiRegionKeyType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "primaryKey", typeJson: "{\"primitive\":\"any\"}")]
        public virtual object PrimaryKey
        {
            get => GetInstanceProperty<object>()!;
        }

        [JsiiProperty(name: "replicaKeys", typeJson: "{\"primitive\":\"any\"}")]
        public virtual object ReplicaKeys
        {
            get => GetInstanceProperty<object>()!;
        }
    }
}
