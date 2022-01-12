using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Codebuild
{
    [JsiiClass(nativeType: typeof(aws.Codebuild.CodebuildProjectSourceBuildStatusConfigOutputReference), fullyQualifiedName: "aws.codebuild.CodebuildProjectSourceBuildStatusConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class CodebuildProjectSourceBuildStatusConfigOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public CodebuildProjectSourceBuildStatusConfigOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CodebuildProjectSourceBuildStatusConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CodebuildProjectSourceBuildStatusConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetContext")]
        public virtual void ResetContext()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTargetUrl")]
        public virtual void ResetTargetUrl()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "contextInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ContextInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "targetUrlInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TargetUrlInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "context", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Context
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "targetUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TargetUrl
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.codebuild.CodebuildProjectSourceBuildStatusConfig\"}", isOptional: true)]
        public virtual aws.Codebuild.ICodebuildProjectSourceBuildStatusConfig? InternalValue
        {
            get => GetInstanceProperty<aws.Codebuild.ICodebuildProjectSourceBuildStatusConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
