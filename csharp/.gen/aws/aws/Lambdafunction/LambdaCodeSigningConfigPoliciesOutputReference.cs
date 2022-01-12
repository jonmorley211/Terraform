using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Lambdafunction
{
    [JsiiClass(nativeType: typeof(aws.Lambdafunction.LambdaCodeSigningConfigPoliciesOutputReference), fullyQualifiedName: "aws.lambdafunction.LambdaCodeSigningConfigPoliciesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class LambdaCodeSigningConfigPoliciesOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public LambdaCodeSigningConfigPoliciesOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LambdaCodeSigningConfigPoliciesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LambdaCodeSigningConfigPoliciesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiOptional]
        [JsiiProperty(name: "untrustedArtifactOnDeploymentInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? UntrustedArtifactOnDeploymentInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "untrustedArtifactOnDeployment", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UntrustedArtifactOnDeployment
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.lambdafunction.LambdaCodeSigningConfigPolicies\"}", isOptional: true)]
        public virtual aws.Lambdafunction.ILambdaCodeSigningConfigPolicies? InternalValue
        {
            get => GetInstanceProperty<aws.Lambdafunction.ILambdaCodeSigningConfigPolicies?>();
            set => SetInstanceProperty(value);
        }
    }
}
