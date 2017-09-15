using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shoot : MonoBehaviour
{
    public GameObject bombPrefab;
    public Transform spawn;
    public Transform[] targets;

    public int[] x, y;
    public float speed = 10f;

    private int i;
    private Rigidbody2D rigid;

    //public Text hintT;
    //public GameObject Hint;
    public ShowHints showH;
    //private string[] continent = new string[6];
    private string[] countryEU = new string[50];
    private string[] countryAF = new string[54];
    private string[] countryAsia = new string[49];
    private string[] countryAU = new string[13];
    private string[] countryNA = new string[23];
    private string[] countrySA = new string[12];
    private string[] hint = new string[10];
    //public string hintText;

    private bool showingHint;

    private float scrW, scrH;
    //private int c, h;

    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
        showH = GameObject.Find("Hint").GetComponent<ShowHints>();
        //Hint = GameObject.FindWithTag("Hint").GetComponent<GameObject>(); 
        //hintT = Hint.GetComponent<Text>(); 
    }

    void Start()
    {
        /*continent = new string[6] { countryEU[50], countryAF[54], countryAsia[49], countryAU[13], countryNA[23], countrySA[12] };

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
        {"Destroy ", "Cry, ", "Goodbye, ", "My Bomb choose ", "Feel my baby, ",
            "Disappear, ", "Target: ", "Taste my ball, ", "Enjoy Fireworks, ", "BOOM! "
        };
        */
        scrW = Screen.width / 16;
        scrH = Screen.height / 9;
    }
    

    void SpawnObject()
    {

        //i = Random.Range(0, 6);
        GameObject shoot = Instantiate(bombPrefab, new Vector3(0, 3.5f), spawn.rotation);
        //bombPrefab = Instantiate(bomb, spawn.position, Quaternion.Euler(Vector3(x, y, z)));
        //target = new Vector3(x[i], y[i], 0);
        rigid = shoot.GetComponent<Rigidbody2D>();
        rigid.gravityScale = 0;

    }

    void Update()
    {
        if (showingHint == false)
        {
            showH.ShowHint();
            showingHint = true;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpawnObject();
        }
        if (Input.GetKeyDown(KeyCode.RightShift))
        {
            //rigid.gravityScale = 2;

            Vector3 direction = targets[showH.c].position - transform.position;
            direction.Normalize();

            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);

            if (rigid != null)
            {
                rigid.AddForce((Vector3)direction * speed, ForceMode2D.Impulse);
            }
        }
    }
}