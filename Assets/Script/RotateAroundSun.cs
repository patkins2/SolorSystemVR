using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAroundSun : MonoBehaviour
{
    Vector3 origin = new Vector3(0f, 0f, 0f);
    GameObject sun, merc, venus, earth, mars, jupiter, saturn, uranus, neptune, pluto;
    GameObject moon;
    GameObject camera;
    Vector3 offset;

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
        camera = GameObject.Find("[CameraRig]");
        offset = new Vector3(25.0f, 0.0f, 0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        sun.transform.RotateAround(origin, Vector3.down, 1f * Time.deltaTime);
        merc.transform.RotateAround(origin, Vector3.down, ((1f / 0.2f)*2) * Time.deltaTime);
        venus.transform.RotateAround(origin, Vector3.down, ((1f/0.6f)*2) * Time.deltaTime);
        earth.transform.RotateAround(origin, Vector3.down, 2f * Time.deltaTime);
        mars.transform.RotateAround(origin, Vector3.down, ((1f/1.9f)*2) * Time.deltaTime);
        jupiter.transform.RotateAround(origin, Vector3.down, ((1f / 11.9f)*2) * Time.deltaTime);
        saturn.transform.RotateAround(origin, Vector3.down, ((1f / 29.5f)*2) * Time.deltaTime);
        uranus.transform.RotateAround(origin, Vector3.down, ((1f / 84f)*2) * Time.deltaTime);
        neptune.transform.RotateAround(origin, Vector3.down, ((1f / 164.8f)*2) * Time.deltaTime);
        pluto.transform.RotateAround(origin, Vector3.down, ((1f / 248f)*2) * Time.deltaTime);
        moon.transform.RotateAround(earth.transform.position, Vector3.down, (1f / 0.13f) * Time.deltaTime);

        merc.transform.Rotate(0, 0.2f, 0, Space.Self);
        venus.transform.Rotate(0, -(0.6f), 0, Space.Self);
        earth.transform.Rotate(0, 1f, 0, Space.Self);
        mars.transform.Rotate(0, 1f/1.9f, 0, Space.Self);
        jupiter.transform.Rotate(0, 1f/11.9f, 0, Space.Self);
        saturn.transform.Rotate(0, 1f / 29.5f, 0, Space.Self);
        uranus.transform.Rotate(0, 1f / 84f, 0, Space.Self);
        neptune.transform.Rotate(0, 1f / 164.8f, 0, Space.Self);
        pluto.transform.Rotate(0, 1f / 248f, 0, Space.Self);
        moon.transform.Rotate(0, (0.13f), 0, Space.Self);
    }
}
