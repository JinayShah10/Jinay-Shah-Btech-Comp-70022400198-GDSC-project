using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        float RandomX = Random.Range(-2f, 2f);

        transform.Translate(Vector3.up * 4 * Time.deltaTime);

        if (transform.position.y <= -5.25f)
        {
            transform.position = (new Vector3(RandomX, 5.13f, 0));
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Time.timeScale = 0;
        }

    }
}

