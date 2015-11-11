using UnityEngine;
using System.Collections;
using Fungus;

public class CargarNivel : MonoBehaviour
{
	public string escena;
	
	void CargarEscena ()
	{
		Flowchart fc = GameObject.FindObjectOfType<Flowchart> ();
		escena = fc.GetStringVariable ("Escena");;
		Application.LoadLevel (escena);
	}
}
