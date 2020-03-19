using System;

public class UnitConverter
{
	int ratio;
	public UnitConverter(int unitRatio) { ratio = unitRatio; } //Constructor
	public int Convert(int unit) { return unit * ratio; } //Method
}


