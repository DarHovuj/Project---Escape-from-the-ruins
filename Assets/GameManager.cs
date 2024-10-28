using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject objects;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("CreateObjects", 1, 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CreateObjects()
    {
        Instantiate(objects, new Vector3(15f,0,0), Quaternion.identity);
    }
}
