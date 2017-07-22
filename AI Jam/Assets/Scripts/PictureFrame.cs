using UnityEngine;
using System.Collections;

public class PictureFrame : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") other.transform.position -= new Vector3(50, 0, 0);
    }
}
