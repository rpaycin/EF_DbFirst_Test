using System;
using System.Collections.Generic;

namespace EF_DBFirst.Entities;

public partial class OfferModel
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public bool? IsDepositMandatory { get; set; }

    public int CommitmentPeriod { get; set; }

    public int OfferTypeId { get; set; }

    public decimal? DiscountRate { get; set; }

    public decimal? FixedAmount { get; set; }

    public decimal? PtfYekdem { get; set; }

    public bool IsActive { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? UpdateDate { get; set; }

    public int? CreatedUserId { get; set; }

    public int? UpdatedUserId { get; set; }
}
