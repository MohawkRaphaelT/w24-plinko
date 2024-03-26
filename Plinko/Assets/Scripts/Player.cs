using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 5;
    public GameObject disc;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Move();
        SpawnDisc();
    }

    void Move()
    {
        Vector3 offset = Vector3.zero;

        bool isHoldingLeft = Input.GetKey(KeyCode.LeftArrow);
        bool isHoldingRight = Input.GetKey(KeyCode.RightArrow);

        if (isHoldingLeft)
            offset.x -= speed;

        if (isHoldingRight)
            offset.x += speed;

        transform.position += offset * Time.deltaTime;
    }

    void SpawnDisc()
    {
        bool doSpawn = Input.GetKeyDown(KeyCode.Space);

        if (doSpawn)
        {
            Instantiate(disc, transform.position, Quaternion.identity);
        }
    }
}
