// Project: SystemsAnalysis.Modeling, File: PipXP.cs
// Namespace: SystemsAnalysis.Modeling, Class: PipXP
// Path: C:\Development\DotNet\Modeling, Author: Arnel
// Code lines: 1040, Size of file: 22.80 KB
// Creation date: 6/30/2008 11:03 AM
// Last modified: 8/26/2008 11:42 AM

using System;
using System.Collections.Generic;
using System.Text;
using SystemsAnalysis.Types;

namespace SystemsAnalysis.Modeling
{
  public class PipXP : PipeConflict
  {
    private const int MINIMUM_PIPE_LENGTH_THRESHOLD_FOR_PARALLEL = 10;
    private const double MINIMUM_DISTANCE_TO_RAIL_FOR_PARALLEL = 30;
    private const double PERCENT_OF_PIPE_LENGTH_THRESHOLD_FOR_PARALLEL = 0.10;

    #region Variables
    private LookupTable<double, double> _parallelWaterLookup;
    private LookupTable<double, double> _parallelSewerLookup;
    private LookupTable<double, double> _parallelRailLookup;
    private LookupTable<double, double> _parallelLRTLookup;

    private Link _Link;

    // Identifying data
    private int _MstLinkID; // MLINKID
    private string _USNode; // USNODE
    private string _DSNode; // DSNODE
    private int _CompKey; // COMPKEY

    // Location data
    private double _USX; // xa
    private double _USY; // ya
    private double _DSX; // xb
    private double _DSY; // yb
    private double _Azimuth; // Deg2N

    // Water facilities
    private int _NumWaterCrossings; // xWtr
    private int _SmallestWaterCrossingDiameterInches; // xWMinD
    private int _LargestWaterCrossingDiameterInches; // xWMaxD
    private bool _HasWaterParallel; // pWtr
    private double _ParallelToWaterLenWithin2ft; // pWtr2
    private double _ParallelToWaterLenWithin4ft; // pWtr4
    private double _ParallelToWaterLenWithin6ft; // pWtr6
    private double _ParallelToWaterLenWithin8ft; // pWtr8
    private double _ParallelToWaterLenWithin10ft; // pWtr10
    private double _ParallelToWaterLenWithin12ft; // pWtr12
    private int _LargestWaterParallelDiameterInches; // pWtrMaxD
    private int _DistToWaterParallelFeet; // pFt2Wtr

    // Sewer Facilities
    private int _NumSewerCrossings; // xSewer
    private int _SmallestSewerCrossingDiameterInches; // xSwrMinD
    private int _LargestSewerCrossingDiameterInches; // xSwrMaxD
    private bool _HasSewerParallel; // pSewer
    private double _ParallelToSewerLenWithin2ft; // pSwr2
    private double _ParallelToSewerLenWithin4ft; // pSwr4
    private double _ParallelToSewerLenWithin6ft; // pSwr6
    private double _ParallelToSewerLenWithin8ft; // pSwr8
    private double _ParallelToSewerLenWithin10ft; // pSwr10
    private int _LargestSewerParallelDiameterInches; // pSwrMaxD
    private int _DistToSewerParallelFeet; // pFt2Swr

    // Transportation facilities
    private int _NumStreetCrossings; // xStrt
    private int _NumArterialCrossings; // xArt
    private int _NumMajorArterialCrossings; // xMJArt
    private int _NumFreewayCrossings; // xFrwy
    private bool _IsInStreet; //pStrt
    private Enumerators.StreetTypeKind _StreetType; // pStrtTyp
    private int _DistToStreetCenterlineFeet; // pFt2Strt
    private int _NumStreetsIfUSNodeInIntersection; // uxCLx
    private int _DistUSNodeToIntersectionFeet; // uxFt2CLx
    private int _NumStreetsIfDSNodeInIntersection; // dxCLx
    private int _DistDSNodeToIntersectionFeet; // dxFt2CLx
    private int _TrafficVolVehiclesPerDay; // pTraffic

    // Railroad facilities
    private int _NumRailroadCrossings; // xRail
    private bool _HasRailroadParallel; // pRail
    private int _DistToRailroadParallelFeet; // pFt2Rail
    private double _ParallelToRailLenWithin10ft; // pRail10
    private double _ParallelToRailLenWithin20ft; // pRail20
    private double _ParallelToRailLenWithin30ft; // pRail30
    private int _NumLightRailCrossings; // xLRT
    private bool _HasLightRailParallel; // pLRT
    private int _DistToLightRailParallelFeet; // pFt2LRT
    private double _ParallelToLightRailLenWithin10ft; // pLRT10
    private double _ParallelToLightRailLenWithin20ft; // pLRT20
    private double _ParallelToLightRailLenWithin30ft; // pLRT30


    // Fiber Optic & Gas facilities
    private int _NumFiberOpticCrossings; // xFiber
    private bool _HasFiberOpticParallel; // pFiber
    private int _DistToFiberOpticParallelFeet; // pFt2Fiber
    private int _NumGasCrossings; // xGas
    private bool _HasGasParallel; // pGas
    private int _DistToGasParallel; // pFt2Gas

    // Environmental zones
    private bool _IsInConservationZone; // xEzonC
    private int _LengthInConservationZoneFeet; // xFtEzonC
    private int _AreaConservationZoneSqFt; // xEzAreaC
    private bool _IsInPreservationZone; // xEzonP
    private int _LengthInPreservationZoneFeet; // xFtEzonP
    private int _AreaPreservationZoneSqFt; // xEzAreaP
    private bool _IsNearContaminationSite; // xEcsi
    private int _DistToNearestEcsiFeet; // xFt2Ecsi
    private double _LengthInEcsiFeet; // xEcsiLen
    private int _VolHazardousConflictCuYd; // xEcsiVol
    private bool _IsNearLUST; // xLUST
    private int _DistToNearestLUSTFeet; // xFt2LUST

    // Public safety
    private bool _IsNearSchool; // xSchl
    private int _DistToSchoolFeet; // xFt2Schl
    private bool _IsNearHospital; // xHosp
    private int _DistToHospitalFeet; // xFt2Hosp
    private bool _IsNearPoliceStation; // xPol
    private int _DistToPoliceStationFeet; // xFt2Pol
    private bool _IsNearFireStation; // xFire
    private int _DistToFireStationFeet; // xFt2Fire
    private int _NumEmergencyRouteCrossings; // xEmt
    private bool _IsInEmergencyRoute; // pEmt
    private int _DistToEmergencyRouteCenterlineFeet; // pFt2Emt

    // Other
    private bool _USNodeInMS4; // uxMS4
    private bool _USNodeInUIC; // uxUIC
    private double _USNodeDepth; // uDepth
    private double _DSNodeDepth; // dDepth
    private int _SurfaceSlopePct; // gSlope
    private bool _IsNearBuilding; // xBldg
    private int _DistToBuildingFeet; // xFt2Bldg
    private bool _IsNearHydrant; // xHyd
    private int _DistToHydrant; // xFt2Hyd
    private bool _IsHardArea; // HardArea
    #endregion

    #region Constructors
    /// <summary>
    /// Creates a pipe conflict object
    /// </summary>
    /// <param name="mdlPipXPRow">A row from the PipXP table</param>
    public PipXP(DataAccess.ModelDataSet.MdlPipXPRow mdlPipXPRow)
    {
      _MstLinkID = Convert.ToInt32(mdlPipXPRow.MLinkID);
      _USNode = mdlPipXPRow.USNode;
      _DSNode = mdlPipXPRow.DSNode;
      _CompKey = Convert.ToInt32(mdlPipXPRow.COMPKEY);

      _NumWaterCrossings = mdlPipXPRow.xWtr;
      _SmallestWaterCrossingDiameterInches = mdlPipXPRow.xWMinD;
      _LargestWaterCrossingDiameterInches = mdlPipXPRow.xWMaxD;
      _HasWaterParallel = mdlPipXPRow.pWtr >= 1;
      _LargestWaterParallelDiameterInches = mdlPipXPRow.pWtrMaxD;
      _DistToWaterParallelFeet = mdlPipXPRow.pFt2Wtr;

      SortedList<double, double> parallelWaterLookup = new SortedList<double, double>();
      parallelWaterLookup.Add(2, _ParallelToWaterLenWithin2ft);
      parallelWaterLookup.Add(4, _ParallelToWaterLenWithin4ft);
      parallelWaterLookup.Add(6, _ParallelToWaterLenWithin6ft);
      parallelWaterLookup.Add(8, _ParallelToWaterLenWithin8ft);
      parallelWaterLookup.Add(10, _ParallelToWaterLenWithin10ft);
      parallelWaterLookup.Add(12, _ParallelToWaterLenWithin12ft);
      _parallelWaterLookup = new LookupTable<double, double>(parallelWaterLookup);

      _NumSewerCrossings = mdlPipXPRow.xSewer;
      _SmallestSewerCrossingDiameterInches = mdlPipXPRow.xSwrMinD;
      _LargestSewerCrossingDiameterInches = mdlPipXPRow.xSwrMaxD;
      _HasSewerParallel = mdlPipXPRow.pSewer >= 1;
      _LargestSewerParallelDiameterInches = mdlPipXPRow.pSwrMaxD;
      _DistToSewerParallelFeet = mdlPipXPRow.pFt2Swr;

      SortedList<double, double> parallelSewerLookup = new SortedList<double, double>();
      parallelSewerLookup.Add(2, _ParallelToSewerLenWithin2ft);
      parallelSewerLookup.Add(4, _ParallelToSewerLenWithin4ft);
      parallelSewerLookup.Add(6, _ParallelToSewerLenWithin6ft);
      parallelSewerLookup.Add(8, _ParallelToSewerLenWithin8ft);
      parallelSewerLookup.Add(10, _ParallelToSewerLenWithin10ft);
      _parallelSewerLookup = new LookupTable<double, double>(parallelSewerLookup);

      _NumStreetCrossings = mdlPipXPRow.xStrt;
      _NumArterialCrossings = mdlPipXPRow.xArt;
      _NumMajorArterialCrossings = mdlPipXPRow.xMJArt;
      _NumFreewayCrossings = mdlPipXPRow.xFrwy;
      _IsInStreet = mdlPipXPRow.pStrt >= 1;
      switch (mdlPipXPRow.pStrtTyp)
      {
        case 1110:
        case 1121:
        case 1122:
        case 1123:
        case 1200:
          _StreetType = Enumerators.StreetTypeKind.Freeway;
          break;
        case 1221:
        case 1222:
        case 1223:
          _StreetType = Enumerators.StreetTypeKind.MajorArterial;
          break;
        case 1300:
        case 1400:
        case 1450:
        case 5301:
        case 5401:
          _StreetType = Enumerators.StreetTypeKind.Arterial;
          break;
        case 1500:
        case 1521:
        case 1700:
        case 1740:
        case 1750:
        case 5500:
        case 5501:
          _StreetType = Enumerators.StreetTypeKind.Street;
          break;
        default:
          _StreetType = Enumerators.StreetTypeKind.None;
          break;
      } // switch
      _DistToStreetCenterlineFeet = mdlPipXPRow.pFt2Strt;
      _NumStreetsIfUSNodeInIntersection = mdlPipXPRow.uxCLx;
      _DistUSNodeToIntersectionFeet = mdlPipXPRow.uxFt2CLx;
      _NumStreetsIfDSNodeInIntersection = mdlPipXPRow.dxCLx;
      _DistDSNodeToIntersectionFeet = mdlPipXPRow.dxFt2CLx;
      _TrafficVolVehiclesPerDay = mdlPipXPRow.pTraffic;

      _NumRailroadCrossings = mdlPipXPRow.xRail;
      _HasRailroadParallel = mdlPipXPRow.pRail >= 1;
      _DistToRailroadParallelFeet = mdlPipXPRow.pFt2Rail;
      
      SortedList<double, double> parallelRailLookup = new SortedList<double, double>();
      parallelRailLookup.Add(10, _ParallelToRailLenWithin10ft);
      parallelRailLookup.Add(20, _ParallelToRailLenWithin20ft);
      parallelRailLookup.Add(30, _ParallelToRailLenWithin30ft);
      _parallelRailLookup = new LookupTable<double, double>(parallelRailLookup);

      _NumLightRailCrossings = mdlPipXPRow.xLRT;
      _HasLightRailParallel = mdlPipXPRow.pLRT >= 1;
      _DistToLightRailParallelFeet = mdlPipXPRow.pFt2LRT;

      SortedList<double, double> parallelLRTLookup = new SortedList<double, double>();
      parallelLRTLookup.Add(10, _ParallelToLightRailLenWithin10ft);
      parallelLRTLookup.Add(20, _ParallelToLightRailLenWithin20ft);
      parallelLRTLookup.Add(30, _ParallelToLightRailLenWithin30ft);
      _parallelLRTLookup = new LookupTable<double, double>(parallelLRTLookup);

      _NumFiberOpticCrossings = mdlPipXPRow.xFiber;
      _HasFiberOpticParallel = mdlPipXPRow.pFiber == 1;
      _DistToFiberOpticParallelFeet = mdlPipXPRow.pFt2Fiber;
      _NumGasCrossings = mdlPipXPRow.xGas;
      _HasGasParallel = mdlPipXPRow.pGas == 1;
      _DistToGasParallel = mdlPipXPRow.pFt2Gas;

      _IsInConservationZone = mdlPipXPRow.xEzonC == 1;
      _LengthInConservationZoneFeet = mdlPipXPRow.xFtEzonC;
      _AreaConservationZoneSqFt = mdlPipXPRow.xEzAreaC;
      _IsInPreservationZone = mdlPipXPRow.xEzonP == 1;
      _LengthInPreservationZoneFeet = mdlPipXPRow.xFtEzonP;
      _AreaPreservationZoneSqFt = mdlPipXPRow.xEzAreaP;
      _IsNearContaminationSite = mdlPipXPRow.xEcsi == 1;
      _DistToNearestEcsiFeet = mdlPipXPRow.xFt2Ecsi;
      _LengthInEcsiFeet = mdlPipXPRow.xEcsiLen;
      _VolHazardousConflictCuYd = mdlPipXPRow.xEcsiVol;

      _IsNearSchool = mdlPipXPRow.xSchl == 1;
      _DistToSchoolFeet = mdlPipXPRow.xFt2Schl;
      _IsNearHospital = mdlPipXPRow.xHosp == 1;
      _DistToHospitalFeet = mdlPipXPRow.xFt2Hosp;
      _IsNearPoliceStation = mdlPipXPRow.xPol == 1;
      _DistToPoliceStationFeet = mdlPipXPRow.xFt2Pol;
      _IsNearFireStation = mdlPipXPRow.xFire == 1;
      _DistToFireStationFeet = mdlPipXPRow.xFt2Fire;
      _NumEmergencyRouteCrossings = mdlPipXPRow.xEmt;
      _IsInEmergencyRoute = mdlPipXPRow.pEmt == 1;
      _DistToEmergencyRouteCenterlineFeet = mdlPipXPRow.pFt2Emt;

      _USNodeInMS4 = mdlPipXPRow.uxMS4 == 1;
      _USNodeInUIC = mdlPipXPRow.uxUIC == 1;
      _USNodeDepth = mdlPipXPRow.uDepth;
      _DSNodeDepth = mdlPipXPRow.dDepth;
      _SurfaceSlopePct = Convert.ToInt32(mdlPipXPRow.gSlope);
      _IsNearBuilding = mdlPipXPRow.xBldg == 1;
      _DistToBuildingFeet = mdlPipXPRow.xFt2Bldg;
      _IsNearHydrant = mdlPipXPRow.xHyd == 1;
      _DistToHydrant = mdlPipXPRow.xFt2Hyd;
      _IsHardArea = mdlPipXPRow.HardArea == 1;
    } // PipXP(PipXPRow)

    #endregion

    #region Properties
    public Link Link
    {
      get
      {
        return _Link;
      }
      set
      {
        _Link = value;
      }
    }

    public int MstLinkID
    {
      get
      {
        return _MstLinkID;
      } // get
    } // MstLinkID

    /// <summary>
    /// USNode
    /// </summary>
    /// <returns>String</returns>
    public string USNode
    {
      get
      {
        return _USNode;
      } // get
    } // USNode

    /// <summary>
    /// DSNode
    /// </summary>
    /// <returns>String</returns>
    public string DSNode
    {
      get
      {
        return _DSNode;
      } // get
    } // DSNode

    /// <summary>
    /// Mst link ID
    /// </summary>
    /// <returns>Int</returns>
    /// <summary>
    /// Comp key
    /// </summary>
    /// <returns>Int</returns>
    public int CompKey
    {
      get
      {
        return _CompKey;
      } // get
    } // CompKey

    /// <summary>
    /// Upstream X-coordinate
    /// </summary>
    public double US_XCoord
    {
      get
      {
        return _USX;
      }
    }

    /// <summary>
    /// Upstream Y-coordinate
    /// </summary>
    public double US_YCoord
    {
      get
      {
        return _USY;
      }
    }

    /// <summary>
    /// Downstream X-coordinate
    /// </summary>
    public double DS_XCoord
    {
      get
      {
        return _DSX;
      }
    }

    /// <summary>
    /// Downstream y-coordinate
    /// </summary>
    public double DS_YCoord
    {
      get
      {
        return _DSY;
      }
    }

    /// <summary>
    /// Direction of line as compared to North (0 degrees), considering only direction of line
    /// from 0 to 180 degrees
    /// </summary>
    public double Direction
    {
      get
      {
        return _Azimuth;
      }
    }

    /// <summary>
    /// Num water crossings
    /// </summary>
    /// <returns>Int</returns>
    public int NumWaterCrossings
    {
      get
      {
        return _NumWaterCrossings;
      } // get
    } // NumWaterCrossings

    /// <summary>
    /// Smallest water crossing diameter inches
    /// </summary>
    /// <returns>Int</returns>
    public int SmallestWaterCrossingDiameterInches
    {
      get
      {
        return _SmallestWaterCrossingDiameterInches;
      } // get
    } // SmallestWaterCrossingDiameterInches

    /// <summary>
    /// Largest water crossing diameter inches
    /// </summary>
    /// <returns>Int</returns>
    public int LargestWaterCrossingDiameterInches
    {
      get
      {
        return _LargestWaterCrossingDiameterInches;
      } // get
    } // LargestWaterCrossingDiameterInches

    /// <summary>
    /// Has water parallel
    /// </summary>
    /// <returns>Bool</returns>
    public bool HasWaterParallel
    {
      get
      {
        if (_Link == null)
          throw new ArgumentNullException(
          String.Format("No link associated with pipe conflict: {0}", MstLinkID));

        double distanceToConsiderAsParallel = ((_USNodeDepth + _DSNodeDepth) / 2) / 3;
        double lengthOfPipeFtNearWaterByFt = 
          LengthOfPipeFtNearWaterByFt(distanceToConsiderAsParallel);
        return (
        ((lengthOfPipeFtNearWaterByFt / _Link.Length) > 
          PERCENT_OF_PIPE_LENGTH_THRESHOLD_FOR_PARALLEL) ||
        (lengthOfPipeFtNearWaterByFt > MINIMUM_PIPE_LENGTH_THRESHOLD_FOR_PARALLEL)
        );
      } // get
    } // HasWaterParallel


    /// <summary>
    /// Returns the length of pipe considered parallel to a water pipe at less than the given distance
    /// </summary>
    /// <param name="distFromWater">Distance to consider from water pipes</param>
    /// <returns>Length of pipe from nearby parallel water pipes</returns>
    public double LengthOfPipeFtNearWaterByFt(double distFromWater)
    {
      double lookupValue;
      try
      {
        lookupValue = _parallelWaterLookup.LookupValueWithCeiling(distFromWater);
      }
      catch (IndexOutOfRangeException)
      {
        lookupValue = 0;
      }
      return lookupValue;
    }

    /// <summary>
    /// Largest water parallel diameter inches
    /// </summary>
    /// <returns>Int</returns>
    public int LargestWaterParallelDiameterInches
    {
      get
      {
        return _LargestWaterCrossingDiameterInches;
      } // get
    } // LargestWaterParallelDiameterInches

    /// <summary>
    /// Dist to water parallel feet
    /// </summary>
    /// <returns>Int</returns>
    public int DistToWaterParallelFeet
    {
      get
      {
        return _DistToWaterParallelFeet;
      } // get
    } // DistToWaterParallelFeet

    /// <summary>
    /// Num sewer crossings
    /// </summary>
    /// <returns>Int</returns>
    public int NumSewerCrossings
    {
      get
      {
        return _NumSewerCrossings;
      } // get
    } // NumSewerCrossings

    /// <summary>
    /// Smallest sewer crossing diameter inches
    /// </summary>
    /// <returns>Int</returns>
    public int SmallestSewerCrossingDiameterInches
    {
      get
      {
        return _SmallestSewerCrossingDiameterInches;
      } // get
    } // SmallestSewerCrossingDiameterInches

    /// <summary>
    /// Largest sewer crossing diameter inches
    /// </summary>
    /// <returns>Int</returns>
    public int LargestSewerCrossingDiameterInches
    {
      get
      {
        return _LargestSewerCrossingDiameterInches;
      } // get
    } // LargestSewerCrossingDiameterInches

    /// <summary>
    /// Has sewer parallel
    /// </summary>
    /// <returns>Bool</returns>
    public bool HasSewerParallel
    {
      get
      {
        if (_Link == null)
          throw new ArgumentNullException(
          String.Format("No link associated with pipe conflict: {0}", MstLinkID));

        double distanceToConsiderAsParallel = ((_USNodeDepth + _DSNodeDepth) / 2) / 3;
        double lengthOfPipeFtNearSewerByFt =
          LengthOfPipeFtNearSewerByFt(distanceToConsiderAsParallel);
        return (
        ((lengthOfPipeFtNearSewerByFt / _Link.Length) >
          PERCENT_OF_PIPE_LENGTH_THRESHOLD_FOR_PARALLEL) ||
        (lengthOfPipeFtNearSewerByFt > MINIMUM_PIPE_LENGTH_THRESHOLD_FOR_PARALLEL)
        );
      } // get
    } // HasSewerParallel

    /// <summary>
    /// Largest sewer parallel diameter inches
    /// </summary>
    /// <returns>Int</returns>
    public int LargestSewerParallelDiameterInches
    {
      get
      {
        return _LargestSewerParallelDiameterInches;
      } // get
    } // LargestSewerParallelDiameterInches

    /// <summary>
    /// Dist to sewer parallel feet
    /// </summary>
    /// <returns>Int</returns>
    public int DistToSewerParallelFeet
    {
      get
      {
        return _DistToSewerParallelFeet;
      } // get
    } // DistToSewerParallelFeet

    /// <summary>
    /// Returns the length of pipe considered parallel to a sewer pipe at less than the given distance
    /// </summary>
    /// <param name="distFromSewer">Distance to consider from sewer pipes</param>
    /// <returns>Length of pipe from nearby parallel sewer pipes</returns>
    public double LengthOfPipeFtNearSewerByFt(double distFromSewer)
    {
      double lookupValue;
      try
      {
        lookupValue = _parallelSewerLookup.LookupValueWithCeiling(distFromSewer);
      }
      catch (IndexOutOfRangeException)
      {
        lookupValue = 0;
      }
      return lookupValue;
    }

    /// <summary>
    /// Num street crossings
    /// </summary>
    /// <returns>Int</returns>
    public int NumStreetCrossings
    {
      get
      {
        return _NumStreetCrossings;
      } // get
    } // NumStreetCrossings

    /// <summary>
    /// Num arterial crossings
    /// </summary>
    /// <returns>Int</returns>
    public int NumArterialCrossings
    {
      get
      {
        return _NumArterialCrossings;
      } // get
    } // NumArterialCrossings

    /// <summary>
    /// Num major arterial crossings
    /// </summary>
    /// <returns>Int</returns>
    public int NumMajorArterialCrossings
    {
      get
      {
        return _NumMajorArterialCrossings;
      } // get
    } // NumMajorArterialCrossings

    /// <summary>
    /// Num freeway crossings
    /// </summary>
    /// <returns>Int</returns>
    public int NumFreewayCrossings
    {
      get
      {
        return _NumFreewayCrossings;
      } // get
    } // NumFreewayCrossings

    /// <summary>
    /// Is in street
    /// </summary>
    /// <returns>Bool</returns>
    public bool IsInStreet
    {
      get
      {
        return _IsInStreet;
      } // get
    } // IsInStreet

    /// <summary>
    /// Street type
    /// </summary>
    /// <returns>Street type</returns>
    public Enumerators.StreetTypeKind StreetType
    {
      get
      {
        return _StreetType;
      } // get
    } // StreetType

    /// <summary>
    /// Dist to street centerline feet
    /// </summary>
    /// <returns>Int</returns>
    public int DistToStreetCenterlineFeet
    {
      get
      {
        return _DistToStreetCenterlineFeet;
      } // get
    } // DistToStreetCenterlineFeet

    /// <summary>
    /// Num streets if us node in intersection
    /// </summary>
    /// <returns>Int</returns>
    public int NumStreetsIfUsNodeInIntersection
    {
      get
      {
        return _NumStreetsIfUSNodeInIntersection;
      } // get
    } // NumStreetsIfUsNodeInIntersection

    /// <summary>
    /// Dist US node to intersection feet
    /// </summary>
    /// <returns>Int</returns>
    public int DistUSNodeToIntersectionFeet
    {
      get
      {
        return _DistUSNodeToIntersectionFeet;
      } // get
    } // DistUSNodeToIntersectionFeet

    /// <summary>
    /// Num streets if DS node in intersection
    /// </summary>
    /// <returns>Int</returns>
    public int NumStreetsIfDSNodeInIntersection
    {
      get
      {
        return _NumStreetsIfDSNodeInIntersection;
      } // get
    } // NumStreetsIfDSNodeInIntersection

    /// <summary>
    /// Dist DS node to intersection feet
    /// </summary>
    /// <returns>Indexer</returns>
    public int DistDSNodeToIntersectionFeet
    {
      get
      {
        return _DistDSNodeToIntersectionFeet;
      } // get
    } // DistDSNodeToIntersectionFeet

    /// <summary>
    /// Num railroad crossings
    /// </summary>
    /// <returns>Int</returns>
    public int NumRailroadCrossings
    {
      get
      {
        return _NumRailroadCrossings;
      } // get
    } // NumRailroadCrossings

    /// <summary>
    /// Has railroad parallel
    /// </summary>
    /// <returns>Bool</returns>
    public bool HasRailroadParallel
    {
      get
      {
        return _HasRailroadParallel;
      } // get
    } // HasRailroadParallel

    public double LengthOfPipeFtNearRailByFt(double distFromRail)
    {
      double lookupValue;
      try
      {
        lookupValue = _parallelRailLookup.LookupValueWithCeiling(distFromRail);
      }
      catch (IndexOutOfRangeException)
      {
        lookupValue = 0;
      }
      return lookupValue;
    }

    /// <summary>
    /// Dist to railroad parallel feet
    /// </summary>
    /// <returns>Int</returns>
    public int DistToRailroadParallelFeet
    {
      get
      {
        return _DistToRailroadParallelFeet;
      } // get
    } // DistToRailroadParallelFeet

    /// <summary>
    /// Num light rail crossings
    /// </summary>
    /// <returns>Int</returns>
    public int NumLightRailCrossings
    {
      get
      {
        return _NumLightRailCrossings;
      } // get
    } // NumLightRailCrossings

    /// <summary>
    /// Has light rail parallel
    /// </summary>
    /// <returns>Bool</returns>
    public bool HasLightRailParallel
    {
      get
      {
        if (_Link == null)
          throw new ArgumentNullException(
          String.Format("No link associated with pipe conflict: {0}", MstLinkID));

        double lengthOfPipeFtNearLRTByFt =
          LengthOfPipeFtNearLRTByFt(MINIMUM_DISTANCE_TO_RAIL_FOR_PARALLEL);
        return (
        ((lengthOfPipeFtNearLRTByFt / _Link.Length) >
          PERCENT_OF_PIPE_LENGTH_THRESHOLD_FOR_PARALLEL) ||
        (lengthOfPipeFtNearLRTByFt > MINIMUM_PIPE_LENGTH_THRESHOLD_FOR_PARALLEL)
        );
      } // get
    } // HasLightRailParallel

    /// <summary>
    /// Dist to light rail parallel feet
    /// </summary>
    /// <returns>Int</returns>
    public int DistToLightRailParallelFeet
    {
      get
      {
        return _DistToLightRailParallelFeet;
      } // get
    } // DistToLightRailParallelFeet

    public double LengthOfPipeFtNearLRTByFt(double distFromLRT)
    {
      double lookupValue;
      try
      {
        lookupValue = _parallelLRTLookup.LookupValueWithCeiling(distFromLRT);
      }
      catch (IndexOutOfRangeException)
      {
        lookupValue = 0;
      }
      return lookupValue;
    }


    /// <summary>
    /// Num fiber optic crossings
    /// </summary>
    /// <returns>Int</returns>
    public int NumFiberOpticCrossings
    {
      get
      {
        return _NumFiberOpticCrossings;
      } // get
    } // NumFiberOpticCrossings

    /// <summary>
    /// Has fiber optic parallel
    /// </summary>
    /// <returns>Bool</returns>
    public bool HasFiberOpticParallel
    {
      get
      {
        return _HasFiberOpticParallel;
      } // get
    } // HasFiberOpticParallel

    /// <summary>
    /// Dist to fiber optic parallel feet
    /// </summary>
    /// <returns>Int</returns>
    public int DistToFiberOpticParallelFeet
    {
      get
      {
        return _DistToFiberOpticParallelFeet;
      } // get
    } // DistToFiberOpticParallelFeet

    /// <summary>
    /// Num gas crossings
    /// </summary>
    /// <returns>Int</returns>
    public int NumGasCrossings
    {
      get
      {
        return _NumGasCrossings;
      } // get
    } // NumGasCrossings

    /// <summary>
    /// Has gas parallel
    /// </summary>
    /// <returns>Bool</returns>
    public bool HasGasParallel
    {
      get
      {
        return _HasGasParallel;
      } // get
    } // HasGasParallel

    /// <summary>
    /// Dist to gas parallel
    /// </summary>
    /// <returns>Int</returns>
    public int DistToGasParallel
    {
      get
      {
        return _DistToGasParallel;
      } // get
    } // DistToGasParallel

    /// <summary>
    /// Is in conservation zone
    /// </summary>
    /// <returns>Bool</returns>
    public bool IsInConservationZone
    {
      get
      {
        return _IsInConservationZone;
      } // get
    } // IsInConservationZone

    /// <summary>
    /// Length in conservation zone feet
    /// </summary>
    /// <returns>Int</returns>
    public int LengthInConservationZoneFeet
    {
      get
      {
        return _LengthInConservationZoneFeet;
      } // get
    } // LengthInConservationZoneFeet

    /// <summary>
    /// Is in preservation zone
    /// </summary>
    /// <returns>Bool</returns>
    public bool IsInPreservationZone
    {
      get
      {
        return _IsInPreservationZone;
      } // get
    } // IsInPreservationZone

    /// <summary>
    /// Length in preservation zone feet
    /// </summary>
    /// <returns>Int</returns>
    public int LengthInPreservationZoneFeet
    {
      get
      {
        return _LengthInPreservationZoneFeet;
      } // get
    } // LengthInPreservationZoneFeet

    /// <summary>
    /// Area conservation zone sq ft
    /// </summary>
    /// <returns>Int</returns>
    public int AreaConservationZoneSqFt
    {
      get
      {
        return _AreaConservationZoneSqFt;
      } // get
    } // AreaConservationZoneSqFt

    /// <summary>
    /// Area preservation zone sq ft
    /// </summary>
    /// <returns>Int</returns>
    public int AreaPreservationZoneSqFt
    {
      get
      {
        return _AreaPreservationZoneSqFt;
      } // get
    } // AreaPreservationZoneSqFt

    /// <summary>
    /// Is near contamination site
    /// </summary>
    /// <returns>Bool</returns>
    public bool IsNearContaminationSite
    {
      get
      {
        return _IsNearContaminationSite;
      } // get
    } // IsNearContaminationSite

    /// <summary>
    /// Dist to nearest ecsi feet
    /// </summary>
    /// <returns>Int</returns>
    public int DistToNearestEcsiFeet
    {
      get
      {
        return _DistToNearestEcsiFeet;
      } // get
    } // DistToNearestEcsiFeet

    /// <summary>
    /// Length of pipe influenced by ECSI in feet
    /// </summary>
    public double LengthInEcsiFeet
    {
      get
      {
        return _LengthInEcsiFeet;
      }
    }

    /// <summary>
    /// Vol hazardous materials cu yd
    /// </summary>
    /// <returns>Int</returns>
    public int VolHazardousMaterialsCuYd
    {
      get
      {
        return _VolHazardousConflictCuYd;
      } // get
    } // VolHazardousMaterialsCuYd

    /// <summary>
    /// True if pipe is near a LUST (leaking underground storage tank)
    /// </summary>
    public bool IsNearLUST
    {
      get
      {
        return _IsNearLUST;
      }
    }

    /// <summary>
    /// Distance from pipe to nearest LUST
    /// </summary>
    public int DistToNearestLUSTFeet
    {
      get
      {
        return _DistToNearestLUSTFeet;
      }
    }

    /// <summary>
    /// Is near school
    /// </summary>
    /// <returns>Bool</returns>
    public bool IsNearSchool
    {
      get
      {
        return _IsNearSchool;
      } // get
    } // IsNearSchool

    /// <summary>
    /// Dist to school feet
    /// </summary>
    /// <returns>Int</returns>
    public int DistToSchoolFeet
    {
      get
      {
        return _DistToSchoolFeet;
      } // get
    } // DistToSchoolFeet

    /// <summary>
    /// Is near hospital
    /// </summary>
    /// <returns>Bool</returns>
    public bool IsNearHospital
    {
      get
      {
        return _IsNearHospital;
      } // get
    } // IsNearHospital

    /// <summary>
    /// Dist to hospital feet
    /// </summary>
    /// <returns>Int</returns>
    public int DistToHospitalFeet
    {
      get
      {
        return _DistToHospitalFeet;
      } // get
    } // DistToHospitalFeet

    /// <summary>
    /// Is near police station
    /// </summary>
    /// <returns>Bool</returns>
    public bool IsNearPoliceStation
    {
      get
      {
        return _IsNearPoliceStation;
      } // get
    } // IsNearPoliceStation

    /// <summary>
    /// Dist to police station feet
    /// </summary>
    /// <returns>Int</returns>
    public int DistToPoliceStationFeet
    {
      get
      {
        return _DistToPoliceStationFeet;
      } // get
    } // DistToPoliceStationFeet

    /// <summary>
    /// Is near fire station
    /// </summary>
    /// <returns>Bool</returns>
    public bool IsNearFireStation
    {
      get
      {
        return _IsNearFireStation;
      } // get
    } // IsNearFireStation

    /// <summary>
    /// Dist to fire station feet
    /// </summary>
    /// <returns>Int</returns>
    public int DistToFireStationFeet
    {
      get
      {
        return _DistToFireStationFeet;
      } // get
    } // DistToFireStationFeet

    /// <summary>
    /// Num emergency route crossings
    /// </summary>
    /// <returns>Int</returns>
    public int NumEmergencyRouteCrossings
    {
      get
      {
        return _NumEmergencyRouteCrossings;
      } // get
    } // NumEmergencyRouteCrossings

    /// <summary>
    /// Is in emergency route
    /// </summary>
    /// <returns>Bool</returns>
    public bool IsInEmergencyRoute
    {
      get
      {
        return _IsInEmergencyRoute;
      } // get
    } // IsInEmergencyRoute

    /// <summary>
    /// Dist to emergency route centerline feet
    /// </summary>
    /// <returns>Int</returns>
    public int DistToEmergencyRouteCenterlineFeet
    {
      get
      {
        return _DistToEmergencyRouteCenterlineFeet;
      } // get
    } // DistToEmergencyRouteCenterlineFeet

    /// <summary>
    /// USNode in MS4
    /// </summary>
    /// <returns>Bool</returns>
    public bool USNodeInMS4
    {
      get
      {
        return _USNodeInMS4;
      } // get
    } // USNodeInMS4

    /// <summary>
    /// USNode in UIC
    /// </summary>
    /// <returns>Bool</returns>
    public bool USNodeInUIC
    {
      get
      {
        return _USNodeInUIC;
      } // get
    } // USNodeInUIC

    /// <summary>
    /// USNode depth
    /// </summary>
    /// <returns>Int</returns>
    public double USNodeDepth
    {
      get
      {
        return _USNodeDepth;
      } // get
    } // USNodeDepth

    /// <summary>
    /// DSNode depth
    /// </summary>
    /// <returns>Int</returns>
    public double DSNodeDepth
    {
      get
      {
        return _DSNodeDepth;
      } // get
    } // DSNodeDepth

    /// <summary>
    /// Surface slope pct
    /// </summary>
    /// <returns>Int</returns>
    public int SurfaceSlopePct
    {
      get
      {
        return _SurfaceSlopePct;
      } // get
    } // SurfaceSlopePct

    /// <summary>
    /// Is near building
    /// </summary>
    /// <returns>Bool</returns>
    public bool IsNearBuilding
    {
      get
      {
        return _IsNearBuilding;
      }
    } // IsNearBuilding

    /// <summary>
    /// Dist to building feet
    /// </summary>
    /// <returns>Int</returns>
    public int DistToBuildingFeet
    {
      get
      {
        return _DistToBuildingFeet;
      } // get
    } // DistToBuildingFeet

    /// <summary>
    /// Is near hydrant
    /// </summary>
    /// <returns>Int</returns>
    public bool IsNearHydrant
    {
      get
      {
        return _IsNearHydrant;
      } // get
    } // IsNearHydrant

    /// <summary>
    /// Dist to hydrant
    /// </summary>
    /// <returns>Int</returns>
    public int DistToHydrant
    {
      get
      {
        return _DistToHydrant;
      } // get
    } // DistToHydrant

    /// <summary>
    /// Is hard area
    /// </summary>
    /// <returns>Bool</returns>
    public bool IsHardArea
    {
      get
      {
        return _IsHardArea;
      } // get
    } // IsHardArea
    #endregion
  }
}
