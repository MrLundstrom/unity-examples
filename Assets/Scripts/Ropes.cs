using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ropes : MonoBehaviour
{
    public LineRenderer right;
    public LineRenderer left;
    public Transform handleR;
    public Transform handleL;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        right.SetPositions(new Vector3[] { right.transform.position, handleR.transform.position });
        left.SetPositions(new Vector3[] { left.transform.position, handleL.transform.position });
    }
}
