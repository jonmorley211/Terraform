using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Elb
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.elb.AlbListenerDefaultAction")]
    public class AlbListenerDefaultAction : aws.Elb.IAlbListenerDefaultAction
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_listener#type AlbListener#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Type
        {
            get;
            set;
        }

        /// <summary>authenticate_cognito block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_listener#authenticate_cognito AlbListener#authenticate_cognito}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "authenticateCognito", typeJson: "{\"fqn\":\"aws.elb.AlbListenerDefaultActionAuthenticateCognito\"}", isOptional: true, isOverride: true)]
        public aws.Elb.IAlbListenerDefaultActionAuthenticateCognito? AuthenticateCognito
        {
            get;
            set;
        }

        /// <summary>authenticate_oidc block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_listener#authenticate_oidc AlbListener#authenticate_oidc}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "authenticateOidc", typeJson: "{\"fqn\":\"aws.elb.AlbListenerDefaultActionAuthenticateOidc\"}", isOptional: true, isOverride: true)]
        public aws.Elb.IAlbListenerDefaultActionAuthenticateOidc? AuthenticateOidc
        {
            get;
            set;
        }

        /// <summary>fixed_response block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_listener#fixed_response AlbListener#fixed_response}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "fixedResponse", typeJson: "{\"fqn\":\"aws.elb.AlbListenerDefaultActionFixedResponse\"}", isOptional: true, isOverride: true)]
        public aws.Elb.IAlbListenerDefaultActionFixedResponse? FixedResponse
        {
            get;
            set;
        }

        /// <summary>forward block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_listener#forward AlbListener#forward}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "forward", typeJson: "{\"fqn\":\"aws.elb.AlbListenerDefaultActionForward\"}", isOptional: true, isOverride: true)]
        public aws.Elb.IAlbListenerDefaultActionForward? Forward
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_listener#order AlbListener#order}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "order", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? Order
        {
            get;
            set;
        }

        /// <summary>redirect block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_listener#redirect AlbListener#redirect}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "redirect", typeJson: "{\"fqn\":\"aws.elb.AlbListenerDefaultActionRedirect\"}", isOptional: true, isOverride: true)]
        public aws.Elb.IAlbListenerDefaultActionRedirect? Redirect
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_listener#target_group_arn AlbListener#target_group_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "targetGroupArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? TargetGroupArn
        {
            get;
            set;
        }
    }
}
