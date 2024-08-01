using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update

    void Start()
    {
        transform.position = new Vector3(-0.15f, -4f, 0);

    }

    // Update is called once per frame
    void Update()
    {
        Limit_Movement();

        void Limit_Movement()
        {
            if (transform.position.y >= -1f)
            {
                transform.position = new Vector3(transform.position.x, -1f, 0);
            }
            else if (transform.position.y <= -3.9f)
            {
                transform.position = new Vector3(transform.position.x, -3.9f, 0);
            }

            if (transform.position.x <= -1.6f)
            {
                transform.position = new Vector3(-1.6f, transform.position.y, 0);
            }
            if (transform.position.x >= 1.6f)
            {
                transform.position = new Vector3(1.6f, transform.position.y, 0);
            }

        }
    }
}
