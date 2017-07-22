using UnityEngine;
using System.Collections;

public class GravityZone : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Physics.gravity = new Vector3(0, 9.81f, 0);
            StartCoroutine(Flip());
        }
    }

    IEnumerator Flip()
    {
        Transform player = GameObject.FindGameObjectWithTag("Player").transform;
        while (player.eulerAngles.z < 180)
        {
            player.eulerAngles += new Vector3(0, 0, 10);
            yield return new WaitForEndOfFrame();
        }

        player.eulerAngles = new Vector3(player.eulerAngles.x, player.eulerAngles.y, 180);
    }
}
