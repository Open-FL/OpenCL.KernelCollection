#include random.cle

__kernel void urnd_gpu(__global uchar* image, int3 dimensions, int channelCount, float maxValue, __global uchar* channelEnableState, int seedA, int seedB)
{
	int idx = get_global_id(0);
	int channel = (int)fmod((float)idx, (float)channelCount);
	if(channel != 0)
	{
		return;
	}
    int2 rndstate = (int2)((seedA>>13) ^ (idx >> 5), seedB-(seedA^idx));

    uchar rndValue = random(&rndstate);

    for(int i = 0; i < 4; i++)
	{
		if(channelEnableState[i] == 0)
			continue;
		image[idx+i] = rndValue;
	}

}