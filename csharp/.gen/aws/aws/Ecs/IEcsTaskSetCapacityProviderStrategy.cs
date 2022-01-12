using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ecs
{
    [JsiiInterface(nativeType: typeof(IEcsTaskSetCapacityProviderStrategy), fullyQualifiedName: "aws.ecs.EcsTaskSetCapacityProviderStrategy")]
    public interface IEcsTaskSetCapacityProviderStrategy
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_task_set#capacity_provider EcsTaskSet#capacity_provider}.</summary>
        [JsiiProperty(name: "capacityProvider", typeJson: "{\"primitive\":\"string\"}")]
        string CapacityProvider
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_task_set#weight EcsTaskSet#weight}.</summary>
        [JsiiProperty(name: "weight", typeJson: "{\"primitive\":\"number\"}")]
        double Weight
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_task_set#base EcsTaskSet#base}.</summary>
        [JsiiProperty(name: "base", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Base
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEcsTaskSetCapacityProviderStrategy), fullyQualifiedName: "aws.ecs.EcsTaskSetCapacityProviderStrategy")]
        internal sealed class _Proxy : DeputyBase, aws.Ecs.IEcsTaskSetCapacityProviderStrategy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_task_set#capacity_provider EcsTaskSet#capacity_provider}.</summary>
            [JsiiProperty(name: "capacityProvider", typeJson: "{\"primitive\":\"string\"}")]
            public string CapacityProvider
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_task_set#weight EcsTaskSet#weight}.</summary>
            [JsiiProperty(name: "weight", typeJson: "{\"primitive\":\"number\"}")]
            public double Weight
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecs_task_set#base EcsTaskSet#base}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "base", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Base
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
