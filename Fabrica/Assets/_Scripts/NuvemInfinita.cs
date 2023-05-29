using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NuvemInfinita : MonoBehaviour
{
    public float VelocidadeDaNuvem;

    // Update is called once per frame
    void Update()
    {
        MovimentarNuvem();
    }

    private void MovimentarNuvem()
    {
        Vector2 deslocamentoDaNuvem = new Vector2(Time.time * VelocidadeDaNuvem, 0f);
        GetComponent<Renderer>().material.mainTextureOffset = deslocamentoDaNuvem;
    }
}
