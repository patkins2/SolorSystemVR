using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    public GameObject cam;
    GameObject pos0, pos1, pos2;
    public float speed = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        pos0 = GameObject.Find("Position0");
        pos1 = GameObject.Find("Position1");
        pos2 = GameObject.Find("Position2");
    }

    // Update is called once per frame
    void Update()
    {
        //sends camera to one of three set destinations
        if (Input.GetKeyDown(KeyCode.Z))
        {
            MoveToPlanet.SetAllToFalse();
            cam.transform.position = pos0.transform.position;
            cam.transform.rotation = Quaternion.Euler(0, 180, 0);
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            MoveToPlanet.SetAllToFalse();
            cam.transform.position = pos1.transform.position;
            cam.transform.rotation = Quaternion.Euler(0, 90, 0);
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            MoveToPlanet.SetAllToFalse();
            cam.transform.position = pos2.transform.position;
            cam.transform.rotation = Quaternion.Euler(0, 0, 0);
        }

        //wasd movement and q & e to move up and down
        if (Input.GetKey(KeyCode.Q))
            cam.transform.position += Vector3.up * speed * Time.deltaTime;
        else if (Input.GetKey(KeyCode.E))
            cam.transform.position += Vector3.down * speed * Time.deltaTime;
        else if (Input.GetKey(KeyCode.A))
            cam.transform.position += Vector3.right * speed * Time.deltaTime;
        else if (Input.GetKey(KeyCode.D))
            cam.transform.position += Vector3.left * speed * Time.deltaTime;
        else if (Input.GetKey(KeyCode.W))
            cam.transform.position += Vector3.back * speed * Time.deltaTime;
        else if (Input.GetKey(KeyCode.S))
            cam.transform.position += Vector3.forward * speed * Time.deltaTime;
    }
}
