using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changePosition : MonoBehaviour
{
    public Transform objectTransform;
    void Update()
{
    if (Input.GetKeyDown(KeyCode.Space))
    {
        float randomX = Random.Range(-10f, 10f);
        float randomY = Random.Range(-5f, 5f);
        Vector3 newPosition = new Vector3(randomX, randomY, 0f);

        objectTransform.position = newPosition;
    }
}
}
