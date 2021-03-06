﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class P_DeterioratingLevel : MonoBehaviour
{
    [SerializeField] float visionCone = 90;
    List<GameObject> objectsToDisappear = new List<GameObject>();
    bool objectsCanDisappear;

    private void Start()
    {
        foreach (GameObject g in GameObject.FindGameObjectsWithTag("Disappearing Object"))
            objectsToDisappear.Add(g);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) objectsCanDisappear = !objectsCanDisappear;

        if (objectsCanDisappear)
        {
            foreach (GameObject g in objectsToDisappear)
            {
                Vector3 targetDirection = transform.position - g.transform.position;
                if (Vector3.Angle(transform.forward, targetDirection) < visionCone)
                {
                    g.SetActive(false);
                }
            }
        }
        
    }
}
