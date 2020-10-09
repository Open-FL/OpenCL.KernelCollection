

float selfmul(float input)
{
	return input * input;
}

#includeinl dynamic/dyn_no_arg.cle SelfMul selfmul
#includeinl dynamic/dyn_no_arg_c.cle SelfMul selfmul