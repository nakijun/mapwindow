#include "stdafx.h"
#include "AngleHelper.h"
#include "GeometryHelper.h"

// *********************************************************
//		FormatAngle()
// *********************************************************	
CStringW AngleHelper::FormatAngle(double angle, tkAngleFormat format, int anglePrecision, bool adjustValue)
{
	if (adjustValue)
	{
		while (angle < -180.0) angle += 360.0;
		while (angle > 180.0) angle -= 360.0;
	}

	CStringW s;
	int val;
	if (format == tkAngleFormat::afDegrees)
	{
		val = (int)Utility::Rint(angle * 10.0);
		s.Format(L"%.1f°", val / 10.0);
		return s;
	}

	int degrees = (int)floor(angle);
	double delta = angle - degrees;
	if (format == tkAngleFormat::afMinutes)
	{
		val = Utility::Rint(60.0 * delta);
		if (val == 60) {
			val = 0;
			degrees += 1;
		}
		s.Format(L"%d° %d'", degrees, val);
		return s;
	}

	int minutes = (int)floor(60.0 * delta);

	delta = delta - minutes / 60.0;
	double seconds = delta*3600.0;

	// TODO: implement formatting for seconds

	s.Format(L"%d° %2d' %2d\"", degrees, minutes, (int)floor(seconds));
	return s;
}

// ***************************************************************
//		FormatBearing()
// ***************************************************************
CStringW AngleHelper::FormatBearing(double angle, tkBearingType bearingType, tkAngleFormat format, int precision, bool adjustValue)
{
	CStringW s;
	switch (bearingType)
	{
		case btAbsolute:
		case btClockwise:
		case btCounterClockwise:
			s = FormatAngle(angle, format, false);
			break;
		case btReducedNDE:
		case btReducedNED:
			s = GetReducedBearing(angle, bearingType, format, precision);
			break;
	}

	return L"";
}

/****************************************************************************/
/*		GetReducedBearing()													*/
/****************************************************************************/
CStringW AngleHelper::GetReducedBearing(double azimuth, tkBearingType bearing, tkAngleFormat format, int precision)
{
	int count = (int)floor(azimuth) / 360;
	double angle = azimuth - count * 360.0;
	count = (int)floor(angle) / 90;

	angle = ((count == 0) || (count == 2)) ? angle - count * 90 : (count + 1) * 90 - angle;

	tkLocalizedStrings ls;
	//switch (count)
	//{
	//	case 0:	ls = tkLocalizedStrings::lsNorthEast;	break;
	//	case 1: ls = tkLocalizedStrings::lsSouthEast;	break;
	//	case 2:	ls = tkLocalizedStrings::lsSouthWest;	break;
	//	case 3: ls = tkLocalizedStrings::lsNorthWest;	break;
	//}

	CStringW rhumb;
	rhumb.Format(L"%s:%s", m_globalSettings.GetLocalizedString(ls), FormatAngle(angle, format, precision));
	return rhumb;
}