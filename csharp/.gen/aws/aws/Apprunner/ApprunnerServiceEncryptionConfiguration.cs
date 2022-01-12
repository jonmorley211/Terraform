using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Apprunner
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.apprunner.ApprunnerServiceEncryptionConfiguration")]
    public class ApprunnerServiceEncryptionConfiguration : aws.Apprunner.IApprunnerServiceEncryptionConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/apprunner_service#kms_key ApprunnerService#kms_key}.</summary>
        [JsiiProperty(name: "kmsKey", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string KmsKey
        {
            get;
            set;
        }
    }
}
