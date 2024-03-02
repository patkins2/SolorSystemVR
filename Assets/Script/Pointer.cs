using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Pointer : MonoBehaviour
{
    public float DefaultLength = 5.0f;
    public GameObject Dot;
    public VRInput Input;
    private LineRenderer LineRenderer = null;


    private void Awake()
    {
        LineRenderer = GetComponent<LineRenderer>();
    }

    private void Update()
    {
        UpdateLine();
    }

    private void UpdateLine()
    {
        //use default
        PointerEventData data = Input.GetData();
        float targetLength = data.pointerCurrentRaycast.distance == 0 ? DefaultLength : data.pointerCurrentRaycast.distance;

        // raycast
        RaycastHit hit = CreateRaycast(targetLength);

        //default
        Vector3 endPostion = transform.position + (transform.forward * targetLength);

        //or based on hit
        if (hit.collider != null)
            endPostion = hit.point;
        //set pose of dot
        Dot.transform.position = endPostion;

        //set pose of line
        LineRenderer.SetPosition(0, transform.position);
        LineRenderer.SetPosition(1, endPostion);
    }

    private RaycastHit CreateRaycast(float length)
    {
        RaycastHit hit;
        Ray ray = new Ray(transform.position, transform.forward);
        Physics.Raycast(ray, out hit, DefaultLength);

        return hit;
    }

}
