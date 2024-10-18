using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoAleatorio : MonoBehaviour
{
    public Rigidbody2D rb;

    public float x = 0;
    public float y = 0;
    float z = 0;
    public int speed = 2;

    void Start()
    {
        x = Random.Range(-1.0f, 1.0f);
        y = Random.Range(-1.0f, 1.0f);
        z = Random.Range(-360, 360);

        Vector3 rot = new Vector3(0, 0, z);
        transform.eulerAngles = transform.eulerAngles + rot;
    }
    void Update()
    {
        Vector3 dir = new Vector3(x, y) * speed * Time.deltaTime;
        transform.position = transform.position + dir;
    }
}
