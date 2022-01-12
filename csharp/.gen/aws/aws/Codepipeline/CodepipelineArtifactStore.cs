using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Codepipeline
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.codepipeline.CodepipelineArtifactStore")]
    public class CodepipelineArtifactStore : aws.Codepipeline.ICodepipelineArtifactStore
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codepipeline#location Codepipeline#location}.</summary>
        [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Location
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codepipeline#type Codepipeline#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Type
        {
            get;
            set;
        }

        /// <summary>encryption_key block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codepipeline#encryption_key Codepipeline#encryption_key}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "encryptionKey", typeJson: "{\"fqn\":\"aws.codepipeline.CodepipelineArtifactStoreEncryptionKey\"}", isOptional: true, isOverride: true)]
        public aws.Codepipeline.ICodepipelineArtifactStoreEncryptionKey? EncryptionKey
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codepipeline#region Codepipeline#region}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Region
        {
            get;
            set;
        }
    }
}
