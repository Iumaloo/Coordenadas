using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quat : MonoBehaviour
{
    void Update()
    {
        Quaternion quaternion = Quaternion.Euler(0, 0, 5 * Time.deltaTime);
        transform.rotation = transform.rotation * quaternion;
    }
}
