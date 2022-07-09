using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Control controller;
    // Start is called before the first frame update
    void Start()
    {
        controller = new Control();
        controller.Keys.Enable();
        controller.Keys.A.performed += context => functionA();
        controller.Keys.D.performed += context => functionD();
    }

    void functionA()
    {
        print("A Pressed");
    }

    void functionD()
    {
        print("D Pressed");
    }



}
