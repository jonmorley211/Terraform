using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Datasources
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.datasources.ElbListener")]
    public class ElbListener : aws.Datasources.IElbListener
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elb#instance_port Elb#instance_port}.</summary>
        [JsiiProperty(name: "instancePort", typeJson: "{\"primitive\":\"number\"}", isOverride: true)]
        public double InstancePort
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elb#instance_protocol Elb#instance_protocol}.</summary>
        [JsiiProperty(name: "instanceProtocol", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string InstanceProtocol
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elb#lb_port Elb#lb_port}.</summary>
        [JsiiProperty(name: "lbPort", typeJson: "{\"primitive\":\"number\"}", isOverride: true)]
        public double LbPort
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elb#lb_protocol Elb#lb_protocol}.</summary>
        [JsiiProperty(name: "lbProtocol", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string LbProtocol
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elb#ssl_certificate_id Elb#ssl_certificate_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sslCertificateId", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? SslCertificateId
        {
            get;
            set;
        }
    }
}
