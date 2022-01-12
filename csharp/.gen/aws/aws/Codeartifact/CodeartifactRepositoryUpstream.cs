using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Codeartifact
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.codeartifact.CodeartifactRepositoryUpstream")]
    public class CodeartifactRepositoryUpstream : aws.Codeartifact.ICodeartifactRepositoryUpstream
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codeartifact_repository#repository_name CodeartifactRepository#repository_name}.</summary>
        [JsiiProperty(name: "repositoryName", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string RepositoryName
        {
            get;
            set;
        }
    }
}
