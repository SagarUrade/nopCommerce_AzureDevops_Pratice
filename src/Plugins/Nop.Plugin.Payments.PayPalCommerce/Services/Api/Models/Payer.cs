﻿using Newtonsoft.Json;

namespace Nop.Plugin.Payments.PayPalCommerce.Services.Api.Models;

/// <summary>
/// Represents the customer who approves and pays for the order
/// </summary>
public class Payer
{
    #region Properties

    /// <summary>
    /// Gets or sets the unique ID for a customer generated by PayPal.
    /// </summary>
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// Gets or sets the email address of the payer.
    /// </summary>
    [JsonProperty(PropertyName = "email_address")]
    public string EmailAddress { get; set; }

    /// <summary>
    /// Gets or sets the PayPal-assigned ID for the payer.
    /// </summary>
    [JsonProperty(PropertyName = "payer_id")]
    public string PayerId { get; set; }

    /// <summary>
    /// Gets or sets the name of the party.
    /// </summary>
    [JsonProperty(PropertyName = "name")]
    public Name Name { get; set; }

    /// <summary>
    /// Gets or sets the phone number of the customer. Available only when you enable the Contact Telephone Number option in the [Profile & Settings](https://www.paypal.com/cgi-bin/customerprofileweb?cmd=_profile-website-payments) for the merchant's PayPal account.
    /// </summary>
    [JsonProperty(PropertyName = "phone")]
    public Phone Phone { get; set; }

    /// <summary>
    /// Gets or sets the birth date of the payer in YYYY-MM-DD format.
    /// </summary>
    [JsonProperty(PropertyName = "birth_date")]
    public string BirthDate { get; set; }

    /// <summary>
    /// Gets or sets the tax information of the payer. Required only for Brazilian payer's.
    /// </summary>
    [JsonProperty(PropertyName = "tax_info")]
    public PayerTax TaxInfo { get; set; }

    /// <summary>
    /// Gets or sets the address of the payer. Also referred to as the billing address of the customer.
    /// </summary>
    [JsonProperty(PropertyName = "address")]
    public Address Address { get; set; }

    /// <summary>
    /// Gets or sets the merchant-generated customer id.
    /// </summary>
    [JsonProperty(PropertyName = "merchant_customer_id")]
    public string MerchantCustomerId { get; set; }

    #endregion
}