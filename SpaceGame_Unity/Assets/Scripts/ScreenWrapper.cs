using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenWrapper : MonoBehaviour
{

    void Update()
    {
        Vector3 viewportPos = Camera.main.WorldToViewportPoint(gameObject.transform.position);
        bool wrapped = false;

        for (int i = 0; i < 2; ++i)
        {
            if (viewportPos[i] > 1 || viewportPos[i] < 0)
            {
                viewportPos[i] = viewportPos[i] - Mathf.Floor(viewportPos[i]);
                wrapped = true;
            } 
        }

        if (wrapped)
        {
            Vector3 newPos = Camera.main.ViewportToWorldPoint(viewportPos);
            transform.position = newPos;
        }

    }
}
