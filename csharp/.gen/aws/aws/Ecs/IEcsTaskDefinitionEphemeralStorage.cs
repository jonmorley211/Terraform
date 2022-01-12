using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ecs
{
    [JsiiInterface(nativeType: typeof(IEcsTaskDefinitionEphemeralStorage), fullyQualifiedName: "aws.ecs.EcsTaskDefinitionEphemeralStorage")]
    public interface IEcsTaskDefinitionEphemeralStorage
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_task_definition#size_in_gib EcsTaskDefinition#size_in_gib}.</summary>
        [JsiiProperty(name: "sizeInGib", typeJson: "{\"primitive\":\"number\"}")]
        double SizeInGib
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IEcsTaskDefinitionEphemeralStorage), fullyQualifiedName: "aws.ecs.EcsTaskDefinitionEphemeralStorage")]
        internal sealed class _Proxy : DeputyBase, aws.Ecs.IEcsTaskDefinitionEphemeralStorage
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_task_definition#size_in_gib EcsTaskDefinition#size_in_gib}.</summary>
            [JsiiProperty(name: "sizeInGib", typeJson: "{\"primitive\":\"number\"}")]
            public double SizeInGib
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
