using System;
using UnityEngine;

public static class Utils
{
    public static Vector3 SphericalToCartesian(float radius, float theta, float rho)
    {
		return new Vector3(
			(float)(radius * Math.Sin(theta) * Math.Cos(rho)),
			(float)(radius * Math.Sin(theta) * Math.Sin(rho)),
			(float)(radius * Math.Cos(theta))		
		);
    }
}

