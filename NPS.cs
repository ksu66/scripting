using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPS : MonoBehaviour
{
    //Start is called before the first frame update
    int level = 1;
    int health = 5;
    float speed = 1.5f;
    Vector3 new_pos;
    void Start()
    {
        health += level;
        print("Heath" + health);
    }

    // Update is called once per frame
    void Update()
    {
        new_pos = transform.position;
        new_pos.x += speed * Time.deltaTime;
        gameObject.transform.position = new_pos;

    }
}
