using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMove : MonoBehaviour
{
    //Переменная для скорости движения
    public static float speed;

    // Start is called before the first frame update
    void Start()
    {
        speed = 0.13f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        //Высчитываем новую позицию объекта
        transform.position = new Vector3(transform.position.x - speed, transform.position.y, 0);

       
    }
}
