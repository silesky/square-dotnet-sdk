using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Square;
using Square.Utilities;

namespace Square.Models
{
    public class Transaction 
    {
        public Transaction(string id = null,
            string locationId = null,
            string createdAt = null,
            IList<Models.Tender> tenders = null,
            IList<Models.Refund> refunds = null,
            string referenceId = null,
            string product = null,
            string clientId = null,
            Models.Address shippingAddress = null,
            string orderId = null)
        {
            Id = id;
            LocationId = locationId;
            CreatedAt = createdAt;
            Tenders = tenders;
            Refunds = refunds;
            ReferenceId = referenceId;
            Product = product;
            ClientId = clientId;
            ShippingAddress = shippingAddress;
            OrderId = orderId;
        }

        /// <summary>
        /// The transaction's unique ID, issued by Square payments servers.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; }

        /// <summary>
        /// The ID of the transaction's associated location.
        /// </summary>
        [JsonProperty("location_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LocationId { get; }

        /// <summary>
        /// The timestamp for when the transaction was created, in RFC 3339 format.
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt { get; }

        /// <summary>
        /// The tenders used to pay in the transaction.
        /// </summary>
        [JsonProperty("tenders", NullValueHandling = NullValueHandling.Ignore)]
        public IList<Models.Tender> Tenders { get; }

        /// <summary>
        /// Refunds that have been applied to any tender in the transaction.
        /// </summary>
        [JsonProperty("refunds", NullValueHandling = NullValueHandling.Ignore)]
        public IList<Models.Refund> Refunds { get; }

        /// <summary>
        /// If the transaction was created with the [Charge](#endpoint-charge)
        /// endpoint, this value is the same as the value provided for the `reference_id`
        /// parameter in the request to that endpoint. Otherwise, it is not set.
        /// </summary>
        [JsonProperty("reference_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ReferenceId { get; }

        /// <summary>
        /// Indicates the Square product used to process a transaction.
        /// </summary>
        [JsonProperty("product", NullValueHandling = NullValueHandling.Ignore)]
        public string Product { get; }

        /// <summary>
        /// If the transaction was created in the Square Point of Sale app, this value
        /// is the ID generated for the transaction by Square Point of Sale.
        /// This ID has no relationship to the transaction's canonical `id`, which is
        /// generated by Square's backend servers. This value is generated for bookkeeping
        /// purposes, in case the transaction cannot immediately be completed (for example,
        /// if the transaction is processed in offline mode).
        /// It is not currently possible with the Connect API to perform a transaction
        /// lookup by this value.
        /// </summary>
        [JsonProperty("client_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ClientId { get; }

        /// <summary>
        /// Represents a physical address.
        /// </summary>
        [JsonProperty("shipping_address", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Address ShippingAddress { get; }

        /// <summary>
        /// The order_id is an identifier for the order associated with this transaction, if any.
        /// </summary>
        [JsonProperty("order_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OrderId { get; }

        public Builder ToBuilder()
        {
            var builder = new Builder()
                .Id(Id)
                .LocationId(LocationId)
                .CreatedAt(CreatedAt)
                .Tenders(Tenders)
                .Refunds(Refunds)
                .ReferenceId(ReferenceId)
                .Product(Product)
                .ClientId(ClientId)
                .ShippingAddress(ShippingAddress)
                .OrderId(OrderId);
            return builder;
        }

        public class Builder
        {
            private string id;
            private string locationId;
            private string createdAt;
            private IList<Models.Tender> tenders;
            private IList<Models.Refund> refunds;
            private string referenceId;
            private string product;
            private string clientId;
            private Models.Address shippingAddress;
            private string orderId;



            public Builder Id(string id)
            {
                this.id = id;
                return this;
            }

            public Builder LocationId(string locationId)
            {
                this.locationId = locationId;
                return this;
            }

            public Builder CreatedAt(string createdAt)
            {
                this.createdAt = createdAt;
                return this;
            }

            public Builder Tenders(IList<Models.Tender> tenders)
            {
                this.tenders = tenders;
                return this;
            }

            public Builder Refunds(IList<Models.Refund> refunds)
            {
                this.refunds = refunds;
                return this;
            }

            public Builder ReferenceId(string referenceId)
            {
                this.referenceId = referenceId;
                return this;
            }

            public Builder Product(string product)
            {
                this.product = product;
                return this;
            }

            public Builder ClientId(string clientId)
            {
                this.clientId = clientId;
                return this;
            }

            public Builder ShippingAddress(Models.Address shippingAddress)
            {
                this.shippingAddress = shippingAddress;
                return this;
            }

            public Builder OrderId(string orderId)
            {
                this.orderId = orderId;
                return this;
            }

            public Transaction Build()
            {
                return new Transaction(id,
                    locationId,
                    createdAt,
                    tenders,
                    refunds,
                    referenceId,
                    product,
                    clientId,
                    shippingAddress,
                    orderId);
            }
        }
    }
}