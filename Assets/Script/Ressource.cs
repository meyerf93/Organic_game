using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ressource : MonoBehaviour {

	public int ressource_value = 100;
    public enum ressource_type { h2o, co2, n, photon };
    public enum Location_type { ground, atmosphere };
    public Location_type location_Type;
    public ressource_type ressource_Type;

    public Ressource()
    {
        ressource_value = 100;
        ressource_Type = ressource_type.h2o;
        location_Type = Location_type.ground;
	}

    public Ressource(int ressource_value, ressource_type ressource_Type, Location_type location_Type)
    {
        this.ressource_value = ressource_value;
        this.ressource_Type = ressource_Type;
        this.location_Type = location_Type;
    }

	public void Create(int ressource_value, ressource_type ressource_Type, Location_type location_Type){
		this.ressource_value = ressource_value;
        this.ressource_Type = ressource_Type;
        this.location_Type = location_Type;
	}
}
