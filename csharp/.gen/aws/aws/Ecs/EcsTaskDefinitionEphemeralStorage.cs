using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ecs
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.ecs.EcsTaskDefinitionEphemeralStorage")]
    public class EcsTaskDefinitionEphemeralStorage : aws.Ecs.IEcsTaskDefinitionEphemeralStorage
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_task_definition#size_in_gib EcsTaskDefinition#size_in_gib}.</summary>
        [JsiiProperty(name: "sizeInGib", typeJson: "{\"primitive\":\"number\"}", isOverride: true)]
        public double SizeInGib
        {
            get;
            set;
        }
    }
}
