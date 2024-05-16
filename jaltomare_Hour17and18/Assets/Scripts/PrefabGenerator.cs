using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabGenerator : MonoBehaviour
{
    public GameObject prefab;
    public Vector3 spawnRange;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = -15; i <= 15; i+=3)
        {
            Vector3 spawnPosition = new Vector3(i, 4.0f, 0f);
            Instantiate<GameObject>(prefab, spawnPosition, Quaternion.identity);
        }

    }

    // Update is called once per frame
    void Update()
    {
        // Whenever we hot the B key we will generate a prefab at the
        // position of the original prefab
        // whenever we hit the space key, we will generate a prefab at the
        // position of the spawn object that this script is attached to

        if(Input.GetKeyDown(KeyCode.B))
        {
            Instantiate(prefab);
        }
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(prefab, transform.position, transform.rotation);
        }
    }
}
