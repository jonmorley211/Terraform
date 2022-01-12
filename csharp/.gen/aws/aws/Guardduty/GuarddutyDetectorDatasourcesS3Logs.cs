using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Guardduty
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.guardduty.GuarddutyDetectorDatasourcesS3Logs")]
    public class GuarddutyDetectorDatasourcesS3Logs : aws.Guardduty.IGuarddutyDetectorDatasourcesS3Logs
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/guardduty_detector#enable GuarddutyDetector#enable}.</summary>
        [JsiiProperty(name: "enable", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOverride: true)]
        public object Enable
        {
            get;
            set;
        }
    }
}
