using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuertaHabitacion : MonoBehaviour
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
    public Transform CamaraHabitacion;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        print(Habitacion.activeSelf ? "Active" : "Inactive");
    }

    private void OnTriggerEnter(Collider other)
    {
        Cargas();
    }


    void Cargas()
    {
        print("CargandoNuevaZona");
        if (Habitacion.activeSelf == false)
        {
            print("Estoy activo Habitacion");
            Habitacion.SetActive(true);
            var poscamara = Camara;
            poscamara.transform.position = CamaraHabitacion.transform.position;
            var posplayer = Player;
            posplayer.transform.position = EntradaHabitacion.transform.position;
            Comedor.SetActive(false);

        }
        else
        {
            Comedor.SetActive(true);
            var poscamara = Camara;
            poscamara.transform.position = CamaraComedor.transform.position;
            var posplayer = Player;
            posplayer.transform.position = EntradaComedor2.transform.position;
            print("Estoy activo Comedor");
            Habitacion.SetActive(false);
        }
    }
}
