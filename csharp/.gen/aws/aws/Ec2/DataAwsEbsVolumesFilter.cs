using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.ec2.DataAwsEbsVolumesFilter")]
    public class DataAwsEbsVolumesFilter : aws.Ec2.IDataAwsEbsVolumesFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/ebs_volumes#name DataAwsEbsVolumes#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/ebs_volumes#values DataAwsEbsVolumes#values}.</summary>
        [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOverride: true)]
        public string[] Values
        {
            get;
            set;
        }
    }
}
