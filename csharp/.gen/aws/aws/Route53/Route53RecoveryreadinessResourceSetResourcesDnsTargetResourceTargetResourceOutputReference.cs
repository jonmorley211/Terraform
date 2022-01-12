using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Route53
{
    [JsiiClass(nativeType: typeof(aws.Route53.Route53RecoveryreadinessResourceSetResourcesDnsTargetResourceTargetResourceOutputReference), fullyQualifiedName: "aws.route53.Route53RecoveryreadinessResourceSetResourcesDnsTargetResourceTargetResourceOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class Route53RecoveryreadinessResourceSetResourcesDnsTargetResourceTargetResourceOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public Route53RecoveryreadinessResourceSetResourcesDnsTargetResourceTargetResourceOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Route53RecoveryreadinessResourceSetResourcesDnsTargetResourceTargetResourceOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Route53RecoveryreadinessResourceSetResourcesDnsTargetResourceTargetResourceOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putNlbResource", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.route53.Route53RecoveryreadinessResourceSetResourcesDnsTargetResourceTargetResourceNlbResource\"}}]")]
        public virtual void PutNlbResource(aws.Route53.IRoute53RecoveryreadinessResourceSetResourcesDnsTargetResourceTargetResourceNlbResource @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Route53.IRoute53RecoveryreadinessResourceSetResourcesDnsTargetResourceTargetResourceNlbResource)}, new object[]{@value});
        }

        [JsiiMethod(name: "putR53Resource", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.route53.Route53RecoveryreadinessResourceSetResourcesDnsTargetResourceTargetResourceR53Resource\"}}]")]
        public virtual void PutR53Resource(aws.Route53.IRoute53RecoveryreadinessResourceSetResourcesDnsTargetResourceTargetResourceR53Resource @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Route53.IRoute53RecoveryreadinessResourceSetResourcesDnsTargetResourceTargetResourceR53Resource)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetNlbResource")]
        public virtual void ResetNlbResource()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetR53Resource")]
        public virtual void ResetR53Resource()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "nlbResource", typeJson: "{\"fqn\":\"aws.route53.Route53RecoveryreadinessResourceSetResourcesDnsTargetResourceTargetResourceNlbResourceOutputReference\"}")]
        public virtual aws.Route53.Route53RecoveryreadinessResourceSetResourcesDnsTargetResourceTargetResourceNlbResourceOutputReference NlbResource
        {
            get => GetInstanceProperty<aws.Route53.Route53RecoveryreadinessResourceSetResourcesDnsTargetResourceTargetResourceNlbResourceOutputReference>()!;
        }

        [JsiiProperty(name: "r53Resource", typeJson: "{\"fqn\":\"aws.route53.Route53RecoveryreadinessResourceSetResourcesDnsTargetResourceTargetResourceR53ResourceOutputReference\"}")]
        public virtual aws.Route53.Route53RecoveryreadinessResourceSetResourcesDnsTargetResourceTargetResourceR53ResourceOutputReference R53Resource
        {
            get => GetInstanceProperty<aws.Route53.Route53RecoveryreadinessResourceSetResourcesDnsTargetResourceTargetResourceR53ResourceOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "nlbResourceInput", typeJson: "{\"fqn\":\"aws.route53.Route53RecoveryreadinessResourceSetResourcesDnsTargetResourceTargetResourceNlbResource\"}", isOptional: true)]
        public virtual aws.Route53.IRoute53RecoveryreadinessResourceSetResourcesDnsTargetResourceTargetResourceNlbResource? NlbResourceInput
        {
            get => GetInstanceProperty<aws.Route53.IRoute53RecoveryreadinessResourceSetResourcesDnsTargetResourceTargetResourceNlbResource?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "r53ResourceInput", typeJson: "{\"fqn\":\"aws.route53.Route53RecoveryreadinessResourceSetResourcesDnsTargetResourceTargetResourceR53Resource\"}", isOptional: true)]
        public virtual aws.Route53.IRoute53RecoveryreadinessResourceSetResourcesDnsTargetResourceTargetResourceR53Resource? R53ResourceInput
        {
            get => GetInstanceProperty<aws.Route53.IRoute53RecoveryreadinessResourceSetResourcesDnsTargetResourceTargetResourceR53Resource?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.route53.Route53RecoveryreadinessResourceSetResourcesDnsTargetResourceTargetResource\"}", isOptional: true)]
        public virtual aws.Route53.IRoute53RecoveryreadinessResourceSetResourcesDnsTargetResourceTargetResource? InternalValue
        {
            get => GetInstanceProperty<aws.Route53.IRoute53RecoveryreadinessResourceSetResourcesDnsTargetResourceTargetResource?>();
            set => SetInstanceProperty(value);
        }
    }
}
