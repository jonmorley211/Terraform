using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Redshift
{
    [JsiiClass(nativeType: typeof(aws.Redshift.RedshiftClusterSnapshotCopyOutputReference), fullyQualifiedName: "aws.redshift.RedshiftClusterSnapshotCopyOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class RedshiftClusterSnapshotCopyOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public RedshiftClusterSnapshotCopyOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected RedshiftClusterSnapshotCopyOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected RedshiftClusterSnapshotCopyOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetGrantName")]
        public virtual void ResetGrantName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRetentionPeriod")]
        public virtual void ResetRetentionPeriod()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "destinationRegionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DestinationRegionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "grantNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? GrantNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "retentionPeriodInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? RetentionPeriodInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "destinationRegion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DestinationRegion
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "grantName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GrantName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "retentionPeriod", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double RetentionPeriod
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.redshift.RedshiftClusterSnapshotCopy\"}", isOptional: true)]
        public virtual aws.Redshift.IRedshiftClusterSnapshotCopy? InternalValue
        {
            get => GetInstanceProperty<aws.Redshift.IRedshiftClusterSnapshotCopy?>();
            set => SetInstanceProperty(value);
        }
    }
}
