// Copyright (C) Sportradar AG.See LICENSE for full license governing this code

using Sportradar.OddsFeed.SDK.Entities.Rest.Enums;

namespace Sportradar.OddsFeed.SDK.Entities
{
    /// <summary>
    /// Extended settlement information for an outcome(market selection) with each-way and dead-heat place factor support
    /// </summary>
    public interface IOutcomeSettlementV2 : IOutcomeSettlement
    {
        /// <summary>
        /// Gets whether the each-way outcome is settled as a win or a place
        /// </summary>
        EachWayResult? EachWayResult { get; }

        /// <summary>
        /// Gets the each-way place factor (fraction of win odds used to settle the place part) for the current <see cref="IOutcomeSettlementV2"/> instance
        /// </summary>
        double? EachWayPlaceFactor { get; }

        /// <summary>
        /// Gets the dead-heat factor for the place part of an each-way bet for the current <see cref="IOutcomeSettlementV2"/> instance
        /// </summary>
        double? DeadHeatFactorPlace { get; }
    }
}
