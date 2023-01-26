using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.AlbHttpRouter
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "yandex.albHttpRouter.AlbHttpRouterRouteOptionsRbac")]
    public class AlbHttpRouterRouteOptionsRbac : yandex.AlbHttpRouter.IAlbHttpRouterRouteOptionsRbac
    {
        private object _principals;

        /// <summary>principals block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_http_router#principals AlbHttpRouter#principals}
        /// </remarks>
        [JsiiProperty(name: "principals", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"yandex.albHttpRouter.AlbHttpRouterRouteOptionsRbacPrincipals\"},\"kind\":\"array\"}}]}}")]
        public object Principals
        {
            get => _principals;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case yandex.AlbHttpRouter.IAlbHttpRouterRouteOptionsRbacPrincipals[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(yandex.AlbHttpRouter.IAlbHttpRouterRouteOptionsRbacPrincipals).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(yandex.AlbHttpRouter.IAlbHttpRouterRouteOptionsRbacPrincipals).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _principals = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_http_router#action AlbHttpRouter#action}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Action
        {
            get;
            set;
        }
    }
}
