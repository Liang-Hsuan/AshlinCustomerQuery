﻿using System;

namespace AshlinCustomerEnquiry.supportingClasses.brightpearl
{
    /* 
    * A supporting class for BPsearch that store all necessary data 
    */
    [Serializable()]
    public class BPvalues
    {
        // fields for customer information
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Company { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }

        // field for order information
        public string[] SKU { get; set; }
        public string[] Description { get; set; }
        public int[] Quantity { get; set; }
        public bool Logo { get; set; }
        public bool Rush { get; set; }

        /* first constructor with no arguments */
        public BPvalues()
        {
            // customer field
            FirstName = "";
            LastName = "";
            Company = "";
            Phone = "";
            Email = "";
            Address1 = "";
            Address2 = "";
            City = "";
            Province = "";
            PostalCode = "";
            Country = "";

            // order field
            SKU = new string[0];
            Description = new string[0];
            Quantity = new int[0];
            Logo = true;
            Rush = false;
        }

        /* seconde constructor that accept all fields parameters */
        public BPvalues(string firstName, string lastName, string company, string phone, string email, string address1, string address2, string city, string province, string postalCode, string country,
                        string[] sku, string[] description,  int[] quantity, bool logo, bool rush)
        {
            // customer information
            FirstName = firstName;
            LastName = lastName;
            Company = company;
            Phone = phone;
            Email = email;
            Address1 = address1;
            Address2 = address2;
            City = city;
            Province = province;
            PostalCode = postalCode;
            Country = country;

            // order information
            SKU = sku;
            Description = description;
            Quantity = quantity;
            Logo = logo;
            Rush = rush;
        }
    }
}