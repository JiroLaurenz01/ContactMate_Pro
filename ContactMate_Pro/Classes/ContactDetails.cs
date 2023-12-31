﻿using ContactMate_Pro.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ContactMate_Pro
{
    public class ContactDetails
    {
        // PROPERTIES FOR OVERVIEW INFORMATION : ESSENTIAL TO BE FILLED
        public string Nickname { get; set; }
        public string Relationship { get; set; }
        public string ContactNumbers { get; set; }
        public string GmailAddresses {  get; set; }

        // PROPERTIES FOR PERSONAL INFORMATION
        public string LastName { get; set; } 
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string ExtensionName { get; set; }
        public string Gender { get; set; }
        public string Age { get; set; }
        public string Birthday { get; set; }
        public string StreetNumber { get; set; }
        public string StreetName { get; set; }
        public string Barangay { get; set; }
        public string City { get; set; }
        public string Province { get; set; }

        // PROPERTIES FOR SOCIAL MEDIA INFORMATION
        private string _facebookLink;
        public string FacebookLink
        {
            get { return _facebookLink; }
            set
            {
                // Regular expression pattern for a valid Facebook profile link.
                string pattern = @"^https:\/\/www\.facebook\.com\/[a-zA-Z0-9\.\-]+\/?$";

                // Validation for Facebook link.
                Validate(pattern, ref _facebookLink, value, "Facebook link");
            }
        }

        private string _instagramLink;
        public string InstagramLink
        {
            get { return _instagramLink; }
            set
            {
                // Regular expression pattern for a valid Instagram profile link.
                string pattern = @"^https:\/\/www\.instagram\.com\/[a-zA-Z0-9_.]+\/?$";

                // Validation for Instagram link.
                Validate(pattern, ref _instagramLink, value, "Instagram link");
            }
        }

        private string _linkedInLink;
        public string LinkedInLink
        {
            get { return _linkedInLink; }
            set
            {
                // Regular expression pattern for a valid LinkedIn profile link.
                string pattern = @"^https:\/\/www\.linkedin\.com\/in\/[a-zA-Z0-9\-]+\/?$";

                // Validation for LinkedIn link.
                Validate(pattern, ref _linkedInLink, value, "LinkedIn link");
            }
        }

        private string _twitterLink;
        public string TwitterLink
        {
            get { return _twitterLink; }
            set
            {
                // Regular expression pattern for a valid Twitter profile link.
                string pattern = @"^https:\/\/twitter\.com\/[a-zA-Z0-9_]+\/?$";

                // Validation for Twitter link.
                Validate(pattern, ref _twitterLink, value, "Twitter link");
            }
        }

        private string _gitHubLink;
        public string GitHubLink
        {
            get { return _gitHubLink; }
            set
            {
                // Regular expression pattern for a valid GitHub profile link.
                string pattern = @"^https:\/\/github\.com\/[a-zA-Z0-9-]+\/?$";

                // Validation for GitHub link.
                Validate(pattern, ref _gitHubLink, value, "GitHub link");
            }
        }

        private string _threadsLink;
        public string ThreadsLink
        {
            get { return _threadsLink; }
            set
            {
                // Regular expression pattern for a valid Threads profile link.
                string pattern = @"^https:\/\/www\.threads\.net\/@([a-zA-Z0-9_]+)\/?$";

                // Validation for GitHub link.
                Validate(pattern, ref _threadsLink, value, "Threads link");
            }
        }

        // This method is defined to validate a given value against a regular expression pattern.
        // If the value matches the pattern, it's assigned to the specified privateHolder variable.
        // If the value doesn't match, an error message is displayed and the privateHolder variable is set to null.
        public void Validate(string pattern, ref string privateHolder, string value, string name)
        {
            Functionality functions = new Functionality();

            // Check if the provided value matches the specified regular expression pattern.
            if (Regex.IsMatch(value, pattern))
                privateHolder = value; // Assign the value to the privateHolder if it's valid.
            else
            {
                // Display an error message using string interpolation to include the invalid value and the expected type.
                functions.Alert($"Entered {name} is invalid .", AlertForm.Type.Error);
                privateHolder = null; // Set the privateHolder to null since the value is invalid.
            }
        }

        // PROPERTIES FOR EMPLOYMENT INFORMATION
        public string CompanyName { get; set; }
        public string JobTitle { get; set; }
        public string WorkContactNumber { get; set; } 
        public string WorkAddress {  get; set; }    
        public string WorkEmailAddress { get; set; }
    }
}
