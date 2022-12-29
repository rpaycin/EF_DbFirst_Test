using System;
using System.Collections.Generic;

namespace EF_DBFirst.Entities;

public partial class OutApplicationInformation
{
    public int Id { get; set; }

    public int OutRegionalApplicationId { get; set; }

    public string? Name { get; set; }

    public string? Surname { get; set; }

    public DateTime? Birthdate { get; set; }

    public string? Title { get; set; }

    public string? MobilePhoneNumber { get; set; }

    public string? PhoneNumber { get; set; }

    public string? EmailAddress { get; set; }

    public bool? ApprovedCommercialMessageConfirmation { get; set; }

    public bool? IsPayEmailNotification { get; set; }

    public bool? IsPaySmsNotification { get; set; }
}
