using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Msk
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.msk.MskconnectCustomPluginLocation")]
    public class MskconnectCustomPluginLocation : aws.Msk.IMskconnectCustomPluginLocation
    {
        /// <summary>s3 block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/mskconnect_custom_plugin#s3 MskconnectCustomPlugin#s3}
        /// </remarks>
        [JsiiProperty(name: "s3", typeJson: "{\"fqn\":\"aws.msk.MskconnectCustomPluginLocationS3\"}", isOverride: true)]
        public aws.Msk.IMskconnectCustomPluginLocationS3 S3
        {
            get;
            set;
        }
    }
}
