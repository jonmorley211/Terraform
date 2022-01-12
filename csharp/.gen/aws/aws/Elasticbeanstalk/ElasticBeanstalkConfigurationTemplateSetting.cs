using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Elasticbeanstalk
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.elasticbeanstalk.ElasticBeanstalkConfigurationTemplateSetting")]
    public class ElasticBeanstalkConfigurationTemplateSetting : aws.Elasticbeanstalk.IElasticBeanstalkConfigurationTemplateSetting
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elastic_beanstalk_configuration_template#name ElasticBeanstalkConfigurationTemplate#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elastic_beanstalk_configuration_template#namespace ElasticBeanstalkConfigurationTemplate#namespace}.</summary>
        [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Namespace
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elastic_beanstalk_configuration_template#value ElasticBeanstalkConfigurationTemplate#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Value
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elastic_beanstalk_configuration_template#resource ElasticBeanstalkConfigurationTemplate#resource}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "resource", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Resource
        {
            get;
            set;
        }
    }
}
