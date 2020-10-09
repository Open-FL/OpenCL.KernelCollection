
float clamprescale(float input, float valueA, float valueB)
{
	
	float dist = valueB - valueA;
	

	if(valueA > input)
	{
		return 0.0f;
	}
	else if(valueB < input)
	{
		return 1.0f;
	}
	else
	{
		return input - valueA / dist;
	}

}

float _clamp(float input, float valueA, float valueB)
{
	return clamp(input, valueA, valueB);
}

#includeinl dynamic/dyn_2_arg.cle ClampRescale clamprescale
#includeinl dynamic/dyn_2_arg.cle Clamp _clamp