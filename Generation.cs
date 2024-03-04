using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generation : MonoBehaviour
{
    public GameObject[] Object;

    public float groundRadius = 1f;

    public LayerMask groundMask;

    void Start()
    {
        for (var i = 0; i < 5; i++)
        {
            var randomX = Random.Range(0, 3);

            var randomY = Random.Range(-5, 8);

            var isTrue = Physics2D.OverlapCircle(new Vector2(randomX, randomY), groundRadius, groundMask);

            if (!isTrue)
            {
                var rand = Random.Range(0, 2);

                Instantiate(Object[rand], new Vector2(randomX, randomY), Quaternion.identity);
            }
        }

    }

}

