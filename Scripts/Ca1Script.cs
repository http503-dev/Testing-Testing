using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ca1Script : MonoBehaviour
{
    int x = 2;
    int y = 4;

    void IntCompare()
    {
        if (x != y)
        {
            if (x > y)
            {
                Debug.Log(x);
            }

            else
            {
                Debug.Log(y);
            }
        }

        else
        {
            Debug.Log("Both integers are equal");
        }
    }

    void LoopNumbers()
    {
        string numbers = "";
        for (int i = 0; i <= 10; i++) 
        {
            numbers += i + " ";
        }
        Debug.Log(numbers); 
    }

    void LoopHelloWorld()
    {
        int count = 0;
        while (count < 10) 
        {
            Debug.Log("Hello World");
            count++;
        }
    }

    void OnCompare()
    {
        IntCompare();
    }

    void OnLoop()
    {
        LoopNumbers(); 
    }

    void OnPrint()
    {
        LoopHelloWorld();
    }

    // Start is called before the first frame update
    void Start()
    {
        OnCompare();
        OnLoop();
        OnPrint();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
