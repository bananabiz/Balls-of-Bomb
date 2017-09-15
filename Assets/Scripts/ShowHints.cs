using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowHints : MonoBehaviour
{
    //public string[] continent = new string[6];

    public string[] countryEU = new string[50];
    public string[] countryAF = new string[54];
    public string[] countryAsia = new string[49];
    public string[] countryAU = new string[13];
    public string[] countryNA = new string[23];
    public string[] countrySA = new string[12];

    public string[] hint = new string[11];
    public string hintText;
    public Text hintT;
    public float scrW, scrH;
    public int c, h;
    //public float timer;

    // Use this for initialization
    public void Start ()
    {
        hintT = this.GetComponent<Text>();

        //continent = new string[6] { countryEU[50], countryAF[54], countryAsia[49], countryAU[13], countryNA[23], countrySA[12] };

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

        hint = new string[11]
        {"Destroy ", "Cry, ", "Goodbye, ", "My Baby choose ", "Feel my power, ",
            "Disappear, ", "Target: ", "Taste my ball, ", "Fireworks, ", "BOOM! ",
            "Beg for mercy, "
        };

        scrW = Screen.width / 16;
        scrH = Screen.height / 9;

        StartCoroutine("waitFiveSeconds"); 
    }

    IEnumerator waitFiveSeconds()
    {
        yield return new WaitForSeconds(5); 
    }

    public void ShowHint()
    {
        c = Random.Range(0, 6);
        h = Random.Range(0, 10);

        if (c == 0)
        {
            hintText = hint[Random.Range(0, 11)] + countryEU[Random.Range(0, 51)] + "!";
        }
        else if (c == 1)
        {
            hintText = hint[Random.Range(0, 11)] + countryAF[Random.Range(0, 55)] + "!";
        }
        else if (c == 2)
        {
            hintText = hint[Random.Range(0, 11)] + countryAsia[Random.Range(0, 50)] + "!";
        }
        else if (c == 3)
        {
            hintText = hint[Random.Range(0, 11)] + countryAU[Random.Range(0, 14)] + "!";
        }
        else if (c == 4)
        {
            hintText = hint[Random.Range(0, 11)] + countryNA[Random.Range(0, 24)] + "!";
        }
        else if (c == 5)
        {
            hintText = hint[Random.Range(0, 11)] + countrySA[Random.Range(0, 13)] + "!";
        }
        if (hintText != "")
        {
            hintT.text = hintText;
        }
        //waitFiveSeconds();
        StartCoroutine("waitFiveSeconds");
    }

}