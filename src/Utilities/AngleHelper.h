#pragma once
class AngleHelper
{
public:
	static CStringW FormatAngle(double angle, tkAngleFormat format, int anglePrecision, bool adjustValue = true);
	static CStringW FormatBearing(double angle, tkBearingType bearingType, tkAngleFormat angleFormat, int anglePrecision, bool adjustValue = true);
	static CStringW GetReducedBearing(double azimuth, tkBearingType bearing, tkAngleFormat format, int anglePrecision);
};

