using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Square;
using Square.Utilities;
using Square.Http.Request;
using Square.Http.Response;
using Square.Http.Client;

namespace Square.Apis
{
    public interface ISubscriptionsApi
    {
        /// <summary>
        /// Creates a subscription for a customer to a subscription plan.
        /// If you provide a card on file in the request, Square charges the card for 
        /// the subscription. Otherwise, Square bills an invoice to the customer's email 
        /// address. The subscription starts immediately, unless the request includes 
        /// the optional `start_date`. Each individual subscription is associated with a particular location. 
        /// For more information, 
        /// see [Subscription API Overview](https://developer.squareup.com/docs/docs/subscriptions-api/overview).
        /// </summary>
        /// <param name="body">Required parameter: An object containing the fields to POST for the request.  See the corresponding object definition for field details.</param>
        /// <return>Returns the Models.CreateSubscriptionResponse response from the API call</return>
        Models.CreateSubscriptionResponse CreateSubscription(Models.CreateSubscriptionRequest body);

        /// <summary>
        /// Creates a subscription for a customer to a subscription plan.
        /// If you provide a card on file in the request, Square charges the card for 
        /// the subscription. Otherwise, Square bills an invoice to the customer's email 
        /// address. The subscription starts immediately, unless the request includes 
        /// the optional `start_date`. Each individual subscription is associated with a particular location. 
        /// For more information, 
        /// see [Subscription API Overview](https://developer.squareup.com/docs/docs/subscriptions-api/overview).
        /// </summary>
        /// <param name="body">Required parameter: An object containing the fields to POST for the request.  See the corresponding object definition for field details.</param>
        /// <return>Returns the Models.CreateSubscriptionResponse response from the API call</return>
        Task<Models.CreateSubscriptionResponse> CreateSubscriptionAsync(Models.CreateSubscriptionRequest body, CancellationToken cancellationToken = default);

        /// <summary>
        /// Searches for subscriptions. 
        /// Results are ordered chronologically by subscription creation date. If
        /// the request specifies more than one location ID, 
        /// the endpoint orders the result 
        /// by location ID, and then by creation date within each location. If no locations are given
        /// in the query, all locations are searched.
        /// You can also optionally specify `customer_ids` to search by customer. 
        /// If left unset, all customers 
        /// associated with the specified locations are returned. 
        /// If the request specifies customer IDs, the endpoint orders results 
        /// first by location, within location by customer ID, and within 
        /// customer by subscription creation date.
        /// For more information, see 
        /// [Retrieve subscriptions](https://developer.squareup.com/docs/docs/subscriptions-api/overview#retrieve-subscriptions).
        /// </summary>
        /// <param name="body">Required parameter: An object containing the fields to POST for the request.  See the corresponding object definition for field details.</param>
        /// <return>Returns the Models.SearchSubscriptionsResponse response from the API call</return>
        Models.SearchSubscriptionsResponse SearchSubscriptions(Models.SearchSubscriptionsRequest body);

        /// <summary>
        /// Searches for subscriptions. 
        /// Results are ordered chronologically by subscription creation date. If
        /// the request specifies more than one location ID, 
        /// the endpoint orders the result 
        /// by location ID, and then by creation date within each location. If no locations are given
        /// in the query, all locations are searched.
        /// You can also optionally specify `customer_ids` to search by customer. 
        /// If left unset, all customers 
        /// associated with the specified locations are returned. 
        /// If the request specifies customer IDs, the endpoint orders results 
        /// first by location, within location by customer ID, and within 
        /// customer by subscription creation date.
        /// For more information, see 
        /// [Retrieve subscriptions](https://developer.squareup.com/docs/docs/subscriptions-api/overview#retrieve-subscriptions).
        /// </summary>
        /// <param name="body">Required parameter: An object containing the fields to POST for the request.  See the corresponding object definition for field details.</param>
        /// <return>Returns the Models.SearchSubscriptionsResponse response from the API call</return>
        Task<Models.SearchSubscriptionsResponse> SearchSubscriptionsAsync(Models.SearchSubscriptionsRequest body, CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieves a subscription.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The ID of the subscription to retrieve.</param>
        /// <return>Returns the Models.RetrieveSubscriptionResponse response from the API call</return>
        Models.RetrieveSubscriptionResponse RetrieveSubscription(string subscriptionId);

        /// <summary>
        /// Retrieves a subscription.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The ID of the subscription to retrieve.</param>
        /// <return>Returns the Models.RetrieveSubscriptionResponse response from the API call</return>
        Task<Models.RetrieveSubscriptionResponse> RetrieveSubscriptionAsync(string subscriptionId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates a subscription. You can set, modify, and clear the 
        /// `subscription` field values. For more information and examples, see 
        /// [Update subscriptions](https://developer.squareup.com/docs/docs/subscriptions-api/overview#update-subscriptions).
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The ID for the subscription to update.</param>
        /// <param name="body">Required parameter: An object containing the fields to POST for the request.  See the corresponding object definition for field details.</param>
        /// <return>Returns the Models.UpdateSubscriptionResponse response from the API call</return>
        Models.UpdateSubscriptionResponse UpdateSubscription(string subscriptionId, Models.UpdateSubscriptionRequest body);

        /// <summary>
        /// Updates a subscription. You can set, modify, and clear the 
        /// `subscription` field values. For more information and examples, see 
        /// [Update subscriptions](https://developer.squareup.com/docs/docs/subscriptions-api/overview#update-subscriptions).
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The ID for the subscription to update.</param>
        /// <param name="body">Required parameter: An object containing the fields to POST for the request.  See the corresponding object definition for field details.</param>
        /// <return>Returns the Models.UpdateSubscriptionResponse response from the API call</return>
        Task<Models.UpdateSubscriptionResponse> UpdateSubscriptionAsync(string subscriptionId, Models.UpdateSubscriptionRequest body, CancellationToken cancellationToken = default);

        /// <summary>
        /// Cancels a subscription immediately and sets the subscription
        /// `status` to `CANCELED`. You can also use the `UpdateSubscription`
        /// endpoint to cancel a subscription at a future date. For more
        /// information, see
        /// [CancelSubscriptions](https://developer.squareup.com/docs/docs/subscriptions-api/overview#cancel-subscriptions).
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The ID of the subscription to cancel.</param>
        /// <return>Returns the Models.CancelSubscriptionResponse response from the API call</return>
        Models.CancelSubscriptionResponse CancelSubscription(string subscriptionId);

        /// <summary>
        /// Cancels a subscription immediately and sets the subscription
        /// `status` to `CANCELED`. You can also use the `UpdateSubscription`
        /// endpoint to cancel a subscription at a future date. For more
        /// information, see
        /// [CancelSubscriptions](https://developer.squareup.com/docs/docs/subscriptions-api/overview#cancel-subscriptions).
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The ID of the subscription to cancel.</param>
        /// <return>Returns the Models.CancelSubscriptionResponse response from the API call</return>
        Task<Models.CancelSubscriptionResponse> CancelSubscriptionAsync(string subscriptionId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Lists all events for a specific subscription.
        /// In the current implementation, only `START_SUBSCRIPTION` and `STOP_SUBSCRIPTION` (when the subscription was canceled) events are returned.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The ID of the subscription to retrieve the events for.</param>
        /// <param name="cursor">Optional parameter: A pagination cursor returned by a previous call to this endpoint. Provide this to retrieve the next set of results for the original query.  For more information, see [Pagination](https://developer.squareup.com/docs/docs/working-with-apis/pagination).</param>
        /// <param name="limit">Optional parameter: The upper limit on the number of subscription events to return  in the response.   Default: `200`</param>
        /// <return>Returns the Models.ListSubscriptionEventsResponse response from the API call</return>
        Models.ListSubscriptionEventsResponse ListSubscriptionEvents(string subscriptionId, string cursor = null, int? limit = null);

        /// <summary>
        /// Lists all events for a specific subscription.
        /// In the current implementation, only `START_SUBSCRIPTION` and `STOP_SUBSCRIPTION` (when the subscription was canceled) events are returned.
        /// </summary>
        /// <param name="subscriptionId">Required parameter: The ID of the subscription to retrieve the events for.</param>
        /// <param name="cursor">Optional parameter: A pagination cursor returned by a previous call to this endpoint. Provide this to retrieve the next set of results for the original query.  For more information, see [Pagination](https://developer.squareup.com/docs/docs/working-with-apis/pagination).</param>
        /// <param name="limit">Optional parameter: The upper limit on the number of subscription events to return  in the response.   Default: `200`</param>
        /// <return>Returns the Models.ListSubscriptionEventsResponse response from the API call</return>
        Task<Models.ListSubscriptionEventsResponse> ListSubscriptionEventsAsync(string subscriptionId, string cursor = null, int? limit = null, CancellationToken cancellationToken = default);

    }
}