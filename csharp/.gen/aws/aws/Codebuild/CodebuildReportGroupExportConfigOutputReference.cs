using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Codebuild
{
    [JsiiClass(nativeType: typeof(aws.Codebuild.CodebuildReportGroupExportConfigOutputReference), fullyQualifiedName: "aws.codebuild.CodebuildReportGroupExportConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class CodebuildReportGroupExportConfigOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public CodebuildReportGroupExportConfigOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CodebuildReportGroupExportConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CodebuildReportGroupExportConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putS3Destination", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.codebuild.CodebuildReportGroupExportConfigS3Destination\"}}]")]
        public virtual void PutS3Destination(aws.Codebuild.ICodebuildReportGroupExportConfigS3Destination @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Codebuild.ICodebuildReportGroupExportConfigS3Destination)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetS3Destination")]
        public virtual void ResetS3Destination()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "s3Destination", typeJson: "{\"fqn\":\"aws.codebuild.CodebuildReportGroupExportConfigS3DestinationOutputReference\"}")]
        public virtual aws.Codebuild.CodebuildReportGroupExportConfigS3DestinationOutputReference S3Destination
        {
            get => GetInstanceProperty<aws.Codebuild.CodebuildReportGroupExportConfigS3DestinationOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "s3DestinationInput", typeJson: "{\"fqn\":\"aws.codebuild.CodebuildReportGroupExportConfigS3Destination\"}", isOptional: true)]
        public virtual aws.Codebuild.ICodebuildReportGroupExportConfigS3Destination? S3DestinationInput
        {
            get => GetInstanceProperty<aws.Codebuild.ICodebuildReportGroupExportConfigS3Destination?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "typeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.codebuild.CodebuildReportGroupExportConfig\"}", isOptional: true)]
        public virtual aws.Codebuild.ICodebuildReportGroupExportConfig? InternalValue
        {
            get => GetInstanceProperty<aws.Codebuild.ICodebuildReportGroupExportConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
