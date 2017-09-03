using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Countries : MonoBehaviour
{
    public string[] continent = new string[6];

    public string[] countryEU = new string[50];
    public string[] countryAF = new string[54];
    public string[] countryAsia = new string[49];
    public string[] countryAU = new string[13];
    public string[] countryNA = new string[23];
    public string[] countrySA = new string[12];

    public string[] hint = new string[10];

    // Use this for initialization
    void Start ()
    {
        continent = new string[6] { "Europe", "Africa", "Asia", "Australia&Oceania", "NorthAmerica", "SouthAmerica" };

        countryEU = new string[50]
        {"Albania", "Andorra", "Armenia", "Austria", "Azerbaijan",
        "Belarus", "Belgium", "Bosnia and Herzegovina", "Bulgaria", "Croatia",
        "Cyprus", "Czech Republic", "Denmark", "Estonia", "Finland",
        "France", "Georgia", "Germany", "Greece", "Hungary",
        "Iceland", "Ireland", "Italy", "Kazakhstan", "Vatican City",
        "Latvia", "Liechtenstein", "Lithuania", "Luxembourg", "Macedonia",
        "Malta", "Moldova", "Monaco", "Montenegro", "Netherlands",
        "Norway", "Poland", "Portugal", "Romania", "Russia",
        "San Marino", "Serbia", "Slovakia", "Slovenia", "Spain",
        "Sweden", "Switzerland", "Turkey", "Ukraine", "United Kingdom",
        };

        countryAF = new string[54]
        {"Algeria", "Angola", "Benin", "Botswana", "Burkina Faso",
        "Burundi", "Cabo Verde", "Cameroon", "Central African Republic", "Chad",
        "Comoros", "Democratic Republic of the Congo", "Republic of the Congo", "Cote d'Ivoire", "Djibouti",
        "Egypt", "Equatorial Guinea", "Eritrea", "Ethiopia", "Gabon",
        "Gambia", "Ghana", "Guinea", "Guinea-Bissau", "Kenya",
        "Lesotho", "Liberia", "Libya", "Madagascar", "Malawi",
        "Mali", "Mauritania", "Mauritius", "Morocco", "Mozambique",
        "Namibia", "Niger", "Nigeria", "Rwanda", "Sao Tome and Principe",
        "Senegal", "Seychelles", "Sierra Leone", "Somalia", "South Africa",
        "South Sudan", "Sudan", "Swaziland", "Tanzania", "Togo",
        "Tunisia", "Uganda", "Zambia", "Zimbabwe" };
        
        countryAsia = new string[49]
        {"Afghanistan", "Armenia", "Azerbaijan", "Bahrain", "Bangladesh",
        "Bhutan", "Brunei", "Cambodia", "China", "Cyprus",
        "Georgia", "India", "Indonesia", "Iran", "Iraq",
        "Israel", "Japan", "Jordan", "Kazakhstan", "Kuwait",
        "Kyrgyzstan", "Laos", "Lebanon", "Malaysia", "Maldives",
        "Mongolia", "Myanmar", "Nepal", "North Korea", "Oman",
        "Pakistan", "Palestine", "Philippines", "Qatar", "Russia",
        "Saudi Arabia", "Singapore", "South Korea", "Sri Lanka", "Syria",
        "Tajikistan", "Thailand", "Timor-Leste", "Turkey", "Turkmenistan",
        "United Arab Emirates", "Uzbekistan", "Vietnam", "Yemen" };

        countryAU = new string[13] 
        { "Australia", "Fiji", "Kiribati", "Marshall Islands", "Micronesia",
            "Nauru", "New Zealand", "Palau", "Papua New Guinea", "Samoa",
            "Solomon Islands", "Tonga", "Vanuatu" };

        countryNA = new string[23] 
        { "Antigua and Barbuda", "Bahamas", "Barbados", "Belize", "Canada",
            "Costa Rica", "Cuba", "Dominica", "Dominican Republic", "El Salvador",
            "Grenada", "Guatemala", "Haiti", "Honduras", "Jamaica",
            "Mexico", "Nicaragua", "Panama", "Saint Kitts and Nevis", "Saint Lucia",
            "Saint Vincent and the Grenadines", "Trinidad and Tobago", "United States of America" };

        countrySA = new string[12] 
        { "Argentina", "Bolivia", "Brazil", "Chile", "Colombia",
            "Ecuador", "Guyana", "Paraguay", "Peru", "Suriname",
            "Uruguay", "Venezuela" };

        hint = new string[10]
        {"Destroy ", "Cry, ", "Goodbye, ", "My bomb choose ", "Feel my baby, ",
            "Disappear, ", "Target: ", "( O )==>> ", "Fireworks, ", "BOOM! "
        };
    }
	
}