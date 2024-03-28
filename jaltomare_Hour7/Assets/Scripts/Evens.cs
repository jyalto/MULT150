using System.Collections;
using UnityEngine;

public class Evens : MonoBehaviour
{
    void Start()
    {
        
        for(int count = 22; count <= 100; count += 2)
        {
            Debug.Log(count);
        }
    }
}
