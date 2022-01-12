using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Codebuild
{
    [JsiiClass(nativeType: typeof(aws.Codebuild.CodebuildProjectBuildBatchConfigRestrictionsOutputReference), fullyQualifiedName: "aws.codebuild.CodebuildProjectBuildBatchConfigRestrictionsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class CodebuildProjectBuildBatchConfigRestrictionsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public CodebuildProjectBuildBatchConfigRestrictionsOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CodebuildProjectBuildBatchConfigRestrictionsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CodebuildProjectBuildBatchConfigRestrictionsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetComputeTypesAllowed")]
        public virtual void ResetComputeTypesAllowed()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaximumBuildsAllowed")]
        public virtual void ResetMaximumBuildsAllowed()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "computeTypesAllowedInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? ComputeTypesAllowedInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maximumBuildsAllowedInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaximumBuildsAllowedInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "computeTypesAllowed", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] ComputeTypesAllowed
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maximumBuildsAllowed", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaximumBuildsAllowed
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.codebuild.CodebuildProjectBuildBatchConfigRestrictions\"}", isOptional: true)]
        public virtual aws.Codebuild.ICodebuildProjectBuildBatchConfigRestrictions? InternalValue
        {
            get => GetInstanceProperty<aws.Codebuild.ICodebuildProjectBuildBatchConfigRestrictions?>();
            set => SetInstanceProperty(value);
        }
    }
}
