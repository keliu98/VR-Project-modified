using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pendulum : MonoBehaviour
{
    public float speed = 1.5f;
    public float limit = 75f;
    public bool randomStart = false;
    private float random = 0;

    void Awake(){
        if (randomStart)
            random = Random.Range(0f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        float angle = limit * Mathf.Sin(Time.time + random * speed);
        transform.localRotation = Quaternion.Euler(0,0,angle);
    }
}
