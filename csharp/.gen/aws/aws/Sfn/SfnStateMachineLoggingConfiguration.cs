using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Sfn
{
    [JsiiByValue(fqn: "aws.sfn.SfnStateMachineLoggingConfiguration")]
    public class SfnStateMachineLoggingConfiguration : aws.Sfn.ISfnStateMachineLoggingConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sfn_state_machine#include_execution_data SfnStateMachine#include_execution_data}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "includeExecutionData", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true, isOverride: true)]
        public object? IncludeExecutionData
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sfn_state_machine#level SfnStateMachine#level}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "level", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Level
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sfn_state_machine#log_destination SfnStateMachine#log_destination}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "logDestination", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? LogDestination
        {
            get;
            set;
        }
    }
}
