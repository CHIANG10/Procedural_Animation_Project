using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IK_Foot_Solver : MonoBehaviour
{

    private void Start()
    {

    }

    private void Update()
    {
        Transform myTransform = this.transform;

        Vector3 pos = myTransform.position;
        pos.x += 1f;
        pos.x -= 2f;

        myTransform.position = pos;
    }





}
