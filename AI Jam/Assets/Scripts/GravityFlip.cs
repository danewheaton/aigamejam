using UnityEngine;
using System.Collections;

public class GravityFlip : MonoBehaviour {

    bool upsideDown;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if(Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(upsideDown ? Flip() : FlipRightSideUp());
            upsideDown = !upsideDown;
        }
    }

    IEnumerator Flip()
    {
        Physics.gravity = new Vector3(0, 9.81f, 0);

        while (transform.eulerAngles.z < 180)
        {
            transform.eulerAngles += new Vector3(0, 0, 10);
            yield return new WaitForEndOfFrame();
        }

        transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, 180);
    }

    IEnumerator FlipRightSideUp()
    {
        Physics.gravity = new Vector3(0, -9.81f, 0);

        while (transform.eulerAngles.z > 10)
        {
            transform.eulerAngles += new Vector3(0, 0, -10);
            yield return new WaitForEndOfFrame();
        }

        transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, 0);
    }

}
