using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.AlbHttpRouter
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "yandex.albHttpRouter.AlbHttpRouterRouteOptionsRbacPrincipals")]
    public class AlbHttpRouterRouteOptionsRbacPrincipals : yandex.AlbHttpRouter.IAlbHttpRouterRouteOptionsRbacPrincipals
    {
        private object _andPrincipals;

        /// <summary>and_principals block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_http_router#and_principals AlbHttpRouter#and_principals}
        /// </remarks>
        [JsiiProperty(name: "andPrincipals", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"yandex.albHttpRouter.AlbHttpRouterRouteOptionsRbacPrincipalsAndPrincipals\"},\"kind\":\"array\"}}]}}")]
        public object AndPrincipals
        {
            get => _andPrincipals;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case yandex.AlbHttpRouter.IAlbHttpRouterRouteOptionsRbacPrincipalsAndPrincipals[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(yandex.AlbHttpRouter.IAlbHttpRouterRouteOptionsRbacPrincipalsAndPrincipals).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(yandex.AlbHttpRouter.IAlbHttpRouterRouteOptionsRbacPrincipalsAndPrincipals).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _andPrincipals = value;
            }
        }
    }
}
