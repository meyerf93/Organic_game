using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Ressources_manager : MonoBehaviour
{
    
	public GameObject resourcePrefab;
	public GameObject Planet;

	public Material co2, h2o, n;

	public int Co2_limit = 100;
	public int H2o_limit = 100;
	public int N_limit = 100;

	List<GameObject> resources_list = new List<GameObject>();

	public void Add_ressource(GameObject ressources)
	{
		resources_list.Add(ressources);
	}
    
	public void Remove_ressource(GameObject resources)
	{
		resources_list.Remove(resources);
	}

	public void CreatePrefab(int limit, int nb,Ressource.ressource_type res_type,Ressource.Location_type loc_type){
		for (int i = 0; i < nb; i++)
        {
			int temp_value = limit / nb;//Random.Range(0, Co2_limit);
			float temp_theta = Random.Range(0, Mathf.PI);
			float temp_rho = Random.Range(0, Mathf.PI * 2);
			Vector3 position;       
			if(loc_type == Ressource.Location_type.ground){
				position = Utils.SphericalToCartesian(Random.Range(0, 20), temp_theta, temp_rho);
			}
			else{
				position = Utils.SphericalToCartesian(Random.Range(30, 50), temp_theta, temp_rho);
			}
			GameObject TempGO = Instantiate<GameObject>(resourcePrefab,position, Quaternion.identity,Planet.transform);
			TempGO.GetComponent<Ressource>().Create(temp_value, res_type, loc_type);
			switch (res_type)
			{
				case Ressource.ressource_type.co2:
					TempGO.GetComponent<Renderer>().material = co2;
					break;
				case Ressource.ressource_type.h2o:
					TempGO.GetComponent<Renderer>().material = h2o;
					break;
				case Ressource.ressource_type.n:
					TempGO.GetComponent<Renderer>().material = n;
					break;
				default:
					break;
			}
            resources_list.Add(TempGO);
        }
        
	}

	public void CreateRessourceManager(int Co2_limit, int Co2_nb, int H2o_limit, int H2o_nb, int N_limit, int N_nb)
	{
        CreatePrefab(Co2_limit/2, Co2_nb/2, Ressource.ressource_type.co2, Ressource.Location_type.atmosphere);
		CreatePrefab(Co2_limit / 2, Co2_nb / 2, Ressource.ressource_type.co2, Ressource.Location_type.ground);
		CreatePrefab(H2o_limit/2, H2o_nb/2, Ressource.ressource_type.h2o, Ressource.Location_type.atmosphere); 
		CreatePrefab(H2o_limit/2, H2o_nb/2, Ressource.ressource_type.h2o, Ressource.Location_type.ground); 
		CreatePrefab(N_limit/2, N_nb/2, Ressource.ressource_type.n, Ressource.Location_type.atmosphere);      
		CreatePrefab(N_limit/2, N_nb/2, Ressource.ressource_type.n, Ressource.Location_type.ground);      
	}
    
}
    
