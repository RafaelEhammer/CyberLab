using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetPosition : MonoBehaviour
{
    public Transform target;

    public float distance = -10f;

    public float height = 0f;

    public float damping = 5.0f;

    public float mapX = 100.0f;
    public float mapY = 100.0f;

    private float minX = 0f;
    private float maxX = 0f;
    private float minY = 0f;
    private float maxY = 0f;

    // Start is called before the first frame update
    void Start()
    {
        minX = transform.position.x;
        minY = transform.position.y;

        maxX = mapX;
        maxY = mapY;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 wantedposition = target.TransformPoint(0, height, distance);

        wantedposition.x = (wantedposition.x < minX) ? minX : wantedposition.x;
        wantedposition.x = (wantedposition.x > maxX) ? maxX : wantedposition.x;

        wantedposition.y = (wantedposition.y < minY) ? minY : wantedposition.y;
        wantedposition.y = (wantedposition.y > maxY) ? maxY : wantedposition.y;

        transform.position = Vector3.Lerp (transform.position, wantedposition, (Time.deltaTime * damping));
    }
}
