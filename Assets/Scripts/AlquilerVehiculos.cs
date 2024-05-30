using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlquilerVehiculos : MonoBehaviour
{
    public GameObject[] vehiculos;
    
    

    // Start is called before the first frame update
    void Start()
    {
        ResetearVehiculos();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            DesactivarTodosLosVehiculos();
            vehiculos[Random.Range(0, vehiculos.Length)].SetActive(true);
        }   
    }
    void ResetearVehiculos()
    {
        DesactivarTodosLosVehiculos();
        vehiculos[0].SetActive(true);
    }

    void DesactivarTodosLosVehiculos() 
    {
        for (int i =0; i< vehiculos.Length; i++)
        foreach(GameObject V in vehiculos)
        {
           vehiculos[i].SetActive(false);
        }
    }
}
