// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace DigiCertSharp
{
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for DigicertRetailAPI.
    /// </summary>
    public static partial class DigicertRetailAPIExtensions
    {
            /// <summary>
            /// Create a pending order for a new SSL Certificate
            /// <see href="https://www.digicert.com/clients/rest/docs/retail/order/ssl-certificate" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='request'>
            /// </param>
            public static OrderCertificateCreatedResponse OrderCertificate(this IDigicertRetailAPI operations, CertificateOrderRequest request)
            {
                return operations.OrderCertificateAsync(request).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create a pending order for a new SSL Certificate
            /// <see href="https://www.digicert.com/clients/rest/docs/retail/order/ssl-certificate" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='request'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<OrderCertificateCreatedResponse> OrderCertificateAsync(this IDigicertRetailAPI operations, CertificateOrderRequest request, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.OrderCertificateWithHttpMessagesAsync(request, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// View order status and other details
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='orderId'>
            /// </param>
            public static OrderDetail GetOrder(this IDigicertRetailAPI operations, string orderId)
            {
                return operations.GetOrderAsync(orderId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// View order status and other details
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='orderId'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<OrderDetail> GetOrderAsync(this IDigicertRetailAPI operations, string orderId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetOrderWithHttpMessagesAsync(orderId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates the certificate based on the provided information. Rekeying a
            /// certificate is accomplishjed by the key being the only change made.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='orderId'>
            /// </param>
            /// <param name='request'>
            /// </param>
            public static ReissueCertificateResponse ReissueCertificate(this IDigicertRetailAPI operations, string orderId, ReissueCertificateRequest request)
            {
                return operations.ReissueCertificateAsync(orderId, request).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates the certificate based on the provided information. Rekeying a
            /// certificate is accomplishjed by the key being the only change made.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='orderId'>
            /// </param>
            /// <param name='request'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ReissueCertificateResponse> ReissueCertificateAsync(this IDigicertRetailAPI operations, string orderId, ReissueCertificateRequest request, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ReissueCertificateWithHttpMessagesAsync(orderId, request, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Retrieve the certificate once the order has been processed and certificate
            /// issued
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='orderId'>
            /// </param>
            public static IssuedCertificate GetIssuedCertificate(this IDigicertRetailAPI operations, string orderId)
            {
                return operations.GetIssuedCertificateAsync(orderId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Retrieve the certificate once the order has been processed and certificate
            /// issued
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='orderId'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IssuedCertificate> GetIssuedCertificateAsync(this IDigicertRetailAPI operations, string orderId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetIssuedCertificateWithHttpMessagesAsync(orderId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
