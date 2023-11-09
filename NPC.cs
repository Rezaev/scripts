using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    int level = 5;
        int health = 10;
    float speed = 1.5f;
    Vector3 new_pos;
    // Start is called before the first frame update
    void Start()
    {
        level += health;
        print("Helth" + health);
    }

    // Update is called once per frame
    void Update()
    {
        new_pos = transform.position;
        new_pos.x += speed * Time.deltaTime;
        gameObject.transform.position = new_pos;
    }
}
