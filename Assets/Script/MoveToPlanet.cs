using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MoveToPlanet : MonoBehaviour
{
    Vector3 origin = new Vector3(0f, 0f, 0f);
    GameObject sun, merc, venus, earth, mars, jupiter, saturn, uranus, neptune, pluto;
    GameObject moon;
    GameObject cam;
    public static GameObject Panel;
    public TextMeshPro PlanetText;
    public TextMeshProUGUI PlanetDesc;
    
    public static bool toMerc, toVenus, toEarth, toMars, toJupiter, toSaturn, toUranus, toNeptune, toPluto;
    // Start is called before the first frame update
    void Start()
    {
        sun = GameObject.Find("Planet_Sun");
        merc = GameObject.Find("Planet_Mercury");
        venus = GameObject.Find("Planet_Venus");
        earth = GameObject.Find("Planet_Earth");
        mars = GameObject.Find("Planet_Mars");
        jupiter = GameObject.Find("Planet_Jupiter");
        saturn = GameObject.Find("Planet_Saturn");
        uranus = GameObject.Find("Planet_Uranus");
        neptune = GameObject.Find("Planet_Neptune");
        pluto = GameObject.Find("Planet_Pluto");
        moon = GameObject.Find("Planet_Moon");

        cam = GameObject.Find("[CameraRig]");
        Panel = GameObject.FindGameObjectWithTag("Panel");

        toMerc = false;
        toVenus = false;
        toEarth = false;
        toMars = false;
        toJupiter = false;
        toSaturn = false;
        toUranus = false;
        toNeptune = false;
        toPluto = false;
        Panel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (toEarth)
        {
            cam.transform.position = earth.transform.position + new Vector3(-250.0f, 50.0f, 0.0f);
            PlanetText.text = "Earth";
            PlanetText.color = new Color32(4, 89, 0, 255);
            PlanetDesc.text = "Atmosphere: N & O" + "\nAvg Temp: 93 F" + "\nOrbital Period: 365 Days"
                   + "\nOrbital Speed: 29.78 km/s";
            Panel.SetActive(true);
        }
        if (toMerc)
        {
            cam.transform.position = merc.transform.position + new Vector3(-250.0f, 50.0f, 0.0f);
            PlanetText.text = "Mercury";
            PlanetText.color = new Color32(255, 255, 255, 255);
            PlanetDesc.text = "Atmosphere: O & S" + "\nAvg Temp: 800 F" + "\nOrbital Period: 88 Days"
                   + "\nOrbital Speed: 47.36 km/s";
            Panel.SetActive(true);
        }
        if (toVenus)
        {
            cam.transform.position = venus.transform.position + new Vector3(-250.0f, 50.0f, 0.0f);
            PlanetText.text = "Venus";
            PlanetText.color = new Color32(226, 122, 12, 255);
            PlanetDesc.text = "Atmosphere: CO2" + "\nAvg Temp: 867 F" + "\nOrbital Period: 224 Days"
                   + "\nOrbital Speed: 35.02 km/s";
            Panel.SetActive(true);
        }
        if (toMars)
        {
            cam.transform.position = mars.transform.position + new Vector3(-250.0f, 50.0f, 0.0f);
            PlanetText.text = "Mars";
            PlanetText.color = new Color32(250, 6, 6, 255);
            PlanetDesc.text = "Atmosphere: CO2 & Ar" + "\nAvg Temp: -81 F" + "\nOrbital Period: 687 Days"
                   + "\nOrbital Speed: 24 km/s";
            Panel.SetActive(true);
        }
        if (toJupiter)
        {
            cam.transform.position = jupiter.transform.position + new Vector3(-1000.0f, 50.0f, 0.0f);
            PlanetText.text = "Jupiter";
            PlanetText.color = new Color32(155, 52, 14, 255);
            PlanetDesc.text = "Atmosphere: H & He" + "\nAvg Temp: -162 F" + "\nOrbital Period: 11.86 Years"
                   + "\nOrbital Speed: 13 km/s";
            Panel.SetActive(true);
        }
        if (toSaturn)
        {
            cam.transform.position = saturn.transform.position + new Vector3(-1000.0f, 50.0f, 0.0f);
            PlanetText.text = "Saturn";
            PlanetText.color = new Color32(243, 205, 6, 255);
            PlanetDesc.text = "Atmosphere: H & He" + "\nAvg Temp: -308 F" + "\nOrbital Period: 29.5 Years"
                   + "\nOrbital Speed: 9.7 km/s";
            Panel.SetActive(true);
        }
        if (toUranus)
        {
            cam.transform.position = uranus.transform.position + new Vector3(-500.0f, 50.0f, 0.0f);
            PlanetText.text = "Uranus";
            PlanetText.color = new Color32(30, 207, 253, 255);
            PlanetDesc.text = "Atmosphere: H & He" + "\nAvg Temp: -322 F" + "\nOrbital Period: 84 Years"
                   + "\nOrbital Speed: 6.8 km/s";
            Panel.SetActive(true);
        }
        if (toNeptune)
        {
            cam.transform.position = neptune.transform.position + new Vector3(-300.0f, 50.0f, 0.0f);
            PlanetText.text = "Neptune";
            PlanetText.color = new Color32(75, 0, 236, 255);
            PlanetDesc.text = "Atmosphere: H & He" + "\nAvg Temp: -330 F" + "\nOrbital Period: 164 Years"
                   + "\nOrbital Speed: 5.43 km/s";
            Panel.SetActive(true);
        }
        if (toPluto)
        {
            cam.transform.position = pluto.transform.position + new Vector3(-250.0f, 50.0f, 0.0f);
            PlanetText.text = "Pluto";
            PlanetText.color = new Color32(255, 0, 131, 255);
            PlanetDesc.text = "Atmosphere: N & CH4" + "\nAvg Temp: -380 F" + "\nOrbital Period: 248 Years"
                   + "\nOrbital Speed: 4.74 km/s";
            Panel.SetActive(true);
        }
    }

    public void Mercury()
    {
        toMerc = true;
        toVenus = false;
        toEarth = false;
        toMars = false;
        toJupiter = false;
        toSaturn = false;
        toUranus = false;
        toNeptune = false;
        toPluto = false;
    }
    public void Venus()
    {
        toMerc = false;
        toVenus = true;
        toEarth = false;
        toMars = false;
        toJupiter = false;
        toSaturn = false;
        toUranus = false;
        toNeptune = false;
        toPluto = false;
    }
    public void Earth()
    {
        toMerc = false;
        toVenus = false;
        toEarth = true;
        toMars = false;
        toJupiter = false;
        toSaturn = false;
        toUranus = false;
        toNeptune = false;
        toPluto = false;
    }
    public void Mars()
    {
        toMerc = false;
        toVenus = false;
        toEarth = false;
        toMars = true;
        toJupiter = false;
        toSaturn = false;
        toUranus = false;
        toNeptune = false;
        toPluto = false;
    }
    public void Jupiter()
    {
        toMerc = false;
        toVenus = false;
        toEarth = false;
        toMars = false;
        toJupiter = true;
        toSaturn = false;
        toUranus = false;
        toNeptune = false;
        toPluto = false;
    }
    public void Saturn()
    {
        toMerc = false;
        toVenus = false;
        toEarth = false;
        toMars = false;
        toJupiter = false;
        toSaturn = true;
        toUranus = false;
        toNeptune = false;
        toPluto = false;
    }
    public void Uranus()
    {
        toMerc = false;
        toVenus = false;
        toEarth = false;
        toMars = false;
        toJupiter = false;
        toSaturn = false;
        toUranus = true;
        toNeptune = false;
        toPluto = false;
    }
    public void Neptune()
    {
        toMerc = false;
        toVenus = false;
        toEarth = false;
        toMars = false;
        toJupiter = false;
        toSaturn = false;
        toUranus = false;
        toNeptune = true;
        toPluto = false;
    }
    public void Pluto()
    {
        toMerc = false;
        toVenus = false;
        toEarth = false;
        toMars = false;
        toJupiter = false;
        toSaturn = false;
        toUranus = false;
        toNeptune = false;
        toPluto = true;
    }
    public static void SetAllToFalse()
    {
        toMerc = false;
        toVenus = false;
        toEarth = false;
        toMars = false;
        toJupiter = false;
        toSaturn = false;
        toUranus = false;
        toNeptune = false;
        toPluto = false;
        Panel.SetActive(false);
    }
}
