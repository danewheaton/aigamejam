using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public enum LensStates { R, G, B}

public class ChangeLens : MonoBehaviour {

    LensStates cLens = LensStates.R;
    [SerializeField]
    Collider
        cube1, pill;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            switch (cLens)
            {
                case LensStates.R:
                    Camera.main.cullingMask = ((1 << LayerMask.NameToLayer("layer1")) |
                        (1 << LayerMask.NameToLayer("Default")));
                    cLens = LensStates.G;
                    pill.enabled = true;
                    cube1.enabled = false;
                    break;
                case LensStates.G:
                    Camera.main.cullingMask = ((1 << LayerMask.NameToLayer("layer2")) |
                        (1 << LayerMask.NameToLayer("Default")));
                    cLens = LensStates.B;
                    pill.enabled = false;
                    cube1.enabled = true;
                    break;
                case LensStates.B:
                    Camera.main.cullingMask = (1 << LayerMask.NameToLayer("Default"));
                    cLens = LensStates.R;
                    pill.enabled = false;
                    cube1.enabled = false;
                    break;
            }


            //if(Camera.main.cullingMask == LayerMask.NameToLayer("Default"))
            //{
            //    Camera.main.cullingMask = ((1 << LayerMask.NameToLayer("layer1")) |
            //    (1 << LayerMask.NameToLayer("Default")));
            //}

            //if (Camera.main.cullingMask == LayerMask.NameToLayer("layer1"))
            //{
            //    Camera.main.cullingMask = ((1 << LayerMask.NameToLayer("layer2")) |
            //    (1 << LayerMask.NameToLayer("Default")));
            //}

            //if (Camera.main.cullingMask == LayerMask.NameToLayer("layer2"))
            //{
            //    Camera.main.cullingMask = (1 << LayerMask.NameToLayer("Default"));
            //}


            //Camera.main.cullingMask = ((1 << LayerMask.NameToLayer("layer1"))|
            //    (1 << LayerMask.NameToLayer("layer2")) |
            //    (1 << LayerMask.NameToLayer("Default")));
        }
    }
}
