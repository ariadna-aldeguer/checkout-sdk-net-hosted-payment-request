using System;
using System.Collections.Generic;

namespace Checkout.Disputes
{
    public sealed class DisputesQueryResponse : IEquatable<DisputesQueryResponse>
    {
        public int? Limit { get; set; }

        public int? Skip { get; set; }

        public string From { get; set; }

        public string To { get; set; }

        public string Id { get; set; }

        public string Statuses { get; set; }

        public string PaymentId { get; set; }

        public string PaymentReference { get; set; }

        public string PaymentArn { get; set; }

        public string ThisChannelOnly { get; set; }

        public int? TotalCount { get; set; }

        public IList<DisputeSummary> Data { get; set; }

        public bool Equals(DisputesQueryResponse other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return Limit == other.Limit && Skip == other.Skip && From == other.From && To == other.To &&
                   Id == other.Id && Statuses == other.Statuses && PaymentId == other.PaymentId &&
                   PaymentReference == other.PaymentReference && PaymentArn == other.PaymentArn &&
                   ThisChannelOnly == other.ThisChannelOnly && TotalCount == other.TotalCount &&
                   Equals(Data, other.Data);
        }

        public override bool Equals(object obj)
        {
            return ReferenceEquals(this, obj) || obj is DisputesQueryResponse other && Equals(other);
        }

        public override int GetHashCode()
        {
            var hashCode = new HashCode();
            hashCode.Add(Limit);
            hashCode.Add(Skip);
            hashCode.Add(From);
            hashCode.Add(To);
            hashCode.Add(Id);
            hashCode.Add(Statuses);
            hashCode.Add(PaymentId);
            hashCode.Add(PaymentReference);
            hashCode.Add(PaymentArn);
            hashCode.Add(ThisChannelOnly);
            hashCode.Add(TotalCount);
            hashCode.Add(Data);
            return hashCode.ToHashCode();
        }
    }
}