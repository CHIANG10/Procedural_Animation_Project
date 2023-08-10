using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IK_Foot_Solver : MonoBehaviour
{
    [SerializeField] Vector3 movementVector = new Vector3(10f, 10f, 10f);
    [SerializeField] float period = 2f;
    // todo remove this later[Range(0, 1)] [SerializeField]
    float movementFactor; // 0 for not moved 1 for fully moved


    Vector3 startPos;
    // Use this for initialization
    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float cycles = Time.time / period;

        const float tau = Mathf.PI * 2;
        float RawSinWave = Mathf.Sin(cycles * tau);

        movementFactor = (RawSinWave + 1f) / 2f;

        Vector3 offset = movementVector * movementFactor;
        transform.position = startPos + offset;
    }

}