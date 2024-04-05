using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed;
    public float tiempoVivo = 0f;
    public float tiempoMaximo = 10f;
 

    void Update()
    {
        transform.position -= new Vector3(speed * Time.deltaTime, 0, 0);

        tiempoVivo += Time.deltaTime;

        if (tiempoMaximo <= tiempoVivo)
            Destroy(this.gameObject);
    }
}
