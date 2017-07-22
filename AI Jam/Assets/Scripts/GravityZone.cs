using UnityEngine;
using System.Collections;

public class GravityZone : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") Physics.gravity = new Vector3(0, 9.81f, 0);
    }
}
