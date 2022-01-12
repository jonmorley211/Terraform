using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Codeartifact
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.codeartifact.CodeartifactRepositoryExternalConnections")]
    public class CodeartifactRepositoryExternalConnections : aws.Codeartifact.ICodeartifactRepositoryExternalConnections
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codeartifact_repository#external_connection_name CodeartifactRepository#external_connection_name}.</summary>
        [JsiiProperty(name: "externalConnectionName", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string ExternalConnectionName
        {
            get;
            set;
        }
    }
}
