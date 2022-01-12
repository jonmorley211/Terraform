using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Route53
{
    [JsiiClass(nativeType: typeof(aws.Route53.Route53RecoveryreadinessResourceSetResourcesDnsTargetResourceOutputReference), fullyQualifiedName: "aws.route53.Route53RecoveryreadinessResourceSetResourcesDnsTargetResourceOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class Route53RecoveryreadinessResourceSetResourcesDnsTargetResourceOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public Route53RecoveryreadinessResourceSetResourcesDnsTargetResourceOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Route53RecoveryreadinessResourceSetResourcesDnsTargetResourceOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Route53RecoveryreadinessResourceSetResourcesDnsTargetResourceOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putTargetResource", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.route53.Route53RecoveryreadinessResourceSetResourcesDnsTargetResourceTargetResource\"}}]")]
        public virtual void PutTargetResource(aws.Route53.IRoute53RecoveryreadinessResourceSetResourcesDnsTargetResourceTargetResource @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Route53.IRoute53RecoveryreadinessResourceSetResourcesDnsTargetResourceTargetResource)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetHostedZoneArn")]
        public virtual void ResetHostedZoneArn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRecordSetId")]
        public virtual void ResetRecordSetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRecordType")]
        public virtual void ResetRecordType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTargetResource")]
        public virtual void ResetTargetResource()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "targetResource", typeJson: "{\"fqn\":\"aws.route53.Route53RecoveryreadinessResourceSetResourcesDnsTargetResourceTargetResourceOutputReference\"}")]
        public virtual aws.Route53.Route53RecoveryreadinessResourceSetResourcesDnsTargetResourceTargetResourceOutputReference TargetResource
        {
            get => GetInstanceProperty<aws.Route53.Route53RecoveryreadinessResourceSetResourcesDnsTargetResourceTargetResourceOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "domainNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DomainNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "hostedZoneArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? HostedZoneArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "recordSetIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RecordSetIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "recordTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RecordTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "targetResourceInput", typeJson: "{\"fqn\":\"aws.route53.Route53RecoveryreadinessResourceSetResourcesDnsTargetResourceTargetResource\"}", isOptional: true)]
        public virtual aws.Route53.IRoute53RecoveryreadinessResourceSetResourcesDnsTargetResourceTargetResource? TargetResourceInput
        {
            get => GetInstanceProperty<aws.Route53.IRoute53RecoveryreadinessResourceSetResourcesDnsTargetResourceTargetResource?>();
        }

        [JsiiProperty(name: "domainName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DomainName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "hostedZoneArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HostedZoneArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "recordSetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RecordSetId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "recordType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RecordType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.route53.Route53RecoveryreadinessResourceSetResourcesDnsTargetResource\"}", isOptional: true)]
        public virtual aws.Route53.IRoute53RecoveryreadinessResourceSetResourcesDnsTargetResource? InternalValue
        {
            get => GetInstanceProperty<aws.Route53.IRoute53RecoveryreadinessResourceSetResourcesDnsTargetResource?>();
            set => SetInstanceProperty(value);
        }
    }
}
