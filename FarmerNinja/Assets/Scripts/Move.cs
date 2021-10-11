using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed = 3.0f;
    void Update()
    {
        Vector3 dir = new Vector3(
            Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
        dir = Vector3.ClampMagnitude(dir, 1.0f);
        transform.Translate(dir * speed * Time.deltaTime);
    }
}
