using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject Cocina;
    public GameObject Habitacion;
    public GameObject Comedor;
    public GameObject PuertaCocina;
    public GameObject PuertaHabitacion;
    public GameObject Player;

    private void OnEnable()
    {
        Cocina.SetActive(false);
        Habitacion.SetActive(false);
        Comedor.SetActive(true);
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
