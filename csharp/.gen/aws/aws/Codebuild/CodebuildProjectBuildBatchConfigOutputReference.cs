using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Codebuild
{
    [JsiiClass(nativeType: typeof(aws.Codebuild.CodebuildProjectBuildBatchConfigOutputReference), fullyQualifiedName: "aws.codebuild.CodebuildProjectBuildBatchConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class CodebuildProjectBuildBatchConfigOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public CodebuildProjectBuildBatchConfigOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CodebuildProjectBuildBatchConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CodebuildProjectBuildBatchConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putRestrictions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.codebuild.CodebuildProjectBuildBatchConfigRestrictions\"}}]")]
        public virtual void PutRestrictions(aws.Codebuild.ICodebuildProjectBuildBatchConfigRestrictions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Codebuild.ICodebuildProjectBuildBatchConfigRestrictions)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCombineArtifacts")]
        public virtual void ResetCombineArtifacts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRestrictions")]
        public virtual void ResetRestrictions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeoutInMins")]
        public virtual void ResetTimeoutInMins()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "restrictions", typeJson: "{\"fqn\":\"aws.codebuild.CodebuildProjectBuildBatchConfigRestrictionsOutputReference\"}")]
        public virtual aws.Codebuild.CodebuildProjectBuildBatchConfigRestrictionsOutputReference Restrictions
        {
            get => GetInstanceProperty<aws.Codebuild.CodebuildProjectBuildBatchConfigRestrictionsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "combineArtifactsInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? CombineArtifactsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "restrictionsInput", typeJson: "{\"fqn\":\"aws.codebuild.CodebuildProjectBuildBatchConfigRestrictions\"}", isOptional: true)]
        public virtual aws.Codebuild.ICodebuildProjectBuildBatchConfigRestrictions? RestrictionsInput
        {
            get => GetInstanceProperty<aws.Codebuild.ICodebuildProjectBuildBatchConfigRestrictions?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "serviceRoleInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ServiceRoleInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutInMinsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? TimeoutInMinsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "combineArtifacts", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object CombineArtifacts
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "serviceRole", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceRole
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "timeoutInMins", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TimeoutInMins
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.codebuild.CodebuildProjectBuildBatchConfig\"}", isOptional: true)]
        public virtual aws.Codebuild.ICodebuildProjectBuildBatchConfig? InternalValue
        {
            get => GetInstanceProperty<aws.Codebuild.ICodebuildProjectBuildBatchConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
