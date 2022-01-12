using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Sagemaker
{
    [JsiiInterface(nativeType: typeof(ISagemakerEndpointDeploymentConfigAutoRollbackConfigurationAlarms), fullyQualifiedName: "aws.sagemaker.SagemakerEndpointDeploymentConfigAutoRollbackConfigurationAlarms")]
    public interface ISagemakerEndpointDeploymentConfigAutoRollbackConfigurationAlarms
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_endpoint#alarm_name SagemakerEndpoint#alarm_name}.</summary>
        [JsiiProperty(name: "alarmName", typeJson: "{\"primitive\":\"string\"}")]
        string AlarmName
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerEndpointDeploymentConfigAutoRollbackConfigurationAlarms), fullyQualifiedName: "aws.sagemaker.SagemakerEndpointDeploymentConfigAutoRollbackConfigurationAlarms")]
        internal sealed class _Proxy : DeputyBase, aws.Sagemaker.ISagemakerEndpointDeploymentConfigAutoRollbackConfigurationAlarms
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_endpoint#alarm_name SagemakerEndpoint#alarm_name}.</summary>
            [JsiiProperty(name: "alarmName", typeJson: "{\"primitive\":\"string\"}")]
            public string AlarmName
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
