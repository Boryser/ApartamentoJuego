using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuertaCocina : MonoBehaviour
{
    public GameObject Cocina;
    public GameObject Habitacion;
    public GameObject Player;
    public GameObject Comedor;
    public Transform EntradaHabitacion;
    public Transform EntradaComedor1;
    public Transform EntradaComedor2;
    public Transform EntradaCocina;
    public GameObject Camara;
    public Transform CamaraComedor;
    public Transform CamaraCocina;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        print(Cocina.activeSelf ? "Active" : "Inactive");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Cargas();
        }
        
    }


    void Cargas()
    {
        print("CargandoNuevaZona");
        if (Cocina.activeSelf==false)
        {
            print("Estoy activo Cocina");
            Cocina.SetActive(true);
            var poscamara = Camara;
            poscamara.transform.position = CamaraCocina.transform.position;
            var posplayer = Player;
            posplayer.transform.position = EntradaCocina.transform.position;
            Comedor.SetActive(false);

        }
        else
        {
            Comedor.SetActive(true);
            var poscamara = Camara;
            poscamara.transform.position = CamaraComedor.transform.position;
            var posplayer = Player;
            posplayer.transform.position = EntradaComedor1.transform.position;
            print("Estoy activo Comedor");
            Cocina.SetActive(false);
        }
    }
}
