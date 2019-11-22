using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteAlways]
public class SetEnemyPositions : MonoBehaviour
{

    [SerializeField]
    bool savePositions = false;

    private void Update()
    {
        if (savePositions)
        {
            SetPositions();
            savePositions = false;
        }
    }


    void SetPositions()
    {
        Target[] enemies = FindObjectsOfType<Target>();

        foreach (Target target in enemies)
        {
            target.startPos = target.transform.localPosition;
        }
    }
}
